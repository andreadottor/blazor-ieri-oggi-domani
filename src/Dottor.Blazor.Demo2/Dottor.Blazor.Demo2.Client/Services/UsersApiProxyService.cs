namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.Models;
using System.Threading.Tasks;

public class UsersApiProxyService : IUsersService
{
    public Task UserInsertAsync(User user)
    {
        return Task.CompletedTask;
    }
}
