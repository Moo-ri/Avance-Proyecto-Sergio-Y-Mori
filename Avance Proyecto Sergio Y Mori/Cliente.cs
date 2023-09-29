using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance_Proyecto_Sergio_Y_Mori
{
    public class Cliente
    {
        public string RazónSocial { get; set; }
        public string RUT { get; set; }
        public string Dirección { get; set; }
        public string TeléfonoContacto { get; set; }
        public string EmailContacto { get; set; }

        public Cliente(string razónSocial, string rut, string dirección, string teléfono, string email)
        {
            RazónSocial = razónSocial;
            RUT = rut;
            Dirección = dirección;
            TeléfonoContacto = teléfono;
            EmailContacto = email;
        }
    }

}
