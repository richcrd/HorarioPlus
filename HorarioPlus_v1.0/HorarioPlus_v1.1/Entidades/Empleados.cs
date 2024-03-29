﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioPlus_v1._1.Datos
{
    public class Empleados
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public double PagoPorHoras { get; set; }
        public double TotalHorasAcumuladas { get; set; }
        public double SalarioNeto { get; set; }
        public string HorarioEmpleado { get; set; }
        public Empleados() // Constructor vacio debido a los archivos json
        {

        }

        public Empleados(string id, string nombre, string apellido1, string apellido2, int edad, string correo, string rol, double pagoPorHoras, double totalHorasAcumuladas, double salarioNeto, string horarioEmpleado)
        {
            this.IdEmpleado = id;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Edad = edad;
            this.Correo = correo;
            this.Rol = rol;
            this.PagoPorHoras = pagoPorHoras;
            this.TotalHorasAcumuladas = totalHorasAcumuladas;
            this.SalarioNeto = salarioNeto;
            this.HorarioEmpleado = horarioEmpleado;
        }
    }
}
