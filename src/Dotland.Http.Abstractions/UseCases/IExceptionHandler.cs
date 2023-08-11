using Microsoft.AspNetCore.Http;

namespace Dotland.Http.Abstractions.UseCases;

public interface IExceptionHandler
{
    Task HandleExceptionAsync(HttpContext httpContext, Exception exception);
    Task HandleExceptionAsync(HttpContext httpContext, Exception exception, int? attributeHttpStatus);
}