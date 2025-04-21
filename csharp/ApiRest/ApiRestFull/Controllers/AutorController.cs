using Microsoft.AspNetCore.Mvc;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutorController : ControllerBase
{
    private readonly IAutor _autorInterface;

    public AutorController(IAutor autorInterface)
    {
        _autorInterface = autorInterface;
    }


    [HttpGet("ListarAutores")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> ListarAutores()
    {
        var autores = await _autorInterface.ListarAutores();
        return Ok(autores);
    }

    [HttpGet("ListarAutorId/{idAutor}")]
    public async Task<ActionResult<RespostaApiDto<AutorModel>>> ListarAutorId(int idAutor)
    {
        var autor = await _autorInterface.ListarAutorId(idAutor);
        return Ok(autor);
    }

    [HttpGet("ListarAutorPorIdLivro/{idLivro}")]
    public async Task<ActionResult<RespostaApiDto<AutorModel>>> ListarAutorPorIdLivro(int idLivro)
    {
        var autor = await _autorInterface.ListarAutorPorIdLivro(idLivro);
        return Ok(autor);
    }

    [HttpPost("CriarAutor")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> CriarAutor(AutorCriarDto autorCriarDto)
    {
        var autores = await _autorInterface.CriarAutor(autorCriarDto);
        return Ok(autores);

    }

    [HttpPut("EditarAutor")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> EditarAutor(AutorEditarDto autorEditarDto)
    {
        var autores = await _autorInterface.EditarAutor(autorEditarDto);
        return Ok(autores);
    }

    [HttpDelete("ExcluirAutor")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> ExcluirAutor(int idAutor)
    {
        var autores = await _autorInterface.ExcluirAutor(idAutor);
        return Ok(autores);
    }


}