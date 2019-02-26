using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStoreSystem
{
    public partial class frmMenuLogin : Form
    {
        public frmMenuLogin()
        {
            InitializeComponent();
        }

        private void lblUsu_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginDG();

        }

        public void loginDG()
        {
            string nomeusu = "allsilva96", senha = "Senac123";

            if ((txtUsu.Text == nomeusu) && (txtSenha.Text == senha))
            {
                MessageBox.Show("Seja Bem Vindo!");
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();

            }
            else
            {
                lblInfo.Text = "Usuário ou Senha incorretos!";
                lblInfo.ForeColor = System.Drawing.Color.Red;

                txtUsu.Focus();
                txtUsu.Clear();
                txtSenha.Clear();
            }
        }

        private void txtUsu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSenha.Focus();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginDG();
            }
        }

        private void frmMenuLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }


}

