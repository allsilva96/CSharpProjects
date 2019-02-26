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
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula4 voltar = new FrmAula4();
            voltar.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double nt1, nt2, nt3, nt4, media;

            nt1 = Convert.ToDouble(txtnt1.Text);
            nt2 = Convert.ToDouble(txtnt2.Text);
            nt3 = Convert.ToDouble(txtnt3.Text);
            nt4 = Convert.ToDouble(txtnt4.Text);

            media = ((nt1 + nt2 + nt3 + nt4) / 4) + 0.05;

            lblMedia2.Text = media.ToString();





        }

        private void sálarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalario abrir = new frmSalario();
            abrir.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMedia_Load(object sender, EventArgs e)
        {

        }

        private void FrmMedia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
