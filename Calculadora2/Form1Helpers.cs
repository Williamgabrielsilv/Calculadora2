namespace Calculadora2
{
    internal static class Form1Helpers
    {
        private static bool ContemDivisaoPorZero(string expressao)
        {
            expressao = expressao.Replace(" ", "");

            // Procura por divisões por zero explícitas
            for (int i = 0; i < expressao.Length - 1; i++)
            {
                if (expressao[i] == '/')
                {
                    string numero = "";
                    int j = i + 1;

                    while (j < expressao.Length && (char.IsDigit(expressao[j]) || expressao[j] == '.'))
                    {
                        numero += expressao[j];
                        j++;
                    }

                    if (double.TryParse(numero, out double valor))
                    {
                        if (valor == 0.0)
                            return true;
                    }
                }
            }

            return false;
        }
    }
}