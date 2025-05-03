using MediatR;
using ApiRestFull.DTOs;
using ApiRestFull.Entities;

namespace ApiRestFull.Handlers.Commands
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
