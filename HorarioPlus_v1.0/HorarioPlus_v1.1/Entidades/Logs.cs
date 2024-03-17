using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioPlus_v1._1.Entidades
{
    public class Logs
    {
        public string IdEmpleado { get; set; }
        public DateTime FechaLogs { get; set; }
        public string NombreEmpleado { get; set; }
        public string AccionLogs { get; set; }

        // Constructor
        public Logs(DateTime fecha_logs, string accion_logs, string idEmpleado = null, string nombreEmpleado = null)
        {
            IdEmpleado = idEmpleado;
            FechaLogs = fecha_logs;
            NombreEmpleado = nombreEmpleado;
            AccionLogs = accion_logs;
        }
    }
}
