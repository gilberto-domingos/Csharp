using ApiRestFull.Data;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Services;

public class LivroService : ILivro
{
    private readonly ApiDbContext _context;

    public LivroService(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> ListarLivros()
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();

        try
        {
            var livros = await _context.Livros.Include(livro => livro.Autor).ToListAsync();
            resposta.Dados = livros;
            resposta.Mensagem = "Todos os livros foram coletados com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<LivroModel>> ListarLivroId(int idLivro)
    {
        var resposta = new RespostaApiDto<LivroModel>();

        try
        {
            var livro = await _context.Livros.Include(livro => livro.Autor)
                                             .FirstOrDefaultAsync(livroBanco => livroBanco.IdLivro == idLivro);

            if (livro == null)
            {
                resposta.Mensagem = "Registro do livro não foi encontrado!";
                return resposta;
            }

            resposta.Dados = livro;
            resposta.Mensagem = "Registro do livro encontrado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> ListarLivroPorIdAutor(int idAutor)
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();

        try
        {
            var livros = await _context.Livros
                .Include(livro => livro.Autor)
                .Where(livroBanco => livroBanco.Autor.IdAutor == idAutor)
                .ToListAsync();

            if (livros == null || livros.Count == 0)
            {
                resposta.Mensagem = "Nenhum livro encontrado para esse autor!";
                return resposta;
            }

            resposta.Dados = livros;
            resposta.Mensagem = "Livros encontrados com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> CriarLivro(LivroCriarDto livroCriarDto)
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();

        try
        {
            var autor = await _context.Autores
                .FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == livroCriarDto.Autor.IdAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Autor não encontrado.";
                return resposta;
            }

            var livro = new LivroModel
            {
                Titulo = livroCriarDto.Titulo,
                Autor = autor
            };

            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Livros.Include(livro => livro.Autor).ToListAsync();
            resposta.Mensagem = "Livro criado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> EditarLivro(LivroEditarDto livroEditarDto)
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();

        try
        {
            var livro = await _context.Livros.Include(livro => livro.Autor)
                .FirstOrDefaultAsync(livroBanco => livroBanco.IdLivro == livroEditarDto.IdLivro);

            if (livro == null)
            {
                resposta.Mensagem = "Livro não encontrado!";
                return resposta;
            }

            var autor = await _context.Autores
                .FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == livroEditarDto.Autor.IdAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Autor não encontrado!";
                return resposta;
            }

            livro.Titulo = livroEditarDto.Titulo;
            livro.Autor = autor;

            _context.Livros.Update(livro);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Livros.Include(livro => livro.Autor).ToListAsync();
            resposta.Mensagem = "Livro atualizado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> ExcluirLivro(int idLivro)
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();

        try
        {
            var livro = await _context.Livros.Include(livro => livro.Autor)
                .FirstOrDefaultAsync(livroBanco => livroBanco.IdLivro == idLivro);

            if (livro == null)
            {
                resposta.Mensagem = "Livro não encontrado!";
                return resposta;
            }

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Livros.Include(livro => livro.Autor).ToListAsync();
            resposta.Mensagem = "Livro excluído com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }
}
