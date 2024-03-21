using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioPlus_v1._1.Entidades
{
    public class Deducciones
    {
        public int IdDeducciones { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }

        public Deducciones(int id_deducciones, string descripcion, double monto)
        {
            IdDeducciones = id_deducciones;
            Descripcion = descripcion;
            Monto = monto;
        }
    }
}
