using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmPanelAdministrador : Form
    {
        public string NombreAdministrador { get; set; }
        public string ApellidoAdministrador { get; set; }

        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public frmPanelAdministrador(string nombre, string apellido)
        {
            InitializeComponent();
            NombreAdministrador = nombre;
            ApellidoAdministrador = apellido;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.DarkBlue;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            pnlContenedor.Controls.Add(formulario);
            formulario.Show();

            
        }

        private void frmPanelAdministrador_Load(object sender, EventArgs e)
        {
            // Configuramos el lblUsuario con el nombre y apellido del administrador
            lblUsuario.Text = $"{NombreAdministrador} {ApellidoAdministrador}";
        }

        private void submenuNuevoRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuEmpleados, new frmNuevoRegistroEmpleado());
            //frmNuevoRegistroEmpleado f = new frmNuevoRegistroEmpleado();
            //f.MdiParent = this;
            //f.Show();
        }

        private void btnCerrarSesionAdmin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que deseas cerrar tu sesion?", "Confirmar Cierre Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                frmLogin formularioLogin = new frmLogin(); // Crea instancia y llamado al login
                formularioLogin.Show();
            }
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCierre = MessageBox.Show("Confirmas el cierre del sistema", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultadoCierre == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAsistencias());
        }
    }
}
