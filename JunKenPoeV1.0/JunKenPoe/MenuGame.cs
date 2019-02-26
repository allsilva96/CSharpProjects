using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunKenPoe
{
    public partial class frmMenu : Form
    {
        enum Escolha {  Pedra, Papel, Tesoura};
        Escolha jogador = new Escolha();
        Escolha cpu = new Escolha();
        Random aleatorio = new Random();
        



        public frmMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuGame_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout info = new frmAbout();
            info.ShowDialog();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogador = Escolha.Tesoura;
            EscolhaJogador();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogador = Escolha.Papel;
            EscolhaJogador();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogador = Escolha.Pedra;
            EscolhaJogador();

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lblUsuP_Click(object sender, EventArgs e)
        {

        }

        private void lblCPUP_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void EscolhaJogador()
        {
            switch(jogador)
            {
                case Escolha.Pedra:
                    picUsu.BackgroundImage = Image.FromFile("c:/haha/Pedra.png");
                    
                    break;
                case Escolha.Papel:
                    picUsu.BackgroundImage = Image.FromFile("c:/haha/Papel.png");
                    break;
                case Escolha.Tesoura:
                    picUsu.BackgroundImage = Image.FromFile("c:/haha/Tesoura.png");
                    break;

            }
        }
        void EscolhaCpu()
        {
            int esc = aleatorio.Next(1, 4);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
