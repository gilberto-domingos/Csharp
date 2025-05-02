using MediatR;
using ApiRestFull.DTOs;
using ApiRestFull.Models;

namespace ApiRestFull.Handlers.Commands
{
    public class CriarLivroCommand : IRequest<LivroModel>
    {
        public LivroCriarDto LivroCriarDto { get; set; }

        public CriarLivroCommand(LivroCriarDto livroCriarDto)
        {
            LivroCriarDto = livroCriarDto;
        }
    }
}
