namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;

public interface IUsersService
{
    Task UserInsertAsync(UserViewModel user);
}
