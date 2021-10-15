using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Usuario
{
    public partial class Form1 : Form

    {
        public Form1()
           
  
        {
            InitializeComponent();
        }
         private String usuario = "root";
        private String password = "root";
        private void button1_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(usuario) && txtPassword.Text.Equals(password))
            {
                lblMensaje.Text = "El usuario " + txtUsuario.Text + " accedio al sistema.";
            }
            else
            {
                lblMensaje.Text += "\nError en la autentificación.";
            }
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
