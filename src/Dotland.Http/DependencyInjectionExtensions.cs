using Dotland.Http.Abstractions.UseCases;
using Dotland.Http.Middleware;
using Dotland.Http.Services;
using Dotland.Http.UseCases;

using Microsoft.AspNetCore.Builder;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddDotlandHttp(this IServiceCollection service)
    {
        return service
            .AddScoped<IResponseMessageFactory, ResponseMessageFactory>()
            .AddScoped(typeof(IResponseMessageFactory<>), typeof(ResponseMessageFactory<>))
            .AddScoped<IExceptionHandler, ExceptionHandlerService>();
    }

    public static IApplicationBuilder UseDotlandHttp(this IApplicationBuilder applicationBuilder)
    {
        return applicationBuilder
            .UseMiddleware<ExceptionProcessorMiddleware>()
            .UseMiddleware<CoreExceptionProcessorMiddleware>();
    }
}