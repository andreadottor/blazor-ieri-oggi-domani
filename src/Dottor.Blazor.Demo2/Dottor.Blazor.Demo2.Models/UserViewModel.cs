namespace Dottor.Blazor.Demo2.Client.ViewModels;

using Dottor.Blazor.Demo2.Models.Attributes;
using System.ComponentModel;

public class UserViewModel
{
    [FieldIndex(10)]
    [DisplayName("Nome")]
    public string FirstName { get; set; } = default!;

    [FieldIndex(20)]
    [DisplayName("Cognome")]
    public string LastName { get; set; } = default!;

    [FieldIndex(30)]
    [DisplayName("Email")]
    public string Email { get; set; } = default!;
}