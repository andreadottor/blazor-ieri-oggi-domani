namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.Models;

public interface IUsersService
{
    Task UserInsertAsync(User user);
}
