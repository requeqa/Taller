using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            /*      Iniciar Login
            frmLogin = new Usuario.frmLogin();
            frmLogin.TopLevel = false;
            frmLogin.AutoScroll = true;
            frmLogin.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frmLogin);
            frmLogin.Show();    // */

            //*      Iniciar Login
            frmAlmacen = new Almacen.frmAlmacen();
            frmAlmacen.TopLevel = false;
            frmAlmacen.AutoScroll = true;
            panel1.Controls.Add(frmAlmacen);
            frmAlmacen.Show();    // */
        }
        private Usuario.frmLogin frmLogin;

        private Almacen.frmAlmacen frmAlmacen;
        private Almacen.Parametros.frmMarca frmMarca;
        private Almacen.Parametros.frmUnidad frmUnidad;

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlmacen = new Almacen.frmAlmacen();
            frmAlmacen.TopLevel = false;
            frmAlmacen.AutoScroll = true;
            panel1.Controls.Add(frmAlmacen);
            frmAlmacen.Show();    // */
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca = new Almacen.Parametros.frmMarca();
            frmMarca.TopLevel = false;
            frmMarca.AutoScroll = true;
            panel1.Controls.Add(frmMarca);
            frmMarca.Show();    // */
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidad = new Almacen.Parametros.frmUnidad();
            frmUnidad.TopLevel = false;
            frmUnidad.AutoScroll = true;
            panel1.Controls.Add(frmUnidad);
            frmUnidad.Show();
        }
    }
}
