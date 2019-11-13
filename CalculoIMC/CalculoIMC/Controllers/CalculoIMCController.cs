using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalculoIMC.Models;

namespace CalculoIMC.Controllers
{
    public class CalculoIMCController : ApiController
    {
        List<ObjetoIMC> listaDeObjetos = new List<ObjetoIMC>()
        {
            new ObjetoIMC(){Nome = "Carol"},
            new ObjetoIMC(){Nome = "Camila"},
            new ObjetoIMC(){Nome = "Brigitte"},
        };


        public List<ObjetoIMC> Get()
        {
            return listaDeObjetos;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(string nomeUsuario, double pesoUsuario, double alturaUsuario)
        {
           var imc =  pesoUsuario / (alturaUsuario * alturaUsuario);

            if (imc <= 24.9)
            {
                return $"Olá {nomeUsuario}, seu IMC é de {imc.ToString("N2")}, o que significa que o seu peso está ideal!";
            }
            else
            {
                return $"Olá {nomeUsuario}, seu IMC é {imc.ToString("N2")}. Infelizmente você está com sobrepeso!";
            } 
        }
        public ObjetoIMC Post(ObjetoIMC values)
        {
            ObjetoIMC imcCalc = values;

            imcCalc.ImcValue = imcCalc.Peso / (imcCalc.Altura * imcCalc.Altura);

            listaDeObjetos.Add(imcCalc);

            return imcCalc;
        }
    }
}
