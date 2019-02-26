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
    public partial class FrmFolhaSalarioV2 : Form
    {
        double sal, salp, salc, imposto, tximposto;

        public void clubLazer()
        {
            cboClubLazer.Items.Clear();

            cboClubLazer.Items.Add("Clube A R$ 100,00");
            cboClubLazer.Items.Add("Clube B R$ 50,00");
            cboClubLazer.Items.Add("Clube C R$ 10,00");

        }
        public FrmFolhaSalarioV2()
        {
            InitializeComponent();
            clubLazer();

        }

        private void btnNvConsulta_Click(object sender, EventArgs e)
        {
            txtImpostoRenda.Text = " ";
            txtSalFolha.Text = " ";
            txtSalLiquido.Text = " ";
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

            if ((imposto >= 1903.99) && (imposto <= 2826.65))
            {
                tximposto = imposto - (imposto * 1.075);
                txtImpostoRenda.Text = String.Format("{0:c}", tximposto);
                imposto = imposto + (imposto - imposto * 1.075);
                txtSalLiquido.Text = String.Format("{0:c}", imposto);
                }
            if ((sal >= 2826.66) && (sal <= 3751.05))
            {
                tximposto = imposto - (imposto * 1.15);
                txtImpostoRenda.Text = String.Format("{0:c}", tximposto);
                imposto = imposto + (imposto - imposto * 1.15);
                txtSalLiquido.Text = String.Format("{0:c}", imposto);

            }

            if ((sal >= 3751.06) && (sal <= 4664.67))
            {
                tximposto = imposto - (imposto * 1.225);
                txtImpostoRenda.Text = String.Format("{0:c}", tximposto);
                imposto = imposto + (imposto - imposto * 1.225);
                txtSalLiquido.Text = String.Format("{0:c}", imposto);

            }
            if (sal >= 4664.68)
            {
                tximposto = imposto - (imposto * 1.275);
                txtImpostoRenda.Text = String.Format("{0:c}", tximposto);
                imposto = imposto + (imposto - imposto * 1.275);
                txtSalLiquido.Text = String.Format("{0:c}", imposto);

            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            sal = Double.Parse(txtSalario.Text);
            txtSalFolha.Text = String.Format("{0:c}", sal);
            imposto = sal;


        }

        private void ckbPlanoSaude_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPlanoSaude.Checked)
            {
                salp = sal - 150;
                txtSalFolha.Text = String.Format("{0:c}", salp);
                imposto = salp;
            }
            else
            {
                salp = salp + 150;
                txtSalFolha.Text = String.Format("{0:c}", salp);
                imposto = salp;
            }

        }

        private void FrmFolhaSalarioV2_Load(object sender, EventArgs e)
        {

        }

        private void cboClubLazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClubLazer.SelectedIndex == 0)
            {
                salc = sal - 100;
                txtSalFolha.Text = String.Format("{0:c}", salc);
                imposto = salc;
            }
            // 
            if (cboClubLazer.SelectedIndex == 1)
            {
                salc = sal - 50;
                txtSalFolha.Text = String.Format("{0:c}", salc);
                imposto = salc;
            }
            //
            if (cboClubLazer.SelectedIndex == 2)
            {
                salc = sal - 10;
                txtSalFolha.Text = String.Format("{0:c}", salc);
                imposto = salc;
            }
            //
            if ((cboClubLazer.SelectedIndex == 0) && (ckbPlanoSaude.Checked))
            {
                salc = salp - 100;
                txtSalFolha.Text = String.Format("{0:c}", salc);
                imposto = salc;
            }
            //
            if ((cboClubLazer.SelectedIndex == 1) && (ckbPlanoSaude.Checked))
            {
                salc = salp - 50;
                txtSalFolha.Text = String.Format("{0:c}", salc);
                imposto = salc;
            }
            if ((cboClubLazer.SelectedIndex == 2) && (ckbPlanoSaude.Checked))
            {
                salc = salp - 10;
                txtSalFolha.Text = String.Format("{0:c}", salc);
                imposto = salc;
            }


        }
    }
}
