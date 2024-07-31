namespace Calculadora
{
    partial class frmCalculadora
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
            txtOperadorA = new TextBox();
            txtOperadorB = new TextBox();
            lbrOperadorA = new Label();
            lbrOperadorB = new Label();
            btnCalcular = new Button();
            txtEspressao = new TextBox();
            txtResultado = new TextBox();
            lbrExpressao = new Label();
            lbrResultado = new Label();
            btnSair = new Button();
            rdbAdicao = new RadioButton();
            rdbSubtracacao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            rdbResto = new RadioButton();
            SuspendLayout();
            // 
            // txtOperadorA
            // 
            txtOperadorA.Location = new Point(130, 50);
            txtOperadorA.Name = "txtOperadorA";
            txtOperadorA.Size = new Size(100, 23);
            txtOperadorA.TabIndex = 0;
            // 
            // txtOperadorB
            // 
            txtOperadorB.Location = new Point(329, 50);
            txtOperadorB.Name = "txtOperadorB";
            txtOperadorB.Size = new Size(100, 23);
            txtOperadorB.TabIndex = 1;
            // 
            // lbrOperadorA
            // 
            lbrOperadorA.AutoSize = true;
            lbrOperadorA.Location = new Point(130, 32);
            lbrOperadorA.Name = "lbrOperadorA";
            lbrOperadorA.Size = new Size(68, 15);
            lbrOperadorA.TabIndex = 2;
            lbrOperadorA.Text = "Operador A";
            // 
            // lbrOperadorB
            // 
            lbrOperadorB.AutoSize = true;
            lbrOperadorB.Location = new Point(329, 32);
            lbrOperadorB.Name = "lbrOperadorB";
            lbrOperadorB.Size = new Size(67, 15);
            lbrOperadorB.TabIndex = 3;
            lbrOperadorB.Text = "Operador B";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(236, 248);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtEspressao
            // 
            txtEspressao.Location = new Point(236, 324);
            txtEspressao.Name = "txtEspressao";
            txtEspressao.Size = new Size(100, 23);
            txtEspressao.TabIndex = 10;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(236, 367);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 11;
            // 
            // lbrExpressao
            // 
            lbrExpressao.AutoSize = true;
            lbrExpressao.Location = new Point(173, 324);
            lbrExpressao.Name = "lbrExpressao";
            lbrExpressao.Size = new Size(59, 15);
            lbrExpressao.TabIndex = 12;
            lbrExpressao.Text = "Expressaõ";
            // 
            // lbrResultado
            // 
            lbrResultado.AutoSize = true;
            lbrResultado.Location = new Point(171, 367);
            lbrResultado.Name = "lbrResultado";
            lbrResultado.Size = new Size(59, 15);
            lbrResultado.TabIndex = 13;
            lbrResultado.Text = "Resultado";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DarkGray;
            btnSair.Location = new Point(493, 407);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 14;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // rdbAdicao
            // 
            rdbAdicao.AutoSize = true;
            rdbAdicao.Location = new Point(236, 99);
            rdbAdicao.Name = "rdbAdicao";
            rdbAdicao.Size = new Size(62, 19);
            rdbAdicao.TabIndex = 15;
            rdbAdicao.TabStop = true;
            rdbAdicao.Text = "&Adição";
            rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracacao
            // 
            rdbSubtracacao.AutoSize = true;
            rdbSubtracacao.Location = new Point(236, 124);
            rdbSubtracacao.Name = "rdbSubtracacao";
            rdbSubtracacao.Size = new Size(78, 19);
            rdbSubtracacao.TabIndex = 16;
            rdbSubtracacao.TabStop = true;
            rdbSubtracacao.Text = "&Subtração";
            rdbSubtracacao.UseVisualStyleBackColor = true;
            rdbSubtracacao.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(236, 149);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(97, 19);
            rdbMultiplicacao.TabIndex = 17;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "&Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(236, 174);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 18;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "&Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbResto
            // 
            rdbResto.AutoSize = true;
            rdbResto.Location = new Point(236, 199);
            rdbResto.Name = "rdbResto";
            rdbResto.Size = new Size(54, 19);
            rdbResto.TabIndex = 19;
            rdbResto.TabStop = true;
            rdbResto.Text = "&Resto";
            rdbResto.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(654, 440);
            Controls.Add(rdbResto);
            Controls.Add(rdbDivisao);
            Controls.Add(rdbMultiplicacao);
            Controls.Add(rdbSubtracacao);
            Controls.Add(rdbAdicao);
            Controls.Add(btnSair);
            Controls.Add(lbrResultado);
            Controls.Add(lbrExpressao);
            Controls.Add(txtResultado);
            Controls.Add(txtEspressao);
            Controls.Add(btnCalcular);
            Controls.Add(lbrOperadorB);
            Controls.Add(lbrOperadorA);
            Controls.Add(txtOperadorB);
            Controls.Add(txtOperadorA);
            Name = "frmCalculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperadorA;
        private TextBox txtOperadorB;
        private Label lbrOperadorA;
        private Label lbrOperadorB;
        private Button btnCalcular;
        private TextBox txtEspressao;
        private TextBox txtResultado;
        private Label lbrExpressao;
        private Label lbrResultado;
        private Button btnSair;
        private RadioButton rdbAdicao;
        private RadioButton rdbSubtracacao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbDivisao;
        private RadioButton rdbResto;
    }
}