using DllPastaWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceListagem
{
    class Program
    {
        //Instanciamos nossa classe principal
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while(menu != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Pasta");
                Console.WriteLine("1 - Criar Pasta Em Meus Documentos");
                Console.WriteLine("2 - Deletar Pasta dos Meus Documentos");
                Console.WriteLine("3 - Listar Meus Documenros");
                Console.WriteLine("4 - Bonus Sextou!!");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch(menu)
                {
                    case 1:
                        //Informo pro usuário que ele deverá informar um nome para a pasta
                        Console.WriteLine("Informe o nome da pasta que deseja adicionar:");
                        //Aqui obtemos o nome que ele digitou para criar nova pasta
                        var nomePasta = Console.ReadLine();
                        //Este método cria a pasta com base no nome que o usuário informou
                        documents.CriarPastaMeusDocumentos(nomePasta);      
                        break;
                    case 2:
                        //Informo pro usuário que ele deverá informar o nome da pasta que deseja exlcuir
                        Console.WriteLine("Informe o nome da para para excluir:");
                        var nomePastaR = Console.ReadLine();
                        documents.DeletarPastaMeusDocumentos(nomePastaR,true);
                        break;
                    case 3:
                        //Obtemos a lista completa de pasta dentro dos meus documentos
                        documents.ObterPastasDiretorioMeuDocumentos().
                            //Apresentamos esta lista para o usuário
                            ForEach(x => Console.WriteLine(x));
                        break;
                    case 4:
                        new HoraDoShow();
                        break;
                }

                Console.ReadKey();

            }
            

            documents.DeletarPastaMeusDocumentos("Pasta Dois",true);

            
             
        }
    }
}
