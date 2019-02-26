using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxZoom
{
    public partial class FrmZoom : Form
    {
        public FrmZoom()
        {
            InitializeComponent();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            double contar;
            
            contar = Convert.ToDouble(lblcontar.Text);

           



            pictureBox1.Width += +5;
            pictureBox1.Height += +5;
            lblcontar.Text = String.Format("{0}", contar + 1);

        }

        private void btnOrig_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 150;
            pictureBox1.Height = 130;
        }

        private void btnZoom2_Click(object sender, EventArgs e)
        {
            pictureBox1.Width +=  - 5;
            pictureBox1.Height +=  -5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblcontar_Click(object sender, EventArgs e)
        {

        }
    }
}
