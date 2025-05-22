using System.ComponentModel.DataAnnotations;

namespace ApiRestFull.Dtos;

public class AutorEditarDto
{
    public Guid idAutor { get; init; }

    public required string Nome { get; set; } = string.Empty;

    public required string Sobrenome { get; set; } = string.Empty;
}