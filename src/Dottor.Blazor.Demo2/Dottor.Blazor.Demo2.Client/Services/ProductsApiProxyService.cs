namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ProductsApiProxyService : IProductsService
{
	private readonly HttpClient _httpClient;

	public ProductsApiProxyService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task ProductInsertAsync(ProductViewModel product)
	{
		var response = await _httpClient.PostAsJsonAsync("api/v1/products", product);
		response.EnsureSuccessStatusCode();
	}

}
