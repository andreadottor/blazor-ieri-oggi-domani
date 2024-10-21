namespace Dottor.Blazor.Demo2.Models.Validators;

using Dottor.Blazor.Demo2.Client.ViewModels;
using FluentValidation;

public sealed class UserViewModelValidator : AbstractValidator<UserViewModel>
{
    public UserViewModelValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("Nome obbligatorio");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Cognome obbligatorio");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email obbligatorio");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Formato Email non valido");
    }
}
