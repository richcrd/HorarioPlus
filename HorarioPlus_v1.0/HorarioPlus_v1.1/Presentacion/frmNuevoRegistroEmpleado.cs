using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmNuevoRegistroEmpleado : Form
    {
        public frmNuevoRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void frmNuevoRegistroEmpleado_Load(object sender, EventArgs e)
        {
            string nuevoIdEmpleado = ManejadorEmpleados.GenerarNuevoIdEmpleado();
            txtIdEmpleado.Text = nuevoIdEmpleado;
            txtIdEmpleado.ReadOnly = true;

            ManejadorEmpleados.CargarInfoEmpleados(dgvTablaEmpleados);
            cbxRol.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Empleado" });
            cbxRol.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Administrador" });
            cbxRol.DisplayMember = "Texto";
            cbxRol.ValueMember = "Valor";
            cbxRol.SelectedIndex = 0;

            foreach(DataGridViewColumn columna in dgvTablaEmpleados.Columns)
            {
                if(columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cbxCategoriaBuscar.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            dgvTablaEmpleados.Rows.Add(new object[] { "", txtIdEmpleado.Text, txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreo.Text, numEdad.Value.ToString(),
                ((OpcionCombo)cbxRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbxRol.SelectedItem).Texto.ToString(),
            });
            LimpiarEntradasTexto();
        }

        private void LimpiarEntradasTexto()
        {
            txtIdEmpleado.Text = "0";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreo.Text = "";
            numEdad.Value = 0;
            cbxRol.SelectedIndex = 0;
        }
    }
}
