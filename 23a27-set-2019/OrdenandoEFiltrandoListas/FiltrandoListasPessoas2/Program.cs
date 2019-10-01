using FiltrandoListasPessoas2.Controller;
using FiltrandoListasPessoas2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoListasPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas podemos agora listar e demais funcionalidades

            PessoaController pessoaController
                //Nessa parte ao iniciar em memoria
                //Iniciamos o construtor
                = new PessoaController();

            pessoaController.ListaDePessoasPublica
                //Usamos o Foreach do linq para percorrer a lista
                .ForEach(i => // criamos a variável i para receper o item da nosa lista
                //imprimimos a informação de cada item da nossa lista
                MostraInformacoes(i));

            MostraIdentificador("Lista-Ordenada-Por-Nome");

            pessoaController
                .GetPessoasOrdenadaAsc()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista-Ordenada-Por-Data");

            pessoaController
                .GetPessoasOrdenadaDescPelaDataNascimento()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista-Ordenada-Mais-De-500-Reais");

            pessoaController
                .GetPessoasOrdenadaComMaisPilasNaCarteira()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador($"Lista-Maiores-De-{18}-Anos");

            pessoaController
                .GetPessoasMaiorIdade()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador($"Lista-Menores-De-{16}-Anos");

            pessoaController
                .GetPessoasIdadeMenorQue()
                .ForEach(i => MostraInformacoes(i));

            Console.ReadKey();
        }
        private static void MostraIdentificador (string nomeAcao)
        {
            Console.WriteLine
                (string.Format("----------------------{0,20}------------------------", nomeAcao));
        }
        /// <summary>
        /// Método que mostra no console formatado nosso objeto "Pessoa"
        /// </summary>
        /// <param name="pessoa"></param>
        private static void MostraInformacoes (Pessoa pessoa)
        {
            //Nosso template que apresenta as informações bonitinhas
            string template = "Id {0,-3} Nome: {1,-10} Nascimento: {2,-15} Carteira: {3,0}";
            //Recebemos as informações bonitinhas com string format
            string textoFormatado = 
                //string.format é usado para formatar as string's
                //deixando nosso texto padrão apresentável
                string.Format(
                    //Nosso primeiro parâmetro é o template que usamos
                    template,
                    //após informa o template, temos os parâmetros.
                    //este método espera um array de parâmetros ou seja
                    //podemos passar muitos parâmetros nele
                    pessoa.Id,
                    pessoa.Nome,
                    //Formatamos a data de nascimento para apresentar a informação reduzida
                    pessoa.DataNascimento.ToShortDateString(),
                    //Aqui apresentamos em valor monetário de acordo com as configurações
                    //locais da máquina
                    pessoa.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);
        }
    }
}
