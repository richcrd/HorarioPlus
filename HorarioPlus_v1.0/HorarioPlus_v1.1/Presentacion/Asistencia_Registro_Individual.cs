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
using SpreadsheetLight;

namespace HorarioPlus_v1._1.Presentacion
{
    
    public partial class Asistencia_Registro_Individual : Form
    {
        DataGridView Registros_Del_Tiempo = new DataGridView();//size:502; 258;location:11; 180;
        Empleados EmpleadoObtenido;
        public static string pathExcel = @"../../../../archivos_empleados/Excel.xlsx";


        public Asistencia_Registro_Individual(Empleados empleadoDelPanel)
        {
            InitializeComponent();
            EmpleadoObtenido = empleadoDelPanel;
            lblNombreEmpleado.Text = EmpleadoObtenido.Nombre;
            GenerarDataGrid();
            this.Controls.Add(Registros_Del_Tiempo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GenerarDataGrid()
        {
            //var Registro = EmpleadoObtenido.RegistroDelTiempo.Last();
            var Registros = EmpleadoObtenido.RegistroDelTiempo;
            string[] CamposDeUnRegistro = {"Fecha","SALIDA M","ENTRADA M","ASISTENCIA" };
            for (var i = 0; i<4;i++)
            {
                DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();
                Columna.Name = $"{CamposDeUnRegistro[i]}";
                Registros_Del_Tiempo.Columns.Add(Columna);
            }
            Registros_Del_Tiempo.Location = new Point(11, 180);
            Registros_Del_Tiempo.Size = new Size(502, 258);
            foreach (var registro in Registros)
            {
                Registros_Del_Tiempo.Rows.Add(registro.FechaMarcada, registro.Salida_Marcada, registro.Entrada_Marcada, registro.Asistencia);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Registros = EmpleadoObtenido.RegistroDelTiempo;
            string[] CamposDeUnRegistro = { "Fecha", "SALIDA M", "ENTRADA M", "ASISTENCIA" };
            for (var i = 0; i < 4; i++)
            {
                DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();
                Columna.Name = $"{CamposDeUnRegistro[i]}";
                Registros_Del_Tiempo.Columns.Add(Columna);
            }
            Registros_Del_Tiempo.Location = new Point(11, 180);
            Registros_Del_Tiempo.Size = new Size(502, 258);
            foreach (var registro in Registros)
            {
                Registros_Del_Tiempo.Rows.Add(registro.FechaMarcada, registro.Salida_Marcada, registro.Entrada_Marcada, registro.Asistencia);
            }
        }

        private void FiltrarTarde_Click(object sender, EventArgs e)
        {
            Registros_Del_Tiempo.Rows.Clear();
            var Registros = EmpleadoObtenido.RegistroDelTiempo;
            foreach (var registro in Registros)
            {
                if (registro.EsTarde)
                {
                    Registros_Del_Tiempo.Rows.Add(registro.FechaMarcada, registro.Salida_Marcada, registro.Entrada_Marcada, registro.Asistencia);
                }
                
            }
        }

        private void FiltrarCorrecto_Click(object sender, EventArgs e)
        {
            Registros_Del_Tiempo.Rows.Clear();
            var Registros = EmpleadoObtenido.RegistroDelTiempo;
            foreach (var registro in Registros)
            {
                if (!registro.EsTarde)
                {
                    Registros_Del_Tiempo.Rows.Add(registro.FechaMarcada, registro.Salida_Marcada, registro.Entrada_Marcada, registro.Asistencia);
                }
                
            }
        }

        private void DeshacerFiltro_Click(object sender, EventArgs e)
        {
            Registros_Del_Tiempo.Rows.Clear();
            var Registros = EmpleadoObtenido.RegistroDelTiempo;
            foreach (var registro in Registros)
            {
                Registros_Del_Tiempo.Rows.Add(registro.FechaMarcada, registro.Salida_Marcada, registro.Entrada_Marcada, registro.Asistencia);
            }

        }

        private void BTN_Crear_Excel_Click(object sender, EventArgs e)
        {
            SLDocument Excel = new SLDocument();

            //System.Data.DataTable dataTable = new System.Data.DataTable();
            DataTable dataTable = new DataTable();
            var Celda1 = new object();
            var Celda2 = new object();
            var Celda3 = new object();
            var Celda4 = new object();
            foreach (DataGridViewTextBoxColumn columna in Registros_Del_Tiempo.Columns)
            {
                string nombreColumna = columna.Name;
                dataTable.Columns.Add(nombreColumna);
            }
            for (int i = 0; i<Registros_Del_Tiempo.RowCount; i++)
            {
                Celda1 = Registros_Del_Tiempo.Rows[i].Cells[0].Value;
                Celda2 = Registros_Del_Tiempo.Rows[i].Cells[1].Value;
                Celda3 = Registros_Del_Tiempo.Rows[i].Cells[2].Value;
                Celda4 = Registros_Del_Tiempo.Rows[i].Cells[3].Value;
                dataTable.Rows.Add(Celda1,Celda2, Celda3, Celda4);
            }
            //dataTable.Rows.Add(Registros_Del_Tiempo.Rows[i].Cells[0].Value.ToString(), Registros_Del_Tiempo.Rows[i].Cells[1].Value.ToString(), Registros_Del_Tiempo.Rows[i].Cells[2].Value.ToString(), Registros_Del_Tiempo.Rows[i].Cells[3].Value.ToString());
            //dataTable.Rows.Add(Registros_Del_Tiempo.Rows[0].Cells[0].Value.ToString(), Registros_Del_Tiempo.Rows[0].Cells[1].Value.ToString(), Registros_Del_Tiempo.Rows[0].Cells[2].Value.ToString(), Registros_Del_Tiempo.Rows[0].Cells[3].Value.ToString());
            Excel.ImportDataTable(1, 1, dataTable, true);
            Excel.SaveAs(pathExcel);
            MessageBox.Show("Excel Creado, revise la carpeta de empleados");
        }
    }
}
