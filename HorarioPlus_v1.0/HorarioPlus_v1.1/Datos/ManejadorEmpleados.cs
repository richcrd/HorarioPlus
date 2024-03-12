﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Datos
{
    public class ManejadorEmpleados
    {
        private const string RUTA_ARCHIVO_EMPLEADOS = @"C:\Users\maria magdalena\Desktop\HorarioPlus\HorarioPlus\archivos_empleados\Empleados.json";

        public static void CargarInfoEmpleados(DataGridView dataGridView)
        {
            try
            {
                // Leer el contenido del archivo JSON
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);

                // Deserializar el contenido del archivo JSON en una lista de objetos Empleado
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);
                
                foreach(Empleados empleado in empleados)
                {
                    dataGridView.Rows.Add(
                        empleado.IdEmpleado,
                        empleado.Nombre,
                        empleado.Apellido1,
                        empleado.Apellido2,
                        empleado.Correo,
                        empleado.Edad,
                        empleado.Rol);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de empleados en el DataGridView: " + 
                    ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
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
                return new Empleados();
            }
        }
    }
}
