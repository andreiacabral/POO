namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_btn_Click(object sender, EventArgs e)
        {
            bool alturaValida = ValidaEntrada(Altura_textBox.Text, "ALTURA");
            bool pesoValido = ValidaEntrada(Peso_textBox.Text, "PESO");

            if (alturaValida && pesoValido)
            {
                double altura = Convert.ToDouble(Altura_textBox.Text);
                double peso = Convert.ToDouble(Peso_textBox.Text);

                double resultado = (peso / (altura * altura));

                if (resultado < 17)
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \nMuito abaixo do peso";
                }
                else if (resultado >= 17 && resultado <= 18.49)
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \nAbaixo do peso";
                }
                else if (resultado >= 18.50 && resultado <= 24.99)
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \nPeso normal";
                }
                else if (resultado >= 25 && resultado <= 29.99)
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \nAcima do peso";
                }
                else if (resultado >= 30 && resultado <= 34.99)
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \n	Obesidade I";
                } 
                else if (resultado >= 35 && resultado <= 39.99)
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \n	Obesidade II";
                }
                else
                {
                    Resultado_lbl.Text = $"Indice IMC:{resultado.ToString("F2")} \n	Obesidade III";
                }
            }
        }

        private bool ValidaEntrada(string entrada, string nomeEntrada)
        {
            bool error = false;
            string mensagem = "";
            List<string> listaErros = new List<string>();
            double isValid;
            double.TryParse(entrada, out isValid);

            if (isValid == 0)
            {
                listaErros.Add($"Insira um valor valido para {nomeEntrada}!");
                error = true;
            }

            double number = Convert.ToDouble(entrada);
            if (number == 0)
            {
                listaErros.Add($"Insira um valor diferente de 0 para {nomeEntrada}!");
                error = true;
            }

            if (error)
            {
                foreach (var item in listaErros)
                {
                    mensagem += item.ToString() + "\n";
                }
                MessageBox.Show(mensagem, "Error");
                return false;
            }
            return true;
        }
    }
}