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
            //AddFormulario(new Usuario.frmLogin());
            /*      Iniciar Login
            frmLogin = new Usuario.frmLogin();
            frmLogin.TopLevel = false;
            frmLogin.AutoScroll = true;
            frmLogin.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frmLogin);
            frmLogin.Show();    // */

            //*      Iniciar Login
            //AddFormulario(new Almacen.frmAlmacen());
            /*frmAlmacen = new Almacen.frmAlmacen();
            frmAlmacen.TopLevel = false;
            frmAlmacen.AutoScroll = true;
            panel1.Controls.Add(frmAlmacen);
            frmAlmacen.Show();    // */
        }
        private Usuario.frmLogin frmLogin;

        private Almacen.frmAlmacen frmAlmacen;
        private Almacen.Parametros.frmMarca frmMarca;
        private Almacen.Parametros.frmUnidad frmUnidad;
        #region metodos
        public void AddFormulario (Form form)
        {
            form.TopLevel = false;
            form.TopMost = false;
            form.AutoScroll = true;
            panel1.Controls.Add(form);
            form.Show();
        }
        #endregion
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlmacen = new Almacen.frmAlmacen();
            AddFormulario(frmAlmacen);
            frmAlmacen.ChangeTab(1);
        }
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormulario(new Almacen.Parametros.frmMarca());
        }
        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormulario(new Almacen.Parametros.frmUnidad());
        }       

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlmacen = new Almacen.frmAlmacen();
            AddFormulario(frmAlmacen);
            frmAlmacen.ChangeTab(2);
        }
    }
}
