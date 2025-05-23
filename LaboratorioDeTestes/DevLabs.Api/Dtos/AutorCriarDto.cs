using DevLabs.Api.Entities;

namespace DevLabs.Api.Dtos;

public class AutorCriarDto
{
    public required string Nome { get; set; } = string.Empty;

    public required string Sobrenome { get; set; } = string.Empty;

    public required ICollection<LivroCriarDto> Livros { get; set; } = new List<LivroCriarDto>();
}