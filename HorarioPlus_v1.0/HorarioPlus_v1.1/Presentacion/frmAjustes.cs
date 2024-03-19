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
    public partial class frmAjustes : Form
    {
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //DateTime = horaSeleccionada = dtpHoraEntrada.Value;
            //MessageBox.Show("Hora Seleccionada: " + horaSeleccionada.ToString("hh:mm: tt"));
        }

        private void btnCerrarSistema_Click(object sender, EventArgs e)
        {
            // Codigo temporal
            DialogResult resultadoCierre = MessageBox.Show("Confirmas el cierre del sistema? Hacer esta accion puede interrumpir algunos procesos", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultadoCierre == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
