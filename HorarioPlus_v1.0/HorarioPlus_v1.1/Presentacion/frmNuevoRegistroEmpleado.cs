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
            ManejadorEmpleados.InicializarRepositorioEmpleado();
            ManejadorEmpleados.CargarInfoEmpleados(dgvTablaEmpleados);
        }

        private void frmNuevoRegistroEmpleado_Load(object sender, EventArgs e)
        {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvTablaEmpleados != null)
            {
                OpcionCombo rolSeleccionado = (OpcionCombo)cbxRol.SelectedItem;
                string textoRol = rolSeleccionado.Texto;

                ManejadorEmpleados manejadorEmpleados = new ManejadorEmpleados();

                string errorMsg = manejadorEmpleados.ValidarCamposEmpleado(
                    txtIdEmpleado.Text,
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    txtCorreo.Text,
                    (int)numEdad.Value);

                if (string.IsNullOrEmpty(errorMsg))
                {
                    // Agregar una nueva fila al DataGridView
                    int rowIndex = dgvTablaEmpleados.Rows.Add();

                    // Verificar si la fila se agregó correctamente antes de asignar valores a las celdas
                    if (rowIndex >= 0 && rowIndex < dgvTablaEmpleados.Rows.Count)
                    {
                        // Asignar valores a las celdas de la nueva fila
                        dgvTablaEmpleados.Rows[rowIndex].Cells[0].Value = txtIdEmpleado.Text;
                        dgvTablaEmpleados.Rows[rowIndex].Cells[1].Value = txtNombre.Text;
                        dgvTablaEmpleados.Rows[rowIndex].Cells[2].Value = txtPrimerApellido.Text;
                        dgvTablaEmpleados.Rows[rowIndex].Cells[3].Value = txtSegundoApellido.Text;
                        dgvTablaEmpleados.Rows[rowIndex].Cells[4].Value = numEdad.Value.ToString();
                        dgvTablaEmpleados.Rows[rowIndex].Cells[5].Value = txtCorreo.Text;
                        dgvTablaEmpleados.Rows[rowIndex].Cells[6].Value = textoRol;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la fila al DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LimpiarEntradasTexto();
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
                MessageBox.Show("El DataGridView no se ha inicializado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarEntradasTexto()
        {
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreo.Text = "";
            numEdad.Value = 0;
            cbxRol.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTablaEmpleados.SelectedRows.Count > 0)
            {
                string idEmpleadoEliminar = dgvTablaEmpleados.SelectedRows[0].Cells[0].Value.ToString();
                ManejadorEmpleados.EliminarEmpleado(idEmpleadoEliminar);
                ManejadorEmpleados.CargarInfoEmpleados(dgvTablaEmpleados);
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun empleado",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTablaEmpleados.SelectedRows.Count > 0)
            {
                string idEmpleadoModificar = dgvTablaEmpleados.SelectedRows[0].Cells[0].Value.ToString();

                // Llama al método BuscarEmpleado para obtener el empleado correspondiente
                Empleados empleadoModificar = ManejadorEmpleados.BuscarEmpleado(idEmpleadoModificar);

                // Verifica si se encontró un empleado con el id especificado
                if (empleadoModificar != null)
                {
                    // Actualiza los campos del formulario con la información del empleado
                    txtIdEmpleado.Text = empleadoModificar.IdEmpleado;
                    txtNombre.Text = empleadoModificar.Nombre;
                    txtPrimerApellido.Text = empleadoModificar.Apellido1;
                    txtSegundoApellido.Text = empleadoModificar.Apellido2;
                    numEdad.Value = empleadoModificar.Edad;
                    txtCorreo.Text = empleadoModificar.Correo;

                    // Selecciona el rol correspondiente en el ComboBox
                    cbxRol.SelectedItem = cbxRol.Items.Cast<OpcionCombo>().FirstOrDefault(item => item.Texto == empleadoModificar.Rol);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún empleado con el ID especificado.",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun empleado",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nuevoIdEmpleado = ManejadorEmpleados.GenerarNuevoIdEmpleado();
            txtIdEmpleado.Text = nuevoIdEmpleado;
            LimpiarEntradasTexto();
        }
    }
}
