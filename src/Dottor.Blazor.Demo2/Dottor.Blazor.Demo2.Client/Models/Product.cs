namespace Dottor.Blazor.Demo2.Client.Models;

using FluentValidation;
using System.ComponentModel;

public class Product
{
    [DisplayName("Nome")]
    public string Name { get; set; } = default!;

    [DisplayName("Codice")]
    public string Code { get; set; } = default!;

    [DisplayName("Prezzo")]
    public decimal Price { get; set; } = 0;
}


public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Nome obbligatorio");
        RuleFor(x => x.Code).NotEmpty().WithMessage("Codice obbligatorio");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Prezzo maggiore di zero");
    }
}