using MediatR;
using ApiRestFull.Dtos;

namespace ApiRestFull.Commands
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
