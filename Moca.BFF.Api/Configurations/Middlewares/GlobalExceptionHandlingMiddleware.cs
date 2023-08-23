using Moca.BFF.External.ExceptionHandler;
using System.Net;

namespace Moca.BFF.Api.Configurations.Middlewares
{
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlingMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (BusinessException ex)
            {
                context.Response.StatusCode = ex.StatusCode;
                context.Response.ContentType = "application/json"; 


                await context.Response.WriteAsJsonAsync(new
                {
                    Message = ex.Message,
                    Date = ex.Data.ToString("dd/MM/yyyy"),
                }); 

                return;
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsJsonAsync(new
                {
                    Message = ex.Message,
                    InnerExceptions = ex.InnerException,
                });

                return;
            }
        }
    }
}
