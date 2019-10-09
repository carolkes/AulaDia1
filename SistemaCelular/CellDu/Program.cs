using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CellDu
{
    class Program
    {
        //1-Colocar console app para startar o projeto
        //2-Adicionar referência CatalogoCelulares
        //3-Adicionar Entity em nosso projeto
        //4-Adicionar o using ao nosso projeto Model,Controller

        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimos uma opção de menu inicial
            var opcao = int.MinValue;
            //Definimos que enquanto for diferente de 0
            //ele continua em nosso loop
            while (opcao !=0)
            {
                //Apresentação do menu inicial
                Console.WriteLine("---ESCOLHA UM MENU---");
                Console.WriteLine("1 - Cadastrar Celular");
                Console.WriteLine("2 - Atualizar Celular");
                Console.WriteLine("3 - Remover Celular");
                Console.WriteLine("4 - Listar Celular");
                Console.WriteLine("0 - Sair");
                
                //Obtemos o menu escolhido pelo usuário
                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a escolha da opção
                switch (opcao)
                {
                    //Caso for 1 ele insere um celular novo
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        //Caso foi 2 ele atualiza um celular existente
                        AtualizarCelular();
                        break;
                    case 3:
                        //Caso foi 3 ele remove um celular existente
                        RemoverCelular();
                        break;
                    case 4:
                        //Caso foi 4 ele Lista os celulares do sistema
                        ListarCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do Sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                //Colocamos true para informar que não deve 
                //aparecer na tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        //Inserir
        public static void InserirCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("-- Inserir Celular --");
            Console.WriteLine("Informe a Marca do Celular:");
            //Obtemos a marca do usuário
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo:");
            //Obtemos o modelo do aparelho
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do Aparelho:");
            //Obtemos o valor do aparelho
            var preco = double.Parse(Console.ReadLine());

            //Criamos o resultado para identificar sucesso ou erro
            var resultado = celulares //Nossa controller pelo nome que demos a ela
                .InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
            //Verificamos se o resultado é verdadeiro ou falso
            if (resultado)//Caso verdade sucesso
                Console.WriteLine("Celular cadastrado com sucesso!");
            else//Caso False apresenta erro
                Console.WriteLine("Erro ao cadastrar aparelho");
        }
        //Atualizar
        public static void AtualizarCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("-- Atualizar Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()//Obtemos a lista de celulares
                .ToList<Celular>()//Convertemos para uma lista em memória
                .ForEach//Laço de repetição para mostrar cada celular
                (x => Console.WriteLine(//Mostramos no console nosso celular
                    $"Id: {x.Id}; Marca: {x.Marca}; Modelo: {x.Modelo}; Preço: {x.Preco}"));

            //Informamos ao usuário que ele precisa colocar o id para realizar alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            //Obtemos o Id informado
            var celularId = int.Parse(Console.ReadLine());

            //Obtemos do banco o item completo que vamos atualizar
            var celular = celulares //Banco de dados
                .GetCelulares()//Obtemos os celulares
                .FirstOrDefault(x => x.Id == celularId); //Regra para obter o celular

            if (celular == null)
            {
                //Informo que esse Id não encontrou um registro
                Console.WriteLine("Id Inválido!");
                return;
            }
            Console.WriteLine("Informe a Marca do Celular:");
            //Obtemos a marca do usuário
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo:");
            //Obtemos o modelo do aparelho
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Preço do Aparelho:");
            //Obtemos o valor do aparelho
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celulares//Nossa controller
                .AtualizarCelular(celular);//Método que atualiza o celular

            //Parte final que mostramos o resultado do processo de atualização
            if (resultado)
                Console.WriteLine("Celular Atualizado Com Sucesso!");
            else
                Console.WriteLine("Erro na atualização!");
        }
        //Remover
        public static void RemoverCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("-- Remover Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()//Obtemos a lista de celulares
                .ToList<Celular>()//Convertemos para uma lista em memória
                .ForEach//Laço de repetição para mostrar cada celular
                (x => Console.WriteLine(//Mostramos no console nosso celular
                    $"Id: {x.Id}; Marca: {x.Marca}; Modelo: {x.Modelo}; Preço: {x.Preco}"));

            //Informamos ao usuário que ele precisa colocar o id para realizar alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            //Obtemos o Id informado
            var celularId = int.Parse(Console.ReadLine());

            //Método que 'remove' o celular de nosso sistema
            var resultado = celulares.RemoverCelular(celularId);


            if (resultado)//Apresentação do resultado da operação
                Console.WriteLine("Celular Removido Com Sucesso!");
            else
                Console.WriteLine("Erro ao Remover Aparelho");
        }
        //Listar
        public static void ListarCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("-- Listar Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()//Obtemos a lista de celulares
                .ToList<Celular>()//Convertemos para uma lista em memória
                .ForEach//Laço de repetição para mostrar cada celular
                (x => Console.WriteLine(//Mostramos no console nosso celular
                    $"Id: {x.Id}; Marca: {x.Marca}; Modelo: {x.Modelo}; Preço {x.Preco}"));
        }
    }
}
