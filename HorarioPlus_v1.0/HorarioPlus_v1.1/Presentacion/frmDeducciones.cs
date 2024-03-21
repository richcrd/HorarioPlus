using HorarioPlus_v1._1.Datos;
using HorarioPlus_v1._1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmDeducciones : Form
    {
        private List<Deducciones> lista_deducciones = new List<Deducciones>();
        public frmDeducciones()
        {
            InitializeComponent();
        }
        private void frmDeducciones_Load(object sender, EventArgs e)
        {
            // llamado a los datos mediante metodo ObtenerDeducciones desde capa datos
            lista_deducciones = DatosDeducciones.ObtenerDeducciones();
            ActualizarTabla();
        }
        private void ActualizarTabla()
        {
            dgvTablaDeducciones.Rows.Clear();
            foreach(var deduccion in lista_deducciones)
            {
                dgvTablaDeducciones.Rows.Add(deduccion.IdDeducciones, deduccion.Descripcion, deduccion.Monto);
            }
        }

        // DEJAR INICIALIZADA LISTA DEDUCCIONES EN CAPA DATOS PARA EVITAR HACER OTRO ARCHIVO JSON Y EVITAR CRUD DEBIDO A QUE ES UNA LISTA
        // CONSTANTE
    }
}
