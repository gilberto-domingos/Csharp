using ServicosListaTarefas.Models;
using ServicosListaTarefas.Services;

namespace ServicosListaTarefas;

class Program
{
    public static void Main(string[] args)
    {
        var tarefaService = new TarefaService();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Tarefas ===\n");

            var tarefas = tarefaService.ObterTodas();
            if (!tarefas.Any())
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }

            Console.WriteLine("\nOpções:");
            Console.WriteLine("1 - Adicionar nova tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            var opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Descrição da nova tarefa: ");
                    var descricao = Console.ReadLine();
                    tarefaService.Adicionar(descricao ?? string.Empty);
                    break;

                case "2":
                    Console.Write("Digite o número da tarefa a concluir: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        var sucesso = tarefaService.MarcarComoConcluida(numero - 1);
                        Console.WriteLine(sucesso 
                            ? "Tarefa marcada como concluída com sucesso!"
                            : "Índice inválido. Nenhuma tarefa foi marcada.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}