namespace Dottor.Blazor.Demo2.Services;

using Dottor.Blazor.Demo2.Client.Models;
using Dottor.Blazor.Demo2.Client.Services;
using System.Threading.Tasks;

public class UsersDataService : IUsersService
{
    public Task UserInsertAsync(User user)
    {
        return Task.CompletedTask;
    }
}
