using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmTesteVariavel : Form
    {
        bool flag = true;
        public FrmTesteVariavel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int num;

            num = 1;

            lblNum.Text = num.ToString();
            lblMostrar.Text = "Senac Largo Treze";
            lblNCompleto.Text = "Técnico em Informática - TI92";
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBandeira_Click(object sender, EventArgs e)
        {
            flag = true;

            lblBandeira.Text = flag.ToString();
            


         
        }

        private void btnFalso_Click(object sender, EventArgs e)
        {
            int num;

            num = 0;

            lblNum.Text = num.ToString();
            lblMostrar.Text = "";
            lblNCompleto.Text = "";

            flag = false;
            lblBandeira.Text = flag.ToString();
            

        }
    }
}
