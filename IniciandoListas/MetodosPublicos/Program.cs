using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public  class Program
    {
        static void Main(string[] args)
        {
            ConversorMonetarioSis();
        }

        public  static  void    ConversorMonetarioSis()
        {
            Console.WriteLine("===SISTEMA CONVERSOR DE MOEDAS===");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine(@"DOLAR - EURO - YEN - BTC");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();

        }
        /// <summary>
        /// Método que converte real para um alvo especificado
        /// Para converter digite os alvos:
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// - "DÓLAR"
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            
            switch (moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormataNumeroDecimalEmIeen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroDecimalEmBit(minhaMoeda));
                    break;      
                default:
                    break;
            } 
            
        }
        /// <summary>
        /// Método que converte meu numero em real para Dólar
        /// </summary>
        /// <param name="meuNumero">Meu número em reais</param>
        /// <returns>Retorna o valor formatado em </returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// Método que converte meu número em real para Euro
        /// </summary>
        /// <param name="meuNumero">meu número em reais</param>
        /// <returns>Retorna meu número formatado em Euros</returns>
        private static string FormataNumeroDecimalEmEuro(double meuNumero)
        {
            return (meuNumero / 4.9877).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro ");
        }
        /// <summary>
        /// Método que coneverte meu número em reais para Iene
        /// </summary>
        /// <param name="meuNumero">Meu número em reais</param>
        /// <returns>Retorna meu número formatado em Iene</returns>
        private static string FormataNumeroDecimalEmIeen(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C5", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Método que converte meu número em reais para Bitcoin
        /// </summary>
        /// <param name="meuNumero">Meu número em reais</param>
        /// <returns>Retorna meu número formatado em BTC</returns>
        private static string FormataNumeroDecimalEmBit(double meuNumero)
        {
            return (meuNumero / 41803.05).ToString("C10").Replace("R$", "BTC");
        }
    }
}
