using ApiRestFull.Data;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Services;

public class LivroService : ILivro
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> ListarLivros()
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();
        try
        {
            var livros = await _livroRepository.ListarLivros();
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

    public async Task<RespostaApiDto<LivroModel>> ListarLivroId(Guid idLivro)
    {
        var resposta = new RespostaApiDto<LivroModel>();
        try
        {
            var livro = await _livroRepository.ListarLivroId(idLivro);
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

    public Task<RespostaApiDto<List<LivroModel>>> ListarLivroPorIdAutor(Guid idAutor)
    {
        throw new NotImplementedException();
    }

    public Task<RespostaApiDto<List<LivroModel>>> CriarLivro(LivroCriarDto livroModelCriarDto)
    {
        throw new NotImplementedException();
    }

    public Task<RespostaApiDto<List<LivroModel>>> EditarLivro(LivroEditarDto livroEditarDto)
    {
        throw new NotImplementedException();
    }

    public Task<RespostaApiDto<List<LivroModel>>> ExcluirLivro(Guid idLivro)
    {
        throw new NotImplementedException();
    }

}
