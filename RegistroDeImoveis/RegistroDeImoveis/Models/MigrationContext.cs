using RegistroDeImoveisMigrationApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroDeImoveisMigrationApiWeb.Models
{
    public class MigrationContext : DbContext
    {
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
    }

}
