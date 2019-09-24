using FiltrandoListasPessoas2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoListasPessoas2.Controller
{
    class PessoaController
    {
        /// <summary>
        /// Lista que contém as pessoas para realizar as atividades
        /// </summary>
        private List<Pessoa> listaDePessoas { get; set; }

        /// <summary>
        /// O método construtor ajuda a iniciar nossa classe para utilizarmos de maneira
        /// correta as informações internas, com isso podemos iniciar nossa lista de pessoas
        /// sem depender do usuário
        /// </summary>
        public PessoaController()
        {
            //Iniciamos a lista de pessoas dentro do nosso método construtor
             listaDePessoas = new List<Pessoa>();

             listaDePessoas.Add(new Pessoa() { Id = 1,  Nome = "Spears",    DataNascimento = DateTime.Parse("07/ 1/2004"),   Carteira = 846.96 });
             listaDePessoas.Add(new Pessoa() { Id = 2,	Nome = "Swanson",	DataNascimento = DateTime.Parse("20/06/2003"),	 Carteira = 233.09 });
             listaDePessoas.Add(new Pessoa() { Id = 3,	Nome = "Gay",	    DataNascimento = DateTime.Parse("03/12/2001"),	 Carteira = 911.92 });
             listaDePessoas.Add(new Pessoa() { Id = 4,	Nome = "Gregory",	DataNascimento = DateTime.Parse("02/01/2000"),	 Carteira = 469.01 });
             listaDePessoas.Add(new Pessoa() { Id = 5,	Nome = "Olson",	    DataNascimento = DateTime.Parse("18/07/2001"),	 Carteira = 261.90 });
             listaDePessoas.Add(new Pessoa() { Id = 6,	Nome = "Garza",	    DataNascimento = DateTime.Parse("01/04/2000"),	 Carteira = 360.41 });
             listaDePessoas.Add(new Pessoa() { Id = 7,	Nome = "Sweet",	    DataNascimento = DateTime.Parse("12/03/2003"),	 Carteira = 312.76 });
             listaDePessoas.Add(new Pessoa() { Id = 8,	Nome = "Cline",	    DataNascimento = DateTime.Parse("26/03/2002"),	 Carteira = 484.51 });
             listaDePessoas.Add(new Pessoa() { Id = 9,	Nome = "Oliver",	DataNascimento = DateTime.Parse("05/07/2004"),	 Carteira = 513.76 });
             listaDePessoas.Add(new Pessoa() { Id = 10,	Nome = "Vang",	    DataNascimento = DateTime.Parse("10/07/2000"),	 Carteira = 271.05 });
             listaDePessoas.Add(new Pessoa() { Id = 11,	Nome = "Maddox",	DataNascimento = DateTime.Parse("29/05/2004"),	 Carteira = 783.97 });
             listaDePessoas.Add(new Pessoa() { Id = 12,	Nome = "Garrett",	DataNascimento = DateTime.Parse("03/06/2006"),	 Carteira = 154.11 });
             listaDePessoas.Add(new Pessoa() { Id = 13,	Nome = "Mcintosh",	DataNascimento = DateTime.Parse("06/07/2006"),	 Carteira = 902.80 });
             listaDePessoas.Add(new Pessoa() { Id = 14,	Nome = "Yang",	    DataNascimento = DateTime.Parse("29/04/2005"),	 Carteira = 550.48 });
             listaDePessoas.Add(new Pessoa() { Id = 15,	Nome = "Hendricks",	DataNascimento = DateTime.Parse("05/09/2003"),	 Carteira = 410.56 });
             listaDePessoas.Add(new Pessoa() { Id = 16,	Nome = "Cain",	    DataNascimento = DateTime.Parse("2/01/2002"	),   Carteira = 221.13 });
             listaDePessoas.Add(new Pessoa() { Id = 17,	Nome = "Blackburn",	DataNascimento = DateTime.Parse("10/05/2000"),	 Carteira = 135.67 });
             listaDePessoas.Add(new Pessoa() { Id = 18,	Nome = "Howe",	    DataNascimento = DateTime.Parse("27/09/2005"),	 Carteira = 360.14 });
             listaDePessoas.Add(new Pessoa() { Id = 19,	Nome = "Pratt",	    DataNascimento = DateTime.Parse("18/09/2000"),	 Carteira = 991.83 });
             listaDePessoas.Add(new Pessoa() { Id = 20,	Nome = "Sherman",	DataNascimento = DateTime.Parse("20/02/2003"),	 Carteira = 667.00 });

            /// <summary>
            /// Temos uma propriedade agora que nos retorna nossa lista com essa propriedade temos a lista completa e sem regras da lista
            /// de pessoas, mas ao liberar somente o GET não damos acesso para alterar fora de classe a lista apenas visualização
            /// </summary>
        }
        public List<Pessoa> ListaDePessoasPublica
        {
            //No GET podemos retornar propriedade privada e calculo de metodos quando necessario
            get { return listaDePessoas; }
        }
        /// <summary>
        ///Método que retorna nossa lista de pessoas ordenada de forma Asc
        ///pelo nome ded cada uma
        /// </summary>
        /// <returns>Retornamos o valor ordenado de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadaAsc()
        {
            return listaDePessoas.OrderBy(x => x.Nome).ToList<Pessoa>();
        }
        /// <summary>
        /// Metodo público que retorna a lista ordenada pela data de nascimento da maior data pra menor data
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> GetPessoasOrdenadaDescPelaDataNascimento()
        {
            return listaDePessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// Método que retorna as pessoas com mais de 500 reais na carteira
        /// </summary>
        /// <param name="valor">Valor informado para o filtro
        /// caso não informado o parâmetro, o valor padrão se torna 500</param>
        /// <returns>retorna a lista com o valor definido e ordenado</returns>
        public List<Pessoa> GetPessoasOrdenadaComMaisPilasNaCarteira(double 
            //Em cado de não informarmos o valor ele permanece 500
            valor=500)
       
        {
            return listaDePessoas
                //realizamos o filtro busca
                .FindAll(x => x.Carteira > valor)
                //ordenamos as informações
                .OrderBy(x => x.Carteira)
                //convertemos para uma lista do tipo pessoa
                .ToList<Pessoa>();
        }
        /// <summary>
        /// Método que retorna a lista de pessoas com idade maior que idade
        ///informada, caso não informado o valor, o valor padrão é 18
        /// </summary>
        /// <param name="idade">Idade  que vamos usar para comparar</param>
        /// <returns>Retorna lista de pessoas pela idade informada</returns>
        public List<Pessoa> GetPessoasMaiorIdade(int idade = 18)
        {
            return listaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) > idade);
        }
        /// <summary>
        /// Método que retorna idade menor que idade informada por parâmetro
        /// caso parâmetro não informado o valor padrão será 16
        /// </summary>
        /// <param name="idade">Parâmetro da idade</param>
        /// <returns>Retorna a lista apenas com os valores</returns>
        public List<Pessoa> GetPessoasIdadeMenorQue(int idade = 16)
        {
            return listaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) < idade);
        }
    }
}
