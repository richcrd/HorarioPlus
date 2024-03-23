using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioPlus_v1._1.Entidades;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Datos
{
    public class ManejadorEmpresa
    {
        #region RUTA ARCHIVO
        private static string RUTA_ARCHIVO_EMPRESA = @"../../../../archivos_empleados/Empresa.json";
        #endregion

        #region METODOS
        // DESERIALIZANDO ARCHIVO JSON
        public static Empresa CargarArchivoEmpresa()
        {
            if (File.Exists(RUTA_ARCHIVO_EMPRESA))
            {
                string empresaJson = File.ReadAllText(RUTA_ARCHIVO_EMPRESA);
                return JsonSerializer.Deserialize<Empresa>(empresaJson);

            } // Si no existe archivo
            else
            {
                return new Empresa(); // podemos delolver una nueva instancia de empresa con valores default
            }
        }
        // SERIALIZANDO ARCHIVO JSON
        public static void GuardarArchivoEmpresa(Empresa empresa)
        {
            JsonSerializerOptions opcionSerializar = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(empresa, opcionSerializar);
            File.WriteAllText(RUTA_ARCHIVO_EMPRESA, json);
        }
        #endregion
    }
}
