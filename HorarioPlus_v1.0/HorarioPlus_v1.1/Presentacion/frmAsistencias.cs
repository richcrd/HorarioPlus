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

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmAsistencias : Form
    {
        int ultimoPanelY = 50;
        int cantidadDePaneles = 0;
        public frmAsistencias()
        {
            InitializeComponent();
            ManejadorEmpleados.CargarArchivoJson();
            foreach(var empleado in ManejadorEmpleados.lista_Empleados)
            {
                GENERAR_REGISTRO(empleado);
            }
        }
        public void GENERAR_REGISTRO(Empleados empleados)
        {
            //CrearPanelito(empleados, true);
            AgregarPanelAlContenedor(CrearPanelito(empleados));

        }
        private Panel CrearPanelito(Empleados empleados)
        {

            Panel nuevoPanel = new Panel();
            nuevoPanel.BackColor = Color.LightBlue;

            nuevoPanel.Location = new Point(20, ultimoPanelY);

            nuevoPanel.Size = new Size(720, 50);

            nuevoPanel.Cursor = Cursors.Hand;

            nuevoPanel.Name = "panel" + cantidadDePaneles;

            nuevoPanel.Tag = empleados;
            // Agrega el evento de clic al panel
            nuevoPanel.Click += new EventHandler(PanelGenerado_Click);
            AgregarLabel(nuevoPanel, empleados);
            return nuevoPanel;

        }
        private void AgregarPanelAlContenedor(Panel nuevoPanel)
        {
            // Agrega el panel al panel contenedor
            pnlContenedor.Controls.Add(nuevoPanel);

            // Actualiza la posición del último panel agregado
            ultimoPanelY += nuevoPanel.Height + 10;
            cantidadDePaneles++;
        }
        private void AgregarLabel(Panel panel, Empleados empleado)
        {
            //Creacion de Label para el nombre
            var lblNombre = new Label
            {
                AutoSize = true,
                Text = $"Nombre: {empleado.Nombre}",
                Location = new Point(10, 5)
            };
            string asistencia = (empleado.RegistroDelTiempo.Last().Asistencia) ? "ASISTIDO" : "AUSENTE";
            Color color = (empleado.RegistroDelTiempo.Last().Asistencia) ? Color.Green : Color.Red; ;
            var lblAsistencia = new Label
            {
                AutoSize = true,
                Text = asistencia,
                Location = new Point(200, 5),
                ForeColor = color,
            };
            panel.Controls.AddRange(new Control[] { lblNombre, lblAsistencia });

        }
        private void PanelGenerado_Click(object sender, EventArgs e)
        {
            // Este método se ejecutará cuando se haga clic en el panel
            Panel panelClicado = sender as Panel;
            Empleados empleadoDelPanel = panelClicado.Tag as Empleados;

            Asistencia_Registro_Individual frmARI = new Asistencia_Registro_Individual(empleadoDelPanel);

            frmARI.ShowDialog();
        }
    }
}
