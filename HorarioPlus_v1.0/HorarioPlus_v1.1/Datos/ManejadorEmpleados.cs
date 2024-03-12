using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using HorarioPlus_v1._1.Presentacion;
using HorarioPlus_v1._1.Presentacion.Utilidades;


namespace HorarioPlus_v1._1.Datos
{
    public class ManejadorEmpleados
    {
        private const string RUTA_ARCHIVO_EMPLEADOS = @"C:\Users\maria magdalena\Desktop\HorarioPlus\HorarioPlus\archivos_empleados\Empleados.json";
        private static int ultimoIdEmpleado = 0;
        public static List<Empleados> Empleados { get; private set; }
        public static void InicializarRepositorioEmpleado()
        {
            if (File.Exists(RUTA_ARCHIVO_EMPLEADOS))
            {
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);
            }
            else
            {
                Empleados = new List<Empleados>();
            }
        }
        static ManejadorEmpleados()
        {
            try
            {
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);

                foreach(var empleado in empleados)
                {
                    int idEmpleado = Convert.ToInt32(empleado.IdEmpleado);
                    if (idEmpleado > ultimoIdEmpleado)
                        ultimoIdEmpleado = idEmpleado;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CargarInfoEmpleados(DataGridView dataGridView)
        {
            try
            {
                // Leer el contenido del archivo JSON
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);

                // Deserializar el contenido del archivo JSON en una lista de objetos Empleado
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);

                foreach (Empleados empleado in empleados)
                {
                    // Agregar una nueva fila al DataGridView
                    int rowIndex = dataGridView.Rows.Add();

                    // Verificar si la fila se agregó correctamente antes de asignar valores a las celdas
                    if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                    {
                        // Asignar valores a las celdas de la nueva fila
                        dataGridView.Rows[rowIndex].Cells[0].Value = empleado.IdEmpleado;
                        dataGridView.Rows[rowIndex].Cells[1].Value = empleado.Nombre;
                        dataGridView.Rows[rowIndex].Cells[2].Value = empleado.Apellido1;
                        dataGridView.Rows[rowIndex].Cells[3].Value = empleado.Apellido2;
                        dataGridView.Rows[rowIndex].Cells[4].Value = empleado.Edad;
                        dataGridView.Rows[rowIndex].Cells[5].Value = empleado.Correo;
                        dataGridView.Rows[rowIndex].Cells[6].Value = empleado.Rol;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la fila al DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de empleados en el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Empleados BuscarEmpleado(string idEmpleado)
        {
            try
            {
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);
                return empleados.Find(e => e.IdEmpleado == idEmpleado);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de empleados : " +
                     ex.Message,
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return null;
            }
        }

        public static string GenerarNuevoIdEmpleado()
        {
            ultimoIdEmpleado++;
            return ultimoIdEmpleado.ToString();
        }

        public static void AgregarEmpleado(Empleados empleadoNuevo)
        {
            try
            {
                Empleados.Add(empleadoNuevo);

                // Obtener la lista actualizada de empleados
                List<Empleados> listaEmpleados = ObtenerListaEmpleados();

                // Convertir la lista de empleados a formato JSON
                string json = JsonSerializer.Serialize(listaEmpleados, new JsonSerializerOptions { WriteIndented = true });

                // Escribir el JSON en el archivo
                File.WriteAllText(RUTA_ARCHIVO_EMPLEADOS, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private static List<Empleados> ObtenerListaEmpleados()
        {
            try
            {
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
                return JsonSerializer.Deserialize<List<Empleados>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de empleados: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return new List<Empleados>();
            }
        }

        public static void GuardarCambios(List<Empleados> listaEmpleados)
        {
            string json = JsonSerializer.Serialize(listaEmpleados, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(RUTA_ARCHIVO_EMPLEADOS, json);
        }

        public static void EliminarEmpleado(string id)
        {
            Empleados.RemoveAll(e => e.IdEmpleado.Equals(id));
            //List<Empleados> listaEmpleados = ObtenerListaEmpleados();
            //ManejadorEmpleados.GuardarCambios(listaEmpleados);
        }
        public static void ActualizarEmpleado(string idEmpleadoOrigen, Empleados empleadoModificado)
        {
            int indiceEmpleadoOriginal = Empleados.FindIndex(e => e.IdEmpleado == idEmpleadoOrigen);
            if(indiceEmpleadoOriginal != -1)
            {
                Empleados[indiceEmpleadoOriginal] = empleadoModificado;
            }
        }

        public string ValidarCampoVacio(string valor, string mensajeError)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return mensajeError + Environment.NewLine;
            }
            return string.Empty;
        }

        public string ValidarCamposEmpleado(string idEmpleado, string nombre, string primerApellido, string segundoApellido, string correo, int edad)
        {
            string errorMsg = "";

            errorMsg += ValidarCampoVacio(idEmpleado, "El id del empleado no puede estar vacio");
            errorMsg += ValidarCampoVacio(nombre, "El nombre del empleado no puede estar vacio");
            errorMsg += ValidarCampoVacio(primerApellido, "El primer apellido del empleado no puede estar vacio");
            errorMsg += ValidarCampoVacio(segundoApellido, "El segundo apellido del empleado no puede estar vacio");
            errorMsg += ValidarCampoVacio(correo, "El correo del empleado no puede estar vacio");
            
            // Llamada al método de validación de edad
            errorMsg += ValidarEdad(edad);

            // Llamada al método de validación de correo electrónico
            errorMsg += ValidarCorreoElectronico(correo);

            return errorMsg;
        }

        // Método de validación de edad
        public string ValidarEdad(int valor)
        {
            if (valor == 0)
            {
                return "La edad del empleado no puede ser cero" + Environment.NewLine;
            }
            else if (valor < 18)
            {
                return "La edad del empleado no cumple los requisitos, debe ser mayor de edad" + Environment.NewLine;
            }
            return string.Empty;
        }

        // Método de validación de correo electrónico
        public string ValidarCorreoElectronico(string correo)
        {
            try
            {
                new MailAddress(correo);
                return string.Empty;
            }
            catch (Exception)
            {
                return "El correo del empleado debe tener un formato correcto" + Environment.NewLine;
            }
        }
    }
}
