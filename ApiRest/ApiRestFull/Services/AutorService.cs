using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.DTOs;

namespace ApiRestFull.Services;

public class AutorService : IAutor
{
    private readonly IAutorRepository _autorRepository;

    public AutorService(IAutorRepository autorRepository)
    {
        _autorRepository = autorRepository;
    }

    public async Task<RespostaApiDto<List<AutorModel>>> ListarAutores()
    {
        var resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autores = await _autorRepository.ListarAutores();
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

    public async Task<RespostaApiDto<AutorModel>> ListarAutorId(Guid idAutor)
    {
        var resposta = new RespostaApiDto<AutorModel>();

        try
        {
            var autor = await _autorRepository.ListarAutorPorId(idAutor);
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

    public async Task<RespostaApiDto<AutorModel>> ListarAutorPorIdLivro(Guid idLivro)
    {
        var resposta = new RespostaApiDto<AutorModel>();

        try
        {
            var autor = await _autorRepository.ListarAutorPorIdLivro(idLivro);
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

            var autorCriado = await _autorRepository.CriarAutor(autor);
            resposta.Dados = new List<AutorModel> { autorCriado };
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
            var autor = new AutorModel
            {
                IdAutor = autorEditarDto.idAutor,
                Nome = autorEditarDto.Nome,
                Sobrenome = autorEditarDto.Sobrenome
            };

            var autorAtualizado = await _autorRepository.EditarAutor(autor);
            resposta.Dados = new List<AutorModel> { autorAtualizado };
            resposta.Mensagem = "Autor atualizado com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }

    public async Task<RespostaApiDto<List<AutorModel>>> ExcluirAutor(Guid idAutor)
    {
        var resposta = new RespostaApiDto<List<AutorModel>>();

        try
        {
            var autor = await _autorRepository.ExcluirAutor(idAutor);
            if (autor == null)
            {
                resposta.Mensagem = "Nenhum registro encontrado!";
                return resposta;
            }

            resposta.Mensagem = "Autor excluído com sucesso!";
        }
        catch (Exception ex)
        {
            resposta.Mensagem = ex.Message;
            resposta.Status = false;
        }

        return resposta;
    }
}
