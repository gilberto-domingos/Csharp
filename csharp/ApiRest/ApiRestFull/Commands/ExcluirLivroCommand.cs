using ApiRestFull.DTOs;
using ApiRestFull.Models;
using MediatR;
using System;

namespace ApiRestFull.Handlers.Commands
{
    public class ExcluirLivroCommand : IRequest<LivroModel>
    {
        public Guid IdLivro { get; }

        public ExcluirLivroCommand(Guid idLivro)
        {
            IdLivro = idLivro;
        }
    }
}
