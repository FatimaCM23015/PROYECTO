using primeraAplicacionFormularios.Models;
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
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
            rellenarTabla();
        }

        public void rellenarTabla()
        {
            Estudiante estudiante = new Estudiante();

            List<Estudiante> listEstudiante = estudiante.getStudiante();
            dtEstudiante.Rows.Clear();
            foreach (var itemEstudiante in listEstudiante)
            {
                Estudiante estu = (Estudiante)itemEstudiante;
                dtEstudiante.Rows.Add(new string[] {estu.idEstudiante.ToString(),
                                                    estu.nombreEstudiante,
                                                    estu.carnet,
                                                     estu.direccion});
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.nombreEstudiante = txtNombre.Text;
            estudiante.carnet = txtCarnet.Text;
            estudiante.direccion = txtDireccion.Text;

            estudiante.insertarDatos(estudiante);
            Console.WriteLine("Insertado");

            rellenarTabla();

        }
    }
}
