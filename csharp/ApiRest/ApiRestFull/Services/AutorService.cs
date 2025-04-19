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
        RespostaApiDto<List<AutorModel>> resposta = new RespostaApiDto<List<AutorModel>>();
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
            return resposta;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<AutorModel>> ListarAutorId(int IdAutor)
    {
        RespostaApiDto<AutorModel> resposta = new RespostaApiDto<AutorModel>();

        {
            try
            {
                var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == IdAutor);

                if (autor == null)
                {
                    resposta.Mensagem = "Nenhum registro encontrado!";
                    return resposta;
                }

                resposta.Dados = autor;
                resposta.Mensagem = "Registro encontrado!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    }

    public async Task<RespostaApiDto<AutorModel>> ListarAutorPorIdLivro(int IdLivro)
    {
        RespostaApiDto<AutorModel> resposta = new RespostaApiDto<AutorModel>();

        try
        {
            var livro = await _context.Livros
                .Include(a => a.AutorModel)
                .FirstOrDefaultAsync(livroBanco => livroBanco.IdLivro == IdLivro);

            if (livro == null)
            {
                resposta.Mensagem = "Nenhum registro encontrado!";
                return resposta;
            }

            resposta.Dados = livro.AutorModel;
            resposta.Mensagem = "Registro encontrado!";
            return resposta;
        }

        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public async Task<RespostaApiDto<List<AutorModel>>> CriarAutor(AutorModelCriarDto autorModelCriarDto)
    {
        RespostaApiDto<List<AutorModel>> resposta = new RespostaApiDto<List<AutorModel>>();
        try
        {
            var autor = new AutorModel()
            {
                Nome = autorModelCriarDto.Nome,
                Sobrenome = autorModelCriarDto.Sobrenome
            };

            _context.Add(autor);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Autores.ToListAsync();
            resposta.Mensagem = "AutorModel cadastrado com sucesso !";
            return resposta;
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public async Task<RespostaApiDto<List<AutorModel>>> EditarAutor(AutorEditarDto autorEditarDto)
    {
        RespostaApiDto<List<AutorModel>> resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == autorEditarDto.idAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Registro não localizado !";
                return resposta;
            }

            autor.Nome = autorEditarDto.Nome;
            autor.Sobrenome = autorEditarDto.Sobrenome;
            _context.Update(autor);
            await _context.SaveChangesAsync();
            resposta.Dados = await _context.Autores.ToListAsync();
            resposta.Mensagem = "Registro atualizado com sucesso!";

            return resposta;
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
            return resposta;
        }
    }


    public async Task<RespostaApiDto<List<AutorModel>>> ExcluirAutor(int IdAutor)
    {
        RespostaApiDto<List<AutorModel>> resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autor = await _context.Autores
            .FirstOrDefaultAsync(autorBanco => autorBanco.IdAutor == IdAutor);

            if (autor == null)
            {
                resposta.Mensagem = "Nenhum registro foi encontrado";
                return resposta;
            }

            _context.Remove(autor);
            await _context.SaveChangesAsync();
            resposta.Mensagem = "Registro apagado com sucesso !";
            resposta.Dados = await _context.Autores.ToListAsync();
        }
        catch (Exception ex)
        {

            resposta.Mensagem = ex.Message;
            resposta.Status = false;

        }

        return resposta;
    }

}