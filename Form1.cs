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
    public partial class Form1 : Form

    {
        public Form1()

        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timerCarregamento_Tick(object sender, EventArgs e)
        {
            progressCarregamento.Value = progressCarregamento.Value + 10;

            if (progressCarregamento.Value == 100)
            {
                timerCarregamento.Stop();
                Progamando newForm = new Progamando();
                newForm.Show();
                this.Hide();
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
