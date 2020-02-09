using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HappyTravelTest.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HappyTravelTest
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var statusMap = new Dictionary<Type, HttpStatusCode>
            {
                [typeof(BadRequestException)] = HttpStatusCode.BadRequest,
                [typeof(DatabaseException)] = HttpStatusCode.InternalServerError,
                [typeof(NetstormingException)] = HttpStatusCode.InternalServerError,
                [typeof(NotFoundException)] = HttpStatusCode.NotFound,
            };
            var statusCode = statusMap.TryGetValue(ex.GetType(), out var code) ? code : HttpStatusCode.InternalServerError;

            var result = JsonConvert.SerializeObject(new { error = ex.Message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            return context.Response.WriteAsync(result);
        }
    }
}
