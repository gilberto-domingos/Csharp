using LaboratorioDeTestesAPI.Commands.Autor;
using LaboratorioDeTestesAPI.Interfaces;
using MediatR;

namespace LaboratorioDeTestesAPI.Handlers.Autor
{
    public class CriarAutorCommandHandler : IRequestHandler<CriarAutorCommand, Entities.Autor>
    {
        private readonly IAutor _autorService;

        public CriarAutorCommandHandler(IAutor autorService)
        {
            _autorService = autorService;
        }

        public async Task<Entities.Autor> Handle(CriarAutorCommand request, CancellationToken cancellationToken)
        {
            return await _autorService.CriarAutor(request.AutorCriarDto);
        }
    }
}
