using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class ContaBancaria
    {
        private string _numeroConta;
        private string _cpf;
        private double _saldo;
        private double _limite;
        private const double _taxaDepositoSeNegativo = 0.03;

        public ContaBancaria(string numeroConta, string cpf, double limite)
        {
            _numeroConta = numeroConta;
            _cpf = cpf;
            _saldo = 0;
            _limite = limite;
        }

        /// <summary>
        /// Método usado para atualizar o limite da conta.
        /// </summary>
        /// <param name="limite">Valor de limite</param>
        /// <returns>Retorna o Limite atual da conta.</returns>
        public double AtualizaLimite(double limite)
        {
            if(limite >= 0)
                _limite = limite;
            return _limite;
        }

        /// <summary>
        /// Método usado para acrescentar dinheiro no saldo da conta. Não é permitdo valores <= 0.
        /// </summary>
        /// <param name="valor">Valor a ser depositado na conta.</param>
        /// <returns></returns>
        public double Depositar(double valor)
        {
            if (valor > 0 && _saldo < 0)
                _saldo += valor - (_saldo * _taxaDepositoSeNegativo * -1);
            else
                _saldo += valor;
                return _saldo;
        }

        /// <summary>
        /// Método usado para sacar dinheiro da Conta.
        /// </summary>
        /// <param name="valor">Valor que desejo sacr.</param>
        /// <returns>Retorna o saldo restante.</returns>
        public double Sacar(double valor)
        {
            if (valor > 0 && valor <= _saldo + _limite && _saldo > 0)
                _saldo -= valor;
            return _saldo;
        }

        /// <summary>
        /// Emite um relatório do estado atual da conta.
        /// </summary>
        /// <returns>Retorna uma string com o estado atual da conta.</returns>
        public string Relatorio()
        {
            return $"Conta {_numeroConta} referente a {_cpf} contém saldo de {_saldo:C2} e limite de {_limite:C2}";
        }

    }
}
