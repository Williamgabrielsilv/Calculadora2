
using System.Data;
using System;
namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Shown += Form1_Shown;
        }



        private void Form1_Shown(object sender, EventArgs e)
        {
            txtResultado.Focus();
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (char.IsDigit(tecla) || "+-*/.".Contains(tecla))
            {
                txtResultado.Text += tecla;
            
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIgual.PerformClick(); // Simula o clique do botão igual
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnApagar.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCE.PerformClick();
                e.Handled = true;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "+";
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "-";
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "*";
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "/";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text)) //verifica se tem algum caracter 
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            /*if (txtResultado,Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
            }*/
        }

        private void btnCE_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expressao = txtResultado.Text;

                // Verifica se há tentativa de divisão por zero
                if (ContemDivisaoPorZero(expressao))
                {
                    throw new DivideByZeroException("Divisão por zero não é permitida.");
                }

                var resultado = new DataTable().Compute(expressao, null);
                txtResultado.Text = resultado.ToString();

                // Posiciona o cursor no fim
                txtResultado.SelectionStart = txtResultado.Text.Length;
                txtResultado.SelectionLength = 0;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Você não pode dividir por zero!", "Erro de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResultado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Expressão inválida!\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
        }
        private bool ContemDivisaoPorZero(string expressao)
        {
            // Remove espaços para facilitar a análise
            expressao = expressao.Replace(" ", "");

            // Verifica se há "/0" ou "/0." (ex: 1/0, 1/0.0)
            return expressao.Contains("/0") || expressao.Contains("/0.");



        }
}
}
