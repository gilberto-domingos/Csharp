using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.DTOs;

public class AutorEditarDto
{
    public int idAutor { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public string Sobrenome { get; set; } = string.Empty;
}