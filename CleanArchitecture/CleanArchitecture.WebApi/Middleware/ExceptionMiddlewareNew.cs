using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;

namespace CleanArchitecture.WebApi.Middleware;

public sealed class ExceptionMiddlewareNew : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        // İstisnayı işleyebilir miyiz?
        if (exception is ValidationException)
        {
            await HandleExceptionAsync(httpContext, exception);
            return true; // İstisna işlendi
        }

        return false; // İstisna işlenemedi, InvokeAsync metoduna geri dön
    }

    private Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = 400; // Kötü İstek

        if (ex is ValidationException validationEx)
        {
            return context.Response.WriteAsync(new ValidationErrorDetails
            {
                Errors = validationEx.Errors.Select(s => s.PropertyName),
                StatusCode = context.Response.StatusCode
            }.ToString());
        }

        return context.Response.WriteAsync(new ErrorResult
        {
            Message = ex.Message,
            StatusCode = context.Response.StatusCode
        }.ToString());
    }
}
