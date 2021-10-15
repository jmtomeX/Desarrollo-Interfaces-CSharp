using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularSerie
{
    public partial class Form1 : Form
    {  
        double[] numeros = new double[4];
        int cont = 1;
        public Form1()
        
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
          switch (cont)
            {
                case 1:
                    recogerNúmeros(Convert.ToDouble(textBox1.Text));
                    break;
                case 2:
                    recogerNúmeros(Convert.ToDouble(textBox1.Text));
                    break;
                case 3:
                    recogerNúmeros(Convert.ToDouble(textBox1.Text));
                    break;
                case 4:
                    recogerNúmeros(Convert.ToDouble(textBox1.Text));
                    break;
            }
        }

        private void recogerNúmeros(double numeroRec) 
        {
            if(cont < 4)
            {
             try
                    {
                      numeros[cont-1] = numeroRec;
                      cont++;
                      label1.Text = "Número " + cont;
                      textBox1.Text = "";
                      textBox1.Focus();
                    } catch(Exception e)
                    {
                        e.ToString();
                    }
            } else
            {
                try
                {
                    numeros[cont-1] = numeroRec;
                    cont= 1;
                    label1.Text = "Número " + cont;
                    textBox1.Text = "";
                
                    double totalOperacion = (numeros[0] + (numeros[0] * numeros[1]) + (numeros[1] * numeros[2]) + (numeros[2] * numeros[3])) / 4;

                   string total = Convert.ToString(totalOperacion);

                      Form2 f2 = new Form2(total);
                      f2.Show();





                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
       
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
