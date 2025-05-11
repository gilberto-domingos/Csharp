using MediatR;
using DevLabs.Api.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;
using DevLabs.Api.Interfaces;

namespace DevLabs.Api.Handlers.Commands
{
    public class ExcluirLivroCommandHandler : IRequestHandler<ExcluirLivroCommand, Entities.Livro>
    {
        private readonly ILivro _livroService;

        public ExcluirLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<Entities.Livro> Handle(ExcluirLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.ExcluirLivro(request.IdLivro);
        }
    }
}
