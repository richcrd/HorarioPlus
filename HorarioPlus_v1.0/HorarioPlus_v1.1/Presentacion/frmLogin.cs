using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
     public partial class frmLogin : Form
 {
     #region INICIALIZACION DE COMPONENTES
     public frmLogin()
     {
         InitializeComponent();
         //Cambios
         ManejadorEmpleados.CargarArchivoJson();
         timerHora.Start();
         GestionDelTiempo.Asignar_Registro_A_Los_Ausentes();
         Empleados.CambiarValorLogico();
         GestionDelTiempo.Asignar_Registro_A_Los_Ausentes();//No borrar

     }

     // Metodo para mostrar reloj en pantalla
     private void timerHora_Tick(object sender, EventArgs e)
     {
         lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
     }
     #endregion

     #region EVENTO CLICK
     // Evento Boton Marcar
     private void btnMarcarRegistro_Click(object sender, EventArgs e)
     {
          string ID = txtEmpleadoId.Text;
          GestionDelTiempo.RegistrarHoraDelEmpleado(ID);
          Empleados empleado = ManejadorEmpleados.BuscarEmpleado(ID);
          //empleado.Marcado = true;
          //ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ID, empleado);
          
          if (empleado!= null)
          {
              empleado.Marcado = true;
              ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ID, empleado);
          }
          else
          {
              MessageBox.Show("El ID del empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              txtEmpleadoId.Clear();
              
          }
     }
     private void btnIngresoSistema_Click(object sender, EventArgs e)
     {
         frmIngreso frmIngreso = new frmIngreso();
         frmIngreso.ShowDialog();
         this.Hide();
     }
     #endregion

     private void frmLogin_Load(object sender, EventArgs e)
     {

     }

     
 }
}
