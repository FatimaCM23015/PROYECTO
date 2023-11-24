using primeraAplicacionFormularios.Models;

namespace primeraAplicacionFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rellenarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double campo1 = double.Parse(txtCampo1.Text);
            double campo2 = double.Parse(txtCampo2.Text);

            double suma = campo1 + campo2;

            lbRespuesta.Text = suma.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double campo1 = double.Parse(txtCampo1.Text);
            double campo2 = double.Parse(txtCampo2.Text);

            double suma = campo1 - campo2;

            lbRespuesta.Text = suma.ToString();

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double campo1 = double.Parse(txtCampo1.Text);
            double campo2 = double.Parse(txtCampo2.Text);

            double suma = campo1 * campo2;

            lbRespuesta.Text = suma.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double campo1 = double.Parse(txtCampo1.Text);
            double campo2 = double.Parse(txtCampo2.Text);

            if (campo2 == 0)
            {
                lbRespuesta.Text = "No se permite division entre 0";

            }
            else
            {
                double suma = campo1 / campo2;

                lbRespuesta.Text = suma.ToString();
            }



        }

        private void btnAbrirNuevoFormulario_Click(object sender, EventArgs e)
        {

            formularioConversor formulario = new formularioConversor();
            formulario.Show();
            this.Close();

        }

        public void rellenarTabla() {

            Productos producto = new Productos();
            List<Productos> listaProducto = producto.generarLista();
            foreach (var itemProducto in listaProducto) {
                Productos productoItem = (Productos)itemProducto;
                dtProductos.Rows.Add(new string[] {productoItem.codigo.ToString(),productoItem.nombre, productoItem.precio.ToString()});
            }
        
        }
    }
}