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

        [HttpPost]
        public Objeto Post(Objeto values)
        {

            return values;  
        }
    }
}