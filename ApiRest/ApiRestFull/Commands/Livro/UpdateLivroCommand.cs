using MediatR;
using ApiRestFull.Dtos;

namespace ApiRestFull.Commands
{
    public record UpdateLivroCommand(LivroEditarDto LivroEditarDto) : IRequest<Entities.Livro>;
}
