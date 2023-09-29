using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance_Proyecto_Sergio_Y_Mori
{
    public class ProductoDeSoftware
    {
        public string Nombre { get; set; }
        public string Versión { get; set; }
        public string Requisitos { get; set; }

        public ProductoDeSoftware(string nombre, string versión, string requisitos)
        {
            Nombre = nombre;
            Versión = versión;
            Requisitos = requisitos;
        }
    }

}
