using LaboratorioDeTestesAPI.Commands.Autor;
using LaboratorioDeTestesAPI.Interfaces;
using MediatR;

namespace LaboratorioDeTestesAPI.Handlers.Autor
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
