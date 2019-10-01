using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public List<Carro> ListaDeCarros { get; set; }
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { Id = 1,  Marca = "Volkswagen", Modelo = "Polo",   Ano = 2019, Cilindradas = 1.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 2,  Marca = "Volkswagen", Modelo = "Gol",    Ano = 2019, Cilindradas = 1.6, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 3,  Marca = "Renault",    Modelo = "Kwid",   Ano = 2017, Cilindradas = 1.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 4,  Marca = "Renault",    Modelo = "Sadero", Ano = 2020, Cilindradas = 1.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 5,  Marca = "Peugeout",   Modelo = "208",    Ano = 2018, Cilindradas = 1.2, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 6,  Marca = "Peugeout",   Modelo = "3008",   Ano = 2011, Cilindradas = 1.6, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 7,  Marca = "Chevrolet",  Modelo = "Celta",  Ano = 2015, Cilindradas = 1.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 8,  Marca = "Chevrolet",  Modelo = "Tracker",Ano = 2016, Cilindradas = 1.8, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 9,  Marca = "Ford",       Modelo = "Fusion", Ano = 2016, Cilindradas = 2.5, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 10, Marca = "Ford",       Modelo = "KA",     Ano = 2019, Cilindradas = 1.5, Portas = 4 });
        }
        public List<Carro> ListaCarrosPublica { get { return ListaDeCarros; } }

    }
}
