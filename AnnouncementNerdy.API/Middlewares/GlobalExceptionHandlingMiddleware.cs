using System.Net;
using System.Text.Json;
using AnnouncementNerdy.Domain.Results;

namespace AnnouncementNerdy.Middlewares;

public class GlobalExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

    public GlobalExceptionHandlingMiddleware(ILogger<GlobalExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);

            context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };

            var result = new CommonResult("An internal server error has occured", e);
            
            var json = JsonSerializer.Serialize(result, options);

            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(json);

        }
    }
}