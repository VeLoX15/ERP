using ERP.Core.Models;
using FluentValidation;

namespace ERP.Core.Validators
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.ArticleNumber)
                .NotEmpty().WithMessage("Article number must not be empty")
                .MaximumLength(50).WithMessage("Name must not have more than 50 characters");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name must not be empty")
                .MaximumLength(50).WithMessage("Name must not have more than 50 characters");

            RuleFor(x => x.Description)
                .MaximumLength(255).WithMessage("Name must not have more than 255 characters");

            RuleFor(x => x.Size.Length)
                .NotEmpty().WithMessage("Length must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Length must not be less than zero");

            RuleFor(x => x.Size.Width)
                .NotEmpty().WithMessage("Width must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Width must not be less than zero");

            RuleFor(x => x.Size.Height)
                .NotEmpty().WithMessage("Height must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Height must not be less than zero");

            RuleFor(x => x.Size.Volume)
                .NotEmpty().WithMessage("Volume must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Volume must not be less than zero");

            RuleFor(x => x.Weight)
                .NotEmpty().WithMessage("Weight must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Weight must not be less than zero");

            RuleFor(x => x.PurchasePrice)
                .NotEmpty().WithMessage("Price must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Price must not be less than zero");

            RuleFor(x => x.SellingPrice)
                .NotEmpty().WithMessage("Price must not be empty")
                .GreaterThanOrEqualTo(0).WithMessage("Price must not be less than zero");

            RuleFor(x => x.InclusionDate)
                .NotEmpty().WithMessage("Date must not be empty")
                .Must(BeValidDate).WithMessage("Invalid Date");
        }

        private bool BeValidDate(DateTime date)
        {
            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = new DateTime(2199, 12, 31);

            return date >= minDate && date <= maxDate;
        }
    }
}