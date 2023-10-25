namespace AppRever.view
{
    partial class TelaForm
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
            lbl_Sistemavalor = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bnt_Calcular = new Button();
            text_valor3 = new TextBox();
            text_valor2 = new TextBox();
            text_valor1 = new TextBox();
            bnt_Limpar = new Button();
            lbl_Resultado = new Label();
            SuspendLayout();
            // 
            // lbl_Sistemavalor
            // 
            lbl_Sistemavalor.AutoSize = true;
            lbl_Sistemavalor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Sistemavalor.Location = new Point(95, 21);
            lbl_Sistemavalor.Name = "lbl_Sistemavalor";
            lbl_Sistemavalor.Size = new Size(278, 32);
            lbl_Sistemavalor.TabIndex = 0;
            lbl_Sistemavalor.Text = "Sistema de Maior Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Primeiro Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 2;
            label3.Text = "Segundo Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 3;
            label4.Text = "Terceiro Valor";
            // 
            // bnt_Calcular
            // 
            bnt_Calcular.Location = new Point(129, 222);
            bnt_Calcular.Name = "bnt_Calcular";
            bnt_Calcular.Size = new Size(211, 37);
            bnt_Calcular.TabIndex = 4;
            bnt_Calcular.Text = "Calcular";
            bnt_Calcular.UseVisualStyleBackColor = true;
            bnt_Calcular.Click += bnt_Calcular_Click;
            // 
            // text_valor3
            // 
            text_valor3.Location = new Point(175, 175);
            text_valor3.Name = "text_valor3";
            text_valor3.Size = new Size(263, 23);
            text_valor3.TabIndex = 6;
            // 
            // text_valor2
            // 
            text_valor2.Location = new Point(175, 137);
            text_valor2.Name = "text_valor2";
            text_valor2.Size = new Size(263, 23);
            text_valor2.TabIndex = 7;
            // 
            // text_valor1
            // 
            text_valor1.Location = new Point(175, 95);
            text_valor1.Name = "text_valor1";
            text_valor1.Size = new Size(263, 23);
            text_valor1.TabIndex = 8;
            // 
            // bnt_Limpar
            // 
            bnt_Limpar.Location = new Point(129, 276);
            bnt_Limpar.Name = "bnt_Limpar";
            bnt_Limpar.Size = new Size(211, 37);
            bnt_Limpar.TabIndex = 10;
            bnt_Limpar.Text = "Limpar";
            bnt_Limpar.UseVisualStyleBackColor = true;
            bnt_Limpar.Click += bnt_Limpar_Click;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = SystemColors.ActiveCaption;
            lbl_Resultado.Location = new Point(95, 350);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(264, 125);
            lbl_Resultado.TabIndex = 11;
            lbl_Resultado.Click += lbl_Resultado_Click;
            // 
            // TelaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(483, 520);
            Controls.Add(lbl_Resultado);
            Controls.Add(bnt_Limpar);
            Controls.Add(text_valor1);
            Controls.Add(text_valor2);
            Controls.Add(text_valor3);
            Controls.Add(bnt_Calcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_Sistemavalor);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema De Valor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Sistemavalor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bnt_Calcular;
        private TextBox text_valor3;
        private TextBox text_valor2;
        private TextBox text_valor1;
        private Button bnt_Limpar;
        private Label lbl_Resultado;
    }
}