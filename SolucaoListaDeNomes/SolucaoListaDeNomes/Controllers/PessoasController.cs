using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SolucaoListaDeNomes.Models;



namespace SolucaoListaDeNomes.Controllers
{
 
    public class PessoasController : ApiController
    {
        List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Caroline", Idade = 23},
            new Pessoa(){Nome = "Camila", Idade = 20},
            new Pessoa(){Nome = "Brigitte", Idade = 59},
            new Pessoa(){Nome = "Edson", Idade = 59},
            new Pessoa(){Nome = "Vinícius", Idade = 31},
            new Pessoa(){Nome = "Abner", Idade = 35},
            new Pessoa(){Nome = "André", Idade = 33},
            new Pessoa(){Nome = "Carolina", Idade = 32},
            new Pessoa(){Nome = "Jéssica", Idade = 28}
        };

        public List<Pessoa> Get()
        {
            return Pessoas;
        }

        public Pessoa Post(Pessoa item)
        {
            Pessoas.Add(item);

            return item;
        }
    

    }
    
}