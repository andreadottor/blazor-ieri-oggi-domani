namespace Dottor.Blazor.Demo2.Endpoints;

using Dottor.Blazor.Demo2.Client.Services;
using Dottor.Blazor.Demo2.Client.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using FluentValidation;

public static class ProductsEndpoint
{
	public static IEndpointRouteBuilder MapProductsEndpoints(this IEndpointRouteBuilder endpoints)
	{
		var group = endpoints.MapGroup("/api/v1/products/");
		group.WithTags("Public");

		group.MapPost("", InsertProductAsync)
			 .WithName("InsertProduct")
			 .WithSummary("Insert new product");

		return endpoints;
	}

	private static async Task<Results<Created, ProblemHttpResult, ValidationProblem>> InsertProductAsync(
		ProductViewModel product,
		ILoggerFactory loggerFactory,
		IProductsService productService,
		IValidator<ProductViewModel> validator)
	{
		var logger = loggerFactory.CreateLogger(typeof(ProductsEndpoint).FullName!);

		// validate model with FluentValidation
		//
		var validationResult = await validator.ValidateAsync(product);

		if (!validationResult.IsValid)
			return TypedResults.ValidationProblem(validationResult.ToDictionary());

		try
		{
			await productService.ProductInsertAsync(product);
			
			return TypedResults.Created();
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "Error on insert new product.");
			return TypedResults.Problem(ex.Message, title: "Error on InsertProduct API");
		}
	}
}
