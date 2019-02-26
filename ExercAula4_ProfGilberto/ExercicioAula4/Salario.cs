using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAula4
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedia abr = new FrmMedia();
            abr.Show();
            this.Hide();
        }

        private void telaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula4 voltar = new FrmAula4();
            voltar.Show();
            this.Hide();
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            double sal, nvsal;

            sal = Convert.ToDouble(txtSalario.Text);

            nvsal = sal + (sal*5 / 100);

            lblNvSal2.Text = String.Format("{0:c}", nvsal);

             
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            double sal, nvsal;

            sal = Convert.ToDouble(txtSalario.Text);

            nvsal = sal + (sal * 10 / 100);

            lblNvSal2.Text = String.Format("{0:c}", nvsal);
        }

        private void btnA15_Click(object sender, EventArgs e)
        {
            double sal, nvsal;

            sal = Convert.ToDouble(txtSalario.Text);

            nvsal = sal + (sal * 15 / 100);

            lblNvSal2.Text = String.Format("{0:c}", nvsal);
        }

        private void btnA20_Click(object sender, EventArgs e)
        {
            double sal, nvsal;

            sal = Convert.ToDouble(txtSalario.Text);

            nvsal = sal + (sal * 20 / 100);

            lblNvSal2.Text = String.Format("{0:c}", nvsal);

        }

        private void frmSalario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
