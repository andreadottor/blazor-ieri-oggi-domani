namespace Dottor.Blazor.Demo2.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;
using Dottor.Blazor.Demo2.Client.Services;
using System.Threading.Tasks;

public class UsersDataService : IUsersService
{
    public Task UserInsertAsync(UserViewModel user)
    {
        return Task.CompletedTask;
    }
}
