namespace ServicosListaCRUD;

internal static class FilmesMock
{
    public static void SeedFilmes(FilmeService service)
    {
        if(service.ObterTodosFilmes().Any()) return;
        
        service.AdicionarFilme("Matrix", "Ficção Científica", "10", "Assistido");
        service.AdicionarFilme("Titanic", "Romance", "9", "Assistido");
        service.AdicionarFilme("Oppenheimer", "Drama", "8", "Não Assistido");
        service.AdicionarFilme("John Wick", "Ação", "9", "Assistido");
        service.AdicionarFilme("Soul", "Animação", "10", "Não Assistido");
    }
    
}