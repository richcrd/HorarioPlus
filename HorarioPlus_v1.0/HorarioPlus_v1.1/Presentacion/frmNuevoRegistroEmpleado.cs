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
        private bool enModoEdicion = false;
        private string idEmpleadoEditar;
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
                    if (enModoEdicion)
                    {
                        Empleados empleadoModificado = new Empleados()
                        {
                            IdEmpleado = txtIdEmpleado.Text,
                            Nombre = txtNombre.Text,
                            Apellido1 = txtPrimerApellido.Text,
                            Apellido2 = txtSegundoApellido.Text,
                            Edad = (int)numEdad.Value,
                            Correo = txtCorreo.Text,
                            Rol = textoRol
                        };

                        ManejadorEmpleados.ActualizarEmpleado(txtIdEmpleado.Text, empleadoModificado);
                        enModoEdicion = false; // Salir del modo de edición
                    }
                    else
                    {
                        dgvTablaEmpleados.Rows.Add(new object[] { "",
                    txtIdEmpleado.Text,
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    numEdad.Value.ToString(),
                    txtCorreo.Text,
                    textoRol});
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
                MessageBox.Show("El DataGridView no se ha inicializado correctamente.",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
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
                idEmpleadoEditar = dgvTablaEmpleados.SelectedRows[0].Cells[0].Value.ToString();
                Empleados empleadoModificar = ManejadorEmpleados.BuscarEmpleado(idEmpleadoEditar);

                if (empleadoModificar != null)
                {
                    enModoEdicion = true; // Establecer el modo de edición
                    txtIdEmpleado.Text = empleadoModificar.IdEmpleado;
                    txtNombre.Text = empleadoModificar.Nombre;
                    txtPrimerApellido.Text = empleadoModificar.Apellido1;
                    txtSegundoApellido.Text = empleadoModificar.Apellido2;
                    numEdad.Value = empleadoModificar.Edad;
                    txtCorreo.Text = empleadoModificar.Correo;
                    cbxRol.SelectedItem = cbxRol.Items.Cast<OpcionCombo>().FirstOrDefault(item => item.Texto == empleadoModificar.Rol);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún empleado con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            enModoEdicion = false; // Salir del modo de edición
            string nuevoIdEmpleado = ManejadorEmpleados.GenerarNuevoIdEmpleado();
            txtIdEmpleado.Text = nuevoIdEmpleado;
            LimpiarEntradasTexto();
        }
    }
}
