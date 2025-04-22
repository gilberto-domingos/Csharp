using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.DTOs;

public class AutorVinculoDto
{
    [Key]
    public Guid IdAutor { get; init; }

    [Required]
    public required string Nome { get; set; } = string.Empty;

    [Required]
    public required string Sobrenome { get; set; } = string.Empty;
}