using MediatR;

namespace LaboratorioDeTestes.Commands.Autor
{
    public class ExcluirAutorCommand : IRequest<Entities.Autor>
    {
        public Guid IdAutor { get; }

        public ExcluirAutorCommand(Guid idAutor)
        {
            IdAutor = idAutor;
        }
    }
}
