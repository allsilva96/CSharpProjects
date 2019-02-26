using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula4
{
    public partial class Aula4 : Form
    {
        public Aula4()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            bool logica = true;
            int num = 45;

            // Todo número float tem de ser adiconado "f" ao final.
            float nreal = 3.75f;
            // Double não precisa, porém não te impede de fazer.
            double nreal2 = 17.999;
            // Para decimal é basicamente igual ao float com excessão da letra, agora usamos "M". 
            decimal salario = 900.99m;



            /*label1.Text = "Valor Lógico: " + logica.ToString();
            label1.Text += "\nValor inteiro: " + num.ToString();
            label1.Text += "\nValores Reais: " + nreal.ToString()
                + ", " + nreal2.ToString() + "\nSalário é: "
                + salario.ToString();*/

            lblMostrar.Text += String.Format(
                "\nValores Reais: {0}, \n{1}, \n{2}", nreal, nreal2, salario
                );
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            double num1, num2, subtrai;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            subtrai = num1 - num2;

            lblResult.Text = String.Format("{0} - {1} = {2}", num1, num2, subtrai);
             
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, soma;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            soma = num1 + num2;

            lblResult.Text = String.Format("{0} + {1} = {2}", num1, num2, soma);

        }

        private void Aula4_Load(object sender, EventArgs e)
        {

        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
