using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Dtos;

public class AutorVinculoDto
{
    [Key]
    public Guid IdAutor { get; init; }

    public required string Nome { get; set; } = string.Empty;

    public required string Sobrenome { get; set; } = string.Empty;
}