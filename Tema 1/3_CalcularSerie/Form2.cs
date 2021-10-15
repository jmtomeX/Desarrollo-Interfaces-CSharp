using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalcularSerie
{
    public partial class Form2 : Form
    {
        public Form2(string total)
        {
            InitializeComponent();
   
            txtBoxResult.Text = total;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "";
            this.Close();
        }
    }
}
