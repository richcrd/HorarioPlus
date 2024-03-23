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
        #region VARIABLES
        private int contadorPDF = 1;
        private  List<Empleados> lista_Empleados = new List<Empleados>();
        #endregion

        #region INICIALIZACION && CARGA
        public frmPagos()
        {
            InitializeComponent();
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
            MostrarTablaPagos();
        }
        private void frmPagos_FormClosing(object sender, FormClosedEventArgs e)
        {
            ManejadorEmpleados.GuardarArchivoJson();
        }
        #endregion

        #region METODOS VOID
        private void MostrarTablaPagos()
        {
            dgvTablaPagos.Rows.Clear();
            foreach (var empleado in lista_Empleados)
            {
                double totalDeducciones = CalculaTotalDeducciones(empleado);
                double pagoNeto = CalculaPagoNeto(empleado);

                dgvTablaPagos.Rows.Add(empleado.IdEmpleado, empleado.Nombre, empleado.Apellido1, totalDeducciones, empleado.PagoPorHoras, empleado.TotalHorasAcumuladas, pagoNeto);
            }
        }
        private double CalculaTotalDeducciones(Empleados empleado)
        {
            double totalDeducciones = 0;
            // Logica para calcular
            return totalDeducciones;
        }
        private double CalculaPagoNeto(Empleados empleado)
        {
            double pagoNeto = 0;
            // Logica para calcular
            return pagoNeto;
        }
        #endregion

        #region EVENTOS CLICK
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
