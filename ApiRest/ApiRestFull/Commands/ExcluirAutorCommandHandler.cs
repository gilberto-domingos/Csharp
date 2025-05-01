using ApiRestFull.Commands.Autor;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Handlers.Autor
{
    public class ExcluirAutorCommandHandler : IRequestHandler<ExcluirAutorCommand, RespostaApiDto<List<AutorModel>>>
    {
        private readonly IAutor _autorService;

        public ExcluirAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<RespostaApiDto<List<AutorModel>>> Handle(ExcluirAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.ExcluirAutor(request.IdAutor);
        }
    }
}
