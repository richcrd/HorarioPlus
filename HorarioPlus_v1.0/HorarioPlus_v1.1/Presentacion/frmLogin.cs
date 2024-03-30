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
         #region area_comentada
         /*
         bool volverAMarcar = true;

         while (volverAMarcar)
         {
             string idEmpleado = txtEmpleadoId.Text;
             Empleados empleado_encontrado = ManejadorEmpleados.BuscarEmpleado(idEmpleado);

             if (empleado_encontrado != null)
             {
                 bool esHoraDeEntrada = true;
                 DateTime horaActual = DateTime.Now;
                 // Horario de 7 a 5
                 bool dentroHorarioLaboral = horaActual.TimeOfDay >= TimeSpan.FromHours(7) && horaActual.TimeOfDay <= TimeSpan.FromHours(17);

                 if (!dentroHorarioLaboral)
                 {
                     MessageBox.Show("Fuera del horario laboral. Debes registrar tu entrada del horario laboral (7am - 5pm)");
                     txtEmpleadoId.Clear();
                     return; // salimos del metodo sin marcar
                 }

                 RegistroAsistencia nuevoRegistro = new RegistroAsistencia
                 {
                     Fecha = DateTime.Today,
                     HoraEntrada = DateTime.Now.ToString("hh:mm::ss tt")
                 };

                 empleado_encontrado.Registros.Add(nuevoRegistro);

                 if(!esHoraDeEntrada && empleado_encontrado.Registros.Any())
                 {
                     var ultimoRegistro = empleado_encontrado.Registros.Last();
                     ultimoRegistro.HoraSalida = DateTime.Now.ToString("hh:mm:ss: tt");
                     string mensajeSalida = $"{empleado_encontrado.Nombre} {empleado_encontrado.Apellido1} has registrado tu salida a las {horaActual.ToString("hh:mm:ss tt")}";
                     MessageBox.Show(mensajeSalida, "Registro Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                     string mensajeEntrada = $"{empleado_encontrado.Nombre} {empleado_encontrado.Apellido1} has registrado tu entrada a las {horaActual.ToString("hh:mm:ss tt")}";
                     MessageBox.Show(mensajeEntrada, "Registro Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }

                 
                 ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, idEmpleado, empleado_encontrado);
                 ManejadorEmpleados.GuardarArchivoJson(ManejadorEmpleados.lista_Empleados);
                 txtEmpleadoId.Clear();
                 volverAMarcar = false;
                 #region Agregado en otro formulario
                 //if (empleado_encontrado.Rol == "Administrador")
                 //{
                 //    DialogResult resultado = MessageBox.Show("¿Desea ingresar al sistema como administrador?", "Confirmar Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 //    if (resultado == DialogResult.Yes)
                 //    {
                 //        this.Hide();
                 //        frmPanelAdministrador frmPanelAdmin = new frmPanelAdministrador(empleado_encontrado.Nombre, empleado_encontrado.Apellido1);
                 //        frmPanelAdmin.ShowDialog();
                 //        volverAMarcar = false; // No volver a marcar si el usuario decide ingresar como administrador
                 //    }
                 //    else
                 //    {
                 //        // Si el usuario elige "No", no volvemos a marcar y salimos del bucle
                 //        volverAMarcar = false;
                 //    }
                 //}
                 //else
                 //{
                 //    txtEmpleadoId.Clear();
                 //    volverAMarcar = false;
                 //}
                 #endregion
             }
             else
             {
                 MessageBox.Show("El ID del empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtEmpleadoId.Clear();
                 volverAMarcar = false;
             }
         }
         */
         #endregion
         string ID = txtEmpleadoId.Text;
         GestionDelTiempo.RegistrarHoraDelEmpleado(ID);
         Empleados empleado = ManejadorEmpleados.BuscarEmpleado(ID);
         empleado.Marcado = true;
         ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ID, empleado);
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
