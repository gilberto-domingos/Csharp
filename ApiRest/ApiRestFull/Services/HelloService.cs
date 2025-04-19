using ApiRestFull.Entities;

namespace ApiRestFull.Services
{
    public class HelloService
    {
        public Hello ObterMensagem()
        {
            return new Hello
            {
                Mensagem = "Olá, mundo! API RESTfull"
            };
        }
    }
}