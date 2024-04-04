using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private string nuevoIdEmpleado;
        private bool nuevoBotonPresionado;
        private Empleados empleadoSeleccionado;
        private int contadorPDF = 1;
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

            dgvTablaEmpleados.SelectionChanged += SeleccionEmpleado_SelectionChanged;
        }
        private void frmPanelAdministrador_FormClosing(object sender, FormClosedEventArgs e)
        {
            ManejadorEmpleados.GuardarArchivoJson(lista_Empleados);
        }
        #endregion

        #region EVENTOS CLICK
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
            EliminarEmpleadoTabla();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nuevoBotonPresionado = false;
            btnNuevo.Enabled = true;
            LimpiarEntradasTexto();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idEmpleadoBuscar = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(idEmpleadoBuscar))
            {
                Empleados empleadoEncontrado = ManejadorEmpleados.BuscarEmpleado(idEmpleadoBuscar);
                if (empleadoEncontrado != null)
                {
                    lista_Empleados.Clear();
                    lista_Empleados.Add(empleadoEncontrado);
                    ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID de empelado para buscar", "Error", MessageBoxButtons.OK);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
            ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
        }
        //private void btnGenerarNomina_Click(object sender, EventArgs e)
        //{
        //    // Crea un nuevo documento PDF
        //    Document doc = new Document();

        //    // Especifica la ubicación donde guardar el PDF
        //    string rutaCarpeta = @"../../../../Nominas PDF/";
        //    string rutaPDF = Path.Combine(rutaCarpeta, "emp" + contadorPDF + ".pdf");

        //    PdfWriter.GetInstance(doc, new FileStream(rutaPDF, FileMode.Create));

        //    // Abre el documento para escribir
        //    doc.Open();

        //    Font tituloHoja = FontFactory.GetFont("Arial", 28, BaseColor.RED);

        //    Paragraph titulo = new Paragraph("Lista de Empleados", tituloHoja);
        //    titulo.Alignment = Element.ALIGN_CENTER;
        //    doc.Add(titulo);

        //    // Crea una tabla PDF
        //    PdfPTable table = new PdfPTable(dgvTablaEmpleados.Columns.Count);
        //    // Establece el ancho de las columnas
        //    float[] anchosColumnas = { 2, 4, 4, 4, 4, 6, 6 };
        //    table.SetWidths(anchosColumnas);

        //    // Añade los encabezados de columna a la tabla
        //    for (int i = 0; i < dgvTablaEmpleados.Columns.Count; i++)
        //    {
        //        table.AddCell(new Phrase(dgvTablaEmpleados.Columns[i].HeaderText));
        //    }

        //    // Añade las filas de datos a la tabla
        //    for (int i = 0; i < dgvTablaEmpleados.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dgvTablaEmpleados.Columns.Count; j++)
        //        {
        //            if (dgvTablaEmpleados.Rows[i].Cells[j].Value != null)
        //            {
        //                table.AddCell(new Phrase(dgvTablaEmpleados.Rows[i].Cells[j].Value.ToString()));
        //            }
        //        }
        //    }

        //    // Añade la tabla al documento
        //    doc.Add(table);

        //    // Cierra el documento
        //    doc.Close();

        //    MessageBox.Show($"PDF generado exitosamente en {rutaPDF}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    // Incrementa el contador para el próximo PDF
        //    contadorPDF++;
        //}
        #endregion

        #region METODOS PROCEDIMIENTOS
        private void NuevoEmpleado()
        {
            if (!nuevoBotonPresionado) // !enModoEdicion
            {
                nuevoBotonPresionado = true;
                btnNuevo.Enabled = false;
                btnInsertar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
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
                else
                {
                    MessageBox.Show("No hay informacion para agregar un nuevo empleado, llene todos los campos vacios",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay informacion para agregar un nuevo empleado, por favor haga clic en 'Nuevo Registro' ",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }
        private void ActualizarEmpleadoExistente()
        {
            if (empleadoSeleccionado != null)
            {
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
                    OpcionCombo rolSeleccionado = (OpcionCombo)cbxRol.SelectedItem;
                    string textoRol = rolSeleccionado.Texto;

                    // Crear un objeto Empleados con los datos modificados
                    Empleados empleadoModificado = new Empleados()
                    {
                        IdEmpleado = empleadoSeleccionado.IdEmpleado,
                        Nombre = txtNombre.Text,
                        Apellido1 = txtPrimerApellido.Text,
                        Apellido2 = txtSegundoApellido.Text,
                        Edad = (int)numEdad.Value,
                        Correo = txtCorreo.Text,
                        Rol = textoRol
                    };

                    // Actualizar el empleado en la lista y mostrar la tabla actualizada
                    ManejadorEmpleados.ActualizarEmpleado(lista_Empleados, empleadoSeleccionado.IdEmpleado, empleadoModificado);
                    ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
                    LimpiarEntradasTexto();
                }
                else
                {
                    // Mostrar mensajes de error de validación
                    MessageBox.Show("Se encontraron los siguientes errores: " + Environment.NewLine +
                        errorMsg,
                         "Error de validación",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún empleado para actualizar.",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }
        private void EliminarEmpleadoTabla()
        {
            if(empleadoSeleccionado != null)
            {
                DialogResult resultadoEliminacion = MessageBox.Show($"Estas seguro que deseas eliminar a: {empleadoSeleccionado.Nombre} {empleadoSeleccionado.Apellido1} de los archivos?", 
                    "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (resultadoEliminacion == DialogResult.OK)
                {
                    ManejadorEmpleados.EliminarEmpleado(lista_Empleados, empleadoSeleccionado.IdEmpleado);
                    ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
                }
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
        public Empleados SeleccionarEmpleado()
        {
            if (dgvTablaEmpleados.SelectedRows.Count > 0)
            {
                btnInsertar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow row = dgvTablaEmpleados.SelectedRows[0];
                // Creamos objeto para los datos de la fila seleccionada
                Empleados empleadoSeleccionado = new Empleados()
                {
                    IdEmpleado = row.Cells["IdEmpleado"].Value.ToString(),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    Apellido1 = row.Cells["Apellido1"].Value.ToString(),
                    Apellido2 = row.Cells["Apellido2"].Value.ToString(),
                    Edad = Convert.ToInt32(row.Cells["Edad"].Value),
                    Correo = row.Cells["Correo"].Value.ToString(),
                    Rol = row.Cells["Rol"].Value.ToString()
                };
                // Asignar los valores del empleado seleccionado a los campos de texto
                txtIdEmpleado.Text = empleadoSeleccionado.IdEmpleado;
                txtNombre.Text = empleadoSeleccionado.Nombre;
                txtPrimerApellido.Text = empleadoSeleccionado.Apellido1;
                txtSegundoApellido.Text = empleadoSeleccionado.Apellido2;
                numEdad.Value = empleadoSeleccionado.Edad;
                txtCorreo.Text = empleadoSeleccionado.Correo;
                cbxRol.SelectedIndex = cbxRol.FindStringExact(empleadoSeleccionado.Rol);

                return empleadoSeleccionado;
            }
            else
            {
                return null;
            }
        }
        private void SeleccionEmpleado_SelectionChanged(object sender, EventArgs e)
        {
            empleadoSeleccionado = SeleccionarEmpleado();
        }
        #endregion
    }
}