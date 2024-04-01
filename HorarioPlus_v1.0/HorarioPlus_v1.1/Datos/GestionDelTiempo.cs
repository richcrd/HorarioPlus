using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Datos
{
    public class GestionDelTiempo
    {
        //Tiempo del sistema en el programa
        public static DateTime HOY = DateTime.Now.Date;//.AddDays(2)
        public static int Hora = DateTime.Now.Hour;
        public static int Minuto = DateTime.Now.Minute;
        public static int Segundo = DateTime.Now.Second;
        public static TimeSpan HourMinSec = new TimeSpan(20, 0, 0);// new TimeSpan(Hora, Minuto, Segundo);

        //Definiendo jornada Laboral
        public static TimeSpan ENTRADA = new TimeSpan(6, 30, 0);//Hora, Minuto, Segundo
        public static TimeSpan SALIDA = new TimeSpan(16, 30, 0);

        //Definiendo datos del registro cronometrico para cada empleado
        public DateTime FechaMarcada { get; set; }
        public TimeSpan Entrada_Marcada { get; set; }
        public TimeSpan Salida_Marcada { get; set; }
        public bool Asistencia { get; set; }
        public GestionDelTiempo() { }
        public GestionDelTiempo(DateTime fecha, TimeSpan hora_De_Entrada, TimeSpan hora_De_Salida)
        {
            FechaMarcada = fecha;
            Entrada_Marcada = hora_De_Entrada;
            Salida_Marcada = hora_De_Salida;
        }

        #region Metodos_De_Busqueda
        public static GestionDelTiempo Buscar_Registro_Por_Fecha(string ID, DateTime FechaParaBuscar)
        {
             Empleados empleado = ManejadorEmpleados.BuscarEmpleado(ID);
             if (empleado!=null)
             {
                 var listaDeRegistros = empleado.RegistroDelTiempo;
                 foreach (var registro in listaDeRegistros)
                 {
                     if (FechaParaBuscar == registro.FechaMarcada)
                     {
                         return registro;
                     }
                 }
             }
             else
             {
                 System.Windows.Forms.MessageBox.Show("Registro No encontrado", "ID ERRONEO", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             return null;
        }
        #endregion

        #region Metodos_De_Confirmacion
        public static bool VerificarAsistencia(string ID, DateTime FechaParaBuscar)
        {

            var RegistroDelTiempo = Buscar_Registro_Por_Fecha(ID, FechaParaBuscar);
            TimeSpan SALIDA = RegistroDelTiempo.Entrada_Marcada;
            TimeSpan ENTRADA = RegistroDelTiempo.Salida_Marcada;

            if ((SALIDA == TimeSpan.Zero) || (ENTRADA == TimeSpan.Zero))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Metodos_De_Registro
        public static void Asignar_Registro_A_Los_Ausentes()
        {
            //fin del dia
            TimeSpan Intervalo_de_Tiempo_1 = new TimeSpan(20, 0, 0);
            TimeSpan Intervalo_de_Tiempo_2 = new TimeSpan(24, 59, 59);

            if (HourMinSec == Intervalo_de_Tiempo_1)//&& HourMinSec<=finDelDia2
            {
                for (int i = 0; i < ManejadorEmpleados.lista_Empleados.Count(); i++)
                {
                    int ultimoElemento = ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo.Count() - 1;

                    if (ManejadorEmpleados.lista_Empleados[i].Marcado == false)
                    {
                        if (ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo.Count() == 0)
                        {
                            GestionDelTiempo Registro = new GestionDelTiempo();
                            Registro.FechaMarcada = HOY;
                            Registro.Entrada_Marcada = TimeSpan.Zero;
                            Registro.Salida_Marcada = TimeSpan.Zero;
                            Registro.Asistencia = false;

                            ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo.Add(Registro);
                            ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ManejadorEmpleados.lista_Empleados[i].IdEmpleado, ManejadorEmpleados.lista_Empleados[i]);
                            //CrearRegistroParaAusencias(ManejadorEmpleados.lista_Empleados[i].IdEmpleado, true);
                        }
                        else
                        {
                            if (ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo[ultimoElemento].FechaMarcada == HOY)
                            {
                                GestionDelTiempo Registro = new GestionDelTiempo();
                                Registro.FechaMarcada = HOY;
                                Registro.Entrada_Marcada = TimeSpan.Zero;
                                Registro.Salida_Marcada = TimeSpan.Zero;
                                Registro.Asistencia = false;
                                ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo[ultimoElemento].FechaMarcada = Registro.FechaMarcada;
                                ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo[ultimoElemento].Entrada_Marcada = Registro.Entrada_Marcada;
                                ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo[ultimoElemento].Salida_Marcada = Registro.Salida_Marcada;
                                ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo[ultimoElemento].Asistencia = Registro.Asistencia;
                                ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ManejadorEmpleados.lista_Empleados[i].IdEmpleado, ManejadorEmpleados.lista_Empleados[i]);
                            }
                            else
                            {
                                GestionDelTiempo Registro = new GestionDelTiempo();
                                Registro.FechaMarcada = HOY;
                                Registro.Entrada_Marcada = TimeSpan.Zero;
                                Registro.Salida_Marcada = TimeSpan.Zero;
                                Registro.Asistencia = false;
                                ManejadorEmpleados.lista_Empleados[i].RegistroDelTiempo.Add(Registro);
                                ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ManejadorEmpleados.lista_Empleados[i].IdEmpleado, ManejadorEmpleados.lista_Empleados[i]);
                            }
                        }
                        ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ManejadorEmpleados.lista_Empleados[i].IdEmpleado, ManejadorEmpleados.lista_Empleados[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        public static void RegistrarHoraDelEmpleado(string ID)
        {
            Empleados empleado = ManejadorEmpleados.BuscarEmpleado(ID);
            GestionDelTiempo Registro = new GestionDelTiempo();
            if (empleado != null)
            {
                int horaMarcada = 16; //GestionDelTiempo.FechaParaBuscar.Hour;
                int minutoMarcado = 30;// GestionDelTiempo.FechaParaBuscar.Minute;

                Registro.FechaMarcada = HOY;
                TimeSpan tiempoMarcado = new TimeSpan(horaMarcada, minutoMarcado, 0);

                int ultimoElemento = empleado.RegistroDelTiempo.Count() - 1;

                if (empleado.RegistroDelTiempo.Count == 0)
                {
                    if (tiempoMarcado <= ENTRADA)
                    {
                        //Ha marcado entrada
                        Registro.Entrada_Marcada = tiempoMarcado;
                        System.Windows.Forms.MessageBox.Show($"Entrada: {Registro.Entrada_Marcada}");

                    }
                    else if (tiempoMarcado >= SALIDA)
                    {
                        //Ha marcado Salida
                        Registro.Salida_Marcada = tiempoMarcado;
                        System.Windows.Forms.MessageBox.Show($"Salida: {Registro.Salida_Marcada}");
                    }
                    else
                    {
                        //Marcado de tiempo entre la entrada y la salida
                        Registro.Entrada_Marcada = tiempoMarcado;
                        System.Windows.Forms.MessageBox.Show($"Entrada: {Registro.Entrada_Marcada}");
                    }

                    empleado.RegistroDelTiempo.Add(Registro);
                }
                else
                {

                    //Verificamos si ya marco en el mismo dia
                    if (empleado.RegistroDelTiempo.Last().FechaMarcada == HOY)
                    {
                        if (tiempoMarcado <= ENTRADA)
                        {
                            //Ha marcado entrada
                            empleado.RegistroDelTiempo[ultimoElemento].Entrada_Marcada = tiempoMarcado;
                            System.Windows.Forms.MessageBox.Show($"Entrada: {empleado.RegistroDelTiempo[ultimoElemento].Entrada_Marcada}");

                        }
                        else if (tiempoMarcado >= SALIDA)
                        {
                            //Ha marcado Salida
                            empleado.RegistroDelTiempo[ultimoElemento].Salida_Marcada = tiempoMarcado;
                            System.Windows.Forms.MessageBox.Show($"Salida: {empleado.RegistroDelTiempo[ultimoElemento].Salida_Marcada}");
                        }
                        else
                        {
                            //Marcado de tiempo entre la entrada y la salida
                            empleado.RegistroDelTiempo[ultimoElemento].Entrada_Marcada = tiempoMarcado;
                            System.Windows.Forms.MessageBox.Show($"Entrada: {Registro.Entrada_Marcada}");
                        }

                        //empleados.RegistroDelTiempo[ultimoElemento] = Registro;

                        ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ID, empleado);

                    }
                    else
                    {
                        if (tiempoMarcado <= ENTRADA)
                        {
                            //Ha marcado entrada
                            Registro.Entrada_Marcada = tiempoMarcado;
                            System.Windows.Forms.MessageBox.Show($"Entrada: {Registro.Entrada_Marcada}");

                        }
                        else if (tiempoMarcado >= SALIDA)
                        {
                            //Ha marcado Salida
                            Registro.Salida_Marcada = tiempoMarcado;
                            System.Windows.Forms.MessageBox.Show($"Salida: {Registro.Salida_Marcada}");
                        }
                        else
                        {
                            //Marcado de tiempo entre la entrada y la salida
                            Registro.Entrada_Marcada = tiempoMarcado;
                            System.Windows.Forms.MessageBox.Show($"Entrada: {Registro.Entrada_Marcada}");



                        }
                        empleado.RegistroDelTiempo.Add(Registro);
                        ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ID, empleado);
                    }
                    if (VerificarAsistencia(ID, HOY))
                    {
                        empleado.RegistroDelTiempo[ultimoElemento].Asistencia = true;
                    }
                    else
                    {
                        empleado.RegistroDelTiempo[ultimoElemento].Asistencia = false;

                    }

                }
                ManejadorEmpleados.ActualizarEmpleado(ManejadorEmpleados.lista_Empleados, ID, empleado);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Registro No encontrado", "ID ERRONEO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            #endregion
    }
}
