using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMigration1.Model;

namespace ConsoleMigration1
{
    class Program
    {
        static MigrationContext db = new MigrationContext();
        static void Main(string[] args)
        {
            db.Usuarios.ToList().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
    }
}
