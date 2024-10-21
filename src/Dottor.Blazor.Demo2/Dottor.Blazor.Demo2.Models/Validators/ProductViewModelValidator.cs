namespace Dottor.Blazor.Demo2.Models.Validators;

using Dottor.Blazor.Demo2.Client.ViewModels;
using FluentValidation;

public sealed class ProductViewModelValidator : AbstractValidator<ProductViewModel>
{
    public ProductViewModelValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Nome obbligatorio");
        RuleFor(x => x.Code).NotEmpty().WithMessage("Codice obbligatorio");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Prezzo maggiore di zero");
    }
}
