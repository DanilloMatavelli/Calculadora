namespace Calculadora
{
    partial class FrmConvertendoCentimetros
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCentimetros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPolegadas = new System.Windows.Forms.Label();
            this.btnConversao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centímetros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCentimetros
            // 
            this.txtCentimetros.Location = new System.Drawing.Point(25, 64);
            this.txtCentimetros.Multiline = true;
            this.txtCentimetros.Name = "txtCentimetros";
            this.txtCentimetros.Size = new System.Drawing.Size(140, 34);
            this.txtCentimetros.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Polegadas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPolegadas
            // 
            this.lblPolegadas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPolegadas.Location = new System.Drawing.Point(25, 135);
            this.lblPolegadas.Name = "lblPolegadas";
            this.lblPolegadas.Size = new System.Drawing.Size(140, 34);
            this.lblPolegadas.TabIndex = 3;
            this.lblPolegadas.UseMnemonic = false;
            this.lblPolegadas.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConversao
            // 
            this.btnConversao.Location = new System.Drawing.Point(210, 92);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(100, 43);
            this.btnConversao.TabIndex = 4;
            this.btnConversao.Text = "Converter";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // FrmConvertendoCentimetros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 266);
            this.Controls.Add(this.btnConversao);
            this.Controls.Add(this.lblPolegadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCentimetros);
            this.Controls.Add(this.label1);
            this.Name = "FrmConvertendoCentimetros";
            this.Text = "FrmConvertendoCentimetros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentimetros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPolegadas;
        private System.Windows.Forms.Button btnConversao;
    }
}