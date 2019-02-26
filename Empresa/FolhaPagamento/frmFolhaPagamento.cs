using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        
        
        public void clubLazer()
        {
            cboClubLazer.Items.Clear();

            cboClubLazer.Items.Add("Clube A R$ 100,00");
            cboClubLazer.Items.Add("Clube B R$ 50,00");
            cboClubLazer.Items.Add("Clube C R$ 10,00");

        }
        public frmFolhaPagamento()
        {
            InitializeComponent();
            clubLazer();

        }

        private void lblSalFolha_Click(object sender, EventArgs e)
        {

        }

        private void lblSalarioLiquido_Click(object sender, EventArgs e)
        {

        }

        private void cboClubLazer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ckbPlanoSaude_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalFolha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double sal, valordesc = 0;

            sal = Double.Parse(txtSalario.Text);
            txtSalFolha.Text = String.Format("{0:c}", sal);

            if (ckbPlanoSaude.Checked)
            {
                sal -= 150;
                txtSalFolha.Text = String.Format("{0:c}", sal);
            }

            if (cboClubLazer.SelectedIndex == 0)
            {
                sal -= 100;
                txtSalFolha.Text = String.Format("{0:c}", sal);
            }
            if (cboClubLazer.SelectedIndex == 1){
                sal -= 50;
                txtSalFolha.Text = String.Format("{0:c}", sal);

            }
            if (cboClubLazer.SelectedIndex == 2)
            {
                sal -= 10;
                txtSalFolha.Text = String.Format("{0:c}", sal);

            }

            if ((sal >= 1903.99)&&(sal <= 2826.65))
            {
                txtImpostoRenda.Text = "Taxa de 7,5%";
                valordesc = sal - (sal* 1.075);
                txtValorDesc.Text = String.Format("{0:c}", valordesc);
                sal = sal + (sal - sal* 1.075);
                txtSalLiquido.Text = String.Format("{0:c}", sal);
                
            }
            if ((sal >= 2826.66) && (sal <= 3751.05 ))
            {
                txtImpostoRenda.Text = "Taxa de 15%";
                valordesc = sal - (sal * 1.15);
                txtValorDesc.Text = String.Format("{0:c}", valordesc);
                sal = sal + (sal - sal * 1.15);
                txtSalLiquido.Text = String.Format("{0:c}", sal);

            }

            if ((sal >= 3751.06) && (sal <= 4664.67))
            {
                txtImpostoRenda.Text = "Taxa de 22,5%";
                valordesc = sal - (sal * 1.225);
                txtValorDesc.Text = String.Format("{0:c}", valordesc);
                sal = sal + (sal - sal * 1.225);
                txtSalLiquido.Text = String.Format("{0:c}", sal);

            }
            if (sal >= 4664.68)
            {
                txtImpostoRenda.Text = "Taxa de 27,5%";
                valordesc = sal - (sal * 1.275);
                txtValorDesc.Text = String.Format("{0:c}", valordesc);
                sal = sal + (sal - sal * 1.275);
                txtSalLiquido.Text = String.Format("{0:c}", sal);

            }




        }

        private void btnNvConsulta_Click(object sender, EventArgs e)
        {
            txtSalFolha.Text = " ";
            txtSalLiquido.Text = " ";
            txtImpostoRenda.Text = " ";
            txtValorDesc.Text = " ";
        }
    }
}
