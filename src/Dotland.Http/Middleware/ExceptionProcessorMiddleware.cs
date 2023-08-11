using Dotland.Http.Abstractions.UseCases;
using Microsoft.AspNetCore.Http;

namespace Dotland.Http.Middleware;

public class ExceptionProcessorMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionProcessorMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public Task InvokeAsync(HttpContext httpContext, IExceptionHandler exceptionHandler)
    {
        try
        {
            return _next(httpContext);
        }
        catch (Exception e)
        {
            return exceptionHandler.HandleExceptionAsync(httpContext, e);
        }
    }
}