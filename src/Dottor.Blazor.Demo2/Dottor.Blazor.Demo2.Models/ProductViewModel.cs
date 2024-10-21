namespace Dottor.Blazor.Demo2.Client.ViewModels;

using Dottor.Blazor.Demo2.Models.Attributes;
using System.ComponentModel;

public class ProductViewModel
{
    [FieldIndex(20)]
    [DisplayName("Nome")]
    public string Name { get; set; } = default!;

    [FieldIndex(10)]
    [DisplayName("Codice")]
    public string Code { get; set; } = default!;

    [FieldIndex(30)]
    [DisplayName("Prezzo")]
    public decimal Price { get; set; } = 0;
}
