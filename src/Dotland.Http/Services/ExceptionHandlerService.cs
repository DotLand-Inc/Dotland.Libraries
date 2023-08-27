using Dotland.Http.Abstractions.UseCases;

using Microsoft.AspNetCore.Http;

namespace Dotland.Http.Services;

public class ExceptionHandlerService : IExceptionHandler
{
    public Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
    {
        return Task.CompletedTask;
    }

    public Task HandleExceptionAsync(HttpContext httpContext, Exception exception, int? attributeHttpStatus)
    {
        return Task.CompletedTask;
    }
}