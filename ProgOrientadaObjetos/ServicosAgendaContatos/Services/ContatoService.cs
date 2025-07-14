using ServicosAgendaContatos.Models;

namespace ServicosAgendaContatos.Services;

internal class ContatoService
{
    private readonly List<Contato> _contatos = new List<Contato>();

    public IReadOnlyList<Contato> ObterTodos() => _contatos.AsReadOnly();

    public void AdicionarContato(string nome, string telefone, string email)
    {
        var contato = new Contato(nome, telefone, email);
        _contatos.Add(contato);
    }

    public Contato? BuscarPorNome(string nome)
    {
        return _contatos.FirstOrDefault(c => string.Equals(c.Nome, nome, StringComparison.OrdinalIgnoreCase));
    }
}