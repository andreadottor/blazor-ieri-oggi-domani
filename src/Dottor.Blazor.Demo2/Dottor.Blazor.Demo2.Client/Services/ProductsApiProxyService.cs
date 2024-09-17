namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.Models;
using System.Threading.Tasks;

public class ProductsApiProxyService : IProductsService
{
    public Task ProductInsertAsync(Product product)
    {
        return Task.CompletedTask;
    }

}
