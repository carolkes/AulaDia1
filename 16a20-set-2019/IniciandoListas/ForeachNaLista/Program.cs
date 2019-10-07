using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaString();
            Console.ReadKey();
        }

        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static  void    ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MMM/dd")));

            Console.ReadKey();

        }

        /// <summary>
        /// Mostra lista de String definidas
        /// </summary>
        private static  void    ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();

        }

        /// <summary>
        /// Mostra lista de números inteiros
        /// </summary>
        private static  void    ListaNumerosInteiros()
        {
            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(meuNumero => Console.WriteLine(meuNumero));

            Console.ReadKey();
        }

        /// <summary>
        /// Minha lista de numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(99.90);
            minhaLista.Add(1450.35);
            minhaLista.Add(10.50);
            minhaLista.Add(1.10);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + "    " + 
                FormataNumeroDecimalEmDolar(meuDecimal) + " " + 
                FormataNumeroDecimalEmEuro(meuDecimal) + "      " + 
                FormataNumeroDecimalEmIeen(meuDecimal) + "      " + 
                FormataNumeroDecimalEmBit(meuDecimal)));

        }

        /// <summary>
        /// Método que converte meu numero em real para Dólar
        /// </summary>
        /// <param name="meuNumero">Meu número em reais</param>
        /// <returns>Retorna o valor formatado em </returns>
        private static  string  FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        /// <summary>
        /// Método que converte meu número em real para Euro
        /// </summary>
        /// <param name="meuNumero">meu número em reais</param>
        /// <returns>Retorna meu número formatado em Euros</returns>
        private static  string  FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.9877).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$","Euro ");
        }

        /// <summary>
        /// Método que coneverte meu número em reais para Iene
        /// </summary>
        /// <param name="meuNumero">Meu número em reais</param>
        /// <returns>Retorna meu número formatado em Iene</returns>
        private static  string  FormataNumeroDecimalEmIeen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        /// <summary>
        /// Método que converte meu número em reais para Bitcoin
        /// </summary>
        /// <param name="meuNumero">Meu número em reais</param>
        /// <returns>Retorna meu número formatado em BTC</returns>
        private static  string  FormataNumeroDecimalEmBit(double meuNumero)
        {
            return (meuNumero / 41803.05).ToString("C10").Replace("R$","BTC");
        }
    }
}
