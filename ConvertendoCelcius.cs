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
    public partial class ConvertendoCelcius : Form
    {
        public ConvertendoCelcius()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //Criar a variavel
            double Graus;
            // Converter para int o campo desejado
            Graus = Convert.ToInt32(textGraus.Text);
            //Calculo para converter
            Graus = Graus * 1.8 + 32;
            //Para mostrar o resultado do calculado no label
            llbResultadoConversao.Text = Convert.ToString(Graus);





        }
    }
}
