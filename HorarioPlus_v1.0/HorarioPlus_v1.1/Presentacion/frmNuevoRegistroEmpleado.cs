using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Presentacion.Utilidades;
using SpreadsheetLight;
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
        public static string RUTA_EXCEL = @"../../../../Nominas PDF/Lista Empleados.xlsx";
        #endregion

        #region INICIO && CIERRE FORMULARIO
        public frmNuevoRegistroEmpleado()
        {
            InitializeComponent();
        }
        private void frmNuevoRegistroEmpleado_Load(object sender, EventArgs e)
        {
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();

            // para que cada empleado tenga un valor por defecto de 50
            foreach (var empleado in lista_Empleados)
            {
                empleado.PagoPorHoras = 50;
            }

            
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
        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            Crear_Excel();
            #region Codigo_viejo_pdf
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
            #endregion
        }
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
                        Rol = textoRol,
                        PagoPorHoras = 50,
                    };

                    // Insertamos el empleado en la lista y mostrar la tabla actualizada
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
                        Rol = textoRol,
                        PagoPorHoras = 50
                    };
                    // Solucion de la eliminacion de registro del tiempo
                    Empleados empleadoSinModificar = ManejadorEmpleados.BuscarEmpleado(empleadoSeleccionado.IdEmpleado);
                    if (empleadoSinModificar.RegistroDelTiempo.Count != 0)
                    {
                        empleadoModificado.RegistroDelTiempo = empleadoSinModificar.RegistroDelTiempo;
                        empleadoModificado.Marcado = empleadoSinModificar.Marcado;
                        // Actualizar el empleado en la lista y mostrar la tabla actualizada
                        ManejadorEmpleados.ActualizarEmpleado(lista_Empleados, empleadoSeleccionado.IdEmpleado, empleadoModificado);
                        ManejadorEmpleados.MostrarTabla(dgvTablaEmpleados, lista_Empleados);
                        LimpiarEntradasTexto();

                    }
                    
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

        #region Metodo_Genera_Excel
        private void Crear_Excel()
        {
            SLDocument Excel = new SLDocument();
            DataTable dt = new DataTable();

            // Para agregar las columnas de la tabla pagos
            dt.Columns.Add("ID Empleado");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Primer Apellido");
            dt.Columns.Add("Segundo Apellido");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Correo");
            dt.Columns.Add("Rol");

            // Agregar los datoss de la tabla
            foreach (DataGridViewRow fila in dgvTablaEmpleados.Rows)
            {
                string IdEmpleado = fila.Cells["IdEmpleado"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido1"].Value.ToString();
                string sapellido = fila.Cells["Apellido2"].Value.ToString();
                string edad = fila.Cells["Edad"].Value.ToString();
                string correo = fila.Cells["Correo"].Value.ToString();
                string rol = fila.Cells["Rol"].Value.ToString();

                dt.Rows.Add(IdEmpleado, nombre, apellido, sapellido, edad, correo, rol);
            }

            // Importamos el dt al excel
            Excel.ImportDataTable(1, 1, dt, true);
            //Guardamos en la ruta
            Excel.SaveAs(RUTA_EXCEL);
            MessageBox.Show("Excel creado, revise la carpeta Nominas");
        }
        #region Codigo_viejo_paraHtml
        //private void GenerarNominaPDF()
        //{
        //    try
        //    {
        //        string HTML_RUTA_ARCHIVO = @"../../../../index.html";
        //        string html = File.ReadAllText(HTML_RUTA_ARCHIVO);

        //        // Para extraer los estilos CSS dentro de la etiqueta <style>
        //        var styleMatch = Regex.Match(html, "<style[^>]*>(.*?)</style>", RegexOptions.Singleline);
        //        string styleContent = styleMatch.Success ? styleMatch.Groups[1].Value : string.Empty;

        //        // Aplicamos los estilos CSS al documento PDF
        //        StyleSheet styles = new StyleSheet();
        //        styles.LoadTagStyle(HtmlTags.TABLE, "border", "1");
        //        styles.LoadTagStyle(HtmlTags.TABLE, "width", "100%");
        //        styles.LoadTagStyle(HtmlTags.TD, "padding", "5px");
        //        styles.LoadTagStyle(HtmlTags.TH, "padding", "5px");
        //        styles.LoadTagStyle(HtmlTags.TH, "background-color", "#dddddd");

        //        // Para aregar los estilos CSS al documento
        //        styles.LoadStyle("estilos", "font-family", "Arial, sans-serif");
        //        styles.LoadStyle("estilos", "margin", "0");
        //        styles.LoadStyle("estilos", "padding", "0");
        //        styles.LoadStyle("estilos h1", "color", "red");
        //        styles.LoadStyle("estilos h1", "text-align", "center");
        //        styles.LoadStyle("estilos h1", "margin-top", "40px");
        //        styles.LoadStyle("estilos h1", "margin-bottom", "40px");
        //        styles.LoadStyle("estilos #tabla-empleados", "width", "70%");
        //        styles.LoadStyle("estilos #tabla-empleados", "border-collapse", "collapse");
        //        styles.LoadStyle("estilos #tabla-empleados", "margin", "0 auto");
        //        styles.LoadStyle("estilos th, td", "border", "1px solid black");
        //        styles.LoadStyle("estilos th, td", "padding", "8px");
        //        styles.LoadStyle("estilos th, td", "text-align", "left");

        //        // Para remover los estilos que son generados en forma de codigo
        //        html = Regex.Replace(html, "<style[^>]*>.*?</style>", string.Empty, RegexOptions.Singleline);

        //        // Reemplazamos de los marcadores de posición con los datos de la empresa
        //        html = html.Replace("{{NombreEmpresa}}", empresa.NombreEmpresa);
        //        html = html.Replace("{{DireccionEmpresa}}", empresa.DireccionEmpresa);
        //        html = html.Replace("{{TelefonoEmpresa}}", empresa.TelefonoEmpresa);
        //        html = html.Replace("{{CorreoEmpresa}}", empresa.CorreoEmpresa);

        //        // Generamos las filas de la tabla de empleados en HTML
        //        StringBuilder tbody = new StringBuilder();
        //        foreach (var empleado in lista_Empleados)
        //        {
        //            tbody.AppendLine("<tr>");
        //            tbody.AppendLine($"<td>{empleado.IdEmpleado}</td>");
        //            tbody.AppendLine($"<td>{empleado.Nombre}</td>");
        //            tbody.AppendLine($"<td>{empleado.Apellido1}</td>");
        //            tbody.AppendLine($"<td>{empleado.Calcular_Deducciones().ToString("N2")}</td>");
        //            tbody.AppendLine($"<td>{empleado.PagoPorHoras.ToString("N2")}</td>");
        //            tbody.AppendLine($"<td>{empleado.Calcular_Horas_Acumuladas().ToString("N2")}</td>");
        //            tbody.AppendLine($"<td>{empleado.Calcular_Salario_Neto().ToString("N2")}</td>");
        //            tbody.AppendLine("</tr>");
        //        }
        //        html = html.Replace("<!-- Aquí se insertarán los datos dinámicamente -->", tbody.ToString());

        //        // Creación del documento PDF
        //        Document doc = new Document();
        //        string RUTA_CARPETA = @"../../../../Nominas PDF/";
        //        string RUTA_PDF = Path.Combine(RUTA_CARPETA, $"Pagos{contadorPDF}.pdf");

        //        // Escritura del archivo PDF
        //        using (FileStream fs = new FileStream(RUTA_PDF, FileMode.Create))
        //        {
        //            PdfWriter.GetInstance(doc, fs);
        //            doc.Open();

        //            // Creación del archivo PDF desde el HTML con estilos
        //            using (StringReader sr = new StringReader(html))
        //            {
        //                List<iTextSharp.text.IElement> elementos = HTMLWorker.ParseToList(sr, styles);
        //                foreach (IElement element in elementos)
        //                {
        //                    doc.Add(element);
        //                }
        //            }
        //            doc.Close();
        //        }

        //        MessageBox.Show($"PDF generado en esta ruta: {RUTA_PDF}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        contadorPDF++;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion
        #endregion
    }
}