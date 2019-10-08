using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;
namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDB contextDB = 
            new CervejaContextDB(@"data source=(localdb)\MSSQLLocalDB;
initial catalog=RevisandoEntity.Model.CervejaContextDB;
integrated security=True;MultipleActiveResultSets=True;
App=EntityFramework");
        
        public void AddCerveja(Cerveja item)
        {
            contextDB.Cervejas.Add(item);
            contextDB.SaveChanges();
        }

    }
}
