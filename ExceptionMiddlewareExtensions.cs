using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;

namespace ExceptionMiddleware
{
    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app,
            JsonSerializerSettings jsonSerializerSettings = null)
        {
            jsonSerializerSettings ??= new JsonSerializerSettings();
            app.UseMiddleware<ExceptionMiddleware>(jsonSerializerSettings);

            return app;
        }
    }
}