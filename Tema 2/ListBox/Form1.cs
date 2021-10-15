using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            anhadirAmigo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBMisAmigos.GetSelected(listBMisAmigos.SelectedIndex) && listBMisAmigos.SelectedItem != null)
                {
                    for (int i = 0;i < listBMisAmigos.Items.Count; i++)
                    {
                        listBMisAmigos.Items.RemoveAt(listBMisAmigos.SelectedIndex);
                    }
                    txtAmigoSelec.Text = "";
                }
            }
            catch (ArgumentOutOfRangeException aOORE)
            {
                MessageBox.Show("Seleccione datos para poder elimininarlos", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Error: " + aOORE.Message);
            }
        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
            listBMisAmigos.Items.Clear();
            txtAmigoSelec.Text = "";
        }

        private void txtNewFriend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                anhadirAmigo();
            }
        }
        private void listBMisAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtAmigoSelec.Text = listBMisAmigos.SelectedItem.ToString();
            }
            catch (NullReferenceException nRE)
            {
                Console.WriteLine("Error " + nRE.Message);
            }

        }
        private void anhadirAmigo()
        {
            if (!txtNewFriend.Text.Equals(""))
            {
                listBMisAmigos.Items.Add(txtNewFriend.Text);
                txtNewFriend.Text = "";
                txtNewFriend.Focus();
            }
            else
            {
                MessageBox.Show("Introduzca datos para poder añadirlos", "Error Añadir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
