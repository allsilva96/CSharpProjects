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
    public partial class FrmAula4 : Form
    {
        public FrmAula4()
        {
            InitializeComponent();
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            double n1, n2, idd;

            n1 = Convert.ToDouble(txtAnoAtual.Text);
            n2 = Convert.ToDouble(txtAnoNasc.Text);

            idd = n1 - n2;

            lblIdade2.Text = idd.ToString();




        }

        private void txtAnoNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double num2, pi, result;

            pi = Math.PI;
            num2 = Convert.ToDouble(txtRaio.Text);

            result = pi * (num2 * num2);

            lblArea2.Text = result.ToString();


            

        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
                double a, b, c, delta, rdelta, x1, x2;

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            delta = b * b - 4 * a * c;
            rdelta = Math.Sqrt(delta);

            x1 = (-b + rdelta) / 2 * a;
            x2 = (-b - rdelta) / 2 * a;

            lblxx1.Text = x1.ToString();
            lblxx2.Text = x2.ToString();


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedia abr = new FrmMedia();
            abr.Show();
            this.Hide();


        }

        private void salárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalario abrir = new frmSalario();
            abrir.Show();
            this.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRaio_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade2_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }
    }
}
