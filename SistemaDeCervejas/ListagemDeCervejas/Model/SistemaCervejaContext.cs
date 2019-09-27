using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    class SistemaCervejaContext
    {
        public int IdContadorCervejas { get; set; } = 1;
        private List<Cerveja> ListaDeCerveja { get; set; }
        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja() { Id = 1, Nome = "Stella Artois",              Litros = 0.55, Alcool = 5,   Valor = 7.49 });
            ListaDeCerveja.Add(new Cerveja() { Id = 2, Nome = "Quilmes",                    Litros = 0.97, Alcool = 4.9, Valor = 14.49 });
            ListaDeCerveja.Add(new Cerveja() { Id = 3, Nome = "Patagonia Amber Lager",      Litros = 0.74, Alcool = 4.7, Valor = 15.4 });
            ListaDeCerveja.Add(new Cerveja() { Id = 4, Nome = "Serrana",                    Litros = 0.60, Alcool = 4.5, Valor = 12.90 });
            ListaDeCerveja.Add(new Cerveja() { Id = 5, Nome = "Original",                   Litros = 0.60, Alcool = 4.9, Valor = 9.50 });
        }
        public List<Cerveja> ListaCervejasPublica { get { return ListaDeCerveja; } }
    }
}
