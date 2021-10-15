using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipos_Letras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float tamanho = 12F;
        private string tipoFuente = "Microsoft Sans Serif";
       

        private void btnComicSans_Click(object sender, EventArgs e)
        {
            tipoFuente = "Comic Sans MS";
            cambiosTexto();
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            txtPrueba.Font = new System.Drawing.Font(tipoFuente , tamanho, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnTachado_Click(object sender, EventArgs e)
        {
            txtPrueba.Font = new System.Drawing.Font(tipoFuente, tamanho, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnMasGrande_Click(object sender, EventArgs e)
        {
            tamanho++;
            cambiosTexto();
        }

        private void btnCourier_Click(object sender, EventArgs e)
        {
            tipoFuente = "Courier New";
            cambiosTexto();
        }

        private void btnCursiva_Click(object sender, EventArgs e)
        {
            txtPrueba.Font = new System.Drawing.Font(tipoFuente, tamanho, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            txtPrueba.Font = new System.Drawing.Font(tipoFuente, tamanho, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnMenosGrande_Click(object sender, EventArgs e)
        {
            tamanho--;
            cambiosTexto();
      
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Ensure that text is currently selected in the text box.   
            if (textBox1.SelectedText.Length > 0)
            {
                lblSeleccion.Text = "El texto tiene " + textBox1.SelectionLength;
                lblSeleccion.Text += " caracteres. El texto seleccionado es: " + textBox1.SelectedText;
            }       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void cambiosTexto()
        {
            txtPrueba.Font = new System.Drawing.Font(tipoFuente, tamanho, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

    }
   
}
