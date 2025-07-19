using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicosListaCRUD
{
    internal class FilmeService
    {
        private readonly List<Filme> _filmes = new();

        public IReadOnlyList<Filme> ObterTodosFilmes() => _filmes.AsReadOnly();

        public void AdicionarFilme(string titulo, string genero, string avaliacao, string status)
        {
            var filme = new Filme(titulo, genero, avaliacao, status);
            _filmes.Add(filme);
        }

        public List<Filme> FiltrarPorGenero(string genero)
        {
            return _filmes
                .Where(f => string.Equals(f.Genero, genero, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Filme> FiltrarPorStatus(string status)
        {
            return _filmes
                .Where(f => string.Equals(f.Status, status, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public bool AtualizarFilme(string titulo, string? novaAvaliacao = null, string? novoStatus = null)
        {
            var filme = _filmes.FirstOrDefault(f => string.Equals(f.Titulo, titulo, StringComparison.OrdinalIgnoreCase));

            if (filme is null)
                return false;

            if (!string.IsNullOrWhiteSpace(novaAvaliacao))
                filme.Avaliacao = novaAvaliacao;

            if (!string.IsNullOrWhiteSpace(novoStatus))
                filme.Status = novoStatus;

            return true;
        }

        public bool RemoverFilmePorTitulo(string titulo)
        {
            var filme = _filmes.FirstOrDefault(f => string.Equals(f.Titulo, titulo, StringComparison.OrdinalIgnoreCase));
            if (filme is null)
                return false;

            _filmes.Remove(filme);
            return true;
        }
    }
}