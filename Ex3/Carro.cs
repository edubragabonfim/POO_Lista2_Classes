using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Carro
    {
        string _placa;
        int _velocidade;


        /// <summary>
        /// Método construtor.
        /// </summary>
        /// <param name="placa">Identificador do carro.</param>
        public Carro(string placa)
        {
            _placa = placa; 
            _velocidade = 0;
        }

        public int Acelerar(int aceleracao)
        {
            if (ValidarVelocidade(aceleracao))
            {
                _velocidade += aceleracao;
                return _velocidade;
            }
            return _velocidade;
        }

        public int Frear(int aceleracao)
        {
            if (ValidarVelocidade(aceleracao))
            {
                _velocidade -= aceleracao;
                return _velocidade;
            }
            return _velocidade;
        }

        private bool ValidarVelocidade(int aceleracao)
        {
            int result = _velocidade + aceleracao;
            return (result >= 0 && result <= 120);
        }


        public string ExibirVelocidade()
        {
            return $"O carro {_placa} se encontra com a velocidade de {_velocidade}";
        }

    }
}
