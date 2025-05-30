using MediatR;

namespace ApiRestFull.Commands
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
