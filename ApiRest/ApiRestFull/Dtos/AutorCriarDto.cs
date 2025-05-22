using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Dtos;

public class AutorCriarDto
{   
    public required string Nome { get; set; } = string.Empty;

    public required string Sobrenome { get; set; } = string.Empty;
}