using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraAplicacionFormularios.Models
{
    class Productos
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }

        public List<Productos> ListaProductos;

        public Productos()
        {
            this.ListaProductos = new List<Productos>();
            //generarLista();


        }
        public Productos(int codigo, string nombre, double precio)
        {
            this.ListaProductos = new List<Productos>();
           // generarLista();
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            //generarLista();
        }

        public List<Productos> generarLista()
        {
            this.ListaProductos = new List<Productos>();
            ListaProductos.Add(new Productos(1,"Computadora", 50.00));
            ListaProductos.Add(new Productos(2, "Teclado", 20.00));
            ListaProductos.Add(new Productos(3, "Mouse", 10.00));

            return ListaProductos;

        }
    }
}
