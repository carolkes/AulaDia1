using MenuRelatorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRelatorio.CarroController
{
    public class CarroController
    {
        private VendasContext contextDV = new VendasContext();

        public CarroController()
        { }
        public List<Carros> RetornaListaDeVendas()
        {
            return contextDV.ListaDeVendasDeCarros.ToList<Carros>();

        }
    }
}