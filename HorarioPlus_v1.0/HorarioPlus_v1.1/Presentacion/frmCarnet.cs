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
        #region ->(Variables de Instancia de Clase)
        //Creacion de la cordenadas de cada carnet segun la separacion y el tamaño etandar para cada carnet en el metodo crearCarnet();
        int panelSeparation = 10; // Espacio entre los paneles
        int panelWidth = 180; // Ancho de cada panel
        int panelHeight = 200; // Altura de cada panel

        int currentX = 10; // Posición horizontal inicial
        int currentY = 10; // Posición vertical inicial

        // Cordenadas o ubicacion de la creacion de los carnets en el metodo de filtradoDeCarnets();
        int x = 10;  // Posición horizontal inicial
        int y = 10;  // Posición vertical inicial
        //private List<Empleados> lista_Empleados = new List<Empleados>();
        #endregion

        #region ->(Inicializa La Ejecucion)
        public frmCarnet()
        {
            InitializeComponent();
            ManejadorEmpleados.CargarArchivoJson();
            crearCarnet();
        }
        #endregion

        #region ->(Creacion de Carnets)
        private void crearCarnet()
        {
            foreach (var empleado in ManejadorEmpleados.lista_Empleados)
            {
                //Creacion de un panel para cada usuario
                var panelC = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightSeaGreen,
                    Location = new Point(currentX, currentY)
                };

                //Creacion del contenedor de la imagen local
                var usImagen = new PictureBox
                {
                    Width = 100,
                    Height = 80,
                    BackColor = Color.LightSeaGreen,
                    Location = new Point(40, 10),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                try
                {
                    // Ruta de la imagen en tu sistema de archivos
                    string rutaImagen = @"../../../../Resources/imagen.jfif";

                    // Carga la imagen desde la ruta
                    usImagen.Image = Image.FromFile(rutaImagen);
                }
                catch (FileNotFoundException ex)
                {
                    // Manejo de la excepción si la imagen no se encuentra
                    Console.WriteLine($"Error: {ex.Message}");
                }

                //Creacion de Label para el nombre
                var LabelN = new Label
                {
                    AutoSize = true,
                    Text = $"Nombre: {empleado.Nombre}",
                    Location = new Point(10, 100)
                };

                //Creacion de Label para el apellido
                var LabelA = new Label
                {
                    AutoSize = true,
                    Text = $"Apellido: {empleado.Apellido1} {empleado.Apellido2}",
                    Location = new Point(10, 117)
                };

                //Creacion de Label para el Rol
                var LabelR = new Label
                {
                    AutoSize = true,
                    Text = $"Cargo: {empleado.Rol}",
                    Location = new Point(10, 134)
                };

                //Creacion de Label para el Carnet
                var LabelID = new Label
                {
                    AutoSize = true,
                    Text = $"No. Carnet: {empleado.IdEmpleado}",
                    Location = new Point(40, 156),
                    Font = new Font("Segoe UI", 8, FontStyle.Bold)
                };

                //Almacenar cada componente en el panel principal
                panelC.Controls.Add(usImagen);
                panelC.Controls.Add(LabelN);
                panelC.Controls.Add(LabelA);
                panelC.Controls.Add(LabelR);
                panelC.Controls.Add(LabelID);
                pnlCarnet.Controls.Add(panelC);

                // Actualiza la posición horizontal para el siguiente panel
                currentX += panelWidth + panelSeparation;

                // Verifica si el siguiente panel cabe en la ventana
                if (currentX + panelWidth + panelSeparation > pnlCarnet.Width)
                {
                    // Si no cabe, colócalo debajo del primero
                    currentX = 10;
                    currentY += panelHeight + panelSeparation;
                }
            }
            //Las variables vuelven a su estado inicial
            panelSeparation = 10;
            currentX = 10;
            currentY = 10;
        }
        #endregion

        #region ->(Busqueda de carnet)
        private void busquedaDeCarnet()
        {
            string carnetBuscado = txtBuscar.Text.Trim();
            int carnetEncontrado = ManejadorEmpleados.lista_Empleados.FindIndex(i => i.IdEmpleado == carnetBuscado);
            if (carnetEncontrado == -1)
            {
                //Mostrar una ventana de dialogo con la estructura ->Texto a mostrar/Titulo/Botones y su funcion
                MessageBox.Show("El Carnet no fue encontrado", "Carnet no encontrado", MessageBoxButtons.OK);
                crearCarnet();
            }
            else
            {
                Empleados empleadoEncontrado = ManejadorEmpleados.lista_Empleados[carnetEncontrado];

                //Creacion de un panel para cada usuario
                var panelC = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightSeaGreen,
                    Location = new Point(10, 10)
                };

                //Creacion del contenedor de la imagen local
                var usImagen = new PictureBox
                {
                    Width = 100,
                    Height = 80,
                    BackColor = Color.LightSeaGreen,
                    Location = new Point(40, 10),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                try
                {
                    // Ruta de la imagen en tu sistema de archivos
                    string rutaImagen = @"../../../../Resources/imagen.jfif";

                    // Carga la imagen desde la ruta
                    usImagen.Image = Image.FromFile(rutaImagen);
                }
                catch (FileNotFoundException ex)
                {
                    // Manejo de la excepción si la imagen no se encuentra
                    Console.WriteLine($"Error: {ex.Message}");
                }

                //Creacion de Label para el nombre
                var LabelN = new Label
                {
                    AutoSize = true,
                    Text = $"Nombre: {empleadoEncontrado.Nombre}",
                    Location = new Point(10, 100)
                };

                //Creacion de Label para el apellido
                var LabelA = new Label
                {
                    AutoSize = true,
                    Text = $"Apellido: {empleadoEncontrado.Apellido1} {empleadoEncontrado.Apellido2}",
                    Location = new Point(10, 117)
                };

                //Creacion de Label para el Rol
                var LabelR = new Label
                {
                    AutoSize = true,
                    Text = $"Cargo: {empleadoEncontrado.Rol}",
                    Location = new Point(10, 134)
                };

                //Creacion de Label para el Carnet
                var LabelID = new Label
                {
                    AutoSize = true,
                    Text = $"No. Carnet: {empleadoEncontrado.IdEmpleado}",
                    Location = new Point(40, 156),
                    Font = new Font("Segoe UI", 8, FontStyle.Bold)
                };

                //Almacenar cada componente en el panel principal
                panelC.Controls.Add(usImagen);
                panelC.Controls.Add(LabelN);
                panelC.Controls.Add(LabelA);
                panelC.Controls.Add(LabelR);
                panelC.Controls.Add(LabelID);

                pnlCarnet.Controls.Add(panelC);
            }
        }
        #endregion

        #region ->(Filtrado de Carnets)
        private void filtradoDeCarnet()
        {
            string carnet1 = txtCarnet1.Text.Trim();
            string carnet2 = txtCarnet2.Text.Trim();

            int carnetE1 = ManejadorEmpleados.lista_Empleados.FindIndex(i => i.IdEmpleado == carnet1);
            int carnetE2 = ManejadorEmpleados.lista_Empleados.FindIndex(a => a.IdEmpleado == carnet2);

            if ((carnetE1 > carnetE2) && (carnetE2 >= 0))
            {
                MessageBox.Show("Ingrese el numero menor al lado izquierdo y el mayor en el lado derecho", "Error en el orden de ingreso de los Catnets", MessageBoxButtons.OK);
                crearCarnet();
            }
            else
            {
                if ((carnetE1 >= 0) && (carnetE2 >= 0))
                {
                    for (int i = carnetE1; i <= carnetE2; i++)
                    {
                        Empleados empleadosEncontrados = ManejadorEmpleados.lista_Empleados[i];
                        //Creacion de un panel para cada usuario
                        var panelC = new Panel
                        {
                            Width = panelWidth,
                            Height = panelHeight,
                            BorderStyle = BorderStyle.FixedSingle,
                            BackColor = Color.LightSeaGreen,
                            Location = new Point(x, y)
                        };

                        //Creacion del contenedor de la imagen local
                        var usImagen = new PictureBox
                        {
                            Width = 100,
                            Height = 80,
                            BackColor = Color.LightSeaGreen,
                            Location = new Point(40, 10),
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        try
                        {
                            // Ruta de la imagen en tu sistema de archivos
                            string rutaImagen = @"../../../../Resources/imagen.jfif";

                            // Carga la imagen desde la ruta
                            usImagen.Image = Image.FromFile(rutaImagen);
                        }
                        catch (FileNotFoundException ex)
                        {
                            // Manejo de la excepción si la imagen no se encuentra
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        //Creacion de Label para el nombre
                        var LabelN = new Label
                        {
                            AutoSize = true,
                            Text = $"Nombre: {empleadosEncontrados.Nombre}",
                            Location = new Point(10, 100)
                        };

                        //Creacion de Label para el apellido
                        var LabelA = new Label
                        {
                            AutoSize = true,
                            Text = $"Apellido: {empleadosEncontrados.Apellido1} {empleadosEncontrados.Apellido2}",
                            Location = new Point(10, 117)
                        };

                        //Creacion de Label para el Rol
                        var LabelR = new Label
                        {
                            AutoSize = true,
                            Text = $"Cargo: {empleadosEncontrados.Rol}",
                            Location = new Point(10, 134)
                        };

                        //Creacion de Label para el Carnet
                        var LabelID = new Label
                        {
                            AutoSize = true,
                            Text = $"No. Carnet: {empleadosEncontrados.IdEmpleado}",
                            Location = new Point(40, 156),
                            Font = new Font("Segoe UI", 8, FontStyle.Bold)
                        };

                        //Almacenar cada componente en el panel principal
                        panelC.Controls.Add(usImagen);
                        panelC.Controls.Add(LabelN);
                        panelC.Controls.Add(LabelA);
                        panelC.Controls.Add(LabelR);
                        panelC.Controls.Add(LabelID);
                        pnlCarnet.Controls.Add(panelC);

                        // Actualiza la posición horizontal para el siguiente panel
                        x += panelWidth + panelSeparation;

                        // Verifica si el siguiente panel cabe en la ventana
                        if (x + panelWidth + panelSeparation > pnlCarnet.Width)
                        {
                            // Si no cabe, colócalo debajo del primero
                            x = 10;
                            y += panelHeight + panelSeparation;
                        }
                        /*Los puntos se llaman de manra diferente ya que si eran llamados por currentX 
                         y currentY se guarda el utimo punto y al refrescar se limpia y se carga el metodo
                        crearCarnet(); pero desde el ultimo punto del filtrado*/
                    }
                }
                else
                {
                    MessageBox.Show("“Lo sentimos, pero uno de los carnets no fue encontrado. Puede ser que el número de carnet que ingresó no esté asignado.”", "Error de Filtrado", MessageBoxButtons.OK);
                    crearCarnet();
                }
            }
        }
        #endregion

        #region ->(Metodos Clicks)
        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            pnlCarnet.Controls.Clear();
            filtradoDeCarnet();
            txtCarnet1.Text = string.Empty;  //Remplazamos el texto por una cadena vacia
            txtCarnet2.Text = string.Empty;  //Remplazamos el texto por una cadena vacia
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            pnlCarnet.Controls.Clear();
            crearCarnet();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlCarnet.Controls.Clear();
            busquedaDeCarnet();
            txtBuscar.Text = string.Empty;  //Remplazamos el texto por una cadena vacia
        }
        #endregion

        #region Metodos_Viejos
        //#region ->(Variables de Instancia de Clase)
        ////Creacion de la cordenadas de cada carnet segun la separacion y el tamaño etandar para cada carnet en el metodo crearCarnet();
        //int panelSeparation = 10; // Espacio entre los paneles
        //int panelWidth = 180; // Ancho de cada panel
        //int panelHeight = 200; // Altura de cada panel

        //// Cordenadas o ubicacion de la creacion de los carnets en el metodo de filtradoDeCarnets();
        //int x = 10;  // Posición horizontal inicial
        //int y = 10;  // Posición vertical inicial
        //#endregion

        //#region ->(Inicializa La Ejecucion)
        //public frmCarnet()
        //{
        //    InitializeComponent();
        //    lista_Empleados = ManejadorEmpleados.CargarArchivoJson();
        //    GenerarCarnet();
        //}
        //#endregion

        //#region >(Creacion de carnet)
        //private void GenerarCarnet()
        //{
        //    int panelSeparacion = 10;
        //    int panelAncho = 180;
        //    int panelAlto = 200;

        //    foreach(var empleado in lista_Empleados)
        //    {
        //        var panel = CrearPanel(panelAncho, panelAlto);
        //        AgregarImagen(panel, @"../../../../Resources/imagen.jfif");
        //        AgregarLabel(panel, empleado);
        //        PosicionarPaneles(panel, panelSeparacion);

        //        pnlCarnet.Controls.Add(panel);
        //    }
        //}
        //#endregion

        //#region >(Metodo para buscar carnet)
        //#endregion

        //#region ->(Ajustes de Carnets)
        //private Panel CrearPanel(int ancho, int alto)
        //{
        //    var panel = new Panel
        //    {
        //        Width = ancho,
        //        Height = alto,
        //        BorderStyle = BorderStyle.FixedSingle,
        //        BackColor = Color.LightSeaGreen
        //    };
        //    return panel;
        //}

        //private void AgregarImagen(Panel panel, string rutaImagen)
        //{
        //    var imagen = new PictureBox
        //    {
        //        Width = 100,
        //        Height = 80,
        //        BackColor = Color.LightSeaGreen,
        //        Location = new Point(40,10),
        //        SizeMode = PictureBoxSizeMode.Zoom
        //    };
        //    try
        //    {
        //        imagen.Image = Image.FromFile(rutaImagen);
        //    }
        //    catch (FileNotFoundException ex) // Por si no encuentra la imagen
        //    {
        //        MessageBox.Show($"Error: " + ex.Message);
        //    }
        //    panel.Controls.Add(imagen);
        //}

        //private void AgregarLabel(Panel panel, Empleados empleado)
        //{
        //    //Creacion de Label para el nombre
        //    var lblNombre = new Label
        //    {
        //        AutoSize = true,
        //        Text = $"Nombre: {empleado.Nombre}",
        //        Location = new Point(10, 100)
        //    };

        //    //Creacion de Label para el apellido
        //    var lblApellidos = new Label
        //    {
        //        AutoSize = true,
        //        Text = $"Apellido: {empleado.Apellido1} {empleado.Apellido2}",
        //        Location = new Point(10, 117)
        //    };

        //    //Creacion de Label para el Rol
        //    var lblRol = new Label
        //    {
        //        AutoSize = true,
        //        Text = $"Cargo: {empleado.Rol}",
        //        Location = new Point(10, 134)
        //    };

        //    //Creacion de Label para el Carnet
        //    var lblId = new Label
        //    {
        //        AutoSize = true,
        //        Text = $"No. Carnet: {empleado.IdEmpleado}",
        //        Location = new Point(40, 156),
        //        Font = new Font("Segoe UI", 8, FontStyle.Bold)
        //    };
        //    panel.Controls.AddRange(new Control[] { lblNombre, lblApellidos, lblRol, lblId });
        //}

        //private void PosicionarPaneles(Panel panel, int separacionPanel)
        //{
        //    int posicX = 10;
        //    int posicY = 10;
        //    panel.Location = new Point(posicX, posicY);

        //    // actualizamos posicion para el siguiente panel
        //    posicX += panel.Width + separacionPanel;

        //    // Verificamos si cabe
        //    if (posicX + panel.Width + separacionPanel > pnlCarnet.Width)
        //    {
        //        posicX = 10;
        //        posicY += panel.Height + separacionPanel;
        //    }
        //}
        //#endregion

        //#region ->(Filtrado de Carnets)
        //private void FiltradoDeCarnet()
        //{
        //    string carnet1 = txtCarnet1.Text.Trim();
        //    string carnet2 = txtCarnet2.Text.Trim();

        //    int carnetE1 = ManejadorEmpleados.lista_Empleados.FindIndex(i => i.IdEmpleado == carnet1);
        //    int carnetE2 = ManejadorEmpleados.lista_Empleados.FindIndex(a => a.IdEmpleado == carnet2);

        //    if ((carnetE1 > carnetE2) && (carnetE2 >= 0))
        //    {
        //        MessageBox.Show("Ingrese el numero menor al lado izquierdo y el mayor en el lado derecho", "Error en el orden de ingreso de los Catnets", MessageBoxButtons.OK);
        //        GenerarCarnet();
        //    }
        //    else
        //    {
        //        if ((carnetE1 >= 0) && (carnetE2 >= 0))
        //        {
        //            for (int i = carnetE1; i <= carnetE2; i++)
        //            {
        //                Empleados empleadosEncontrados = ManejadorEmpleados.lista_Empleados[i];
        //                //Creacion de un panel para cada usuario
        //                var panelC = new Panel
        //                {
        //                    Width = panelWidth,
        //                    Height = panelHeight,
        //                    BorderStyle = BorderStyle.FixedSingle,
        //                    BackColor = Color.LightSeaGreen,
        //                    Location = new Point(x, y)
        //                };

        //                //Creacion del contenedor de la imagen local
        //                var usImagen = new PictureBox
        //                {
        //                    Width = 100,
        //                    Height = 80,
        //                    BackColor = Color.LightSeaGreen,
        //                    Location = new Point(40, 10),
        //                    SizeMode = PictureBoxSizeMode.Zoom
        //                };
        //                try
        //                {
        //                    // Ruta de la imagen en tu sistema de archivos
        //                    string rutaImagen = @"C:\Users\DELL\OneDrive\Desktop\HorarioPlus-main\HorarioPlus_v1.0\recurso\imagen.jfif";

        //                    // Carga la imagen desde la ruta
        //                    usImagen.Image = Image.FromFile(rutaImagen);
        //                }
        //                catch (FileNotFoundException ex)
        //                {
        //                    // Manejo de la excepción si la imagen no se encuentra
        //                    Console.WriteLine($"Error: {ex.Message}");
        //                }

        //                //Creacion de Label para el nombre
        //                var LabelN = new Label
        //                {
        //                    AutoSize = true,
        //                    Text = $"Nombre: {empleadosEncontrados.Nombre}",
        //                    Location = new Point(10, 100)
        //                };

        //                //Creacion de Label para el apellido
        //                var LabelA = new Label
        //                {
        //                    AutoSize = true,
        //                    Text = $"Apellido: {empleadosEncontrados.Apellido1} {empleadosEncontrados.Apellido2}",
        //                    Location = new Point(10, 117)
        //                };

        //                //Creacion de Label para el Rol
        //                var LabelR = new Label
        //                {
        //                    AutoSize = true,
        //                    Text = $"Cargo: {empleadosEncontrados.Rol}",
        //                    Location = new Point(10, 134)
        //                };

        //                //Creacion de Label para el Carnet
        //                var LabelID = new Label
        //                {
        //                    AutoSize = true,
        //                    Text = $"No. Carnet: {empleadosEncontrados.IdEmpleado}",
        //                    Location = new Point(40, 156),
        //                    Font = new Font("Segoe UI", 8, FontStyle.Bold)
        //                };

        //                //Almacenar cada componente en el panel principal
        //                panelC.Controls.Add(usImagen);
        //                panelC.Controls.Add(LabelN);
        //                panelC.Controls.Add(LabelA);
        //                panelC.Controls.Add(LabelR);
        //                panelC.Controls.Add(LabelID);
        //                pnlCarnet.Controls.Add(panelC);

        //                // Actualiza la posición horizontal para el siguiente panel
        //                x += panelWidth + panelSeparation;

        //                // Verifica si el siguiente panel cabe en la ventana
        //                if (x + panelWidth + panelSeparation > pnlCarnet.Width)
        //                {
        //                    // Si no cabe, colócalo debajo del primero
        //                    x = 10;
        //                    y += panelHeight + panelSeparation;
        //                }
        //                /*Los puntos se llaman de manra diferente ya que si eran llamados por currentX 
        //                 y currentY se guarda el utimo punto y al refrescar se limpia y se carga el metodo
        //                crearCarnet(); pero desde el ultimo punto del filtrado*/
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("“Lo sentimos, pero uno de los carnets no fue encontrado. Puede ser que el número de carnet que ingresó no esté asignado.”", "Error de Filtrado", MessageBoxButtons.OK);
        //            GenerarCarnet();
        //        }
        //    }
        //}
        //#endregion

        //#region ->(Metodos Clicks)
        #endregion

    }
}