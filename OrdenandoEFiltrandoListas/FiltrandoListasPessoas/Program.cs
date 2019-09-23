using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoListasPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListasPessoas = new List<Pessoas>();

            ListasPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("07/11/2004"),
                ReaisNaCarteira = 846.96
            });
            ListasPessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                ReaisNaCarteira = 233.09
            });
            ListasPessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                ReaisNaCarteira = 911.92
            });
            ListasPessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                ReaisNaCarteira = 469.01
            });
            ListasPessoas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                ReaisNaCarteira = 260.41
            });
            ListasPessoas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                ReaisNaCarteira = 312.76
            });
            ListasPessoas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                ReaisNaCarteira = 484.51
            });

            #region Lista De Nomes em Ordem Crescente
            Console.WriteLine("<--------------------Nomes em Ordem Crescente---------------------->");
            ListasPessoas.OrderBy(x => x.Nome).ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.Id} - {i.Nome}        {i.DataNascimento.ToShortDateString()}        {i.ReaisNaCarteira}"));
            #endregion

            #region Lista Data de Nascimento em Ordem Decrescente
            Console.WriteLine("<-------------Datas de Nascimento em Ordem Decrescente------------->");
            ListasPessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.Id} - {i.Nome}       {i.DataNascimento.ToShortDateString()}       {i.ReaisNaCarteira}"));
            #endregion

            #region Lista De Pessoas Com Mais de 500 reais
            Console.WriteLine("<------------------Pessoas Com Mais de 500 Reais------------------->");
            var filtroCarteira = ListasPessoas.Where(x => x.ReaisNaCarteira > 500).OrderBy(x => x.Id);

            filtroCarteira.ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.Id} - {i.Nome}       {i.DataNascimento.ToShortDateString()}        {i.ReaisNaCarteira}"));
            #endregion

            #region Lista De Pessoas Com 18+
            Console.WriteLine("<--------------------Pessoas Maiores De 18 Anos--------------------->");
            (from maiorIdade in ListasPessoas
             where (DateTime.Today.Year - maiorIdade.DataNascimento.Year) >= 18
             select maiorIdade).ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.Id} - {i.Nome}         {i.DataNascimento.ToShortDateString()}         {i.ReaisNaCarteira}"));
            #endregion

            #region Lista De Pessoas Com 16-
            Console.WriteLine("<--------------------Pessoas Menores De 16 Anos--------------------->");
            (from menorIdade in ListasPessoas
             where (DateTime.Today.Year - menorIdade.DataNascimento.Year) <= 16
             select menorIdade).ToList<Pessoas>().ForEach(i => Console.WriteLine($"{i.Id} - {i.Nome}        {i.DataNascimento.ToShortDateString()}       {i.ReaisNaCarteira}"));
            #endregion

            Console.ReadKey();
        }
    }
}
