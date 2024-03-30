using HorarioPlus_v1._1.Datos;
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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            ManejadorEmpleados.CargarArchivoJson();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string idEmpleado = txtIdAdmin.Text;
            Empleados empleado_encontrado = ManejadorEmpleados.BuscarEmpleado(idEmpleado);
            
            if(empleado_encontrado != null)
            {
                if (empleado_encontrado.Rol == "Administrador")
                {
                    frmPanelAdministrador frmPanelAdmin = new frmPanelAdministrador(empleado_encontrado.Nombre, empleado_encontrado.Apellido1);
                    frmPanelAdmin.Show();
                    this.Close();
                    txtIdAdmin.Text = "";
                }
                else
                {
                    MessageBox.Show("El ID del empleado que ingresó no tiene permisos para acceder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El ID del empleado que ingresó no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdAdmin.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
