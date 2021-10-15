using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estructuras_y_Vairables_Globales
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbNombre.Text = Global.nombre;
            lb1Apellido.Text = Global.primerApellido;
            lb2Apellido.Text = Global.segundoApellido;
            lbDNI.Text = Global.dNI;
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
