using ServicosAgendaContatos.Services;

namespace ServicosAgendaContatos;


class Program
{
    public static void Main(string[] args)
    {
        var contatoService = new ContatoService();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Agenda de Contatos ===\n");

            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar todos os contatos");
            Console.WriteLine("3 - Buscar contato por nome");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            var opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    var nome = Console.ReadLine();

                    Console.Write("Telefone: ");
                    var telefone = Console.ReadLine();

                    Console.Write("E-mail: ");
                    var email = Console.ReadLine();

                    try
                    {
                        contatoService.AdicionarContato(nome ?? "", telefone ?? "", email ?? "");
                        Console.WriteLine("\nContato adicionado com sucesso!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"\nErro: {ex.Message}");
                    }

                    break;

                case "2":
                    var contatos = contatoService.ObterTodos();
                    if (!contatos.Any())
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }
                    else
                    {
                        foreach (var contato in contatos)
                        {
                            Console.WriteLine(contato);
                        }
                    }

                    break;

                case "3":
                    Console.Write("Digite o nome a ser buscado: ");
                    var buscaNome = Console.ReadLine();

                    var encontrado = contatoService.BuscarPorNome(buscaNome ?? "");
                    if (encontrado is not null)
                    {
                        Console.WriteLine("\nContato encontrado:");
                        Console.WriteLine(encontrado);
                    }
                    else
                    {
                        Console.WriteLine("\nContato não encontrado.");
                    }

                    break;

                case "0":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}