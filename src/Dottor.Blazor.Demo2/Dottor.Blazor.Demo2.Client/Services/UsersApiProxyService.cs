namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class UsersApiProxyService : IUsersService
{
	private readonly HttpClient _httpClient;

	public UsersApiProxyService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task UserInsertAsync(UserViewModel user)
	{
		var response = await _httpClient.PostAsJsonAsync("api/v1/users", user);
		response.EnsureSuccessStatusCode();
	}
}