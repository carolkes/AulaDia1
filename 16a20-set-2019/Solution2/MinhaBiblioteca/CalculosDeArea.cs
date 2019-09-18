﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Método para retornar áreas de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">Lado do quadrado</param>
        /// <returns>Retorna a área total do quadrado</returns>
        public  double CalculaAreaDoQuadrado(int    ladoDoQuadrado)
        {
            return ladoDoQuadrado*ladoDoQuadrado;
        }
    }
}
