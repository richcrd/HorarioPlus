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
        #region VARIABLES
        private List<Empleados> lista_Empleados = new List<Empleados>();
        private bool enModoEdicion = false;
        private string idEmpleadoEditar;
        private string nuevoIdEmpleado;
        private bool nuevoBotonPresionado;
        #endregion

        #region INICIO && CIERRE FORMULARIO
        public frmNuevoRegistroEmpleado()
        {
            InitializeComponent();
        }
        private void frmNuevoRegistroEmpleado_Load(object sender, EventArgs e)
        {
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
            ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
            cbxRol.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Empleado" });
            cbxRol.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Administrador" });
            cbxRol.DisplayMember = "Texto";
            cbxRol.ValueMember = "Valor";
            cbxRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvTablaEmpleados.Columns)
            {
                if (columna.Visible && columna.Name != "btnSeleccionar")
                {
                    // Obtener el nombre de la columna
                    string nombreColumna = columna.HeaderText;

                    // Agregar el nombre de la columna directamente al ComboBox
                    cbxCategoriaBuscar.Items.Add(nombreColumna);
                }
            }
        }
        private void frmPanelAdministrador_FormClosing(object sender, FormClosedEventArgs e)
        {
            ManejadorEmpleados.GuardarArchivoJson();
        }
        #endregion

        #region CRUD - EVENTOS CLICK
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoEmpleado();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarNuevoEmpleado();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleadoExistente();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nuevoBotonPresionado = false;
            btnNuevo.Enabled = true;
            LimpiarEntradasTexto();
        }
        #endregion

        #region NUEVOS METODOS PROCEDIMIENTOS
        private void NuevoEmpleado()
        {
            if (!nuevoBotonPresionado) // !enModoEdicion
            {
                nuevoBotonPresionado = true;
                btnNuevo.Enabled = false;
                nuevoIdEmpleado = ManejadorEmpleados.GenerarNuevoIdEmpleado();
                txtIdEmpleado.Text = nuevoIdEmpleado;
                LimpiarEntradasTexto();
            }
        }
        private void InsertarNuevoEmpleado()
        {
            if (!string.IsNullOrEmpty(nuevoIdEmpleado))
            {
                OpcionCombo rolSeleccionado = (OpcionCombo)cbxRol.SelectedItem;
                string textoRol = rolSeleccionado.Texto;

                ManejadorEmpleados manejador_Empleados = new ManejadorEmpleados();
                string errorMsg = manejador_Empleados.ValidarCamposEmpleado
                    (
                        txtNombre.Text,
                        txtPrimerApellido.Text,
                        txtSegundoApellido.Text,
                        (int)numEdad.Value,
                        txtCorreo.Text
                    );
                if (string.IsNullOrEmpty(errorMsg))
                {
                    Empleados nuevoEmpleado = new Empleados()
                    {
                        IdEmpleado = nuevoIdEmpleado,
                        Nombre = txtNombre.Text,
                        Apellido1 = txtPrimerApellido.Text,
                        Apellido2 = txtSegundoApellido.Text,
                        Edad = (int)numEdad.Value,
                        Correo = txtCorreo.Text,
                        Rol = textoRol
                    };

                    ManejadorEmpleados.AgregarEmpleado(nuevoEmpleado, dgvTablaEmpleados);
                    ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
                    LimpiarEntradasTexto();

                    nuevoBotonPresionado = false;
                    btnNuevo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun empleado para agregar.",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }
        private void ActualizarEmpleadoExistente()
        {
            if (enModoEdicion)
            {
                OpcionCombo rolSeleccionado = (OpcionCombo)cbxCategoriaBuscar.SelectedItem;
                string textoRol = rolSeleccionado.Texto;

                ManejadorEmpleados manejador_Empleados = new ManejadorEmpleados();
                string errorMsg = manejador_Empleados.ValidarCamposEmpleado
                     (
                         txtNombre.Text,
                         txtPrimerApellido.Text,
                         txtSegundoApellido.Text,
                         (int)numEdad.Value,
                         txtCorreo.Text
                     );
                if (string.IsNullOrEmpty(errorMsg))
                {
                    Empleados empleadoModificado = new Empleados() // Crear objeto Empleados con los datos modificados
                    {
                        IdEmpleado = idEmpleadoEditar,
                        Nombre = txtNombre.Text,
                        Apellido1 = txtPrimerApellido.Text,
                        Apellido2 = txtSegundoApellido.Text,
                        Edad = (int)numEdad.Value,
                        Correo = txtCorreo.Text,
                        Rol = textoRol
                    };

                    ManejadorEmpleados.ActualizarEmpleado(idEmpleadoEditar, empleadoModificado);
                    ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
                    LimpiarEntradasTexto();
                    enModoEdicion = false;
                }
                else
                {
                    MessageBox.Show("Se encontraron los siguientes errores: " + Environment.NewLine +
                        errorMsg,
                         "Error de validación",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun empleado para actualizar.",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }
        private void EliminarEmpleado()
        {
            if(dgvTablaEmpleados.SelectedRows.Count > 0)
            {
                string idEmpleadoEliminar = dgvTablaEmpleados.SelectedRows[0].Cells[0].Value.ToString();
                ManejadorEmpleados.EliminarEmpleado(idEmpleadoEliminar);
                ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun empleado para eliminar",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }
        public void LimpiarEntradasTexto()
        {
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreo.Text = "";
            numEdad.Value = 0;
            cbxRol.SelectedIndex = 0;
        }
        #endregion
    }
}
