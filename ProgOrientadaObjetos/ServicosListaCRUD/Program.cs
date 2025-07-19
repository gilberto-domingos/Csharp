using ServicosListaCRUD;

class Program
{
    public static void Main(string[] args)
    {
        var filmeService = new FilmeService();
        
        FilmesMock.SeedFilmes(filmeService);
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Controle de Filmes Assistidos ===\n");

            Console.WriteLine("1 - Adicionar novo filme");
            Console.WriteLine("2 - Listar todos os filmes");
            Console.WriteLine("3 - Filtrar filmes por gênero");
            Console.WriteLine("4 - Filtrar filmes por status");
            Console.WriteLine("5 - Atualizar avaliação ou status de um filme");
            Console.WriteLine("6 - Remover filme pelo título");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            var opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Título: ");
                    var titulo = Console.ReadLine();

                    Console.Write("Gênero: ");
                    var genero = Console.ReadLine();

                    Console.Write("Avaliação: ");
                    var avaliacao = Console.ReadLine();

                    Console.Write("Status (assistido/não assistido): ");
                    var status = Console.ReadLine();

                    try
                    {
                        filmeService.AdicionarFilme(titulo ?? "", genero ?? "", avaliacao ?? "", status ?? "");
                        Console.WriteLine("\nFilme adicionado com sucesso!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"\nErro: {ex.Message}");
                    }
                    break;

                case "2":
                    var filmes = filmeService.ObterTodosFilmes();
                    if (!filmes.Any())
                    {
                        Console.WriteLine("Nenhum filme cadastrado.");
                    }
                    else
                    {
                        foreach (var filme in filmes)
                        {
                            Console.WriteLine(filme);
                        }
                    }
                    break;

                case "3":
                    Console.Write("Digite o gênero a ser filtrado: ");
                    var buscaGenero = Console.ReadLine();

                    var encontradosGenero = filmeService.FiltrarPorGenero(buscaGenero ?? "");
                    if (encontradosGenero.Any())
                    {
                        Console.WriteLine("\nFilmes encontrados:");
                        foreach (var f in encontradosGenero)
                            Console.WriteLine(f);
                    }
                    else
                    {
                        Console.WriteLine("\nNenhum filme encontrado com esse gênero.");
                    }
                    break;

                case "4":
                    Console.Write("Digite o status a ser filtrado (assistido/não assistido): ");
                    var buscaStatus = Console.ReadLine();

                    var encontradosStatus = filmeService.FiltrarPorStatus(buscaStatus ?? "");
                    if (encontradosStatus.Any())
                    {
                        Console.WriteLine("\nFilmes encontrados:");
                        foreach (var f in encontradosStatus)
                            Console.WriteLine(f);
                    }
                    else
                    {
                        Console.WriteLine("\nNenhum filme encontrado com esse status.");
                    }
                    break;

                case "5":
                    Console.Write("Digite o título do filme a ser atualizado: ");
                    var tituloAtualizar = Console.ReadLine();

                    Console.Write("Nova avaliação (pressione Enter para não alterar): ");
                    var novaAvaliacao = Console.ReadLine();

                    Console.Write("Novo status (pressione Enter para não alterar): ");
                    var novoStatus = Console.ReadLine();

                    var atualizado = filmeService.AtualizarFilme(tituloAtualizar ?? "", novaAvaliacao, novoStatus);
                    if (atualizado)
                        Console.WriteLine("\nFilme atualizado com sucesso.");
                    else
                        Console.WriteLine("\nFilme não encontrado.");
                    break;

                case "6":
                    Console.Write("Digite o título do filme a ser removido: ");
                    var tituloRemover = Console.ReadLine();

                    var removido = filmeService.RemoverFilmePorTitulo(tituloRemover ?? "");
                    if (removido)
                        Console.WriteLine("\nFilme removido com sucesso.");
                    else
                        Console.WriteLine("\nFilme não encontrado.");
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
    
    private static void SeedFilmes(FilmeService service)
    {
        if (service.ObterTodosFilmes().Any()) return;

        service.AdicionarFilme("Matrix", "Ficção Científica", "10", "Assistido");
        service.AdicionarFilme("Titanic", "Romance", "9", "Assistido");
        service.AdicionarFilme("Oppenheimer", "Drama", "8", "Não Assistido");
        service.AdicionarFilme("John Wick", "Ação", "9", "Assistido");
        service.AdicionarFilme("Soul", "Animação", "10", "Não Assistido");
    }
}
