using HorarioPlus_v1._1.Entidades;
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
    public partial class frmAjustes : Form
    {
        #region VARIABLES
        public Empresa empresa;
        #endregion
        public frmAjustes()
        {
            InitializeComponent();
            CargarDatosEmpresa();
        }
        #region METODOS CLICK
        private void btnCerrarSistema_Click(object sender, EventArgs e)
        {
            // Codigo temporal
            DialogResult resultadoCierre = MessageBox.Show("Confirmas el cierre del sistema? Hacer esta accion puede interrumpir algunos procesos", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultadoCierre == DialogResult.OK)
            {
                Application.Exit();
            }
        } 
        #endregion

        #region METODOS VOID
        private void CargarDatosEmpresa()
        {
            empresa = ManejadorEmpresa.CargarArchivoEmpresa();
            if(empresa != null)
            {
                txtNombre.Text = empresa.NombreEmpresa;
                txtDireccion.Text = empresa.DireccionEmpresa;
                txtTelefono.Text = empresa.TelefonoEmpresa;
                txtCorreo.Text = empresa.CorreoEmpresa;
            }
            else
            {
                empresa = new Empresa
                {
                    NombreEmpresa = "Empresa S.A",
                    DireccionEmpresa = "Calle 10",
                    TelefonoEmpresa = "2266-2222",
                    CorreoEmpresa = "empresa@gmail.com"
                };

                txtNombre.Text = empresa.NombreEmpresa;
                txtDireccion.Text = empresa.DireccionEmpresa;
                txtTelefono.Text = empresa.TelefonoEmpresa;
                txtCorreo.Text = empresa.CorreoEmpresa;

            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            empresa.NombreEmpresa = txtNombre.Text;
            empresa.DireccionEmpresa = txtDireccion.Text;
            empresa.TelefonoEmpresa = txtTelefono.Text;
            empresa.CorreoEmpresa = txtCorreo.Text;
            ManejadorEmpresa.GuardarArchivoEmpresa(empresa);

            MessageBox.Show("Datos de la empresa guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarDatos_Click(object sender, EventArgs e)
        {
            txtNombre.Text = empresa.NombreEmpresa;
            txtDireccion.Text = empresa.DireccionEmpresa;
            txtTelefono.Text = empresa.TelefonoEmpresa;
            txtCorreo.Text = empresa.CorreoEmpresa;
        }
        #endregion
    }
}
