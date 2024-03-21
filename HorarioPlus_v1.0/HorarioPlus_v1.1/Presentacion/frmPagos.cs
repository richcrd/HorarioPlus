using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmPagos : Form
    {
        private  List<Empleados> lista_Empleados = new List<Empleados>();
        public frmPagos()
        {
            InitializeComponent();
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
            MostrarTablaPagos();
        }
        private void frmPagos_FormClosing(object sender, FormClosedEventArgs e)
        {
            ManejadorEmpleados.GuardarArchivoJson();
        }
        private void MostrarTablaPagos()
        {
            dgvTablaPagos.Rows.Clear();
            foreach (var empleado in lista_Empleados)
            {
                double totalDeducciones = CalculaTotalDeducciones(empleado);
                double pagoNeto = CalculaPagoNeto(empleado);

                dgvTablaPagos.Rows.Add(empleado.IdEmpleado, empleado.Nombre, empleado.Apellido1, totalDeducciones, empleado.PagoPorHoras, empleado.TotalHorasAcumuladas, pagoNeto);
            }
        }
        private double CalculaTotalDeducciones(Empleados empleado)
        {
            double totalDeducciones = 0;
            // Logica para calcular
            return totalDeducciones;
        }

        private double CalculaPagoNeto(Empleados empleado)
        {
            double pagoNeto = 0;
            // Logica para calcular
            return pagoNeto;
        }
    }
}
