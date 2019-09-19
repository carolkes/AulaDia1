using MinhaSegundaClasse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<Frutas>
            {
                new Frutas()
                {
                    NomeDaFruta = "Laranja",
                    Quantidade = 3

                },
                new Frutas()
                {
                    NomeDaFruta = "Uva",
                    Quantidade = 2
                }
            };
            minhaCestaDeFrutas.ForEach(i => Console.WriteLine);

            Console.ReadKey();

        }
    }
}
