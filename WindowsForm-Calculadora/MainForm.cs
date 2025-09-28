using System.Globalization;

namespace WindowsForm_Calculadora
{
    public partial class MainForm : Form
    {
        private double primeiroOperando = 0;
        private string operacaoAtual = null;
        private bool resetarVisor = false;

        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisorCalc.Text = "0";
            primeiroOperando = 0;
            operacaoAtual = null;
            resetarVisor = false;
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVisorCalc.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double v))
            {
                v = -v;
                txtVisorCalc.Text = v.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVisorCalc.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double v))
            {
                if (v < 0)
                {
                    MessageBox.Show("Raiz quadrada de número negativo não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                v = Math.Sqrt(v);
                txtVisorCalc.Text = v.ToString(CultureInfo.CurrentCulture);
                resetarVisor = true;
                operacaoAtual = null;
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            var botao = sender as Button;
            if (botao == null) return;
            string digito = botao.Text;

            if (resetarVisor || txtVisorCalc.Text == "0")
            {
                txtVisorCalc.Text = digito;
                resetarVisor = false;
            }
            else
            {
                txtVisorCalc.Text += digito;
            }
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            var botao = sender as Button;
            if (botao == null) return;
            string texto = botao.Text;

            string op = texto switch
            {
                "×" => "*",
                "÷" => "/",
                "x^y" => "^",
                _ => texto
            };

            if (double.TryParse(txtVisorCalc.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double v))
            {
                primeiroOperando = v;
                operacaoAtual = op;
                resetarVisor = true;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            var separador = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (!txtVisorCalc.Text.Contains(separador))
            {
                txtVisorCalc.Text += separador;
                resetarVisor = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacaoAtual == null) return;

            if (!double.TryParse(txtVisorCalc.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double segundoOperando))
            {
                MessageBox.Show("Operando inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = 0;
            bool erro = false;

            try
            {
                switch (operacaoAtual)
                {
                    case "+":
                        resultado = primeiroOperando + segundoOperando;
                        break;
                    case "-":
                        resultado = primeiroOperando - segundoOperando;
                        break;
                    case "*":
                        resultado = primeiroOperando * segundoOperando;
                        break;
                    case "/":
                        if (Math.Abs(segundoOperando) < double.Epsilon)
                        {
                            MessageBox.Show("Divisão por zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            erro = true;
                        }
                        else resultado = primeiroOperando / segundoOperando;
                        break;
                    case "^":
                        resultado = Math.Pow(primeiroOperando, segundoOperando);
                        break;
                    default:
                        erro = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = true;
            }

            if (!erro)
            {
                txtVisorCalc.Text = resultado.ToString(CultureInfo.CurrentCulture);
                primeiroOperando = resultado;
                resetarVisor = true;
                operacaoAtual = null;
            }
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            // números
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift)
            {
                string d = (e.KeyCode - Keys.D0).ToString();
                SimularCliqueNumero(d);
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                string d = (e.KeyCode - Keys.NumPad0).ToString();
                SimularCliqueNumero(d);
            }
            else if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                btnVirgula_Click(btnVirgula, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Add)
                btnOperador_Click(btnSomar, EventArgs.Empty);
            else if (e.KeyCode == Keys.Subtract)
                btnOperador_Click(btnSubtrair, EventArgs.Empty);
            else if (e.KeyCode == Keys.Multiply)
                btnOperador_Click(btnMultiplicar, EventArgs.Empty);
            else if (e.KeyCode == Keys.Divide)
                btnOperador_Click(btnDividir, EventArgs.Empty);
            else if (e.KeyCode == Keys.Enter)
                btnIgual_Click(btnIgual, EventArgs.Empty);
            else if (e.KeyCode == Keys.Escape)
                btnLimpar_Click(btnLimpar, EventArgs.Empty);
        }

        // método auxiliar para reaproveitar lógica de clique de número via teclado
        private void SimularCliqueNumero(string digito)
        {
            if (resetarVisor || txtVisorCalc.Text == "0")
            {
                txtVisorCalc.Text = digito;
                resetarVisor = false;
            }
            else
            {
                txtVisorCalc.Text += digito;
            }
        }

        // abre o menu
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog(this);
        }
    }
}
