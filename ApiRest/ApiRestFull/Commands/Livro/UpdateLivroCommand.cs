using MediatR;
using ApiRestFull.DTOs;
using ApiRestFull.Entities;
using System.Collections.Generic;

namespace ApiRestFull.Handlers.Livro.Commands
{
    public record UpdateLivroCommand(LivroEditarDto LivroEditarDto) : IRequest<Entities.Livro>;
}
