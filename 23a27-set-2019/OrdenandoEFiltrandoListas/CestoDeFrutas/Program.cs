using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Programando em uma linha
            var cestaDeFrutas = new List<Fruta>();

            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelha",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });
            //Pera
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Pêra",
                Cor = "Verde",
                Peso = 133
            });

            #region Lista 0 - Lista Decrescente
            //Neste ponto ordenamos valores de forma decrescente pelo nome
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));
            #endregion

            #region Lista 1 - Lista Crescente
            Console.WriteLine("------------------------------");
            //Aqui ordemanos os valores pelo id de forma crescente
            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Peso {i.Peso}"));
            #endregion 

            #region Lista 2 - Filtro Peso
            Console.WriteLine("----------Filtro Peso---------");
            ///Aqui filtramos os registros maiores que 100gramas e pelo nome
            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);
           
            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));
            //Frutinha recebe cada fruta de nossa cesta
            

            (from frutinha in cestaDeFrutas
             where frutinha.Peso > 100 // Aqui escolhemos a(s) fruta(s) com mais de 100g
             select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida: {i.Nome}"));
            //Aqui juntamos a informação filtrada
            #endregion

            #region Lista 3 - Filtro Cores

            Console.WriteLine("----------Filtro Cores---------");

            //aqui criamos uma variável que receberá o valor buscado
            var mostrandoFind = cestaDeFrutas.
                //aqui é feito o filtro das informações por uma "ou --> || <--" outra cor
                Find(x => x.Cor == "Verde" || x.Cor == "Vermelha");

            Console.WriteLine($"Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");
            //aqui criamos uma variável que receberá a coleção que estemos buscando
            var mostrandoFindAll = cestaDeFrutas.
                //Find All com esta condição tras frutas de cor amarela "ou" vermelhas
                FindAll(x => x.Cor == "Verde" || x.Cor == "Vermelha");

            mostrandoFindAll.ForEach(i => Console.WriteLine($" Id {i.Id} Nome{i.Nome}"));
            //aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //Como agora ele não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id {item.Id} Nome {item.Nome}");
            #endregion

            #region Lista 4 - Find com order by

            Console.WriteLine("----------Find Com Order By---------");

            var cestaDeFrutasFindOrder = cestaDeFrutas
                //Ordenei minha lista
                .OrderBy(x => x.Nome)
                //converti para lista de fruta novamente
                .ToList<Fruta>()
                //busco minha informação
                .Find(x => x.Cor == "Verde" || x.Cor == "Vermelho");

            Console.WriteLine($"Id {cestaDeFrutasFindOrder.Id} Nome {cestaDeFrutasFindOrder.Nome}");

            Console.ReadKey();
            #endregion
        }
    }
}
#endregion
