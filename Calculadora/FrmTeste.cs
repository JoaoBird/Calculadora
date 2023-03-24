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
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Soma":
                    double res = Convert.ToInt32(txtBox_Valor1.Text) + Convert.ToInt32(txtBox_Valor2.Text);
                    lblResultado.Text = res.ToString();
                    break;
                case "Subtração":
                    res = Convert.ToInt32(txtBox_Valor1.Text) - Convert.ToInt32(txtBox_Valor2.Text);
                    lblResultado.Text = res.ToString();
                    break;
                case "Divisão":
                    res = Convert.ToInt32(txtBox_Valor1.Text) / Convert.ToInt32(txtBox_Valor2.Text);
                    lblResultado.Text = res.ToString();
                    break;
                case "Multiplicação":
                    res = Convert.ToInt32(txtBox_Valor1.Text) * Convert.ToInt32(txtBox_Valor2.Text);
                    lblResultado.Text = res.ToString();
                    break;
                case "Exponenciação":
                    res = Math.Pow( Convert.ToInt32(txtBox_Valor1.Text) , Convert.ToInt32(txtBox_Valor2.Text));
                    lblResultado.Text = res.ToString();
                    break;
                case "Raiz":
                    res = Math.Pow(Convert.ToInt32(txtBox_Valor1.Text),1.0/ Convert.ToInt32(txtBox_Valor2.Text));
                    lblResultado.Text = res.ToString();
                    break;
            }
            

        }

            
        

        private void txtBox_Valor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete)
            {
                txtBox_Valor2.BackColor = Color.Red;
                MessageBox.Show("Campo restrito a Numero!");
            }
            else
            {
                txtBox_Valor2.BackColor = Color.White;
            }


        }

        private void txtBox_Valor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;
            if (e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete)
            {
                txtBox_Valor2.BackColor = Color.Red;
                MessageBox.Show("Campo restrito a Numero!");
            }
            else 
            {
                txtBox_Valor2.BackColor = Color.White;
            }

            
        }

        private void txtBox_Valor1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtBox_Valor1,"Campo restrito a Numero");
           
        }

        private void FrmTeste_Load(object sender, EventArgs e)
        {
            
        }
    }
}
