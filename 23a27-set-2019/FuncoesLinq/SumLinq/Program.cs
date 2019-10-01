using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomarInteiroPrimitivos();
            SomaInteirosLista();
            SomaBalasListaDeCriancas();

            Console.ReadKey();
        }
        /// <summary>
        /// Método que mostra números inteiros por um primitivo
        /// </summary>
        private static void SomarInteiroPrimitivos()
        {
            //quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção destes
            //valores
            int[] colecaoInteiros =
                //alocamos memória para nosa coleção de valor informamos a quantidade de memória
                //que vamos ocupar
                //memoriaOcupadaInt * quantidadeInformada
                new int[5] 
            //Aqui carregamos nossa coleção de valores
            { 1, 2, 3, 4, 5 };

            Console.WriteLine(colecaoInteiros.Sum());
        }
        /// <summary>
        /// Método que soma valores de [um em um] em uma lista
        /// </summary>
        private static void SomaInteirosLista()
        {
            List<int> listaDeInteiros = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };
            Console.WriteLine(listaDeInteiros.Sum());
        }
        /// <summary>
        /// Método que soma a quantidade de bala das crianças
        /// </summary>
        private static void SomaBalasListaDeCriancas()
        {
            //Nossa lista de crianças foi criada e carregada em memória
            List<Crianca> criancas = new List<Crianca>()
            {
                //criando uma nova criança dentro da minha lista
                new Crianca()
                {
                    Nome = "Joãozinho", //Neste caso apenas uma propriedade de outra
                    Balas = 9
                }, //vigula separamos um objeto de outro
                new Crianca()
                {
                    Nome = "Joana",
                    Balas = 68
                }
            };

            Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda:");
            Console.WriteLine(
                //soma nossa quantidade de balas
                criancas.Sum(x => x.Balas));
        }
    }
}
