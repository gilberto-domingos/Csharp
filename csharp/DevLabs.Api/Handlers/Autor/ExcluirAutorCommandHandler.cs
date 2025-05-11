using LaboratorioDeTestes.Commands.Autor;
using LaboratorioDeTestes.Interfaces;
using MediatR;

namespace LaboratorioDeTestes.Handlers.Autor
{
    public class ExcluirAutorCommandHandler : IRequestHandler<ExcluirAutorCommand, Entities.Autor>
    {
        private readonly IAutor _autorService;

        public ExcluirAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<Entities.Autor> Handle(ExcluirAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.ExcluirAutor(request.IdAutor);
        }
    }
}
