using ApiRestFull.DTOs;
using ApiRestFull.Entities;
using MediatR;
using System;

namespace ApiRestFull.Handlers.Commands
{
    public class ExcluirLivroCommand : IRequest<Entities.Livro>
    {
        public Guid IdLivro { get; }

        public ExcluirLivroCommand(Guid idLivro)
        {
            IdLivro = idLivro;
        }
    }
}
