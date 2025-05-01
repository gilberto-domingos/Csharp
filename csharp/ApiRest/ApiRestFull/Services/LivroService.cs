using ApiRestFull.DTOs;
using ApiRestFull.Exceptions;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;

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

    public async Task<RespostaApiDto<List<LivroModel>>> ListarLivroPorIdAutor(Guid idAutor)
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();
        try
        {
            var livro = await _livroRepository.ListarLivroPorIdAutor(idAutor);
            resposta.Dados = livro;
            resposta.Mensagem = "Registro encontrado com sucesso!";
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
            await _livroRepository.CriarLivro(livroCriarDto);
            var livros = await _livroRepository.ListarLivros();
            resposta.Dados = livros;
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
            var livros = await _livroRepository.EditarLivro(livroEditarDto);

            resposta.Dados = livros;
            resposta.Mensagem = "Livro editado com sucesso!";
        }
        catch (NotFoundException ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }
        catch (Exception ex)
        {
            resposta.Mensagem = $"Erro ao editar livro: {ex.Message}";
            resposta.Status = false;
        }
        return resposta;
    }

    public async Task<RespostaApiDto<List<LivroModel>>> ExcluirLivro(Guid idLivro)
    {
        var resposta = new RespostaApiDto<List<LivroModel>>();
        try
        {
            var livros = await _livroRepository.ExcluirLivro(idLivro);

            resposta.Dados = livros;
            resposta.Mensagem = "Livro excluído com sucesso!";
        }
        catch (NotFoundException ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }
        catch (Exception ex)
        {
            resposta.Mensagem = $"Erro ao excluir livro: {ex.Message}";
            resposta.Status = false;
        }
        return resposta;
    }


}
