using DevLabs.Api.Commands.Autor;
using DevLabs.Api.Interfaces;
using MediatR;

namespace DevLabs.Api.Handlers.Autor
{
    public class EditarAutorCommandHandler : IRequestHandler<EditarAutorCommand, Entities.Autor>
    {
        private readonly IAutor _autorService;

        public EditarAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<Entities.Autor> Handle(EditarAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.EditarAutor(request.AutorEditarDto);
        }
    }
}
