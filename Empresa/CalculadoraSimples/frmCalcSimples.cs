using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class FrmCalcSimples : Form
    {
        public FrmCalcSimples()
        {
            InitializeComponent();
        }

        private void FrmCalcSimples_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            double num1, num2, adicao = 0;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            adicao = num1 + num2;

            lblResultado.Text = String.Format("{0} + {1} = {2}", num1, num2, adicao);
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, sub = 0;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            sub = num1 - num2;

            lblResultado.Text = String.Format("{0} - {1} = {2}", num1, num2, sub);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, mult = 0;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            mult = num1 * num2;

            lblResultado.Text = String.Format("{0} x {1} = {2}", num1, num2, mult);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, div = 0;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            div = num1 / num2;

            lblResultado.Text = String.Format("{0} ÷ {1} = {2}", num1, num2, div);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
