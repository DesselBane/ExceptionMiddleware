using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace ExceptionMiddleware
{
    public class ExceptionMiddleware
    {
        #region Constructors

        public ExceptionMiddleware(RequestDelegate next, IHostingEnvironment environment)
        {
            _next        = next;
            _environment = environment;
        }

        #endregion

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            } catch (InvalidRestOperationException invalidRestOperationException)
            {
                context.Response.StatusCode = invalidRestOperationException.ResponseCode;
                await
                    context.Response
                           .WriteAsync(JsonConvert.SerializeObject(new ExceptionDTO(invalidRestOperationException)));
            } catch (Exception exception)
            {
                context.Response.StatusCode = 500;

                if (_environment.IsDevelopment())
                {
                    var ex = exception;

                    do
                    {
                        await context.Response.WriteAsync(ex.Message);
                        await context.Response
                                     .WriteAsync("\n##########################################################################");
                        await context.Response.WriteAsync(ex.StackTrace);
                        await context.Response
                                     .WriteAsync("\n--------------------------------------------------------------------------");
                        ex = ex.InnerException;
                    } while (ex != null);
                } else
                {
                    await context.Response.WriteAsync("Ups... Something bad happened :(");
                }
            }
        }

        #region Vars

        private readonly RequestDelegate     _next;
        private readonly IHostingEnvironment _environment;

        #endregion
    }
}