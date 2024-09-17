namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;
using System.Threading.Tasks;

public class UsersApiProxyService : IUsersService
{
    public Task UserInsertAsync(UserViewModel user)
    {
        return Task.CompletedTask;
    }
}
