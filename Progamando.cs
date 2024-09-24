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
    public partial class Progamando : Form
    {
        public Progamando()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Captura o botão que foi clicado
            txtResultado.Text += btn.Text; // Adiciona o texto do botão ao TextBox
        }
    }
}
