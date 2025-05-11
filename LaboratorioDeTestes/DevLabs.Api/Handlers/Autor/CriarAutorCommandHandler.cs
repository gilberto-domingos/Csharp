using DevLabs.Api.Commands.Autor;
using DevLabs.Api.Interfaces;
using MediatR;

namespace DevLabs.Api.Handlers.Autor
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
