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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
                      

            num1 = Double.Parse(txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);



            if (rdbAdicao.Checked)
            {
                resp = num1 + num2;
                lblResp.Text = resp.ToString();
                }
            if (rdbSub.Checked)
            {
                resp = num1 - num2;
                lblResp.Text = resp.ToString();
            }
            if (rdbMult.Checked)
            {
                resp = num1 * num2;
                lblResp.Text = resp.ToString();
            }
            if (rdbDiv.Checked)
            {
                if (num2 == 0)
                {
                    lblResp.Text = "Impossível dividir por 0";
                }
                else
                {
                    resp = num1 / num2;
                    lblResp.Text = resp.ToString();
                }
            }

        
            
            
            
                             
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResp.Text = "";
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
