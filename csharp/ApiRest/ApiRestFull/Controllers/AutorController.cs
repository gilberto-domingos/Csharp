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

    [HttpGet("ListarAutorId/{IdAutor}")]
    public async Task<ActionResult<RespostaApiDto<AutorModel>>> ListarAutorId(int IdAutor)
    {
        var autor = await _autorInterface.ListarAutorId(IdAutor);
        return Ok(autor);
    }

    [HttpGet("ListarAutorPorIdLivro/{IdLivro}")]
    public async Task<ActionResult<RespostaApiDto<AutorModel>>> ListarAutorPorIdLivro(int IdLivro)
    {
        var autor = await _autorInterface.ListarAutorPorIdLivro(IdLivro);
        return Ok(autor);
    }

    [HttpPost("CriarAutor")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> CriarAutor(AutorModelCriarDto autorModelCriarDto)
    {
        var autor = await _autorInterface.CriarAutor(autorModelCriarDto);
        return Ok(autor);

    }

    [HttpPut("EditarAutor")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> EditarAutor(AutorEditarDto autorEditarDto)
    {
        var autor = await _autorInterface.EditarAutor(autorEditarDto);
        return Ok(autor);
    }

    [HttpDelete("ExcluirAutor")]
    public async Task<ActionResult<RespostaApiDto<List<AutorModel>>>> ExcluirAutor(int IdAutor)
    {
        var autor = await _autorInterface.ExcluirAutor(IdAutor);
        return Ok(autor);
    }


}