using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRelatorio.Model
{
    public class Carros
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDeVenda { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
