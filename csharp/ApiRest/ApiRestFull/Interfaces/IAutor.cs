using SistemaVendas.DTOs;
using SistemaVendas.Models;

namespace SistemaVendas.Interfaces;

public interface IAutor
{
    Task<DtoResponse<List<Autor>>> ListarAutores();
    Task<DtoResponse<Autor>> ListarAutorId(int idAutor);
    Task<DtoResponse<Autor>> ListarAutorPorIdLivro(int IdLivro);
}