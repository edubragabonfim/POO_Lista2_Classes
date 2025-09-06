using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public class Data
    {
        int _dia;
        int _mes;
        int _ano;

        /// <summary>
        /// Método Construtor
        /// </summary>
        public Data(int dia, int mes, int ano)
        {
            int mesValidado = ValidarMes(mes);
            int diaValidado = ValidarDia(dia, mesValidado, VerificaSeAnoBissexto(ano));

            _dia = diaValidado;
            _mes = mesValidado;
            _ano = ano;
        }

        /// <summary>
        /// Método usado para validar se o dia informado pelo usuário é válido, dado o mês.
        /// </summary>
        /// <param name="dia">Dia informado pelo usuário.</param>
        /// <param name="mes">Mês informado pelo usuário e que passou pela função ValidarMes()</param>
        /// <param name="anoBissexto">True se o ano informado fir bissexto.</param>
        /// <returns>Retorna um dia válido.</returns>
        private int ValidarDia(int dia, int mes, bool anoBissexto)
        {
            int result = 1;

            List<int> mesesCom30 = new List<int> { 4, 6, 9, 11 };
            List<int> mesesCom31 = new List<int> { 1, 3, 5, 7, 8, 10, 12 };

            if (mesesCom30.Contains(mes))
            {
                if (dia >= 1 && dia <= 30)
                    result = dia;
            }
                
            if (mesesCom31.Contains(mes))
            {
                if (dia >= 1 && dia <= 31)
                    result = dia;
            }
                
            if (mes == 2 && anoBissexto)
            {
                if (dia >= 1 && dia <= 29)
                    result = dia;
            } else
            {
                if (dia >= 1 && dia <= 28)
                    result = dia;
            }

            return result;
        }

        /// <summary>
        /// Método para validar se o mês informado é possível, dado que os meses sao de 1 a 12.
        /// </summary>
        /// <param name="mes">Número referente ao mês.</param>
        /// <returns>Retorna 1 se o mês informado não foi válido.</returns>
        private int ValidarMes(int mes)
        {
            int result = 1;
            if (mes >= 1 && mes <= 12)
                result = mes;
            return result;
        }

        /// <summary>
        /// Método usado para Verificar se o ano informado pelo usuário é um Ano bissexto.
        /// </summary>
        /// <param name="ano">Ano informado pelo usuário.</param>
        /// <returns>Retorna True caso seja um ano bissexto.</returns>
        private bool VerificaSeAnoBissexto(int ano)
        {
            bool result = false;

            bool divPor4 = ano % 4 == 0;
            bool divPor100 = ano % 100 == 0;
            bool divPor400 = ano % 400 == 0;

            if (divPor400)
                result = true;
            else if (divPor4 && divPor100)
                result = false;
            else
                result = true;

            return result;
        }

        /// <summary>
        /// Método usado para normalizar data no padrão inteiro e facilitar a comparação.
        /// </summary>
        /// <param name="data">Objeto da classe Data</param>
        /// <returns>Retorna uma data em um padrão inteiro.</returns>
        public static int InterizaDatas(Data data)
        {
            return (data._ano * 10000) + (data._mes * 100) + data._dia;
        }

        /// <summary>
        /// Método usado para verificar se uma data recebida é maior que a atual.
        /// </summary>
        /// <param name="data">Data com a qual desejo comparar.</param>
        /// <returns>Retorna True caso a data que está invocando seja maior.</returns>
        public bool DataMaiorQue(Data data)
        {
            // 08/06/2025 é menor que 02/07/2025
            // 08/06/2005 é maior que 02/07/2003
            // 01/01/2024 é menor que 31/12/2024

            bool result = false;
            int calc = (_ano * 10000) + (_mes * 100) + _dia;

            if (calc > InterizaDatas(data))
                result = true;

            return result;

        }

        /// <summary>
        /// Método Static para comparar se uma data é maior que a outra.
        /// </summary>
        /// <param name="d1">Data principal.</param>
        /// <param name="d2">Data com a qual desejo comparar.</param>
        /// <returns>Retorna True caso a data principal é maior que a data com a qual desejo comparar.</returns>
        public static bool DataMaiorQue(Data d1, Data d2)
        {
            bool result = false;

            if (InterizaDatas(d1) > InterizaDatas(d2))
                result = true;

            return result;

        }


        public int DiferencaEntreDatas(Data data)
        {
            return 1;
        }

        /// <summary>
        /// Método usado para retornar a Data Formatada.
        /// </summary>
        /// <returns>Data formatada como DD/MM/YYYY</returns>
        public string Impressao()
        {
            
            return $"{_dia.ToString("D2")}/{_mes.ToString("D2")}/{_ano}";
        }

    }
}
