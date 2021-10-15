using Grpc.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        string filePath = "C:/Users/iremt/source/repos/Ejercicios 2/Imagenes_y_ComboBox/imgs/";
        // Lista de imagenes
        List<PictureBox> imagenesFila1 = new List<PictureBox>();
        public Form1()
        {

            InitializeComponent();

            // Añadir las imágenes
            imagenesFila1.Add(pictureBox1);
            imagenesFila1.Add(pictureBox2);
            imagenesFila1.Add(pictureBox3);
            imagenesFila1.Add(pictureBox4);
            imagenesFila1.Add(pictureBox5);
            imagenesFila1.Add(pictureBox6);


            // Recogerlas y quitarlas de la vista
            //  MessageBox.Show(ImagenesFila1[0].Name.ToString());
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    imagenesFila1[i].Image = Image.FromFile(filePath + (i + 1) + ".jpg");
                    imagenesFila1[i].Visible = false;
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {

                    Console.WriteLine("Error", outOfRange.Message);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                comboBox1.Items.Add("Imagen " + (i + 1));
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            estadoCheckBox(checkBox1, pictureBox4);


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            estadoCheckBox(checkBox2, pictureBox5);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            estadoCheckBox(checkBox3, pictureBox6);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DialogResult dialogResult = MessageBox.Show(comboBox1.SelectedIndex.ToString()); 
            for (int i = 0; i < 3; i++)
            {
                imagenesFila1[i].Visible = false;
            }
            imagenesFila1[(comboBox1.SelectedIndex)].Visible = true;
                

         



        }

        private void estadoCheckBox(CheckBox checkB, PictureBox pictureB)
        {
            if (checkB.Checked)
            {
                pictureB.Visible = true;
            }
            else
            {
                pictureB.Visible = false;
            }
        }
    }
}
