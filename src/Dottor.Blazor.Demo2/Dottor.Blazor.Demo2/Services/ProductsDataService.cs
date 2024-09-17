namespace Dottor.Blazor.Demo2.Services;

using Dottor.Blazor.Demo2.Client.Services;
using Dottor.Blazor.Demo2.Client.ViewModels;

public class ProductsDataService : IProductsService
{
    public Task ProductInsertAsync(ProductViewModel product)
    {
        return Task.CompletedTask;
    }
}
