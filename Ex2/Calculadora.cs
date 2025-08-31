using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Calculadora
    {
        double _numero1;
        double _numero2;

        public Calculadora(double numero1, double numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
        }

        private bool DivisaoValida()
        {
            return _numero2 != 0;
        }

        public double Soma()
        {
            return _numero1 + _numero2;
        }

        public double Subtracao()
        {
            return _numero1 - _numero2;
        }

        public double Multiplicacao()
        {
            return _numero1 * _numero2;
        }
        
        public double Divisao()
        {
            double result = 0;
            if (DivisaoValida())
                result = _numero1 / _numero2;
            return result;
        }

        public void AlterarNumero1(double numero)
        {
            _numero1 = numero;
        }

        public void AlterarNumero2(double numero)
        {
            _numero2 = numero;
        }

    }
}
