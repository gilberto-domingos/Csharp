using DevLabs.Api.Dtos;
using MediatR;

namespace DevLabs.Api.Handlers.Commands
{
    public class CriarLivroCommand : IRequest<Entities.Livro>
    {
        public LivroCriarDto LivroCriarDto { get; set; }

        public CriarLivroCommand(LivroCriarDto livroCriarDto)
        {
            LivroCriarDto = livroCriarDto;
        }
    }
}
