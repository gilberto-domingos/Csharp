using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRestFull.Handlers.Commands
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
