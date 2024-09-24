namespace Dottor.Blazor.Demo2.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;
using Dottor.Blazor.Demo2.Client.Services;
using System.Threading.Tasks;

public class UsersDataService : IUsersService
{
    private readonly ILogger<UsersDataService> _logger;

	public UsersDataService(ILogger<UsersDataService> logger)
	{
		_logger = logger;
	}

	public Task UserInsertAsync(UserViewModel user)
    {
		_logger.LogInformation("New user created!");

		return Task.CompletedTask;
    }
}
