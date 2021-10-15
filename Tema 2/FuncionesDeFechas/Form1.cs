using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionesDeFechas
{
    public partial class form1 : Form
    {
        public form1(string text = "")
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            bool fechaCorrecta = false;
            limpiarTxt();
            DateTime horaFechaActual = DateTime.Now;

            txtAhora.Text = horaFechaActual.ToString();
            txtHoy.Text = horaFechaActual.ToString("dd-MM-yyyy");
            txtHoraHoy.Text = horaFechaActual.ToString("hh:mm:ss tt");
            //  txtAhora.Text = Convert.ToDateTime(fechaActual).ToString("dd/MM/yyyy");

            // comprobar si la fecha es correcta
            while (!fechaCorrecta)
            {
                // SUMA DE FECHAS
                string resultadoSumaFechas = "";
                DateTime fechaParaSumar = new DateTime();
                string fecha = "";
                string numMeses = "0";
                string fechaInical = "";
                string fechaFinal = "";
                TimeSpan nuevaFecha = new TimeSpan();
                try
                {
                    fecha = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una fecha de la forma dd/mm/aaaa.", "Función Sumar Fechas", "21/12/2022");
                    fechaCorrecta = Comprobar_Formato_Fecha(fecha);
                }
                catch (FormatException fE)
                {
                    MessageBox.Show(fechaCorrecta + " ERROR " + fE.Message);
                }

                try
                {
                    do
                    {
                        numMeses = Microsoft.VisualBasic.Interaction.InputBox("Meses a sumar a la fecha anterior.", "Función Sumar Fechas", numMeses);
                    } while (numMeses == String.Empty);

                }
                catch (Exception eX)
                {
                    MessageBox.Show("ERROR " + eX.Message);
                }

                // Añade los meses a la fecha
                try
                {
                    fechaParaSumar = Convert.ToDateTime(fecha);
                    resultadoSumaFechas = fechaParaSumar.AddMonths(int.Parse(numMeses)).ToString("dd/MM/yyyy");
                }
                catch (FormatException fE)
                {
                    MessageBox.Show(fechaCorrecta + " ERROR " + fE.Message);
                }

                txtSumaFecha.Text = "Fecha de inicio " + fechaParaSumar.ToString("dd/MM/yyyy") + ". Meses a sumar: " + numMeses + ". Nueva fecha: " + resultadoSumaFechas;

                // DIFERENCIA DE FECHAS
                try
                {
                    fechaInical = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha inicial de la forma dd/mm/aaaa.", "Función Sumar Fechas", "12/11/2020");
                    Convert.ToDateTime(fechaInical);
                    fechaCorrecta = Comprobar_Formato_Fecha(fechaInical);
                }
                catch (FormatException fE)
                {
                    MessageBox.Show(fechaCorrecta + " ERROR " + fE.Message);
                }

                try
                {
                    fechaFinal = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la fecha final de la forma dd/mm/aaaa.", "Función Sumar Fechas", "20/11/2020");
                    Convert.ToDateTime(fechaFinal);
                    fechaCorrecta = Comprobar_Formato_Fecha(fechaFinal);
                    nuevaFecha = Convert.ToDateTime(fechaInical).Subtract(Convert.ToDateTime(fechaFinal));
                }
                catch (FormatException fE)
                {
                    MessageBox.Show(fechaCorrecta + " ERROR " + fE.Message);
                }

                txtDiferenciaFechas.Text = "Desde " + fechaInical + " hasta " + fechaFinal + " hay " + nuevaFecha.ToString("dd") + " días";

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        private void limpiarTxt()
        {
            txtHoraHoy.Text = "";
            txtAhora.Text = "";
            txtSumaFecha.Text = "";
            txtHoy.Text = "";
            txtDiferenciaFechas.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Salir", "Salir del Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }
        private bool Comprobar_Formato_Fecha(string fecha)
        {
            DateTime fechaRe;
            bool result = DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaRe);
            //  limpiarTxt();
            if (!result)
            {
                MessageBox.Show("Datos erróneos", "Introduzca los datos correctamente o pulse salir.");
            }

            return result;
        }
    }


}

