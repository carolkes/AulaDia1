using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCoreRegistroImoveis.Model;

namespace WebApiCoreRegistroImoveis.Model
{
    public class RegistroContext : DbContext
    {
        public virtual DbSet<Proprietario> Proprietarios { get; set; }
        public virtual DbSet<Imovel> Imoveis { get; set; }
    }
}
