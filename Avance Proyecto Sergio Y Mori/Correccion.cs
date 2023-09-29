using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance_Proyecto_Sergio_Y_Mori
{
    public class CorreccionError
    {
        public ErrorReportado ErrorSolucionado { get; set; }
        public DateTime FechaCorrección { get; set; }
        public Desarrollador DesarrolladorCorrección { get; set; }
        public string DescripciónCorrección { get; set; }

        public CorreccionError(ErrorReportado error, DateTime fecha, Desarrollador desarrollador, string descripción)
        {
            ErrorSolucionado = error;
            FechaCorrección = fecha;
            DesarrolladorCorrección = desarrollador;
            DescripciónCorrección = descripción;
        }
    }

}
