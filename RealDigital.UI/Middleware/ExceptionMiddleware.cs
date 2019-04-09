using Microsoft.AspNetCore.Http;
using RealDigital.Application.Errors;
using RealDigital.Application.Models.ErrorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.UI.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch(Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            string errorMessage = "Oops!!! something went wrong please contact support";

            if (exception.GetType() == typeof(RecordNotFound))
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                errorMessage = "Record Not Found";
            }

            return httpContext.Response.WriteAsync(new ErrorModel()
            {
                Message = errorMessage,
                StatusCode = httpContext.Response.StatusCode
            }.ToString());
        }
    }
}
