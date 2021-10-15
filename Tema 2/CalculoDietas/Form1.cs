using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDietas
{

    public partial class Form1 : Form
    {
        double totalDietas = 0;
        double totalViajes = 0;
        double totalHoras = 0;

        double totalDia = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Calculo de dietas
        private void checkDesayuno_CheckStateChanged(object sender, EventArgs e)
        {
            anhadirDieta(checkDesayuno, 3);
        }

        private void checkComida_CheckStateChanged(object sender, EventArgs e)
        {
            anhadirDieta(checkComida, 9);
        }

        private void checkCena_CheckStateChanged(object sender, EventArgs e)
        {
            anhadirDieta(checkCena, 15.5);
        }

        // input que recoge los km, cada km se cobra a 0.25€
        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            double totalKms = 0;
            bool entradaCorrecta = comprobarNumeros(e, txtKm);
            // si son números 
            if (entradaCorrecta && e.KeyChar == 13)
            {
                //  txtTotalViajes = CDbl(txtKm.Text);
                try
                {
                    totalKms = (Convert.ToDouble(txtKm.Text)) * 0.25;
                }
                catch (FormatException fE)
                {
                    Console.WriteLine(fE.Message);
                }

                totalViajes = totalViajes + totalKms;
                txtTotalViajes.Text = totalViajes.ToString();

                // salario total del día
                totalDia = totalDia + totalViajes;
                txtTotalSalarioDia.Text = totalViajes.ToString();


                // bloquear el input
                txtKm.ReadOnly = true;

                // tabular al siguiente input
                SendKeys.Send("{TAB}");
            }
        }

        // calculo de las horas de viaje, se pagan a 18€
        private void txtHorasViaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            double totalHoras = 0;
            bool entradaCorrecta = comprobarNumeros(e, txtHorasViaje);
            // si son números 
            if (entradaCorrecta && e.KeyChar == 13)
            {
                //  txtTotalViajes = CDbl(txtKm.Text);
                try
                {
                    totalHoras = (Convert.ToDouble(txtHorasViaje.Text)) * 18;
                }
                catch (FormatException fE)
                {
                    Console.WriteLine(fE.Message);
                }

                totalViajes = totalViajes + totalHoras;
                txtTotalViajes.Text = totalViajes.ToString();

                // salario total del día
                totalDia = totalDia + totalViajes;
                txtTotalSalarioDia.Text = totalDia.ToString();

                // bloquear el input
                txtHorasViaje.ReadOnly = true;

                // tabular al siguiente input
                SendKeys.Send("{TAB}");
            }
        }

        // calculo de las horas trabajadas, se pagan a 42€
        private void txtHorasTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool entradaCorrecta = comprobarNumeros(e, txtKm);
            // si son números 
            if (entradaCorrecta && e.KeyChar == 13)
            {
                try
                {
                    totalHoras = (Convert.ToDouble(txtHorasTrabajo.Text)) * 42;
                }
                catch (FormatException fE)
                {
                    Console.WriteLine(fE.Message);
                }

                txtTotalHorasTrabajo.Text = totalHoras.ToString();

                // salario total del día
                totalDia = totalDia + totalHoras;
                txtTotalSalarioDia.Text = totalDia.ToString();

                // bloquear el input
                txtHorasTrabajo.ReadOnly = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool comprobarNumeros(KeyPressEventArgs e, TextBox txt)
        {
            if (e.KeyChar == 44 && !txt.Text.Contains(','))
            {
                return false;
            }
            // comprobar que sean solo números, condicional con el código ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return false;
            }

            return true;
        }

        private void anhadirDieta(CheckBox tipoCheck, double precioDieta)
        {
            if (tipoCheck.Checked == true)
            {
                totalDietas = totalDietas + precioDieta;
                totalDia = totalDia + precioDieta;
            }
            else
            {
                totalDietas = totalDietas - precioDieta;
                totalDia = totalDia - precioDieta;
            }

            // si se limpia queda guardado el resultado en negativo hasta que se vuelve a limpiar la segunda vez
            txtTotalDietas.Text = totalDietas.ToString();

            txtTotalSalarioDia.Text = totalDia.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            totalDietas = 0;
            totalViajes = 0;
            totalHoras = 0;
            totalDia = 0;

            txtKm.Text = "0";
            txtHorasViaje.Text = "0";
            txtHorasTrabajo.Text = "0";

            txtTotalDietas.Text = "0";
            txtTotalViajes.Text = "0";
            txtTotalHorasTrabajo.Text = "0";
            txtTotalSalarioDia.Text = "0";


            txtKm.ReadOnly = false;
            txtHorasViaje.ReadOnly = false;
            txtHorasTrabajo.ReadOnly = false;

            checkDesayuno.Checked = false;
            checkComida.Checked = false;
            checkCena.Checked = false;
        }

        private void txtKm_Enter(object sender, EventArgs e)
        {
            txtKm.Text = "";
        }

        private void txtHorasViaje_Enter(object sender, EventArgs e)
        {
            txtHorasViaje.Text = "";
        }

        private void txtHorasTrabajo_Enter(object sender, EventArgs e)
        {
            txtHorasTrabajo.Text = "";
        }
    }

}

/*
Para utilizar un número decimal utilizaremos CBDL:
Text1.text = CDbl(Val(Txttext2.Text))
 */
