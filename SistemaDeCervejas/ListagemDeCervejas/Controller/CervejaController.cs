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
        /// <summary>
        /// Método que retorna o valor total de litros das cervejas listadas
        /// </summary>
        /// <returns></returns>
        public double ValorTotalEmLitros()
        {
            return cervejaContext.ListaCervejasPublica.Sum(x => x.Litros);
        }
        /// <summary>
        /// Método que retorna o valor total das cervejas listadas
        /// </summary>
        /// <returns>Retornamos o valor total em double</returns>
        public double ValorTotalCervejas()
        {
           return cervejaContext.ListaCervejasPublica.Sum(x => x.Valor);
        }
        /// <summary>
        /// Método que retorna a lista de cervejas
        /// </summary>
        /// <returns>Retorna a lista de cervejas</returns>
        public List<Cerveja> GetCervejas()
        {
                return cervejaContext.ListaCervejasPublica;  
        }
        /// <summary>
        /// Método que pemite o usuario adicionar mais cervejas
        /// </summary>
        /// <param name="parametroCerveja"></param>
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
