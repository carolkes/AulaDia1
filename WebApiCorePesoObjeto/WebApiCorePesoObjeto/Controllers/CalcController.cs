using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCorePesoObjeto.Model;

namespace WebApiCorePesoObjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {

        List<Objeto> listaDeObjetos = new List<Objeto>();

        [HttpGet]
        public List<Objeto> Get(Objeto item)
        {
            listaDeObjetos.Add(item);

            return listaDeObjetos;
        }

        [HttpPost]
        public Objeto Post(Objeto values)
        {
            listaDeObjetos.Add(values);

            return values;  
        }
    }
}