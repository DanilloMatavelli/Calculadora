namespace Calculadora
{
    partial class ConvertendoCelcius
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.llbResultadoConversao = new System.Windows.Forms.Label();
            this.textGraus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coloque a temperatura";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(260, 38);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(103, 46);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Converter";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // llbResultadoConversao
            // 
            this.llbResultadoConversao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.llbResultadoConversao.Location = new System.Drawing.Point(123, 131);
            this.llbResultadoConversao.Name = "llbResultadoConversao";
            this.llbResultadoConversao.Size = new System.Drawing.Size(193, 46);
            this.llbResultadoConversao.TabIndex = 4;
            // 
            // textGraus
            // 
            this.textGraus.Location = new System.Drawing.Point(12, 38);
            this.textGraus.Multiline = true;
            this.textGraus.Name = "textGraus";
            this.textGraus.Size = new System.Drawing.Size(222, 46);
            this.textGraus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(155, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Converter em Fahrenheit";
            // 
            // ConvertendoCelcius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textGraus);
            this.Controls.Add(this.llbResultadoConversao);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label2);
            this.Name = "ConvertendoCelcius";
            this.Text = "ConvertendoCelcius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label llbResultadoConversao;
        private System.Windows.Forms.TextBox textGraus;
        private System.Windows.Forms.Label label3;
    }
}