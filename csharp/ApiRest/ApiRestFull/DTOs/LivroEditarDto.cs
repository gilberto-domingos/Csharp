using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.DTOs;

public class LivroEditarDto
{
    public Guid IdLivro { get; init; }


    public required string Titulo { get; set; }

    public Guid IdAutor { get; init; }


    public required AutorVinculoDto Autor { get; set; }
}