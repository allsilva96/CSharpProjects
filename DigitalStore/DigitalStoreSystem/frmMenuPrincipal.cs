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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenuLogin voltar = new frmMenuLogin();
            voltar.Show();
            
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            frmMenuLogin voltar = new frmMenuLogin();
            voltar.Show();
            this.Close();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios func = new frmFuncionarios();
            func.Show();
            this.Hide();
        }
    }
}
