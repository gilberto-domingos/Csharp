using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosListaCRUD
{
    internal class Filme
    {
        private string _titulo;
        private string _genero;
        private string _avaliacao;
        private string _status;

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public string Genero { 
            get => _genero;
            set => _genero = value;
        }

        public string Avaliacao
        {
            get => _avaliacao;
            set => _avaliacao = value;
        }

        public string Status
        {
            get => _status;
            set => _status = value;
        }

        public Filme(string titulo, string genero, string avaliacao, string status)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("O titulo é obrigatório.", nameof(titulo));

            if (string.IsNullOrWhiteSpace(genero))
                throw new ArgumentException("O genero é obrigatório.", nameof(genero));

            if (string.IsNullOrWhiteSpace(avaliacao))
                throw new ArgumentException("O avaliacao é obrigatório.", nameof(avaliacao));

            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("O status é obrigatório.", nameof(status));

            _titulo = titulo;
            _genero = genero;
            _avaliacao = avaliacao;
            _status = status;           
        }

        public override string ToString()
        {
            return $"Titulo : {_titulo} | Genero : {_genero} | Avaliação: {_avaliacao} | Status: {_status}";
        }
    }
}
