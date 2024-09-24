namespace Dottor.Blazor.Demo2.Services;

using Dottor.Blazor.Demo2.Client.Services;
using Dottor.Blazor.Demo2.Client.ViewModels;

public class ProductsDataService : IProductsService
{
	private readonly ILogger<ProductsDataService> _logger;

	public ProductsDataService(ILogger<ProductsDataService> logger)
	{
		_logger = logger;
	}
	public Task ProductInsertAsync(ProductViewModel product)
    {
		_logger.LogInformation("New product created!");

		return Task.CompletedTask;
    }
}
