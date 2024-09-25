namespace Dottor.Blazor.Demo2.Client.ViewModels;

using Dottor.Blazor.Demo2.Client.Attributes;
using FluentValidation;
using System.ComponentModel;

public class ProductViewModel
{
    [FieldIndex(2)]
    [DisplayName("Nome")]
    public string Name { get; set; } = default!;

    [FieldIndex(1)]
    [DisplayName("Codice")]
    public string Code { get; set; } = default!;

    [FieldIndex(3)]
    [DisplayName("Prezzo")]
    public decimal Price { get; set; } = 0;
}


public sealed class ProductViewModelValidator : AbstractValidator<ProductViewModel>
{
    public ProductViewModelValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Nome obbligatorio");
        RuleFor(x => x.Code).NotEmpty().WithMessage("Codice obbligatorio");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Prezzo maggiore di zero");
    }
}