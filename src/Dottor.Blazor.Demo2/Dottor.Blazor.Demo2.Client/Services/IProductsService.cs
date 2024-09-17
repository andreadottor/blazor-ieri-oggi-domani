namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.Models;

public interface IProductsService
{
    Task ProductInsertAsync(Product product);
}
