using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        bool validacao = false;
        double valorValidado, imposto, valorTotal;
        string valor;
        double faixa1 = 0;
        double faixa2 = 0;
        double faixa3 = 0;
        double faixa4 = 0;

        WriteLine($"\u001b[36m{Environment.NewLine}-------- CALCULADORA DE IMPOSTO --------\u001b[0m{Environment.NewLine}");
        WriteLine($"Para calcular o imposto, digite o valor a seguir: {Environment.NewLine}");


        do
        {
            Write("Valor: R$ ");
            valor = ReadLine();


            //validação do valor

            if (double.TryParse(valor, out valorValidado) && valorValidado >= 0.00)
            {
                validacao = true;
            }
            else
            {
                WriteLine("\u001b[31mVocê não digitou um número válido. Tente novamente!\n\u001b[0m");
            }
        }
        while (!validacao);

        // Separação das faixas

        if (valorValidado < 1200)
        {
            Console.WriteLine("Isento");
        }
        else if (valorValidado >= 1200.00 && valorValidado < 2500.00)
        {
            faixa1 = 1200.00;
            faixa2 = valorValidado - 1200.00;
        }
        else if (valorValidado >= 2500.00 && valorValidado < 5000.00)
        {
            faixa1 = 1200.00;
            faixa2 = 1300.00;
            faixa3 = valorValidado - 5000.00;
        }
        else
        {
            faixa1 = 1200.00;
            faixa2 = 1300.00;
            faixa3 = 2500.00;
            faixa4 = valorValidado - 5000.00;
        }

        // Calculo do Imposto

        imposto = faixa1 * 0 + faixa2 * 0.1 + faixa3 * 0.15 + faixa4 * 0.2;

        // Resposta

        WriteLine($"{Environment.NewLine}--------------------------------------{Environment.NewLine}");
        WriteLine($"Total de Impostos a pagar: \u001b[31mR$ {imposto.ToString("F2")}\u001b[0m");

        ReadKey();

    }
}