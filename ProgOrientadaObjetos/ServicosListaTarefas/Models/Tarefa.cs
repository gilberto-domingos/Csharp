namespace ServicosListaTarefas.Models;

internal class Tarefa
{
    public string Descricao { get; private set; }
    public bool Concluida { get; private set; }

    public Tarefa(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
            throw new ArgumentException("A descrição da tarefa não pode estar vazia");
        
        Descricao = descricao;
        Concluida = false;
    }

    public void MarcarConcluida()
    {
        Concluida = true;
    }

    public override string ToString()
    {
        var status = Concluida ? "[v]" : "[ ]";
        return $"{status}{Descricao}";
    }
}