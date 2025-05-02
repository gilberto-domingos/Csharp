using ApiRestFull.Commands.Autor;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using MediatR;

namespace ApiRestFull.Handlers.Autor
{
    public class EditarAutorCommandHandler : IRequestHandler<EditarAutorCommand, AutorModel>
    {
        private readonly IAutor _autorService;

        public EditarAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<AutorModel> Handle(EditarAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.EditarAutor(request.AutorEditarDto);
        }
    }
}
