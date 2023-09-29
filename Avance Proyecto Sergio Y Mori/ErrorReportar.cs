using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance_Proyecto_Sergio_Y_Mori
{
    public class ErrorReportado
    {
        public int IdentificadorError { get; set; }
        public DateTime FechaNotificación { get; set; }
        public Cliente ClienteNotificador { get; set; }
        public ProductoDeSoftware ProductoConError { get; set; }
        public string DescripciónError { get; set; }

        public ErrorReportado(int id, DateTime fecha, Cliente cliente, ProductoDeSoftware producto, string descripción)
        {
            IdentificadorError = id;
            FechaNotificación = fecha;
            ClienteNotificador = cliente;
            ProductoConError = producto;
            DescripciónError = descripción;
        }
    }

}
