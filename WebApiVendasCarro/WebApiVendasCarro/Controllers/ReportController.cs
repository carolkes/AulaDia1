using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVendasCarro.Models;

namespace WebApiVendasCarro.Controllers
{
    [RoutePrefix("Api/Report")]
    public class ReportController : ApiController
    {
        private BaseInnerJoinContext db = new BaseInnerJoinContext();

        [HttpGet]
        [Route("CustomVendasCarros")]
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
        [Route("{ano}")]
        public object CustomVendasOnCarros(int ano)
        {
            var listaVendas = db.Vendas.Where(x => x.DatInc.Year == ano).ToList();
            var listaCarros = db.Carros.ToList();

            var conteudo = from ven in listaVendas
                           join car in listaCarros
                           on ven.Carro equals car.Id
                           select new
                           {
                               ven.Id,
                               Carro = car.Modelo,
                               ven.Quantidade,
                               ven.Valor,
                               Total = (ven.Quantidade * ven.Valor).ToString()
                           };

            return conteudo;
        

            //var listVendas = db.Vendas.ToList();
            //var listCarros = db.Carros.ToList();

            //var conteudoRtorno = from ven in listVendas
            //                     join car in listCarros
            //                     on ven.Carro equals car.Id
            //                     where ano == ven.DatInc.Year
            //                     select new
            //                     {
            //                         CarroModelo = car.Modelo,
            //                         CarroId = car.Id,
            //                         AnoVenda = ven.DatInc
            //                     };

            //return conteudoRtorno;
        }
        [HttpGet]
        [Route("{usuario}/{ano}")]
        public object CustomVendasOnCarrosOnUsuarios(int ano, int usuario)
        {
            var listUsuario = db.Usuarios.ToList();

            var listVendas = db.Vendas.Where(
                x => x.DatInc.Year == ano &&
                x.UsuInc == usuario).ToList();

            var listCarros = db.Carros.ToList();
            

            var retornoConteudo = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join usu in listUsuario
                                  on ven.UsuInc equals usu.Id
                                  select new
                                  {
                                      ven.Id,
                                      Carro = car.Modelo,
                                      ven.Quantidade,
                                      ven.Valor,
                                      Total = (ven.Quantidade * ven.Valor).ToString(),
                                      NomeUsuario = usu.Usuario
                                  };

            return retornoConteudo;
        }
        [HttpGet]
        [Route("PorMarca/{marca}/{ano}")]
        public object CustomVendasOnMarcas(int ano, int marca)
        {
            var listVendas = db.Vendas.Where(
                x => x.DatInc.Year == ano).ToList();

            var listCarros = db.Carros.Where(x => x.Marca == marca).ToList();
            
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from ven in listVendas
                                  join car in listCarros
                                  on ven.Carro equals car.Id
                                  join mar in listMarcas
                                  on car.Marca equals mar.Id
                                  group new { ven, car, mar }
                                  by new { ven.DatInc.Month, mar.Nome }
                                  into ingroup
                                  select new
                                  {
                                      PeriodoVenda = ingroup.Key.Month,
                                      MarcaVenda = ingroup.Key.Nome,
                                      ValorTotalVendas = ingroup.Sum(x => x.ven.Quantidade * x.ven.Valor)
                                  };
                                 
            return conteudoRetorno.OrderByDescending(x => x.ValorTotalVendas);
        }

    }
}
