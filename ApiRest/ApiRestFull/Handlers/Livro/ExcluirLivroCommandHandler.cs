using MediatR;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRestFull.Handlers.Commands
{
    public class ExcluirLivroCommandHandler : IRequestHandler<ExcluirLivroCommand, LivroModel>
    {
        private readonly ILivro _livroService;

        public ExcluirLivroCommandHandler(ILivro livroService)
        {
            _livroService = livroService;
        }

        public async Task<LivroModel> Handle(ExcluirLivroCommand request, CancellationToken cancellationToken)
        {
            return await _livroService.ExcluirLivro(request.IdLivro);
        }
    }
}
