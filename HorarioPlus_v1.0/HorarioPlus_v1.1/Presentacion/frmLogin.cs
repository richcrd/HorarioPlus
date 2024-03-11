﻿using HorarioPlus_v1._1.Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmLogin : Form
    {
        #region RUTA_ARCHIVOS_JSON
        private const string RUTA_ARCHIVO_EMPLEADOS = @"C:\Users\maria magdalena\Desktop\HorarioPlus\HorarioPlus\archivos_empleados\Empleados.json";
        #endregion

        public frmLogin()
        {
            InitializeComponent();
            timerHora.Start();
        }

        #region Eventos Internos
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public Empleados BuscarEmpleado(string idEmpleado)
        {
            try
            {
                // Leer el contenido del archivo JSON
                string json = File.ReadAllText(RUTA_ARCHIVO_EMPLEADOS);

                // Deserializar el contenido del archivo JSON en una lista de objetos Empleado
                List<Empleados> empleados = JsonSerializer.Deserialize<List<Empleados>>(json);

                // Regresa el empleado correspondiente al ID
                return empleados.Find(e => e.IdEmpleado == idEmpleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Devolver un nuevo objeto Empleado en caso de error
                return new Empleados();
            }
        }
        #endregion

        #region Eventos Click
        private void btnMarcarRegistro_Click(object sender, EventArgs e)
        {
            bool volverAMarcar = true;

            while (volverAMarcar)
            {
                string idEmpleado = txtEmpleadoId.Text; // Agregar funcionalidad de mostrar ID con checkBoxs
                Empleados empleado = BuscarEmpleado(idEmpleado);

                if (empleado != null)
                {
                    string mensaje = $"{empleado.Nombre} {empleado.Apellido1} registrado a las {DateTime.Now.ToString("hh:mm:ss tt")}";
                    MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmpleadoId.Clear();

                    if (empleado.Rol == "Administrador")
                    {
                        DialogResult resultado = MessageBox.Show("¿Desea ingresar al sistema como administrador?", "Confirmar Acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            this.Hide();
                            frmPanelAdministrador frmPanelAdmin = new frmPanelAdministrador(empleado.Nombre, empleado.Apellido1);
                            frmPanelAdmin.ShowDialog();
                            volverAMarcar = false; // No volver a marcar si el usuario decide ingresar como administrador
                        }
                        else
                        {
                            // Si el usuario elige "No", no volvemos a marcar y salimos del bucle
                            volverAMarcar = false;
                        }
                    }
                    else
                    {
                        txtEmpleadoId.Clear();
                        volverAMarcar = false;
                    }
                }
                else
                {
                    // Si el ID del empleado no existe, mostramos un mensaje de error
                    MessageBox.Show("El ID del empleado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpleadoId.Clear();
                    volverAMarcar = false; // No volvemos a marcar si el id del empleado no existe
                }
            }
        }
        #endregion
    }
}
