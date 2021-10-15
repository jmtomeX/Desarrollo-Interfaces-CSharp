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
    // Enumerador para definir la operación que se va a realizar
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5
    }
    public partial class Calculadora : Form
    {
    

        public Calculadora()
        {
            InitializeComponent();
        }

        double valor1;
        double valor2;

        Operacion operador = Operacion.NoDefinida;

        bool leidoUnNumero = false;

        private void button10_Click(object sender, EventArgs e)
        {
            leidoUnNumero = true;
            if (resultado.Text == "0")
            {
                return;
            }
            else
            {
                resultado.Text += "0";
            }
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void leerNumero(string numero)
        {
            leidoUnNumero = true;
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = numero;
            }
            else
            {
                resultado.Text += numero;
            }
        }

        private double ejecutarOperaciones()
        {
            double resultadoOperacion = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultadoOperacion = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultadoOperacion = valor1 - valor2;
                    break;
                case Operacion.Multiplicacion:
                    resultadoOperacion = valor1 * valor2;
                    break;
                case Operacion.Division:
                    if(valor2 == 0)
                    {
                        lblHistorial.Text = "ERROR al dividir entre 0";
                        resultadoOperacion = 0;
                    }
                    else
                    {
                        resultadoOperacion = valor1 / valor2;
                    }
                    
                    break;
                case Operacion.Modulo:
                    resultadoOperacion = valor1 % valor2;
                    break;
            }

            return resultadoOperacion;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            leerNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            leerNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            leerNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && leidoUnNumero)
            {
                // recogemos el número de la caja y lo parseamos a double
                valor2 = Convert.ToDouble(resultado.Text);
          
                lblHistorial.Text += valor2 + "=";

                double resultadoOp = ejecutarOperaciones();

                valor1 = 0;
                valor2 = 0;

                // empieza de nuevo al acabar la operación
                leidoUnNumero = false;
                resultado.Text = Convert.ToString(resultadoOp);

            }
        }

        private void obtenerValor(string operador)
        {
            // recogemos el número de la caja y lo parseamos a double 
            valor1 = Convert.ToDouble(resultado.Text);

            // guardar en el historial
            lblHistorial.Text = resultado.Text + operador;
            resultado.Text = "0";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            obtenerValor("+");
        }


        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            obtenerValor("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            obtenerValor("X");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            obtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            obtenerValor("%");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            lblHistorial.Text = "";
            leidoUnNumero = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(resultado.Text.Length > 1)
            {
                string txtResultado = resultado.Text;
                // ir borrando números
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                // borrar carácteres
                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    resultado.Text = "0";
                }

                resultado.Text = txtResultado;
            }else
            {
                resultado.Text = "0";
            }
        }

        private void btnComa_Click_1(object sender, EventArgs e)
        {
             if(resultado.Text.Contains(","))
                 {
                    return;
                 }
             resultado.Text += ",";
        }

    }
}
