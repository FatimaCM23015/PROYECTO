using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeraAplicacionFormularios
{
    public partial class formularioConversor : Form
    {
        public formularioConversor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (convertirFC.Checked)
            {
                //EL CHECKBOX ESTA SELECCIONADO
                double grados = double.Parse(textBox1.Text);
                double respuestaCelcius = ((grados - 32) * 5 )/ 9;
                lbGradosC.Text = $"Los grados C son {respuestaCelcius}";

            }
            else {
                lbGradosC.Text = "No selecciona esta conversion";
            }
            if (convertirCF.Checked)
            {
                //el checkbox esta seleccionado
                double grados = double.Parse(textBox1.Text);
                double respuestaF = ((grados * 9) / 5) + 32;
                lbGradosF.Text = $"Los grados F son: {respuestaF}";
            }
            else { 
                lbGradosF.Text = "No selecciona esta conversion";
            }

        }
    }
}
