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
        EntityAlunosContextDB contextDB = new EntityAlunosContextDB();

        public IQueryable<Aluno> GetAlunos()
        {
            return contextDB.ListaDeAlunos;
        }
        public void AddAlunos(Aluno item)
        {
            contextDB.ListaDeAlunos.Add(item);
            contextDB.SaveChanges();
        }
    }
}
