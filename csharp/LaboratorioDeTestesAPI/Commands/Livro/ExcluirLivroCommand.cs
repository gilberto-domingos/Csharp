using MediatR;

namespace LaboratorioDeTestesAPI.Handlers.Commands
{
    public class ExcluirLivroCommand : IRequest<Entities.Livro>
    {
        public Guid IdLivro { get; }

        public ExcluirLivroCommand(Guid idLivro)
        {
            IdLivro = idLivro;
        }
    }
}
