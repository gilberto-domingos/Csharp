using MediatR;

namespace DevLabs.Api.Commands.Livro
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
