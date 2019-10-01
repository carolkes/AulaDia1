using SistemaAmigosFixos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAmigosFixos
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAmigos = new List<Amigos>();

            listaAmigos.Add(new Amigos()
            {
                NomeAmigo = "Camila",
                TempoDeAmizade = 10                

            });
            listaAmigos.Add(new Amigos()
            {
                NomeAmigo = "Ingrid",
                TempoDeAmizade = 3285
            });
            listaAmigos.Add(new Amigos()
            {
                NomeAmigo = "Lais",
                TempoDeAmizade = 400
            });

            listaAmigos.ForEach(i => Console.WriteLine($"Eu e a {i.NomeAmigo} somos amigas à {i.TempoDeAmizade} dias!"));
            Console.ReadKey();
        }
    }
}
