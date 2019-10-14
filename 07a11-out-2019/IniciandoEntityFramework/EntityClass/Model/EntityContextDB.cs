using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    //Criando minha primeira Herança
    public class EntityContextDB : 
        DbContext // DbContext classe pronta que contém todos os processos
        // de conexão com o banco de dados, listagem das tabelas
        // seleção das informações
    {
        public DbSet//Palavra reservada para o Entity que indica que
            // vamos definir uma tabela do nosso banco de dados
            <Pessoa> // Aqui definimos nossa tabela pessoas
            //ou seja, especificamos qual de nossas classes será
            //uma referência de uma tabela no banco de dados.
            //Ela vai ao banco com o nome que deginimos em nossa classe
            ListaDePessoas { get; set; } //(variavel para o sistema acessar a classe Pessoa)
        //nesta parte liberamos nossa tabela para acessar
    }
}
