using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_Simple_texto
{
    public partial class Form1 : Form
    {
        FontFamily fontFamilyArial = new FontFamily("Arial");
        FontFamily fontFamilyCourier = new FontFamily("Courier New");
        FontFamily fontFamilyImpact = new FontFamily("Impact");
        FontFamily fontFamilySymbol = new FontFamily("Symbol");
        public Form1()
        {
            InitializeComponent();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fontArial = txtCaja.Font;
            txtCaja.Font = new Font(fontFamilyArial , fontArial.Size, fontArial.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fontCourier = txtCaja.Font;
            txtCaja.Font = new Font(fontFamilyCourier, fontCourier.Size, fontCourier.Style);
        }

        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Font fontImpact = txtCaja.Font;
            txtCaja.Font = new Font(fontFamilyImpact, fontImpact.Size, fontImpact.Style);
        }

        private void symbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Font fontSymbol = txtCaja.Font;
            txtCaja.Font = new Font(fontFamilySymbol, fontSymbol.Size, fontSymbol.Style);
        }

    }
}
