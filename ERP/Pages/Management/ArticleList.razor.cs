using DbController.MySql;
using DbController;
using ERP.Core.Filters;
using ERP.Core.Models;
using ERP.Core.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

namespace ERP.Pages.Management
{
    public partial class ArticleList
    {
        private int _page = 1;
        public ArticleFilter Filter { get; set; } = new()
        {
            Limit = AppdatenService.PageLimit
        };

        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public List<Article> FilterData { get; set; } = new();

        public int Page { get => _page; set => _page = value < 1 ? 1 : value; }
        public int TotalItems { get; set; }

        protected override void OnInitialized()
        {
            FilterData = FilterData.Where(x => x.Id == Id).ToList();
        }

        protected override async Task OnInitializedAsync()
        {
            var storedData = await JSRuntime.InvokeAsync<string>("sessionStorage.getItem", "articles");
            if (!string.IsNullOrEmpty(storedData))
            {
                FilterData = JsonSerializer.Deserialize<List<Article>>(storedData) ?? new();
            }
            else
            {
                FilterData = new List<Article>();
            }
        }

        protected override async Task SaveAsync()
        {
            if (Input is null)
            {
                return;
            }

            await base.SaveAsync();
            await LoadAsync();
        }
        public async Task LoadAsync(bool navigateToPage1 = false)
        {
            Filter.PageNumber = navigateToPage1 ? 1 : Page;
            using IDbController dbController = new MySqlController(AppdatenService.ConnectionString);
            TotalItems = await Service.GetTotalAsync(Filter, dbController);
            Data = await Service.GetAsync(Filter, dbController);
        }

        protected override async Task DeleteAsync()
        {
            await base.DeleteAsync();
            await LoadAsync();
        }

        private void CalculateResult()
        {
            if(Input is not null) 
            {
                decimal length = Input.Size.Length;
                decimal width = Input.Size.Width;
                decimal height = Input.Size.Height;

                Input.Size.Volume = length * width * height;
            }
            StateHasChanged();
        }
    }
}