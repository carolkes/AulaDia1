using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiBancoExistente.Models;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarroesController
    {
        private DataBaseContext db = new DataBaseContext();

        [HttpGet]
        [Route("Api/Carroes/CustomCarros")]
        public object CustomCarrosQuery()
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from carros in listaDeCarros
                                select new
                                {
                                    NomeCarro = carros.Modelo,
                                    CarroId = carros.Id
                                };
            return retornoCarros;
        }

        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarca()
        {
            var listCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listMarcas
                                  join car in listCarros
                                  on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarroId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };

            return conteudoRetorno;
        }
        [HttpGet]
        [Route("Api/Carroes/CarrosComUsuarios")]
        public object CustomCarrosOnUsuario()
        {
            var listCarros = db.Carros.ToList();
            var listUsuario = db.Usuarios.ToList();


            var conteudoRetorno = from usu in listUsuario
                                  join car in listCarros
                                  on usu.Id equals car.UsuInc
                                  select new
                                  {
                                      CarroId = car.Id,
                                      NomeCar = car.Modelo,
                                      UsuarioNome = usu.Usuario1
                                  };

            return conteudoRetorno;
        }
        [HttpGet]
        [Route("Api/Marcas/CustomMarcas")]
        public object CustomMarcasQuery()
        {
            var listaDeMarcas = db.Marcas.ToList();

            var retornoMarcas = from marca in listaDeMarcas
                                select new
                                {
                                    NomeMarca = marca.Nome,
                                    MarcaId = marca.Id
                                };
            return retornoMarcas;
        }
        [HttpGet]
        [Route("Api/Usuarios/CustomUsuarios")]
        public object CustomUsuariosQuery()
        {
            var listaDeUsuarios = db.Usuarios.ToList();

            var retornoUsuarios = from usuario in listaDeUsuarios
                                  select new
                                  {
                                      NomeUsuario = usuario.Usuario1,
                                      MarcaId = usuario.Id
                                  };
            return retornoUsuarios;
        }
        [HttpGet]
        [Route("Api/Vendas/CustomVendas")]
        public object CustomVendasQuery()
        {
            var listaDeVendas = db.Vendas.ToList();

            var retornoVendas = from vendas in listaDeVendas
                                select new
                                {
                                    CarroVendido = vendas.Carro,
                                    VendaId = vendas.Id,
                                    QtdadeVenda = vendas.Quantidade
                                };
            return retornoVendas;
        }
        
    }
}