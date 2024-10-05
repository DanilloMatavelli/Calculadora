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
    public partial class FrmConvertendoCentimetros : Form
    {
        public FrmConvertendoCentimetros()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            //Criar a variavel
            double Centimetros;
            // Converter para int o campo desejado
            Centimetros = Convert.ToInt32(txtCentimetros.Text);
            //Calculo para converter
            Centimetros = Centimetros / 2.54;
            //Para mostrar o resultado do calculado no label
            lblPolegadas.Text = Convert.ToString(Centimetros);
        }
    }
}
