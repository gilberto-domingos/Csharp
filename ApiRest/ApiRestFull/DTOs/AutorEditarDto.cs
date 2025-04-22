using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.DTOs;

public class AutorEditarDto
{
    public Guid idAutor { get; init; }

    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public string Sobrenome { get; set; } = string.Empty;
}