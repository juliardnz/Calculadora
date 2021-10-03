using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btAdicao_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btSubt_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else 
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btLimparCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
            }
            
        
    }
}
