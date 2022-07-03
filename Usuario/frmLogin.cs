using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller.Usuario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Botones
        private void BtnInicio_Click(object sender, EventArgs e) { login(); }
        private void tbX_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) login(); }
        #endregion

        #region Funciones
        private void login() { MessageBox.Show(tbUser.Text + " - " + tbPass.Text); }
        #endregion
    }
}
