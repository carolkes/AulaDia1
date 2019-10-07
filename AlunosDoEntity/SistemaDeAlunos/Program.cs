using EntityClass.Controller;
using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeAlunos
{
    class Program
    {
        static AlunoController aluno = new AlunoController();
        static void Main(string[] args)
        {
            MenuSistema();
            Console.ReadKey();
        }
        private static void ImprimeMenu()
        {
            Console.WriteLine("----Cadastro Alunos----");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("1 - Adicionar Novo Aluno");
        }
        private static void MenuSistema()
        {
            ImprimeMenu();

            var menuEscolhido = int.Parse(Console.ReadLine());

            while (menuEscolhido != 0)
            {
                switch (menuEscolhido)
                {
                    case 1:
                        AdicionarAlunoNaLista();
                        break;
                }

                ImprimeMenu();
                menuEscolhido = int.Parse(Console.ReadLine());
            }
        }
        private static void AdicionarAlunoNaLista()
        {
            Console.WriteLine("Digite o NOME do aluno que deseja cadastrar:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            var idade = int.Parse(Console.ReadLine());

            aluno.AddAlunos(new Aluno()
            {
                Nome = nome,
                Idade = idade
            });
            aluno.GetAlunos().ToList<Aluno>()
                .ForEach(x => Console.WriteLine(x.Nome + " " + x.Idade));
        }
       

    }
}
