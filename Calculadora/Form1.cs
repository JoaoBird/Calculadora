using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Frm_Calculadora : Form
    {
        public Frm_Calculadora()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
          
            

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeste newMDIChild = new FrmTeste();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
