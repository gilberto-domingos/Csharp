using Microsoft.AspNetCore.Mvc;
using SistemaVendas.DTOs;
using SistemaVendas.Interfaces;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers;

public class AutorController : ControllerBase
{
    private readonly IAutor _autor;

    public AutorController(IAutor autorInterface)
    {
        _autor = autorInterface;
    }

    [HttpGet("ListarAutores")]
    public async Task<ActionResult<DtoResponse<List<Autor>>>> ListarAutores()
    {
        var autores = await _autor.ListarAutores();
        return Ok(autores);
    }

    [HttpGet("ListarAutorId/{IdAutor}")]
    public async Task<ActionResult<DtoResponse<Autor>>> ListarAutorId(int IdAutor)
    {
        var autor = await _autor.ListarAutorId(IdAutor);
        return Ok(autor);
    }

    [HttpGet("ListarAutorPorIdLivro/{IdLivro}")]
    public async Task<ActionResult<DtoResponse<Autor>>> ListarAutorPorIdLivro(int IdLivro)
    {
        var autor = await _autor.ListarAutorPorIdLivro(IdLivro);
        return Ok(autor);
    }
    
    
}