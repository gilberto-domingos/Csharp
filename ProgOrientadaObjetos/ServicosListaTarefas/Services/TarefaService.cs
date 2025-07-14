using ServicosListaTarefas.Models;

namespace ServicosListaTarefas.Services;

internal class TarefaService
{
    private readonly List<Tarefa> _tarefas = new List<Tarefa>();

    public IReadOnlyList<Tarefa> ObterTodas() => _tarefas.AsReadOnly();

    public void Adicionar(string descricao)
    {
        var tarefa = new Tarefa(descricao);
        _tarefas.Add(tarefa);
    }

    public bool MarcarComoConcluida(int indice)
    {
        if(indice < 0 || indice >=_tarefas.Count)
         return false;
        
        _tarefas[indice].MarcarConcluida();
         return true;
    }
}