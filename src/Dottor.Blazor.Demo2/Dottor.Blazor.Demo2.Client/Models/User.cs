namespace Dottor.Blazor.Demo2.Client.Models;

using FluentValidation;
using System.ComponentModel;

public class User
{
    [DisplayName("Nome")]
    public string FirstName { get; set; } = default!;
    [DisplayName("Cognome")]
    public string LastName { get; set; } = default!;
    [DisplayName("Email")]
    public string Email { get; set; } = default!;
}

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("Nome obbligatorio");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Cognome obbligatorio");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email obbligatorio");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Formato Email non valido");
    }
}
