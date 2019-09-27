using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext cervejaContext = new SistemaCervejaContext();
        public double ValorTotalEmLitros()
        {
            return cervejaContext.ListaCervejasPublica.Sum(x => x.Litros);
        }
        public double ValorTotalCervejas()
        {
           return cervejaContext.ListaCervejasPublica.Sum(x => x.Valor);
        }
        public List<Cerveja> GetCervejas()
        {
                return cervejaContext.ListaCervejasPublica;  
        }
        public void AdicionarCerveja(Cerveja parametroCerveja)
        {
            parametroCerveja.Id = cervejaContext.IdContadorCervejas++;

            cervejaContext.ListaCervejasPublica.Add(parametroCerveja);
        }
        public double TotalAlcool ()
        {
            return cervejaContext.ListaCervejasPublica.Sum(x => x.Alcool);
        }
        public void TesteBafometro()
        {

        }
    }
}
