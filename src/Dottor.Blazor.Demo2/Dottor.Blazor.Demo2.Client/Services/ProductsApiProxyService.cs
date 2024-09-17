namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;
using System.Threading.Tasks;

public class ProductsApiProxyService : IProductsService
{
    public Task ProductInsertAsync(ProductViewModel product)
    {
        return Task.CompletedTask;
    }

}
