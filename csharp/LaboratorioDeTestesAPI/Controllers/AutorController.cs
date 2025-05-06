using MediatR;
using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Commands.Autor;
using LaboratorioDeTestesAPI.Queries.Autor;
using Microsoft.AspNetCore.Mvc;
using LaboratorioDeTestesAPI.Entities;

namespace LaboratorioDeTestesAPI.Controllers;

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
    public async Task<ActionResult<List<Autor>>> ListarAutores()
    {
        var result = await _mediator.Send(new ListarAutoresQuery());
        return Ok(result);
    }

    [HttpGet("ListarAutorId/{idAutor:guid}")]
    public async Task<ActionResult<Autor>> ListarAutorId(Guid idAutor)
    {
        var result = await _mediator.Send(new ListarAutorIdQuery(idAutor));
        return Ok(result);
    }

    [HttpGet("ListarAutorPorIdLivro/{idLivro:guid}")]
    public async Task<ActionResult<Autor>> ListarAutorPorIdLivro(Guid idLivro)
    {
        var result = await _mediator.Send(new ListarAutorPorIdLivroQuery(idLivro));
        return Ok(result);
    }

    [HttpPost("CriarAutor")]
    public async Task<ActionResult<Autor>> CriarAutor(AutorCriarDto dto)
    {
        var result = await _mediator.Send(new CriarAutorCommand(dto));
        return Ok(result);
    }

    [HttpPut("EditarAutor")]
    public async Task<ActionResult<Autor>> EditarAutor(AutorEditarDto dto)
    {
        var result = await _mediator.Send(new EditarAutorCommand(dto));
        return Ok(result);
    }

    [HttpDelete("ExcluirAutor/{idAutor:guid}")]
    public async Task<ActionResult<Autor>> ExcluirAutor(Guid idAutor)
    {
        var result = await _mediator.Send(new ExcluirAutorCommand(idAutor));
        return Ok(result);
    }
}
