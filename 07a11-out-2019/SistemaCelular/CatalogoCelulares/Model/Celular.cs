using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixamos a classe pública
    public class Celular : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(30)]//Definição de tamanho máximo do campo
        [Required]//Definindo campo obrigatório
        public string Marca { get; set; }

        [MaxLength(30)]//Definição de tamanho máximo do campo
        [Required]//Definindo campo obrigatório
        public string Modelo { get; set; }
       
        [Required]//Definindo campo obrigatório
        public double Preco { get; set; }
    }
}
