using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller.Almacen
{
    public partial class frmAlmacen : Form
    {
        public frmAlmacen()
        {
            InitializeComponent();
            CargarProductos();
            CargarCombo();
        }
        Producto producto;
        List<Producto> productos = new List<Producto>();

        void CargarProductos()
        {
            for (int i = 1; i <= 3; i++) { productos.Add(new Producto(i)); }            
            var bindingList = new BindingList<Producto>(productos);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
        void CargarCombo()
        {
            producto = new Producto();
            foreach (Marca marca in producto.Marcas) { cbMarca.Items.Add(marca.Descripcion); }
            //foreach (Unidad unidad in producto.Unidades) { cbUnidad.Items.Add(unidad.Descripcion); }
        }

        private void unidadDeManejoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
