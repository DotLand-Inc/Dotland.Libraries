using Dotland.Attributes.Exceptions;
using Dotland.Http.Abstractions.Exceptions;
using Dotland.Http.Abstractions.Extensions;
using Dotland.Http.Abstractions.UseCases;

using Microsoft.AspNetCore.Http;

namespace Dotland.Http.Middleware;

public class CoreExceptionProcessorMiddleware
{
    private readonly RequestDelegate _next;

    public CoreExceptionProcessorMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public Task InvokeAsync(HttpContext httpContext, IExceptionHandler exceptionHandler)
    {
        try
        {
            return _next(httpContext);
        }
        catch (CoreException e)
        {
            var attribute = e.Code.GetCustomAttribute<CoreExceptionAttribute>();
            return exceptionHandler.HandleExceptionAsync(httpContext, e, attribute?.HttpStatus);
        }
    }
}