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
using HorarioPlus_v1._1.Datos;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmPanelAdministrador : Form
    {
        #region PROPIEDADES && VARIABLES
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
        #endregion

        #region CARGA && CIERRE FORMULARIO
        private void frmPanelAdministrador_Load(object sender, EventArgs e)
        {
            // Configuramos el lblUsuario con el nombre y apellido del administrador
            lblUsuario.Text = $"{NombreAdministrador} {ApellidoAdministrador}";
        }

        #endregion

        #region EVENTOS CLICK
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
        #endregion

        #region EVENTOS FORMULARIOS (ABRIR)
        // Metodo para abrir formularios
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.LightBlue;
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
        private void menuAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAsistencias());
        }

        private void subMenuNuevoRegistro_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuEmpleados, new frmNuevoRegistroEmpleado());
        }

        private void subMenuHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuEmpleados, new frmHorarioEmpleados());
        }

        private void subMenuPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuPagos, new frmPagos());
        }

        private void subMenuDeducciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuPagos, new frmDeducciones());
        }

        private void menuNominas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmNominas());
        }

        private void menuCarnet_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCarnet());
        }

        private void menuActividad_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmActividad());
        }
        #endregion
    }
}
