using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalStoreSystem
{
    public partial class frmFuncionarios : Form
    {
        public void checkSexo()
        {
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Feminino");
        }
        public void checkEstadoCivil()
        {
            cboEstadoCivil.Items.Add("Solteiro(a)");
            cboEstadoCivil.Items.Add("Casado(a)");
            cboEstadoCivil.Items.Add("Separdo(a)");
            cboEstadoCivil.Items.Add("Viúvo(a)");

        }
        public void checkEstado()
        {
            cboEstado.Items.Add("AC");
            cboEstado.Items.Add("AL");
            cboEstado.Items.Add("AP");
            cboEstado.Items.Add("AM");
            cboEstado.Items.Add("BA");
            cboEstado.Items.Add("CE");
            cboEstado.Items.Add("DF");
            cboEstado.Items.Add("ES");
            cboEstado.Items.Add("GO");
            cboEstado.Items.Add("MA");
            cboEstado.Items.Add("MT");
            cboEstado.Items.Add("MS");
            cboEstado.Items.Add("MG");
            cboEstado.Items.Add("PA");
            cboEstado.Items.Add("PB");
            cboEstado.Items.Add("PR");
            cboEstado.Items.Add("PE");
            cboEstado.Items.Add("PI");
            cboEstado.Items.Add("RJ");
            cboEstado.Items.Add("RN");
            cboEstado.Items.Add("RS");
            cboEstado.Items.Add("RO");
            cboEstado.Items.Add("RR");
            cboEstado.Items.Add("SC");
            cboEstado.Items.Add("SP");
            cboEstado.Items.Add("SE");
            cboEstado.Items.Add("TO");
        }
        public frmFuncionarios()
        {
            InitializeComponent();
            checkSexo();
            checkEstadoCivil();
            checkEstado();
        }

        
    }
}
