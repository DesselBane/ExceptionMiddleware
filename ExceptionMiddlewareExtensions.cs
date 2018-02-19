using Microsoft.AspNetCore.Builder;

namespace ExceptionMiddleware
{
    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<global::ExceptionMiddleware.ExceptionMiddleware>();

            return app;
        }
    }
}