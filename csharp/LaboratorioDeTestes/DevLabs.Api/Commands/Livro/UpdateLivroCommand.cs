using MediatR;
using DevLabs.Api.Entities;
using System.Collections.Generic;
using DevLabs.Api.Dtos;

namespace DevLabs.Api.Handlers.Livro.Commands
{
    public record UpdateLivroCommand(LivroEditarDto LivroEditarDto) : IRequest<Entities.Livro>;
}
