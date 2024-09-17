using Dottor.Blazor.Demo2.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IProductsService, ProductsApiProxyService>();
builder.Services.AddScoped<IUsersService, UsersApiProxyService>();

await builder.Build().RunAsync();
