namespace Dottor.Blazor.Demo2.Services;

using Dottor.Blazor.Demo2.Client.Models;
using Dottor.Blazor.Demo2.Client.Services;

public class ProductsDataService : IProductsService
{
    public Task ProductInsertAsync(Product product)
    {
        return Task.CompletedTask;
    }
}
