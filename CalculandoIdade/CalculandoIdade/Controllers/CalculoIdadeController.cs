using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicação
        /// </summary>
        /// <returns>Retorna o que posso app faz</returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }
        public  string Get(int anoNascimento, string nomeUsuario = "Defaul")
        {

            if ((DateTime.Now.Year - anoNascimento) >= 18)
            {
                return $"{nomeUsuario}, você pode beber caraaaa";
            }
            else
            {
                return $"{nomeUsuario}, você pode beber não.. mas temos suco, toddynho e chá";
            }
        }
    }
}
