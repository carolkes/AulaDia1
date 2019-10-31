using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiVendasCarro.Models;

namespace WebApiVendasCarro.Controllers
{
    public class CarrosController : ApiController
    {
        private BaseInnerJoinContext db = new BaseInnerJoinContext();

        [HttpGet]
        [Route("Api/Carros/CustomVendasCarros")]
        public object CustomVendasOnCarros()
        {
            var listCarros = db.Carros.ToList();
            var listVendas = db.Vendas.ToList();

            var retornoCarros = from ven in listVendas
                                join car in listCarros
                                on ven.Carro equals car.Id
                                select new
                                {
                                    CarroModelo = car.Modelo,
                                    CarroId = car.Id,
                                    AnoVenda = ven.DatInc

                                };
            return retornoCarros;
        }
        [HttpGet]
        [Route("Api/Carros/CustomVendasOnCarros/{ano}")]
        public object CustomVendasOnCarros(int ano)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();

            var conteudoRtorno = from ven in listVendas
                                 join car in listCarros
                                 on ven.Carro equals car.Id
                                 where ano == ven.DatInc.Year
                                 select new
                                 {
                                     CarroModelo = car.Modelo,
                                     CarroId = car.Id,
                                     AnoVenda = ven.DatInc
                                 };

            return conteudoRtorno;                  
        }
        [HttpGet]
        [Route("Api/Carros/CustomVendasOnCarrosOnUsuarios/{usuario}/{ano}")]
        public object CustomVendasOnCarrosOnUsuarios(int ano, int usuario)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var listUsuario = db.Usuarios.ToList();

            var retornoConteudo = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join usu in listUsuario
                                  on ven.UsuInc equals usu.Id
                                  where ano == ven.DatInc.Year
                                  && usuario == ven.UsuInc
                                  select new
                                  {
                                      CarroModelo = car.Modelo,
                                      CarroId = car.Id,
                                      AnoVenda = ven.DatInc,
                                      NomeUsuario = usu.Usuario
                                  };

            return retornoConteudo;
        }
        [HttpGet]
        [Route("Api/Carros/CustomVendasOnMarcas/{marca}/{ano}")]
        public object CustomVendasOnMarcas(int ano, int marca)
        {
            var listVendas = db.Vendas.ToList();
            var listCarros = db.Carros.ToList();
            var listUsuario = db.Usuarios.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join usu in listUsuario
                                  on ven.UsuInc equals usu.Id
                                  join mar in listMarcas
                                  on car.Marca equals mar.Id
                                  select new
                                  {
                                      MarcaCarro = mar.Nome,
                                      MarcaId = mar.Id,
                                      ModeloCarro = car.Modelo,
                                      CarroId = car.Id,
                                      NomeUsuario = usu.Usuario
                                  };
            return conteudoRetorno;
        }

            // GET: api/Carros
        public IQueryable<Carros> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carros/5
        [ResponseType(typeof(Carros))]
        public IHttpActionResult GetCarros(int id)
        {
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return NotFound();
            }

            return Ok(carros);
        }

        // PUT: api/Carros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarros(int id, Carros carros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carros.Id)
            {
                return BadRequest();
            }

            db.Entry(carros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Carros
        [ResponseType(typeof(Carros))]
        public IHttpActionResult PostCarros(Carros carros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carros.Id }, carros);
        }

        // DELETE: api/Carros/5
        [ResponseType(typeof(Carros))]
        public IHttpActionResult DeleteCarros(int id)
        {
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carros);
            db.SaveChanges();

            return Ok(carros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarrosExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}