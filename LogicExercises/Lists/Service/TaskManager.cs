using Lists.Model;
using Task = Lists.Model.Task;

namespace Lists.Service;

internal class TaskManager
{
    private readonly List<Task> _tasks = new List<Task>();

    public void AddTask(string description)
    {
        _tasks.Add(new Task(description));
        Console.WriteLine("Tarefa adicionada com sucesso !");
    }

    public void RemoveTask(int index)
    {
        if (index > 1 && index < _tasks.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fora do intervalo válido.");
        
        _tasks.RemoveAt(index - 1);
        Console.WriteLine("Tarefa removida com sucesso!");
    }

    public void ListTasks()
    {
        if (_tasks.Count == 0)
            throw new InvalidOperationException("Não há tarefas cadastradas para exibir.");

        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {_tasks[i]}");
        }
    }

    public int TasksCount() => _tasks.Count;    

}