using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_
{
    public partial class Form1 : Form
    {

        string[,] datos = { { "root", "irem" }, { "root", "1234" } };
        int intentos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == datos[0, 0] && textBox2.Text == datos[1, 0])
            {
                // Habiendo hecho login correctamente con this.Hide(); cerramos el formulario actual en este caso es el de login
                this.Hide();
                //Luego creamos un objeto del formulario Principal 
                Calculadora p = new Calculadora();
                //Luego de creado el objeto acedemos a metodo Show() para que nos muestre la ventana
                p.Show();
                //Agregamos un else if para velidar los intentos de inicio si este llega a 3 intentos el programa 
                // finalizara
            }
            else if (intentos == 3)
            {
                //Mostramos un mensaje al usuario que a alcanzado el numero de intentos maximo
                MessageBox.Show("Ha alcanzado el nivel maximo de intentos, Porfavor vuelva a intentarlo", "Mensaje del sistema",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                //El programa se cierra automaticamente.
                Application.Exit();

                //Luego esta el else final este permitira al programa contar los intentos de inicio y enviar mensaje al 
                //usuario cada vez que falle
            }
            else
            {
                //Por cada intento fallido aumentamos un uno a la variable hasta llegar a 3 intentos
                intentos += 1;
                //Enviamos error por cada intento con un MessageBox
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ", "Mensaje del sistema",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpiamos la caja de texto de la contraseña
                textBox2.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
