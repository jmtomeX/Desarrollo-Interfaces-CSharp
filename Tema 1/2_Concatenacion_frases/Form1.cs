using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concatenacion_frases
{
    public partial class Form1 : Form
    {
        int contadorBtn = 1;
        String[] frase = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFraseCompleta.Text = "";
            txtFraseCompleta.Focus();
            btnFrase1.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            frase[0] = txtFraseCompleta.Text;
            txtFraseCompleta.Text = "";
            btnFrase1.Enabled = false;
            btnFrase2.Enabled = true;
            txtFraseCompleta.Focus();
        }

        private void btnFrase2_Click(object sender, EventArgs e)
        {
            frase[1] = txtFraseCompleta.Text;
            txtFraseCompleta.Text = "";
            btnFrase2.Enabled = false;
            btnFrase3.Enabled = true;
            txtFraseCompleta.Focus();
        }

        private void btnFrase3_Click(object sender, EventArgs e)
        {
                frase[2] = txtFraseCompleta.Text;
                txtFraseCompleta.Text = "";
                btnFrase3.Enabled = false;
                btnFrase4.Enabled = true;
            txtFraseCompleta.Focus();
        }

        private void btnFrase4_Click(object sender, EventArgs e)
        {
            frase[3] = txtFraseCompleta.Text;
            txtFraseCompleta.Text = "";
            btnFrase4.Enabled = false;
            btnFrase5.Enabled = true;
            txtFraseCompleta.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                frase[4] = txtFraseCompleta.Text;
                txtFraseCompleta.Text = "";
                btnFrase5.Enabled = false;
                btnFrase6.Enabled = true;
                btnFrase6.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             for(int i =0; i< frase.Length; i++)
            {
                txtFraseCompleta.Text += frase[i] + " ";
            }
            btnFrase6.Enabled = false;
        }

      
    }
}
