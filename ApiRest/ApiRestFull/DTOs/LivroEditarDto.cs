using ApiRestFull.Models;

namespace ApiRestFull.DTOs;

public class LivroEditarDto
{
    public int IdLivro { get; set; }
    public string Titulo { get; set; }
    public int IdAutor { get; set; }
    public AutorVinculoDto Autor { get; set; }
}