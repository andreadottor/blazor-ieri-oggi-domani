﻿namespace Dottor.Blazor.Demo2.Endpoints;

using Dottor.Blazor.Demo2.Client.Services;
using Dottor.Blazor.Demo2.Client.ViewModels;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;

public static class UsersEndpoint
{
	public static IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder endpoints)
	{
		var group = endpoints.MapGroup("/api/v1/users/");
		group.WithTags("Public");

		group.MapPost("", InsertUserAsync)
			 .WithName("InsertUser")
			 .WithSummary("Insert new user");

		return endpoints;
	}

	private static async Task<Results<Created, ProblemHttpResult, ValidationProblem>> InsertUserAsync(
		UserViewModel user,
		ILoggerFactory loggerFactory,
		IUsersService userService,
		IValidator<UserViewModel> validator)
	{
		var logger = loggerFactory.CreateLogger(typeof(UsersEndpoint).FullName!);

		// validate model with FluentValidation
		//
		var validationResult = await validator.ValidateAsync(user);

		if (!validationResult.IsValid)
			return TypedResults.ValidationProblem(validationResult.ToDictionary());

		try
		{
			await userService.UserInsertAsync(user);

			return TypedResults.Created();
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "Error on insert new user.");
			return TypedResults.Problem(ex.Message, title: "Error on InsertUser API");
		}
	}
}