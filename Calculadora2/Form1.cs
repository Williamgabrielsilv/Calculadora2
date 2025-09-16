namespace Calculadora2
{
    public partial class Form1 : Form
    {
        private readonly IDataTableWrapper _dtWrapper;
        public Form1(IDataTableWrapper dtWrapper)
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.Shown += Form1_Shown;
            this.KeyPress += Form1_KeyPress;
            this.KeyDown += Form1_KeyDown;

            _dtWrapper = dtWrapper;
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            txtResultado.Focus();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (char.IsDigit(tecla) || "+-*/.,".Contains(tecla))
            {
                // Para garantir que só tem uma vírgula por número, você pode melhorar depois
                if (txtResultado.Text.Contains(Environment.NewLine))
                {
                    var linhas = txtResultado.Text
                        .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    txtResultado.Text = linhas.Length > 1 ? linhas[^1] : "";
                }

                txtResultado.Text += tecla;
                txtResultado.SelectionStart = txtResultado.Text.Length;
                txtResultado.SelectionLength = 0;
                e.Handled = true;
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIgual.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                //btnApagar.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCE.PerformClick();
                e.Handled = true;

            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            var totalLines = txtResultado.Lines.Length;
            if (totalLines > 1)
                txtResultado.Lines = [.. txtResultado.Lines.Skip(totalLines - 1)];

            Button senderEv = (Button)sender;
            txtResultado.Text += senderEv.Text;
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.SelectionLength = 0;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text)) // verifica se tem algum caracter
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);

                // Move o cursor para o final do texto atualizado
                txtResultado.SelectionStart = txtResultado.Text.Length;
                txtResultado.SelectionLength = 0;
            }
        }


        private void btnCE_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expressao = txtResultado.Text.Replace(',', '.'); // troca vírgula por ponto

                var resultado = _dtWrapper.ComputeExpression(expressao);

                txtResultado.Text = txtResultado.Text + Environment.NewLine + resultado;
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

    }
}

