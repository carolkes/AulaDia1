using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        //Realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

        public
            IQueryable //Aqui temos nossa primeira interface com a classe IQueryable.
                       //Essa classe contém várias funcionalidades prontas para
                       //usar igual ao banco de dados, como os 'selects'
            <Pessoa> //Definimos o tipo que irá retornar
            GetPessoas()//Damos um nome ao nosso método
        {
            return contextDB.ListaDePessoas; // Retornamos nossa lista de pessoas
        }
        /// <summary>
        /// Método para adicionar pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
            //Faz automaticamente o nosso 'insert' no banco de dados
        {
            contextDB //Nosso banco de dados
                .ListaDePessoas//Nossa tabela Pessoa
                .Add(item);//Adicionamos o item

            contextDB.SaveChanges(); //Salvamos no banco
        }
    }
}
