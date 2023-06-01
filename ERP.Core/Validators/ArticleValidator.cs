using ERP.Core.Models;
using FluentValidation;

namespace ERP.Core.Validators
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.ArticleNumber)
                .MaximumLength(50).WithMessage("Name must not have more than 50 characters");

            RuleFor(x => x.Name)
                .MaximumLength(50).WithMessage("Name must not have more than 50 characters");

            RuleFor(x => x.Weight)
                .GreaterThanOrEqualTo(0).WithMessage("Weight must not be less than zero");

            RuleFor(x => x.PurchasePrice)
                .GreaterThanOrEqualTo(0).WithMessage("Purchase Price must not be less than zero");

            RuleFor(x => x.SellingPrice)
                .GreaterThanOrEqualTo(0).WithMessage("Selling Price must not be less than zero");
        }
    }
}