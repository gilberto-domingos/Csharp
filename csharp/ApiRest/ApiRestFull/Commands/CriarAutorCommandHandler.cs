using ApiRestFull.Commands.Autor;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Handlers.Autor
{
    public class CriarAutorCommandHandler : IRequestHandler<CriarAutorCommand, RespostaApiDto<List<AutorModel>>>
    {
        private readonly IAutor _autorService;

        public CriarAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<RespostaApiDto<List<AutorModel>>> Handle(CriarAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.CriarAutor(request.AutorCriarDto);
        }
    }
}
