namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfirma = new Button();
            txtNumero1 = new TextBox();
            resultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero2 = new TextBox();
            valor1 = new Label();
            valor2 = new Label();
            operacao = new Label();
            SuspendLayout();
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(491, 126);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 0;
            btnConfirma.Text = "Confirma\r\n";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += button1_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(279, 126);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            txtNumero1.TextChanged += TxtNumero1_TextChanged;
            // 
            // resultado
            // 
            resultado.FormattingEnabled = true;
            resultado.ItemHeight = 15;
            resultado.Location = new Point(152, 170);
            resultado.Name = "resultado";
            resultado.Size = new Size(170, 244);
            resultado.TabIndex = 3;
            // 
            // cmbOperacao
            // 
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiação", "Logaritmos" });
            cmbOperacao.Location = new Point(152, 127);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 4;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(385, 126);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 5;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // valor1
            // 
            valor1.AutoSize = true;
            valor1.Location = new Point(279, 108);
            valor1.Name = "valor1";
            valor1.Size = new Size(62, 15);
            valor1.TabIndex = 6;
            valor1.Text = "1°Número";
            // 
            // valor2
            // 
            valor2.AutoSize = true;
            valor2.Location = new Point(385, 108);
            valor2.Name = "valor2";
            valor2.Size = new Size(65, 15);
            valor2.TabIndex = 7;
            valor2.Text = "2° Número";
            // 
            // operacao
            // 
            operacao.AutoSize = true;
            operacao.Location = new Point(152, 108);
            operacao.Name = "operacao";
            operacao.Size = new Size(58, 15);
            operacao.TabIndex = 8;
            operacao.Text = "Operação";
            operacao.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 619);
            Controls.Add(cmbOperacao);
            Controls.Add(operacao);
            Controls.Add(valor2);
            Controls.Add(valor1);
            Controls.Add(txtNumero2);
            Controls.Add(resultado);
            Controls.Add(txtNumero1);
            Controls.Add(btnConfirma);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnConfirma;
        private TextBox txtNumero1;
        private ListBox resultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero2;
        private Label valor1;
        private Label valor2;
        private Label operacao;
    }
}
