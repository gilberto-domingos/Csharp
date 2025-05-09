using MediatR;
using LaboratorioDeTestesAPI.Dtos;

namespace LaboratorioDeTestesAPI.Handlers.Commands
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
