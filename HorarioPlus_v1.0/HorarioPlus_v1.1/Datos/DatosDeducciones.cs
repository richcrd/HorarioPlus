using HorarioPlus_v1._1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioPlus_v1._1.Datos
{
    public class DatosDeducciones
    {
        public static List<Deducciones> ObtenerDeducciones()
        {
            List<Deducciones> lista_deducciones = new List<Deducciones>
            {
                new Deducciones(1, "INSS", 0.15),
                new Deducciones(2, "IR", 0.10),
            };
            return lista_deducciones;
        }
    }
}
