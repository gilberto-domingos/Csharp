namespace ServicosAgendaContatos.Models;

internal class Contato
{
    private string _nome;
    private string _telefone;
    private string _email;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string Telefone
    {
        get => _telefone;
        set => _telefone = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public Contato(string nome, string telefone, string email)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome é obrigatório.", nameof(nome));

        if (string.IsNullOrWhiteSpace(telefone))
            throw new ArgumentException("O telefone é obrigatorio.", nameof(telefone));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("O email é obrigatório.", nameof(email));
        
        _nome = nome;
        _telefone = telefone;
        _email = email;
    }

    public override string ToString()
    {
        return $"Nome : {_nome} | Telefone: {_telefone} | Email: {_email}";
    }
}