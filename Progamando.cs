using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Progamando : Form
    {
        float valor1 = 0;
        string operacao = "";
        public Progamando()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "1"; // Adiciona o texto do botão ao TextBox
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "2"; // Adiciona o texto do botão ao TextBox
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "3"; // Adiciona o texto do botão ao TextBox
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "4"; // Adiciona o texto do botão ao TextBox
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "5"; // Adiciona o texto do botão ao TextBox
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "6"; // Adiciona o texto do botão ao TextBox
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "7"; // Adiciona o texto do botão ao TextBox
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "8"; // Adiciona o texto do botão ao TextBox
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "9"; // Adiciona o texto do botão ao TextBox
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblResultado.Text = lblResultado.Text + "0"; // Adiciona o texto do botão ao TextBox
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(lblResultado.Text);
            operacao = "Mais";
            lblResultado.Text = "";

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(lblResultado.Text);
            operacao = "Menos";
            lblResultado.Text = "";
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(lblResultado.Text);
            operacao = "Multiplicação";
            lblResultado.Text = "";
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(lblResultado.Text);
            operacao = "Divisão";
            lblResultado.Text = "";
        }

        private void butIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "Mais")
            {
                float resultado = valor1 + Convert.ToSingle(lblResultado.Text);
                lblResultado.Text = resultado.ToString();
            }

            if (this.operacao =="Menos")
            {
                float resultado = valor1 - Convert.ToSingle(lblResultado.Text);
                lblResultado.Text = resultado.ToString();   
            }

            if (this.operacao == "Multiplicação")
            {
                float resultado = valor1 * Convert.ToSingle(lblResultado.Text);
                lblResultado.Text = resultado.ToString();
            }

            if (this.operacao == "Divisão")
            {
                float resultado = valor1 / Convert.ToSingle(lblResultado.Text);
                lblResultado.Text = resultado.ToString();
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertendoCelcius newFrom = new ConvertendoCelcius();  
            newFrom.Show(); 
        }

        private void Progamando_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void polegadasParaCentimetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConvertendoCentimetros newFrom = new FrmConvertendoCentimetros();
            newFrom.Show();
        }
    }
}
