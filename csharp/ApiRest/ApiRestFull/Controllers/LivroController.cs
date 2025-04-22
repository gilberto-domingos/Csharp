using Microsoft.AspNetCore.Mvc;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.DTOs;
using Microsoft.Identity.Client;

namespace ApiRestFull.Controllers;


[ApiController]
[Route("api/[Controller]")]
public class LivroController : ControllerBase
{
    private readonly ILivro _livroInterface;


    public LivroController(ILivro livroInterface)
    {

        _livroInterface = livroInterface;
    }

    [HttpGet("ListarLivros")]
    public async Task<ActionResult<RespostaApiDto<List<LivroModel>>>> ListarLivros()
    {
        var livros = await _livroInterface.ListarLivros();
        return Ok(livros);
    }

    [HttpGet("ListarLivroId/{idLivro:guid}")]
    public async Task<ActionResult<RespostaApiDto<LivroModel>>> ListarLivroId(Guid idLivro)
    {
        var livros = await _livroInterface.ListarLivroId(idLivro);
        return Ok(livros);
    }

    [HttpGet("ListarLivroPorIdAutor/{idAutor:guid}")]
    public async Task<ActionResult<RespostaApiDto<LivroModel>>> ListarLivroPorIdAutor(Guid idAutor)
    {
        var livro = await _livroInterface.ListarLivroPorIdAutor(idAutor);
        return Ok(livro);
    }

    [HttpPost("CriarLivro")]
    public async Task<ActionResult<RespostaApiDto<List<LivroModel>>>> CriarLivro(LivroCriarDto livroCriarDto)
    {
        var livros = await _livroInterface.CriarLivro(livroCriarDto);
        return Ok(livros);
    }

    [HttpPut("EditarLivro")]
    public async Task<ActionResult<RespostaApiDto<List<LivroModel>>>> EditarLivro(LivroEditarDto livroEditarDto)
    {
        var livros = await _livroInterface.EditarLivro(livroEditarDto);
        return Ok(livros);
    }

    [HttpDelete("ExcluirLivro/{idLivro:guid}")]
    public async Task<ActionResult<RespostaApiDto<List<LivroModel>>>> ExcluirLivro(Guid idLivro)
    {
        var livros = await _livroInterface.ExcluirLivro(idLivro);
        return Ok(livros);
    }





}