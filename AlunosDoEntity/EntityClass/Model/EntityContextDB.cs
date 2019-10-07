using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityAlunosContextDB : DbContext // já faz tudo pra
        //criar conexão com o banco de dados e sincroniza
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}
