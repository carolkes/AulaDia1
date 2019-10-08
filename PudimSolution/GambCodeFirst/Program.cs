using CodeFirstTeste.Controller;
using CodeFirstTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GambCodeFirst
{
    public class Program
    {
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            cerveja.AddCerveja(new Cerveja() { Nome = "Skol" });

            Console.ReadKey();
        }
    }
}
