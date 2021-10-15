using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeclaIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyEventArgs e)
        {
           if( e.KeyCode == Keys.Enter)
            {
               
                 textBox2.Text = textBox1.Text;
                textBox1.Text = "";
               
 
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13){
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Focus();
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("Heo");
            if (e.KeyChar == 13)
            {
                textBox3.Text = textBox2.Text;
                textBox2.Text = "";
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("Heo");
            if (e.KeyChar == 13)
            {
                textBox1.Text = textBox3.Text;
                textBox3.Text = "";
                textBox1.Focus();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
