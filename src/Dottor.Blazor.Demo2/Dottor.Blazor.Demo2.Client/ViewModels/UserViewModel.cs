namespace Dottor.Blazor.Demo2.Client.ViewModels;

using FluentValidation;
using System.ComponentModel;

public class UserViewModel
{
    [DisplayName("Nome")]
    public string FirstName { get; set; } = default!;
    [DisplayName("Cognome")]
    public string LastName { get; set; } = default!;
    [DisplayName("Email")]
    public string Email { get; set; } = default!;
}

public class UserViewModelValidator : AbstractValidator<UserViewModel>
{
    public UserViewModelValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("Nome obbligatorio");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Cognome obbligatorio");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email obbligatorio");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Formato Email non valido");
    }
}
