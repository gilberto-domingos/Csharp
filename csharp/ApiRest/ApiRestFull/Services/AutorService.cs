using Microsoft.EntityFrameworkCore;
using SistemaVendas.Data;
using SistemaVendas.DTOs;
using SistemaVendas.Interfaces;
using SistemaVendas.Models;

namespace SistemaVendas.Services;

public class AutorService : IAutor
{
    private readonly ApiDbContext _context;

    public AutorService(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<DtoResponse<List<Autor>>> ListarAutores()
    {
        DtoResponse<List<Autor>> response = new DtoResponse<List<Autor>>();
        try
        {
            var autores = await _context.Autores.ToListAsync();
            response.Dados = autores;
            response.Mensagem = "Todos os autores foram coletado";
        }
        catch (Exception ex)
        {
            response.Mensagem = ex.Message;
            response.Status = false;
            return response;
        }

        return response;
    }

    public async Task<DtoResponse<Autor>> ListarAutorId(int IdAutor)
    {
        DtoResponse<Autor> response = new DtoResponse<Autor>();

        {
            try
            {
                var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == IdAutor);

                if (autor == null)
                {
                    response.Mensagem = "Nenhum registro encontrado!";
                    return response;
                }

                response.Dados = autor;
                response.Mensagem = "Registro encontrado!";
                return response;
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }
    }

    public async Task<DtoResponse<Autor>> ListarAutorPorIdLivro(int IdLivro)
    {
        DtoResponse<Autor> response = new DtoResponse<Autor>();

        try
        {
            var livro = await _context.Livros
                .Include(l => l.IdLivro == IdLivro)
                .FirstOrDefaultAsync(livroBanco => livroBanco.IdLivro == IdLivro);

            if (livro == null)
            {
                response.Mensagem = "Nenhum registro encontrado!";
                return response;
            }

            response.Dados = livro.Autor;
            response.Mensagem = "Registro encontrado!";
            return response;
        }

        catch (Exception ex)
        {
            response.Mensagem = ex.Message;
            response.Status = false;
            return response;
        }
    }
}