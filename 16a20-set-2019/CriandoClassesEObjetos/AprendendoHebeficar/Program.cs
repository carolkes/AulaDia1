using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCadastroPessoas;
using SistemaCadastroPessoas.Model;

namespace AprendendoOuteRef
{
    class Program
    {
        static void Hebeficar(out int idade)
        {
            idade = 16000;
        }
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa();
            p1.Nome = "Caroline";
            p1.Idade = 23;
            p1.Sexo = 'F';
            p1.Altura = 1.63;
            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "Camila";
            p2.Idade = 19;
            p2.Sexo = 'F';
            p2.Altura = 1.60;
            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "Ronaldo";
            p3.Idade = 15;
            p3.Sexo = 'M';
            p3.Altura = 1.70;
            pessoas.Add(p3);


            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach (Pessoa p in pessoas)
            {
                if(p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }
            pessoas.Where(pes => pes.Idade < 18);
            
            //Lambda = Where/OrderBy/FirstOrDefault














            List<int> numeros = new List<int>();
            Random rdm = new Random();
            //HashSet<int> dados = new HashSet<int>();
            //dados.add(30);
            for (int i = 0; i < 10; i++)
            {
                //Gera um número aleatório de 0 a 10
                int valorGeradoAleatoriamente = rdm.Next(100);
                //Verifica se a lista não contém este número gerado
                    if (!numeros.Contains(valorGeradoAleatoriamente))
                {
                    //adiciona o número gerado pelo random (que não é repetido)
                    numeros.Add(valorGeradoAleatoriamente);
                }
                    else
                {
                    i--;
                }
                    
                

                    
            }









            int ii = 30;
            Hebeficar(out ii);
            Console.WriteLine(ii);
            int resultadoConversao = 0;
            if(int.TryParse("145", out resultadoConversao))
            {

            }

        }
        
        
    }
}
