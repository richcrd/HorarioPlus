using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioPlus_v1._1.Entidades;


namespace HorarioPlus_v1._1.Datos
{
    public class Empleados
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public double PagoPorHoras { get; set; }
        public double TotalHorasAcumuladas { get; set; }
        public double SalarioNeto { get; set; }
        public string HorarioEmpleado { get; set; }

        //Datos cronometricos del empleado
        public List<GestionDelTiempo> RegistroDelTiempo { get; set; } = new List<GestionDelTiempo>();
        public bool Marcado { get; set; } = false;

        #region CONSTRUCTORES
        public Empleados() {}
        
         public Empleados(string id, string nombre, string apellido1, string apellido2, int edad, string correo, string rol, double pagoPorHoras, double totalHorasAcumuladas, double salarioNeto, string horarioEmpleado)
         {
             IdEmpleado = id;
             Nombre = nombre;
             Apellido1 = apellido1;
             Apellido2 = apellido2;
             Edad = edad;
             Correo = correo;
             Rol = rol;
             PagoPorHoras = pagoPorHoras;
             TotalHorasAcumuladas = totalHorasAcumuladas;
             SalarioNeto = salarioNeto;
             HorarioEmpleado = horarioEmpleado;
         }
        #endregion

        #region Metodos_Adicionales
        public static bool CambiarValorLogico()
         {
             //cambiar a false la propiedad "Marcado" si el dia es diferente del actual
             List<Empleados> ListaEmpleados = ManejadorEmpleados.lista_Empleados;
        
             for (int i = 0; i < ListaEmpleados.Count(); i++)
             {
                 int ultimoElemento = ListaEmpleados[i].RegistroDelTiempo.Count() - 1;
                 if (ListaEmpleados[i].RegistroDelTiempo[ultimoElemento].FechaMarcada != GestionDelTiempo.HOY)
                 {
                     ListaEmpleados[i].Marcado = false;
                     ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ListaEmpleados[i].IdEmpleado, ListaEmpleados[i]);
                 }
             }
             return false;
         }
         public static void BorrarRegistro()
         {
             List<Empleados> ListaEmpleados = ManejadorEmpleados.lista_Empleados;
             for (int i = 0; i < ListaEmpleados.Count(); i++)
             {
                 ListaEmpleados[i].RegistroDelTiempo.Clear();
                 ListaEmpleados[i].Marcado = false;
                 ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ListaEmpleados[i].IdEmpleado, ListaEmpleados[i]);
        
             }
         }
        #endregion

        #region METODOS_PARA_CALCULAR_PAGOS
        // Metodo que nos sera util para sacar el total horas acumuladas, hacemos uso del metodo TotalHours de TimeSpan
        public double Calcular_Horas_Acumuladas()
        {
            double totalHoras = 0;
            foreach (var registro in RegistroDelTiempo)
            {
                TimeSpan diferencia_tiempo = registro.Salida_Marcada - registro.Entrada_Marcada;
                totalHoras += diferencia_tiempo.TotalHours;
            }
            return totalHoras;
        }

        public double Calcular_Salario_Neto()
        {
            double horas_trabajadas = Calcular_Horas_Acumuladas();
            double deducciones = Calcular_Deducciones();
            double salarioNeto = horas_trabajadas * PagoPorHoras - deducciones;
            return salarioNeto;
        }

        public double Calcular_Deducciones()
        {
            double totalDeducciones = 0;
            List<Deducciones> lista_Deducciones = DatosDeducciones.ObtenerDeducciones();
            foreach (var deduccion in lista_Deducciones)
            {
                totalDeducciones += deduccion.Monto;
            }
            return totalDeducciones;
        }
        #endregion
    }
}
