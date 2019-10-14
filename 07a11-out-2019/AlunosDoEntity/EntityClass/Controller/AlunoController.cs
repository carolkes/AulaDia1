using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Controller
{
    public class AlunoController
    {
        //Este novo objeto representa nosso banco de dados
        EntityAlunosContextDB contextDB = new EntityAlunosContextDB();

        public IQueryable<Aluno> GetAlunos()
        {
            //Retorna os alunos dentro do sistema
            return contextDB.Alunos;
        }
        public void AddAlunos(Aluno item)
        {
            //Adiciono o aluno na minha lista
            contextDB.Alunos.Add(item);
            //Salvo essa informação no banco de dados
            contextDB.SaveChanges();
        }
    }
}
