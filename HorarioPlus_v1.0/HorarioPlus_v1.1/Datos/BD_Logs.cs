using HorarioPlus_v1._1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HorarioPlus_v1._1.Datos
{
    public class BD_Logs
    {
        #region VARIABLES
        private const string RUTA_LOGS = @"C:\Users\maria magdalena\Desktop\HorarioPlus\HorarioPlus\archivos_empleados\logs.json";
        public static List<Logs> lista_Logs { get; set; } = new List<Logs>();
        #endregion

        #region Metodos Logs
        public static List<Logs> CargarArchivoLogs()
        {
            if (File.Exists(RUTA_LOGS))
            {
                try
                {
                    string jsonReadLogs = File.ReadAllText(RUTA_LOGS);
                    // Deserializando el archivo JSON en una lista de objetos Empleado
                    lista_Logs = JsonSerializer.Deserialize<List<Logs>>(jsonReadLogs);
                    return lista_Logs;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al cargar el archivo de logs en el DataGridView: " +
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
        public static void AgregarLog(Logs log)
        {
            try
            {
                lista_Logs.Add(log);
                GuardarLog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void GuardarLog()
        {
            try
            {
                JsonSerializerOptions opcionSerializar = new JsonSerializerOptions { WriteIndented = true };
                string jsonWriteLogs = JsonSerializer.Serialize(lista_Logs, opcionSerializar);
                File.WriteAllText(RUTA_LOGS, jsonWriteLogs);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}