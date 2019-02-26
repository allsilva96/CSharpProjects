using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {

            escolhaNum();

        }
        public void escolhaNum()
        {
            string valor = "";


            if (txtNum.Text.Equals(""))
            {

                MessageBox.Show("Por favor! Insira apenas números");
                txtNum.Focus();
                txtNum.Clear();
            }
            else
            {

                switch (Convert.ToInt32(txtNum.Text))
                {
                    case 1:
                        valor = "1";
                        break;
                    case 2:
                        valor = "2";
                        break;
                    case 3:
                        valor = "3";
                        break;
                    case 4:
                        valor = "4";
                        break;
                    case 5:
                        valor = "5";
                        break;

                    default:
                        MessageBox.Show("Escolha um item  de 1 a 5");

                        break;



                }
                if (Convert.ToInt32(txtNum.Text) <= 5)
                {
                    DialogResult msg = MessageBox.Show("Escolheu o item " + valor);
                    txtNum.Focus();
                    txtNum.Clear();
                }
                else
                {
                    txtNum.Focus();
                    txtNum.Clear();
                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = 50, v2 = 35, resp = 0;

            resp = v1 + v2;

            DialogResult mensagem = MessageBox.Show("A soma de " + v1 + " + " + v2 + " = " + resp, "Escolha", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

            if (mensagem == DialogResult.Yes)
            {
                MessageBox.Show("Tu escolheu SIM!!");

            }
            if (mensagem == DialogResult.No)
            {
                MessageBox.Show("Tu escolheu NÃO!!");
            }
            if (mensagem == DialogResult.Cancel)
            {
                MessageBox.Show("Tu decidiu CANCELAR!!");
            }

        }
        public void testeNome()
        {


            string nome = "Senac";

            if (txtNome.Text.Equals(nome))
            {

                MessageBox.Show("Seja Bem Vindo!");
            }
            else
            {
                MessageBox.Show("Insira o nome correto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                txtNome.Clear();
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            testeNome();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                testeNome();
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                escolhaNum();

            }
        }
    }
}
