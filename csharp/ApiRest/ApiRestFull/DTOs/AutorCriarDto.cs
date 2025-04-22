using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.DTOs;

public class AutorCriarDto
{
    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public string Sobrenome { get; set; } = string.Empty;
}