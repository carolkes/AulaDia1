using CatalogoCelulares.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Controller
{
    //1-Usar nossa pasta model
    //2-Criar uma instância nova da nossa Context
    //3-
    //Deixar a classe pública
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();

        //Listagem
        /// <summary>
        /// Método que retorna lista de celulares ativos apenas
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB //Acesso ao banco de dados
                .Celulares //Nossa tabela de banco de dados
                .Where(x => x.Ativo == true); //As condições do filtro
        }
        //Atualização
        /// <summary>
        /// Método que atualiza um registro válido do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = //Definimos uma variável par o celular
                contextDB //Usamos o banco de dados
                .Celulares //Nossa tabela que  tem os celulares
                .FirstOrDefault(x => x.Id == item.Id); //Regra para realizar a busca

            //Falamos que nosso celular da tabela vai ser igual nosso celular que estamos
            //passando
            if (celular == null) //Verificamos que ele realmente encontrou um celular
                return false; //Caso não tenha encontrado retornamos falso
            else
            {
                item.DataAlteracao = DateTime.Now;//Atualizamos a data
                // da alteração do nosso celular
            }
                
            contextDB.SaveChanges(); //Salvamos a informação no banco

            return true; //Retornamos que foi atualizado
        }
        //Inserção
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool InserirCelular(Celular item)
        {
            if (string //Nosso tipo que contém vários métodos prontos para string
                .IsNullOrWhiteSpace //Método que identifica espaços em branco apenas
                                    //ou Valor null
                (item.Marca))//Nosso campo que vamos validar
                return false;

            if (string
                .IsNullOrWhiteSpace
                (item.Modelo))
                return false;

            if (item.Preco <= 0)//Verificamos se o valor informado é maior que 0
                return false;//Caso não seja maior que zero, retorna para fora do método

            //Salvamos nosso item dentro de nossa tabela em memória
            contextDB.Celulares.Add(item);
            //Salvamos agora no banco esta informação
            contextDB.SaveChanges();

            //Retornamos verdadeiro para indicar sucesso na inserção do registro
            return true;
        }
        //Remoção
        /// <summary>
        /// Método utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = //Nossa variável
                contextDB //Nossa base de dados
                .Celulares //Nossa tabela de celular
                .FirstOrDefault//Buscamos o item para desativar
                (x => x.Id == id);//Informamos a regra de busca por Id

            if (celular == null)//Verificamos se este item existe
                return false;//Caso não exista, sai do nosso método

            celular.Ativo = false;//Desativamos item

            contextDB.SaveChanges();//Salvamos em nosso banco

            return true;//Retornamos verdadeiro
        }
       
    }
}
