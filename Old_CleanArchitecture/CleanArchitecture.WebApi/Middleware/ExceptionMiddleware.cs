﻿
using CleanArchitecture.Application.Features.Products.AddProduct;
using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;

namespace CleanArchitecture.WebApi.Middleware;

public sealed class ExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
		try
		{
			await next(context);
		}
		catch (Exception ex)
		{
			await HandleExceptionAsync(context, ex);
		}
    }  

    private Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
		context.Response.ContentType = "application/json";
		context.Response.StatusCode = 500;

		if(ex.GetType() == typeof(ValidationException))
		{
			context.Response.StatusCode = 429;
			return context.Response.WriteAsync(new ValidationErrorDetails
			{
				Errors = ((ValidationException)ex).Errors.Select(s => s.PropertyName),
				StatusCode = 429
			}.ToString());
		}

		return context.Response.WriteAsync(new ErrorResult
		{
			Message = ex.Message,
			StatusCode = 500
		}.ToString());
    }
}
