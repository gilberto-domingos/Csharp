using MediatR;
using ApiRestFull.DTOs;
using ApiRestFull.Commands.Autor;
using ApiRestFull.Queries.Autor;
using Microsoft.AspNetCore.Mvc;
using ApiRestFull.Models;

namespace ApiRestFull.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutorController : ControllerBase
{
    private readonly IMediator _mediator;

    public AutorController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("ListarAutores")]
    public async Task<ActionResult<List<AutorModel>>> ListarAutores()
    {
        var result = await _mediator.Send(new ListarAutoresQuery());
        return Ok(result);
    }

    [HttpGet("ListarAutorId/{idAutor:guid}")]
    public async Task<ActionResult<AutorModel>> ListarAutorId(Guid idAutor)
    {
        var result = await _mediator.Send(new ListarAutorIdQuery(idAutor));
        return Ok(result);
    }

    [HttpGet("ListarAutorPorIdLivro/{idLivro:guid}")]
    public async Task<ActionResult<AutorModel>> ListarAutorPorIdLivro(Guid idLivro)
    {
        var result = await _mediator.Send(new ListarAutorPorIdLivroQuery(idLivro));
        return Ok(result);
    }

    [HttpPost("CriarAutor")]
    public async Task<ActionResult<AutorModel>> CriarAutor(AutorCriarDto dto)
    {
        var result = await _mediator.Send(new CriarAutorCommand(dto));
        return Ok(result);
    }

    [HttpPut("EditarAutor")]
    public async Task<ActionResult<AutorModel>> EditarAutor(AutorEditarDto dto)
    {
        var result = await _mediator.Send(new EditarAutorCommand(dto));
        return Ok(result);
    }

    [HttpDelete("ExcluirAutor/{idAutor:guid}")]
    public async Task<ActionResult<AutorModel>> ExcluirAutor(Guid idAutor)
    {
        var result = await _mediator.Send(new ExcluirAutorCommand(idAutor));
        return Ok(result);
    }
}
