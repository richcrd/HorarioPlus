using HorarioPlus_v1._1.Datos;
using System;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmCerrarSistema : Form
    {
        public frmCerrarSistema()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string idEmpleado = txtIDconfirmacion.Text;
            frmLogin Busqueda = new frmLogin(); // Creamos instancia

            Empleados empleado = Busqueda.BuscarEmpleado(idEmpleado); // llamado
            if (empleado != null)
            {
                if (empleado.Rol == "Administrador")
                {
                    DialogResult resultadoCierre = MessageBox.Show("Confirmas el cierre del sistema", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (resultadoCierre == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("El ID del empleado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
