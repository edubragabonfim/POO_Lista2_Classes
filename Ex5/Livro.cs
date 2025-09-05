using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Livro
    {
        private string _titulo;
        private string _autor;
        private int _qtdPaginas;
        private double _totalAvaliacoes;
        private int _qtdAvaliacoes;
        private int _minutosPorPagina;

        public Livro(string titulo, string autor, int qtdPaginas)
        {
            _titulo = titulo;
            _autor = autor;
            _qtdPaginas = qtdPaginas;
            _totalAvaliacoes = 0;
            _qtdAvaliacoes = 0;
        }

        /// <summary>
        /// Método interno da classe usado para validar se a nota dada pelo usuário é válida.
        /// </summary>
        /// <param name="avaliacao">Avaliação informada pelo usuário.</param>
        /// <returns>Retorna True se a nota for válida.</returns>
        private bool ValidarAvaliacao(double avaliacao)
        {
            bool result = false;
            if (avaliacao >= 0 && avaliacao <= 5)
                result = true;
            return result;
        }

        /// <summary>
        /// Método usado para contabilizar 
        /// </summary>
        /// <param name="avaliacao"></param>
        /// <returns></returns>
        public int ReceberAvaliacao(double avaliacao)
        {
            if (ValidarAvaliacao(avaliacao))
            {
                _totalAvaliacoes += avaliacao;
                _qtdAvaliacoes++;
            }
            return _qtdAvaliacoes;
        }

        /// <summary>
        /// Método para calcular a Avaliação média do livro.
        /// </summary>
        /// <returns>Retorna o resultado do cálculo Total avaliações / Quantidade de avaliações.</returns>
        public double CalcularAvaliacaoMedia()
        {
            double result = 0;
            if(_totalAvaliacoes>0)
                result = _totalAvaliacoes / _qtdAvaliacoes;
            return Math.Round(result, 2);

        }

        /// <summary>
        /// Método que serve para atualizar o Tempo de Leitura por página em minutos.
        /// </summary>
        /// <param name="minutos">Minutos gastos por página.</param>
        /// <returns>Retorna o tempo informado pelo usuário, em minutos.</returns>
        public int AtualizaTempoLeitura(int minutos)
        {
            _minutosPorPagina = minutos;
            return _minutosPorPagina;
        }

        /// <summary>
        /// Método que transforma os minutos totais de leitura de um livro em Hora e Minutos.
        /// </summary>
        /// <returns>Retorna uma string no formato (HH)h:(MM)m</returns>
        public string CalculaTempoLeitura()
        {
            int minutosTotal = _minutosPorPagina * _qtdPaginas;

            int horas = minutosTotal / 60;
            int minutos = minutosTotal % 60;
            return $"{horas}h:{minutos}m";
        }


        public string Relatorio()
        {
            return $"Livro {_titulo} | Autor {_autor} \n" +
                $"Avaliação: {CalcularAvaliacaoMedia()} Estrelas - Tempo de Leitura {CalculaTempoLeitura()}";
        }

    }
}
