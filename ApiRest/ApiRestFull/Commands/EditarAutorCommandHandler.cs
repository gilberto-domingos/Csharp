using ApiRestFull.Commands.Autor;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Handlers.Autor
{
    public class EditarAutorCommandHandler : IRequestHandler<EditarAutorCommand, RespostaApiDto<List<AutorModel>>>
    {
        private readonly IAutor _autorService;

        public EditarAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<RespostaApiDto<List<AutorModel>>> Handle(EditarAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.EditarAutor(request.AutorEditarDto);
        }
    }
}
