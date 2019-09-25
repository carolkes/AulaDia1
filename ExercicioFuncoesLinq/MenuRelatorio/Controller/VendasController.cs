using MenuRelatorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRelatorio.CarroController
{
    public class VendasController
    {
        private VendasContext contextDV = new VendasContext();

        public VendasController()
        { }
        public void AdicionarLista(Vendas parametroVendas)
        {
            parametroVendas.Id = contextDV.IdContadorDeVendas++;
            contextDV.ListaDeVendas.Add(parametroVendas);
        }
        public List<Vendas> RetornaListaDeVendas()
        {
            return contextDV.ListaDeVendas.Where(x => x.Ativo).ToList<Vendas>();

        }
    }
}