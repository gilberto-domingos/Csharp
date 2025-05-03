using Microsoft.EntityFrameworkCore;
using ApiRestFull.Data;
using ApiRestFull.Entities;
using ApiRestFull.DTOs;
using ApiRestFull.Interfaces;
using ApiRestFull.Exceptions;

namespace ApiRestFull.Repositories;

public class LivroRepository : ILivroRepository
{
    private readonly ApiDbContext _context;

    public LivroRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<List<Livro>> ListarLivros()
    {
        return await _context.Livros.Include(l => l.Autor).ToListAsync();
    }

    public async Task<Livro> ListarLivroId(Guid idLivro)
    {
        var livro = await _context.Livros
            .Include(l => l.Autor)
            .FirstOrDefaultAsync(l => l.IdLivro == idLivro);

        if (livro == null)
            throw new NotFoundException($"Livro com ID {idLivro} não encontrado.");

        return livro;
    }

    public async Task<List<Livro>> ListarLivrosPorIdAutor(Guid idAutor)
    {
        var livros = await _context.Livros
            .Include(l => l.Autor)
            .Where(l => l.Autor.IdAutor == idAutor)
            .ToListAsync();

        return livros;
    }

    public async Task<Livro> CriarLivro(LivroCriarDto livroCriarDto)
    {
        var autor = await _context.Autores
            .FirstOrDefaultAsync(a => a.IdAutor == livroCriarDto.Autor.IdAutor);

        if (autor == null)
            throw new NotFoundException($"Autor com ID {livroCriarDto.Autor.IdAutor} não encontrado.");

        var livro = new Livro
        {
            Titulo = livroCriarDto.Titulo,
            Autor = autor
        };

        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();

        return livro;
    }

    public async Task<Livro> EditarLivro(LivroEditarDto livroEditarDto)
    {
        var livro = await _context.Livros
            .Include(l => l.Autor)
            .FirstOrDefaultAsync(l => l.IdLivro == livroEditarDto.IdLivro);

        if (livro == null)
            throw new NotFoundException($"Livro com ID {livroEditarDto.IdLivro} não encontrado.");

        var autor = await _context.Autores
            .FirstOrDefaultAsync(a => a.IdAutor == livroEditarDto.Autor.IdAutor);

        if (autor == null)
            throw new NotFoundException($"Autor com ID {livroEditarDto.Autor.IdAutor} não encontrado.");

        livro.Titulo = livroEditarDto.Titulo;
        livro.Autor = autor;

        _context.Livros.Update(livro);
        await _context.SaveChangesAsync();

        return livro;
    }

    public async Task<Livro> ExcluirLivro(Guid idLivro)
    {
        var livro = await _context.Livros
            .FirstOrDefaultAsync(l => l.IdLivro == idLivro);

        if (livro == null)
            throw new NotFoundException($"Livro com ID {idLivro} não encontrado.");

        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();

        return livro;
    }
}
