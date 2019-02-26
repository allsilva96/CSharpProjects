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
    public partial class FrmEstados : Form
    {
        public void CarregaCombo ()
        {
            cboEstados.Items.Clear();
            cboEstados.Items.Add("São Paulo");
            cboEstados.Items.Add("Rio de Janeiro");
            cboEstados.Items.Add("Amazonas");
            cboEstados.Items.Add("Acre");
            cboEstados.Items.Add("Sergipe");
            cboEstados.Items.Add("Crimelândia");
            cboEstados.Items.Add("Pernambuco");
            cboEstados.Items.Add("Ceará");
            cboEstados.Items.Add("Bahia");
        }
        public FrmEstados()
        {
            InitializeComponent();
            CarregaCombo();
            carregaLista();

        }

        private void btnCarregareEstados_Click(object sender, EventArgs e)
        {
            
            
      
    }

        private void lblEstados_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbEstados.Items.Clear();

        }

        private void FrmEstados_Load(object sender, EventArgs e)
        {
            //CarregaCombo();
        }

        
        private void cboEstados_MouseClick(object sender, MouseEventArgs e)
        {
            //CarregaCombo();
        }

        private void ltbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblList.Text = ltbEstados.SelectedItem.ToString();
            cboEstados.SelectedIndex = ltbEstados.SelectedIndex;
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            carregaLista();
            

        }
        public void carregaLista ()
        {
            ltbEstados.Items.Add("São Paulo");
            ltbEstados.Items.Add("Rio de Janeiro");
            ltbEstados.Items.Add("Amazonas");
            ltbEstados.Items.Add("Acre");
            ltbEstados.Items.Add("Sergipe");
            ltbEstados.Items.Add("Crimelândia");
            ltbEstados.Items.Add("Pernambuco");
            ltbEstados.Items.Add("Ceará");
            ltbEstados.Items.Add("Bahia");
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // lblSEstad.Text = cboEstados.Text;

                       
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblSEstad.Text = cboEstados.SelectedItem.ToString();
            ltbEstados.SelectedIndex = cboEstados.SelectedIndex;
           
        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {
            
                lblSexo.Text = "Masculino";
            
        }

        private void rdbFemin_CheckedChanged(object sender, EventArgs e)
        {
            
            
                lblSexo.Text = "Feminino";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            if (rdbFemin.Checked)
            {
                MessageBox.Show("Você escolheu Feminino!!!!");
            }
            else if (rdbMasc.Checked)
            {
                MessageBox.Show("Você escolheu Masculino!!!!");
            }
        }
    }
}
