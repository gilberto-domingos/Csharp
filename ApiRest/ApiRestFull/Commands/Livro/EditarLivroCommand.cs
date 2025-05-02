using MediatR;
using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Commands
{
    public class EditarLivroCommand : IRequest<LivroModel>
    {
        public LivroEditarDto LivroEditarDto { get; set; }

        public EditarLivroCommand(LivroEditarDto livroEditarDto)
        {
            LivroEditarDto = livroEditarDto;
        }
    }
}
