using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorarioPlus_v1._1.Presentacion
{
    public partial class frmHorarioEmpleados : Form
    {
        int i = 1;
        int posicionTB;
        int Hora, Minutos, Segundos ,HoraS,MinS,SEGS;


        TimeSpan TiempoEntrada = new TimeSpan();

       

        public frmHorarioEmpleados()
        {
            InitializeComponent();
        }


        private void dgvTablaEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if ((txtHorasEntrada.Text == string.Empty) && (txtHoraSalida.Text == string.Empty) && (txtminutosEntrada.Text == string.Empty)&&
                (txtminutosSalida.Text == string.Empty)&&(txtsegundosEntrada.Text == string.Empty)&&(txtsegundosSalida.Text == string.Empty))
            {

                MessageBox.Show("Campo invalido", "Cambio" +
           "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                MessageBox.Show("Cambio Exitoso", "ActualizarHorario" +
                "", MessageBoxButtons.OK, MessageBoxIcon.None);
                AsignarHorarios();
                txtHoraSalida.Clear();
                txtHorasEntrada.Clear();
                txtminutosEntrada.Clear();
                txtminutosSalida.Clear();
                txtsegundosEntrada.Clear();
                txtsegundosSalida.Clear();

            }




        }
       
        private void AsignarHorarios()
               
        {
          string txtHE = txtHorasEntrada.Text;
          Hora = Convert.ToInt32(txtHE);
     
            string txtHS = txtHoraSalida.Text;
            HoraS = Convert.ToInt32(txtHS);
          
            string txtME= txtminutosEntrada.Text;
            Minutos= Convert.ToInt32(txtME);
            
            string txtMS =txtminutosSalida.Text;
            MinS = Convert.ToInt32(txtMS);
           
            string txtSE = txtsegundosEntrada.Text;
            Segundos = Convert.ToInt32(txtSE);
          
           string txtSS= txtsegundosSalida.Text;
            SEGS = Convert.ToInt32(txtSS);
           
            TimeSpan E = new TimeSpan(Hora, Minutos, Segundos);
            TimeSpan S = new TimeSpan(HoraS,MinS,SEGS);

            dgvTablaEntrada.Rows.Add(i + "", E,S);
            i = i + 1;
            txtHorasEntrada.Focus();

        }


        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {

        }


    }
        

}

