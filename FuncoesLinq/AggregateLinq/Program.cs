using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNomes = new List<string>()
            {
                "Caroline",
                "Vinícius",
                "Madu",
                "Ollie",
                "Peca"
            };

            var texto =  listaDeNomes
                //No Aggregate temos o nome atual que estamos lendo
                //e o próximo nome da lista
                .Aggregate((nome1, nome2) => nome1 + "; " + nome2);
            //No passo seguinte temos o nome 'próximo' que vira o atual
            //e pega o próximo da lista após o atual

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
