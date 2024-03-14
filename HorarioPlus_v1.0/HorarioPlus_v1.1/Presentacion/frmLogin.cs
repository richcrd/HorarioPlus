using HorarioPlus_v1._1.Datos;
using System;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            timerHora.Start();
        }

        // Metodo para mostrar reloj en pantalla
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // Evento Boton Marcar
        private void btnMarcarRegistro_Click(object sender, EventArgs e)
        {
            bool volverAMarcar = true;

            while (volverAMarcar)
            {
                string idEmpleado = txtEmpleadoId.Text;
                Empleados empleado_encontrado = ManejadorEmpleados.BuscarEmpleado(idEmpleado);

                if (empleado_encontrado != null)
                {
                    string mensaje = $"{empleado_encontrado.Nombre} {empleado_encontrado.Apellido1} registrado a las {DateTime.Now.ToString("hh:mm:ss tt")}";
                    MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmpleadoId.Clear();

                    if (empleado_encontrado.Rol == "Administrador")
                    {
                        DialogResult resultado = MessageBox.Show("¿Desea ingresar al sistema como administrador?", "Confirmar Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            this.Hide();
                            frmPanelAdministrador frmPanelAdmin = new frmPanelAdministrador(empleado_encontrado.Nombre, empleado_encontrado.Apellido1);
                            frmPanelAdmin.ShowDialog();
                            volverAMarcar = false; // No volver a marcar si el usuario decide ingresar como administrador
                        }
                        else
                        {
                            // Si el usuario elige "No", no volvemos a marcar y salimos del bucle
                            volverAMarcar = false;
                        }
                    }
                    else
                    {
                        txtEmpleadoId.Clear();
                        volverAMarcar = false;
                    }
                }
                else
                {
                    // Si el ID del empleado no existe, mostramos un mensaje de error
                    MessageBox.Show("El ID del empleado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpleadoId.Clear();
                    volverAMarcar = false; // No volvemos a marcar si el id del empleado no existe
                }
            }
        }
    }
}
