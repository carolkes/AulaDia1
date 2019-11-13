using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculoIMC.Models
{
    public class ObjetoIMC
    {
        public double ImcValue { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Nome { get; set; } = string.Empty;
    }
}