using Microsoft.AspNetCore.Mvc;
using MediatR;
using LaboratorioDeTestesAPI.Dtos;
using LaboratorioDeTestesAPI.Entities;
using LaboratorioDeTestesAPI.Handlers.Livro.Commands;
using LaboratorioDeTestesAPI.Handlers.Commands;
using LaboratorioDeTestesAPI.Handlers.Livro.Queries;
using LaboratorioDeTestesAPI.Queries.Livro;  
 


namespace LaboratorioDeTestesAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class LivroController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LivroController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<Livro>> CriarLivro(LivroCriarDto livroCriarDto)
        {
            var livro = await _mediator.Send(new CriarLivroCommand(livroCriarDto));
            return Ok(livro);
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<List<Livro>>> ListarLivros()
        {
            var livros = await _mediator.Send(new ListarLivrosQuery());
            return Ok(livros);
        }

        [HttpGet("ListarLivroId/{idLivro:guid}")]
        public async Task<ActionResult<Livro>> ListarLivroId(Guid idLivro)
        {
            var livro = await _mediator.Send(new ListarLivroIdQuery(idLivro));
            return Ok(livro);
        }

        [HttpGet("ListarLivroPorIdAutor/{idAutor:guid}")]
        public async Task<ActionResult<Livro>> ListarLivroPorIdAutor(Guid idAutor)
        {
            var livro = await _mediator.Send(new ListarLivrosPorIdAutorQuery(idAutor));
            return Ok(livro);
        }


        [HttpPut("EditarLivro")]
        public async Task<ActionResult<Livro>> EditarLivro(LivroEditarDto dto)
        {
            var livro = await _mediator.Send(new UpdateLivroCommand(dto));
            return Ok(livro);
        }

        [HttpDelete("ExcluirLivro/{idLivro:guid}")]
        public async Task<ActionResult<Livro>> ExcluirLivro(Guid idLivro)
        {
            var livro = await _mediator.Send(new DeleteLivroCommand(idLivro));
            return Ok(livro);
        }
    }
}
