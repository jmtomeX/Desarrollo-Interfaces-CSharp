using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_y_Vairables_Globales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txt1Apellido.Text = "";
            txt2Apellido.Text = "";
            txtDni.Text = "";

            Form2 frm = new Form2();

            frm.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text !="" && txt1Apellido.Text != "" && txt2Apellido.Text != "" && txtDni.Text != "")
            {
                Global.nombre = txtNombre.Text;
                Global.primerApellido = txt1Apellido.Text;
                Global.segundoApellido = txt2Apellido.Text;
                Global.dNI = txtDni.Text;
                MessageBox.Show("Datos añadidos correctamente.", "Carga de datos Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deben estar todos los campos completos.", "Carga de datos Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
