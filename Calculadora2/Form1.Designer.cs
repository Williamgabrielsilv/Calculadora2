namespace Calculadora2
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
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSoma = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicação = new Button();
            btnApagar = new Button();
            btnDivisão = new Button();
            txtResultado = new TextBox();
            btnPonto = new Button();
            btn0 = new Button();
            btnSubtração = new Button();
            btnCE = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 234);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 64);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(83, 234);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 64);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(154, 234);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 64);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 304);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 64);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(83, 304);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 64);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(154, 304);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 64);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(225, 304);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(65, 134);
            btnSoma.TabIndex = 7;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btn_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 164);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 64);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(83, 164);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 64);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(154, 164);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 64);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click;
            // 
            // btnMultiplicação
            // 
            btnMultiplicação.Location = new Point(225, 164);
            btnMultiplicação.Name = "btnMultiplicação";
            btnMultiplicação.Size = new Size(65, 64);
            btnMultiplicação.TabIndex = 11;
            btnMultiplicação.Text = "*";
            btnMultiplicação.UseVisualStyleBackColor = true;
            btnMultiplicação.Click += btn_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(154, 94);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(65, 64);
            btnApagar.TabIndex = 14;
            btnApagar.Text = "=>";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnDivisão
            // 
            btnDivisão.Location = new Point(225, 94);
            btnDivisão.Name = "btnDivisão";
            btnDivisão.Size = new Size(65, 64);
            btnDivisão.TabIndex = 15;
            btnDivisão.Text = "/";
            btnDivisão.UseVisualStyleBackColor = true;
            btnDivisão.Click += btn_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 12);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(278, 53);
            txtResultado.TabIndex = 23;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPonto
            // 
            btnPonto.Location = new Point(12, 374);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(65, 64);
            btnPonto.TabIndex = 17;
            btnPonto.Text = ",";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btn_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(83, 374);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 64);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn_Click;
            // 
            // btnSubtração
            // 
            btnSubtração.Location = new Point(225, 234);
            btnSubtração.Name = "btnSubtração";
            btnSubtração.Size = new Size(65, 64);
            btnSubtração.TabIndex = 20;
            btnSubtração.Text = "-";
            btnSubtração.UseVisualStyleBackColor = true;
            btnSubtração.Click += btn_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(12, 94);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(136, 64);
            btnCE.TabIndex = 21;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click_1;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(154, 373);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(65, 64);
            btnIgual.TabIndex = 22;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            btnIgual.KeyDown += Form1_KeyDown;
            // 
            // Form1
            // 
            AcceptButton = btnIgual;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 449);
            Controls.Add(btnIgual);
            Controls.Add(btnCE);
            Controls.Add(btnSubtração);
            Controls.Add(btn0);
            Controls.Add(btnPonto);
            Controls.Add(txtResultado);
            Controls.Add(btnDivisão);
            Controls.Add(btnApagar);
            Controls.Add(btnMultiplicação);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSoma);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSoma;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicação;
        private Button btnApagar;
        private Button btnDivisão;
        private TextBox txtResultado;
        private Button btnPonto;
        private Button btn0;
        private Button btnSubtração;
        private Button btnCE;
        private Button btnIgual;
    }
}
