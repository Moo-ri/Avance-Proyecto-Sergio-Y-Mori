using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance_Proyecto_Sergio_Y_Mori
{
    public class Desarrollador
    {
        public string Nombre { get; set; }
        public string RUT { get; set; }
        public string Email { get; set; }

        public Desarrollador(string nombre, string rut, string email)
        {
            Nombre = nombre;
            RUT = rut;
            Email = email;
        }
    }

}
