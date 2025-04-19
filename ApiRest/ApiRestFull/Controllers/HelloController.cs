using Microsoft.AspNetCore.Mvc;
using ApiRestFull.Services;
using ApiRestFull.Entities;

namespace ApiRestFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly HelloService _helloService;

        public HelloController(HelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public IActionResult GetHello()
        {
            var mensagem = _helloService.ObterMensagem();
            return Ok(mensagem);
        }
    }
}