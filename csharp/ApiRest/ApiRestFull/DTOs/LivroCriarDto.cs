using System.ComponentModel.DataAnnotations;
using ApiRestFull.Models;

namespace ApiRestFull.DTOs;

public class LivroCriarDto
{
    public string Titulo { get; set; }

    [Required]
    public int IdAutor { get; set; }
    [Required]
    public AutorVinculoDto Autor { get; set; }
}