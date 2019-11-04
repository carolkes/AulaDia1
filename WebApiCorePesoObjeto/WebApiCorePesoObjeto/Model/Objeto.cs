using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCorePesoObjeto.Model
{
    public class Objeto
    {
        [Key]
        public int Id { get; set; }
        public double Densidade { get; set; }
        public double Volume { get; set; }
        public double Gravidade { get; set; } = 9.81;
        public double Peso { get { return Densidade * Volume * Gravidade; } }

    }
}
