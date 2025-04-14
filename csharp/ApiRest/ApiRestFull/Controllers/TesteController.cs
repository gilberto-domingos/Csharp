using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Data;
using SistemaVendas.Entities;

namespace SistemaVendas.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TesteController : ControllerBase
{
    private readonly ApiDbContext _context;

    public TesteController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpPost("add")]
    public IActionResult AddProduto([FromBody] Produto novoProduto)
    {
        _context.Produtos.Add(novoProduto);
        _context.SaveChanges();

        return Ok(novoProduto);
    }

    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_context.Produtos.ToList());
    }
}