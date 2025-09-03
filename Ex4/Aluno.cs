using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{

    /// <summary>
    /// Deve responder a situacao do Aluno (Aprovado, Reavaliacao e Reprovado)
    /// </summary>
    class Aluno
    {
        private string _matricula;
        private string _nome;
        private int _quantidadeAvaliacoes;
        private double _somatoriaPontos;
        private double _notaReavaliacao;
        private bool _fezReavaliacao;

        public Aluno(string matricula, string nome)
        {
            _matricula = matricula;
            _nome = nome;

            _notaReavaliacao = 0;
            _quantidadeAvaliacoes = 0;
            _somatoriaPontos = 0;
            _fezReavaliacao = false;
        }

        /// <summary>
        /// Método utilizado para validar se a nota de uma avaliação está entre 0 e 10 pontos.
        /// </summary>
        /// <param name="pontuacao">Nota de uma avaliação.</param>
        /// <returns>Retorna Verdadeiro se a nota estiver entre 0 e 10 e falso se não.</returns>
        private bool ValidarNota(double pontuacao)
        {
            bool result = false;
            if (pontuacao >= 0 && pontuacao <= 10)
                result = true;
            return result;
        }

        /// <summary>
        /// Método utilizado para acrescentar a nota de uma avaliação a nota total.
        /// </summary>
        /// <param name="pontuacao">Nota de uma avaliação</param>
        /// <returns>Retorna a somatoria de pontos.</returns>
        public double FazerAtividadeAvaliativa(double pontuacao)
        {
            if (ValidarNota(pontuacao))
            {
                _somatoriaPontos += pontuacao;
                _quantidadeAvaliacoes++;
            }

            return _somatoriaPontos;
        }

        /// <summary>
        /// Método usado para informar a nota da Reavaliacao. Só faz o cálculo se não tiver feito a reavalicao ainda.
        /// </summary>
        /// <param name="pontuacaoReavaliacao">Nota de uma avaliação</param>
        /// <returns>Retorna a nota da Reavaliação.</returns>
        public double FazerReavaliacao(double pontuacaoReavaliacao)
        {
            if(!_fezReavaliacao)
            {
                _notaReavaliacao = pontuacaoReavaliacao;
                _fezReavaliacao = true;
            }

            return _notaReavaliacao;
        }

        /// <summary>
        /// Calcula a nota final considerando as avaliações normais.
        /// </summary>
        /// <returns>Retorna a nota final sendo Soma/Qtd Avaliacoes.</returns>
        private double CalculaNotaAvaliacoes()
        {
            return _somatoriaPontos / _quantidadeAvaliacoes;
        }

        /// <summary>
        /// Calcula a nota final.
        /// </summary>
        /// <returns>Retorna a nota final.</returns>
        private double CalculaNotaFinal()
        {
            if (_fezReavaliacao)
            {
                return (_notaReavaliacao + CalculaNotaAvaliacoes()) / 2;
            }
            else
            {
                return CalculaNotaAvaliacoes();
            }
        }

        /// <summary>
        /// Calcula a situação atual do Aluno.
        /// </summary>
        /// <returns>Retorna a situação.</returns>
        private string CalculaSituacaoAluno()
        {
            double result = CalculaNotaFinal();
            if (result >= 6)
                return "Aprovado";
            else if (result < 4)
                return "Reprovado";
            else
                return "Reavaliação";
        }
    
        /// <summary>
        /// Exibe uma mensagem contendo a situação do aluno.
        /// </summary>
        /// <returns>Retorna uma string com a situação do aluno.</returns>
        public string Relatorio()
        {
            return $"O Aluno {_nome} tem a situação {CalculaSituacaoAluno()} com nota {CalculaNotaFinal().ToString("N2")}";
        }

    }
}
