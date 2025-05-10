using LaboratorioDeTestes.Data;
using LaboratorioDeTestes.Entities;
using LaboratorioDeTestes.Exceptions;
using LaboratorioDeTestes.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioDeTestes.Repositories;

public class AutorRepository : IAutorRepository
{
    private readonly ApiDbContext _context;

    public AutorRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<List<Autor>> ListarAutores()
    {
        return await _context.Autores.ToListAsync();
    }

    public async Task<Autor> ListarAutorPorId(Guid idAutor)
    {
        var autor = await _context.Autores
                                  .FirstOrDefaultAsync(livro => livro.IdAutor == idAutor);

        if (autor == null)
            throw new Exception($"Autor com ID {idAutor} não encontrado.");

        return autor;
    }

    public async Task<Autor> ListarAutorPorIdLivro(Guid idLivro)
    {
        var livro = await _context.Livros
                                  .Include(l => l.Autor)
                                  .FirstOrDefaultAsync(l => l.IdLivro == idLivro);

        if (livro == null || livro.Autor == null)
            throw new NotFoundException($"Livro com ID {idLivro} ou seu autor não foram encontrados.");

        return livro.Autor;
    }


    public async Task<Autor> CriarAutor(Autor autor)
    {
        _context.Add(autor);
        await _context.SaveChangesAsync();
        return autor;
    }

    public async Task<Autor> EditarAutor(Autor autor)
    {
        _context.Update(autor);
        await _context.SaveChangesAsync();
        return autor;
    }

    public async Task<Autor> ExcluirAutor(Guid idAutor)
    {
        var autor = await _context.Autores.FirstOrDefaultAsync(a => a.IdAutor == idAutor);
        if (autor == null)
            throw new NotFoundException($"Autor com ID {idAutor} não encontrado.");


        _context.Remove(autor);
        await _context.SaveChangesAsync();
        return autor;
    }
}
