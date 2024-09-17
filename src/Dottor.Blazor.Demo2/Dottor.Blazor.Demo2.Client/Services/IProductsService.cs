namespace Dottor.Blazor.Demo2.Client.Services;

using Dottor.Blazor.Demo2.Client.ViewModels;

public interface IProductsService
{
    Task ProductInsertAsync(ProductViewModel product);
}
