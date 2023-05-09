using ERP.Core.Models;
using FluentValidation;

namespace ERP.Core.Validator
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.ArticleNumber)
                .NotEmpty()
                .WithMessage("Article number must not be empty");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name must not be empty")
                .MaximumLength(55)
                .WithMessage("Fraction must contain only 55 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(255)
                .WithMessage("Description must contain only 255 characters.");

            RuleFor(x => x.Weight)
                .NotNull()
                .WithMessage("");

            RuleFor(x => x.Length)
                .NotNull()
                .WithMessage("");
        }
    }
}