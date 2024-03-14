using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace HorarioPlus_v1._1.Datos
{
    public class ManejadorEmpleados
    {
        #region VARIABLES && PROPIEDADES
        private const string RUTA_ARCHIVO_EMPLEADOS = @"C:\Users\maria magdalena\Desktop\HorarioPlus\HorarioPlus\archivos_empleados\Empleados.json";
        private static int ultimoIdEmpleado = 0;
        public static List<Empleados> lista_Empleados { get; set; } = new List<Empleados>();

        #endregion

        #region MANEJADOR_EMPLEADO_COMMENTED
        //static ManejadorEmpleados()
        //{
        //    try
        //    {
        //        string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
        //        List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);

        //        foreach (var empleado in empleados)
        //        {
        //            int idEmpleado = Convert.ToInt32(empleado.IdEmpleado);
        //            if (idEmpleado > ultimoIdEmpleado)
        //                ultimoIdEmpleado = idEmpleado;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar el archivo de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion

        #region CRUD
        // Metodo para cargar archivo json
        public static List<Empleados> CargarArchivoJson()
        {
            if (File.Exists(RUTA_ARCHIVO_EMPLEADOS))
            {
                try 
                {
                    string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
                    // Deserializando el archivo JSON en una lista de objetos Empleado
                    lista_Empleados = JsonSerializer.Deserialize<List<Empleados>>(json);
                    return lista_Empleados;
                    #region COMMENTED AREA
                    //foreach (Empleados empleado in lista_Empleados)
                    //{
                    //    // Agregar una nueva fila al DataGridView
                    //    int rowIndex = dgvTablaEmpleados.Rows.Add();

                    //    // Verificar si la fila se agregó correctamente antes de asignar valores a las celdas
                    //    if (rowIndex >= 0 && rowIndex < dgvTablaEmpleados.Rows.Count)
                    //    {
                    //        // Asignar valores a las celdas de la nueva fila
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[0].Value = empleado.IdEmpleado;
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[1].Value = empleado.Nombre;
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[2].Value = empleado.Apellido1;
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[3].Value = empleado.Apellido2;
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[4].Value = empleado.Edad;
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[5].Value = empleado.Correo;
                    //        dgvTablaEmpleados.Rows[rowIndex].Cells[6].Value = empleado.Rol;
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Error al agregar la fila al DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    #endregion
                }
                catch (Exception error) 
                {
                    MessageBox.Show("Error al cargar el archivo de empleados en el DataGridView: " + 
                        error.Message, 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            } // Si no existe archivo
            else
            {
                MessageBox.Show("Error: No se encuentra el archivo especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        // Metodo para guardar lista en archivo json
        public static void GuardarArchivoJson()
        {
            JsonSerializerOptions opcionSerializar = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(lista_Empleados, opcionSerializar);
            File.WriteAllText(RUTA_ARCHIVO_EMPLEADOS, json);
        }

        // Metodo para BuscarEmpleado usando como parametro id
        public static Empleados BuscarEmpleado(string idEmpleado)
        {
            try
            {
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);
                // Utilizamos lINQ para buscar el empleados con el id
                Empleados empleado = empleados.FirstOrDefault(e => e.IdEmpleado == idEmpleado);

                if (empleado == null)
                {
                    MessageBox.Show("Empleado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return empleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de empleados : " +
                     ex.Message,
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return null;
            }
        }

        // Metodo para generar un nuevo id
        public static string GenerarNuevoIdEmpleado()
        {
            int ultimoIdEmpleado = ObtenerUltimoIdEmpleado();
            int nuevoIdEmpleado = ultimoIdEmpleado + 1;
            return nuevoIdEmpleado.ToString();
        }

        //Metodo para obtener el ultimo ID empleado existente
        public static int ObtenerUltimoIdEmpleado()
        {
            int maxId = 0;
            foreach(var empleado in lista_Empleados)
            {
                int idEmpleado = Convert.ToInt32(empleado.IdEmpleado);
                if(idEmpleado > maxId)
                {
                    maxId = idEmpleado;
                }
            }
            return maxId;
        }

        // Metodo para mostrar tabla actualizada
        public static void MostrarTabla(DataGridView dgvTablaEmpleados, List<Empleados> lista_Empleados)
        {
            dgvTablaEmpleados.Rows.Clear(); // Limpiar tabla antes de agregar los empleados
            foreach (var empleado in lista_Empleados)
            {
                dgvTablaEmpleados.Rows.Add(empleado.IdEmpleado, empleado.Nombre, empleado.Apellido1, empleado.Apellido2, empleado.Edad, empleado.Correo, empleado.Rol);
            }
        }

        // Metodo para agregar un nuevo empleado a la lista
        public static void AgregarEmpleado(Empleados empleadoNuevo, DataGridView dataGridView)
        {
            try
            {
                lista_Empleados.Add(empleadoNuevo);
                GuardarArchivoJson();

                int rowIndex = dataGridView.Rows.Add();
                if(rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
                {
                    dataGridView.Rows[rowIndex].Cells[0].Value = empleadoNuevo.IdEmpleado;
                    dataGridView.Rows[rowIndex].Cells[1].Value = empleadoNuevo.Nombre;
                    dataGridView.Rows[rowIndex].Cells[2].Value = empleadoNuevo.Apellido1;
                    dataGridView.Rows[rowIndex].Cells[3].Value = empleadoNuevo.Apellido2;
                    dataGridView.Rows[rowIndex].Cells[4].Value = empleadoNuevo.Edad;
                    dataGridView.Rows[rowIndex].Cells[5].Value = empleadoNuevo.Correo;
                    dataGridView.Rows[rowIndex].Cells[6].Value = empleadoNuevo.Rol;
                }
                else
                {
                    MessageBox.Show("Error al agregar fila al DataGridView", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Metodo para eliminar empleado de lista
        public static void EliminarEmpleado(string id)
        {
            lista_Empleados.RemoveAll(e => e.IdEmpleado.Equals(id));
        }

        // Metodo para actualizar empleado de lista
        public static void ActualizarEmpleado(string idEmpleadoOrigen, Empleados empleadoModificado)
        {
            int indiceEmpleadoOriginal = lista_Empleados.FindIndex(e => e.IdEmpleado == idEmpleadoOrigen);
            if (indiceEmpleadoOriginal != -1)
            {
                lista_Empleados[indiceEmpleadoOriginal] = empleadoModificado;
                GuardarArchivoJson();
            }
            else
            {
                MessageBox.Show("No se encontro el empleado con el ID especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region VALIDACION DATOS
        // Metodo para validarCampo
        public string ValidarCampoVacio(string valor, string mensajeError)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return mensajeError + Environment.NewLine;
            }
            return string.Empty;
        }

        // Metodo para validarCampos en inputs
        public string ValidarCamposEmpleado(string nombre, string primerApellido, string segundoApellido, int edad, string correo)
        {
            string errorMsg = "";

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
        #endregion
    }
}
