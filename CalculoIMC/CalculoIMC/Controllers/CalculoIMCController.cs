using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculoIMC.Controllers
{
    public class CalculoIMCController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(string nomeUsuario, double pesoUsuario, double alturaUsuario)
        {
           var imc =  pesoUsuario / (alturaUsuario * alturaUsuario);

            return $"Olá {nomeUsuario}, seu IMC é {imc} e ele foi calculado de acordo com sua altura {alturaUsuario} e peso {pesoUsuario} Kg.";
        }
    }
}
