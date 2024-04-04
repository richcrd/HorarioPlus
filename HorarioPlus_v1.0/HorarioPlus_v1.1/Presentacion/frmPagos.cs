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
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;
using System.IO;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmPagos : Form
    {
        #region VARIABLES && LISTA
        private int contadorPDF = 1;
        private  List<Empleados> lista_Empleados = new List<Empleados>();
        #endregion

        #region INICIALIZACION && SALIDA FORMULARIO
        public frmPagos()
        {
            InitializeComponent();
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
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

        #region METODO_GENERA_NOMINA_PDF
        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            // Crea un nuevo documento PDF
            Document doc = new Document();

            // Especifica la ubicación donde guardar el PDF
            string rutaCarpeta = @"../../../../Nominas PDF/";
            string rutaPDF = Path.Combine(rutaCarpeta, "pagos" + contadorPDF + ".pdf");

            PdfWriter.GetInstance(doc, new FileStream(rutaPDF, FileMode.Create));

            // Abre el documento para escribir
            doc.Open();

            Font tituloHoja = FontFactory.GetFont("Arial", 28, BaseColor.RED);

            Paragraph titulo = new Paragraph("Planilla de Pagos", tituloHoja);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            // Crea una tabla PDF
            PdfPTable table = new PdfPTable(dgvTablaPagos.Columns.Count);
            // Establece el ancho de las columnas
            float[] anchosColumnas = { 2, 4, 4, 4, 4, 5, 5 };
            table.SetWidths(anchosColumnas);

            // Añade los encabezados de columna a la tabla
            for (int i = 0; i < dgvTablaPagos.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dgvTablaPagos.Columns[i].HeaderText));
            }

            // Añade las filas de datos a la tabla
            for (int i = 0; i < dgvTablaPagos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTablaPagos.Columns.Count; j++)
                {
                    if (dgvTablaPagos.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new Phrase(dgvTablaPagos.Rows[i].Cells[j].Value.ToString()));
                    }
                }
            }

            doc.Add(table);
            doc.Close();

            MessageBox.Show($"PDF generado exitosamente en {rutaPDF}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            contadorPDF++;
        }
        #endregion
    }
}
