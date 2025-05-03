using MediatR;
using System;
using ApiRestFull.Entities;
using System.Collections.Generic;

namespace ApiRestFull.Handlers.Livro.Commands
{
    public record DeleteLivroCommand(Guid IdLivro) : IRequest<Entities.Livro>;
}
