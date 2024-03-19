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
    public partial class frmAjustes : Form
    {
        #region VARIABLES
        public static string nombreEmpresaDefault;
        public static string direccionDefault;
        public static string telefonoDefault;
        public static string correoDefault;
        #endregion
        public frmAjustes()
        {
            InitializeComponent();
            InicializarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //DateTime = horaSeleccionada = dtpHoraEntrada.Value;
            //MessageBox.Show("Hora Seleccionada: " + horaSeleccionada.ToString("hh:mm: tt"));
        }

        private void btnCerrarSistema_Click(object sender, EventArgs e)
        {
            // Codigo temporal
            DialogResult resultadoCierre = MessageBox.Show("Confirmas el cierre del sistema? Hacer esta accion puede interrumpir algunos procesos", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultadoCierre == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void InicializarDatos()
        {
            nombreEmpresaDefault = "Empresa S,A";
            direccionDefault = "Calle 10";
            telefonoDefault = "2266-3030";
            correoDefault = "empresa@gmail.com";

            txtNombreEmpresa.Text = nombreEmpresaDefault;
            txtDireccionEmpresa.Text = direccionDefault;
            txtTelefono.Text = telefonoDefault;
            txtCorreo.Text = correoDefault;
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            nombreEmpresaDefault = txtNombreEmpresa.Text;
            direccionDefault = txtDireccionEmpresa.Text;
            telefonoDefault = txtTelefono.Text;
            correoDefault = txtCorreo.Text;

            MessageBox.Show("Datos guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarDatos_Click(object sender, EventArgs e)
        {
            txtNombreEmpresa.Text = nombreEmpresaDefault;
            txtDireccionEmpresa.Text = direccionDefault;
            txtTelefono.Text = telefonoDefault;
            txtCorreo.Text = correoDefault;
        }
    }
}
