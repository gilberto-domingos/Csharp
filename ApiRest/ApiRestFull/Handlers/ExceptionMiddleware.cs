using ApiRestFull.Exceptions;
using System.Net;
using System.Text.Json;

namespace ApiRestFull.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro tratado pelo middleware");

                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            HttpStatusCode status;
            string mensagem;

            switch (exception)
            {
                case NotFoundException:
                    status = HttpStatusCode.NotFound;
                    mensagem = exception.Message;
                    break;
                default:
                    status = HttpStatusCode.InternalServerError;
                    mensagem = "Ocorreu um erro inesperado.";
                    break;
            }

            context.Response.StatusCode = (int)status;

            var resultado = JsonSerializer.Serialize(new
            {
                status = context.Response.StatusCode,
                mensagem
            });

            return context.Response.WriteAsync(resultado);
        }
    }
}
