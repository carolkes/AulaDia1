using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;
using System.Data.Entity;
using RevisandoEntity.Controller;



namespace AplicacaoVisual
{
    public class Program
    {
        //1-Setar a aplicação visual para startar o projeto
        //2-Vamos adicionar o EntityFramework ao nosso projeto Console
        //3-Colocar em nosso using o System.Data.Emtity
        //4-Adicionar a referência da nossa ClassLibrary

        //static CervejaContextDB cerveja = new CervejaContextDB();
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            /*cerveja.Cervejas.Add(new Cerveja() { Nome = "Skol Beats" });

            cerveja.SaveChanges();*/

            /*cerveja.Cervejas.ToList<Cerveja>()
                 .ForEach(x => Console.WriteLine(x.Nome));*/

            cerveja.AddCerveja(new Cerveja() { Nome = "Cerveja Stella" });
            //só adiciona a lista o nome que tiver 'Cerveja no nome'

            cerveja.GetCervejas()
                .ToList<Cerveja>()
                .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
