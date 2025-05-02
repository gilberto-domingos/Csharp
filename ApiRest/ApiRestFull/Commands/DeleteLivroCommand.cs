using MediatR;
using System;
using ApiRestFull.Models;
using System.Collections.Generic;

namespace ApiRestFull.Handlers.Livro.Commands
{
    public record DeleteLivroCommand(Guid IdLivro) : IRequest<LivroModel>;
}
