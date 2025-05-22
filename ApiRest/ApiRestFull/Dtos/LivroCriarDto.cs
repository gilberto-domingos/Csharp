using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Dtos;

public class LivroCriarDto
{
    public required string Titulo { get; set; }

    public Guid IdAutor { get; init; }

    public required AutorVinculoDto Autor { get; set; }
}