using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class ApiResponseEnvelopeFilter : IAsyncResultFilter
{
    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if (context.Result is ObjectResult objectResult && objectResult.StatusCode >= 200 && objectResult.StatusCode < 300)
        {
            var envelope = new
            {
                status = true,
                mensagem = "Requisição realizada com sucesso.",
                dados = objectResult.Value
            };

            context.Result = new ObjectResult(envelope)
            {
                StatusCode = objectResult.StatusCode
            };
        }

        await next();
    }
}
