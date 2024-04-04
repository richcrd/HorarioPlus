using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using SpreadsheetLight;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmPagos : Form
    {
        #region VARIABLES && LISTA
        private int contadorPDF = 1;
        private List<Empleados> lista_Empleados = new List<Empleados>();
        private Empresa empresa;
        public static string RUTA_EXCEL = @"../../../../Nominas PDF/Planilla Pagos.xlsx";
        #endregion

        #region INICIALIZACION && SALIDA FORMULARIO
        public frmPagos()
        {
            InitializeComponent();
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
            empresa = ManejadorEmpresa.CargarArchivoEmpresa();
            MostrarTablaPagos();
        }
        #endregion

        #region EVENTO_CIERRE_FORMULARIO
        private void frmPagos_FormClosing(object sender, FormClosedEventArgs e)
        {
            ManejadorEmpleados.GuardarArchivoJson(lista_Empleados);
        }
        #endregion

        #region METODO_MUESTRA_TABLA
        private void MostrarTablaPagos()
        {
            dgvTablaPagos.Rows.Clear();
            foreach (var empleado in lista_Empleados)
            {
                double salarioNeto = empleado.Calcular_Salario_Neto();
                double totalHoras = empleado.Calcular_Horas_Acumuladas();
                double totalDeducciones = empleado.Calcular_Deducciones();

                string tthFormateadas = totalHoras.ToString("N2");
                string sslNeto = salarioNeto.ToString("N2");

                dgvTablaPagos.Rows.Add
                    (
                    empleado.IdEmpleado,
                    empleado.Nombre,
                    empleado.Apellido1,
                    totalDeducciones,
                    empleado.PagoPorHoras,
                    tthFormateadas,
                    sslNeto
                    );
            }
        }
        #endregion

        #region Metodo_Genera_Planilla
        private void Crear_Excel()
        {
            SLDocument planilla_Pagos = new SLDocument();
            DataTable dt = new DataTable();

            // Para agregar las columnas de la tabla pagos
            dt.Columns.Add("ID Empleado");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Deducciones");
            dt.Columns.Add("Pago por Horas");
            dt.Columns.Add("Total de Horas");
            dt.Columns.Add("Salario Neto");

            // Agregar los datoss de la tabla
            foreach (DataGridViewRow fila in dgvTablaPagos.Rows)
            {
                string IdEmpleado = fila.Cells["IdEmpleado"].Value.ToString();
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido1"].Value.ToString();
                string deducciones = fila.Cells["totalDeducciones"].Value.ToString();
                string pagoxhoras = fila.Cells["PagoPorHoras"].Value.ToString();
                string totalHoras = fila.Cells["HorasAcumuladas"].Value.ToString();
                string salarioNeto = fila.Cells["salarioNeto"].Value.ToString();

                dt.Rows.Add(IdEmpleado, nombre, apellido, deducciones, pagoxhoras, totalHoras, salarioNeto);
            }

            // Importamos el dt al excel
            planilla_Pagos.ImportDataTable(1, 1, dt, true);
            //Guardamos en la ruta
            planilla_Pagos.SaveAs(RUTA_EXCEL);
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

        #region EVENTO_NOMINA_PDF
        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            Crear_Excel();
        }
        #endregion
    }
}
