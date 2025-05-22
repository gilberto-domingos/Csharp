using MediatR;
using ApiRestFull.Dtos;

namespace ApiRestFull.Commands
{
    public class EditarLivroCommand : IRequest<Entities.Livro>
    {
        public LivroEditarDto LivroEditarDto { get; set; }

        public EditarLivroCommand(LivroEditarDto livroEditarDto)
        {
            LivroEditarDto = livroEditarDto;
        }
    }
}
