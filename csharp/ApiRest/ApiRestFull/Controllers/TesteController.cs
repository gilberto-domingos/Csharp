using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Data;
using SistemaVendas.Entities;

namespace SistemaVendas.Controllers;

[ApiController]
[Route("[controller]")]
public class TesteController : ControllerBase
{
    private readonly ApiDbContext _context;

    public TesteController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpPost("add")]
    public IActionResult AddProduto()
    {
        var novoProduto = new Produto
        {
            Id = 01,
            Nome = "Produto Teste",
            Preco = 99.99M
        };

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