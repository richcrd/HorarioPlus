using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HorarioPlus_v1._1.Datos;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmCarnet : Form
    {
        private List<Empleados> lista_Empleados = new List<Empleados>();
        public frmCarnet()
        {
            InitializeComponent();
            lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
        }

        #region METODOS

        private void GenerarCarnet()
        {
            int panelSeparacion = 10;
            int panelAncho = 180;
            int panelAlto = 200;

            foreach(var empleado in lista_Empleados)
            {
                var panel = CrearPanel(panelAncho, panelAlto);
                AgregarImagen(panel, @"../../../../Resources/imagen.jfif");
                AgregarLabel(panel, empleado);
                PosicionarPaneles(panel, panelSeparacion);

                pnlCarnet.Controls.Add(panel);
            }
        }

        private void GenerarCarnetIndividual(Empleados empleado)
        {
            int panelSeparacion = 10;
            int panelAncho = 180;
            int panelAlto = 200;

            var panel = CrearPanel(panelAncho, panelAlto);
            AgregarImagen(panel, @"../../../../Resources/imagen.jfif");
            AgregarLabel(panel, empleado);
            PosicionarPaneles(panel, panelSeparacion);

            pnlCarnet.Controls.Clear();
            pnlCarnet.Controls.Add(panel);

        }

        private Panel CrearPanel(int ancho, int alto)
        {
            var panel = new Panel
            {
                Width = ancho,
                Height = alto,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightSeaGreen
            };
            return panel;
        }

        private void AgregarImagen(Panel panel, string rutaImagen)
        {
            var imagen = new PictureBox
            {
                Width = 100,
                Height = 80,
                BackColor = Color.LightSeaGreen,
                Location = new Point(40,10),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            try
            {
                imagen.Image = Image.FromFile(rutaImagen);
            }
            catch (FileNotFoundException ex) // Por si no encuentra la imagen
            {
                MessageBox.Show($"Error: " + ex.Message);
            }
            panel.Controls.Add(imagen);
        }

        private void AgregarLabel(Panel panel, Empleados empleado)
        {
            //Creacion de Label para el nombre
            var lblNombre = new Label
            {
                AutoSize = true,
                Text = $"Nombre: {empleado.Nombre}",
                Location = new Point(10, 100)
            };

            //Creacion de Label para el apellido
            var lblApellidos = new Label
            {
                AutoSize = true,
                Text = $"Apellido: {empleado.Apellido1} {empleado.Apellido2}",
                Location = new Point(10, 117)
            };

            //Creacion de Label para el Rol
            var lblRol = new Label
            {
                AutoSize = true,
                Text = $"Cargo: {empleado.Rol}",
                Location = new Point(10, 134)
            };

            //Creacion de Label para el Carnet
            var lblId = new Label
            {
                AutoSize = true,
                Text = $"No. Carnet: {empleado.IdEmpleado}",
                Location = new Point(40, 156),
                Font = new Font("Segoe UI", 8, FontStyle.Bold)
            };
            panel.Controls.AddRange(new Control[] { lblNombre, lblApellidos, lblRol, lblId });
        }

        private void PosicionarPaneles(Panel panel, int separacionPanel)
        {
            int posicX = 10;
            int posicY = 10;
            panel.Location = new Point(posicX, posicY);

            // actualizamos posicion para el siguiente panel
            posicX += panel.Width + separacionPanel;

            // Verificamos si cabe
            if (posicX + panel.Width + separacionPanel > pnlCarnet.Width)
            {
                posicX = 10;
                posicY += panel.Height + separacionPanel;
            }
        }

        private void btnGenerarUno_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var empleado = lista_Empleados.Find(x => x.IdEmpleado == id);
            if (empleado != null)
            {
                GenerarCarnetIndividual(empleado);
            }
            else
            {
                MessageBox.Show("El empleado con el ID que ingresaste no existe.");
            }
        }

        private void btnGenerarTodos_Click(object sender, EventArgs e)
        {
            pnlCarnet.Controls.Clear();
            GenerarCarnet();
        }
        #endregion
    }
}