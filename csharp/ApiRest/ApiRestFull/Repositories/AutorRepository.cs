using Microsoft.EntityFrameworkCore;
using ApiRestFull.Data;
using ApiRestFull.Interfaces;
using ApiRestFull.Models;
using ApiRestFull.Exceptions;

namespace ApiRestFull.Repositories;

public class AutorRepository : IAutorRepository
{
    private readonly ApiDbContext _context;

    public AutorRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<List<AutorModel>> ListarAutores()
    {
        return await _context.Autores.ToListAsync();
    }

    public async Task<AutorModel> ListarAutorPorId(Guid idAutor)
    {
        var autor = await _context.Autores
                                  .FirstOrDefaultAsync(livro => livro.IdAutor == idAutor);

        if (autor == null)
            throw new Exception($"Autor com ID {idAutor} não encontrado.");

        return autor;
    }

    public async Task<AutorModel> ListarAutorPorIdLivro(Guid idLivro)
    {
        var livro = await _context.Livros
                                  .Include(l => l.Autor)
                                  .FirstOrDefaultAsync(l => l.IdLivro == idLivro);

        if (livro == null || livro.Autor == null)
            throw new NotFoundException($"Livro com ID {idLivro} ou seu autor não foram encontrados.");

        return livro.Autor;
    }


    public async Task<AutorModel> CriarAutor(AutorModel autor)
    {
        _context.Add(autor);
        await _context.SaveChangesAsync();
        return autor;
    }

    public async Task<AutorModel> EditarAutor(AutorModel autor)
    {
        _context.Update(autor);
        await _context.SaveChangesAsync();
        return autor;
    }

    public async Task<AutorModel> ExcluirAutor(Guid idAutor)
    {
        var autor = await _context.Autores.FirstOrDefaultAsync(a => a.IdAutor == idAutor);
        if (autor == null)
            throw new NotFoundException($"Autor com ID {idAutor} não encontrado.");


        _context.Remove(autor);
        await _context.SaveChangesAsync();
        return autor;
    }
}
