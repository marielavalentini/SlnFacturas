using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFacturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            //creacion de producto 1

            List<DetalleFactura> listaDetalle = new List<DetalleFactura>();

            List<Producto> listaProductos = new List<Producto>();

            Categoria Categoria1  = new Categoria("Bebidas", listaProductos);

            Producto producto1 = new Producto("Coca cola", 200, listaDetalle, Categoria1);

           
            //creacion de producto 2
            List<DetalleFactura> listaDetalle2 = new List<DetalleFactura>();

            List<Producto> listaProductos2 = new List<Producto>();

            Categoria Categoria2 = new Categoria("Bebidas Alcoholicas", listaProductos);

            Producto producto2 = new Producto("Fernet", 2300, listaDetalle2, Categoria2);

            MessageBox.Show("Producto: " + producto1.Nombre);
            MessageBox.Show("Producto: " + producto2.Nombre);
        }
    }
}
