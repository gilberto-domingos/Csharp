using Microsoft.EntityFrameworkCore;
using ApiRestFull.Data;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

namespace ApiRestFull.Services;

public class AutorService : IAutor
{
    private readonly ApiDbContext _context;

    public AutorService(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<RespostaApiDto<List<AutorModel>>> ListarAutores()
    {
        var resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autores = await _context.Autores.ToListAsync();
            resposta.Dados = autores;
            resposta.Mensagem = "Todos os autores foram coletados";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<AutorModel>> ListarAutorId(int idAutor)
    {
        var resposta = new RespostaApiDto<AutorModel>();

        try
        {
            var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == idAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Nenhum registro encontrado!";
                return resposta;
            }

            resposta.Dados = autor;
            resposta.Mensagem = "Registro encontrado!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<AutorModel>> ListarAutorPorIdLivro(int idLivro)
    {
        var resposta = new RespostaApiDto<AutorModel>();

        try
        {
            var livro = await _context.Livros
                .Include(livro => livro.Autor)
                .FirstOrDefaultAsync(livroBanco => livroBanco.IdLivro == idLivro);

            if (livro == null)
            {
                resposta.Mensagem = "Nenhum registro encontrado!";
                return resposta;
            }

            resposta.Dados = livro.Autor;
            resposta.Mensagem = "Registro encontrado!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<AutorModel>>> CriarAutor(AutorCriarDto autorCriarDto)
    {
        var resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autor = new AutorModel
            {
                Nome = autorCriarDto.Nome,
                Sobrenome = autorCriarDto.Sobrenome
            };

            _context.Add(autor);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Autores.ToListAsync();
            resposta.Mensagem = "Autor cadastrado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<AutorModel>>> EditarAutor(AutorEditarDto autorEditarDto)
    {
        var resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == autorEditarDto.idAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Registro não localizado!";
                return resposta;
            }

            autor.Nome = autorEditarDto.Nome;
            autor.Sobrenome = autorEditarDto.Sobrenome;

            _context.Update(autor);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Autores.ToListAsync();
            resposta.Mensagem = "Registro atualizado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<AutorModel>>> ExcluirAutor(int idAutor)
    {
        var resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == idAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Nenhum registro foi encontrado";
                return resposta;
            }

            _context.Remove(autor);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Autores.ToListAsync();
            resposta.Mensagem = "Registro apagado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }
}
