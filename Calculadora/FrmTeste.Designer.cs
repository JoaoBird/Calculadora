namespace Calculadora
{
    partial class FrmTeste
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
            this.components = new System.ComponentModel.Container();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Valor1 = new System.Windows.Forms.TextBox();
            this.txtBox_Valor2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(112, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2:";
            // 
            // txtBox_Valor1
            // 
            this.txtBox_Valor1.Location = new System.Drawing.Point(112, 39);
            this.txtBox_Valor1.Name = "txtBox_Valor1";
            this.txtBox_Valor1.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Valor1.TabIndex = 3;
            this.txtBox_Valor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Valor1_KeyPress);
            this.txtBox_Valor1.MouseHover += new System.EventHandler(this.txtBox_Valor1_MouseHover);
            // 
            // txtBox_Valor2
            // 
            this.txtBox_Valor2.Location = new System.Drawing.Point(112, 76);
            this.txtBox_Valor2.Name = "txtBox_Valor2";
            this.txtBox_Valor2.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Valor2.TabIndex = 4;
            this.txtBox_Valor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Valor2_KeyPress);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(54, 214);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Divisão",
            "Multiplicação",
            "Exponenciação",
            "Raiz"});
            this.comboBox1.Location = new System.Drawing.Point(112, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // FrmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtBox_Valor2);
            this.Controls.Add(this.txtBox_Valor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeste";
            this.Load += new System.EventHandler(this.FrmTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Valor1;
        private System.Windows.Forms.TextBox txtBox_Valor2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}