using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        double horasTrabalhadas = 0;
        double salario = 0;
        double horasExtras = 0;
        double salarioMes = 0;
        double salarioHorasExtras = 0;
        bool validacaoHorasTrabalhadas = false;
        bool validacaoSalario = false;

        WriteLine($"\u001b[36m{Environment.NewLine}-------- CÁLCULO DE HORAS EXTRAS --------\u001b[0m{Environment.NewLine}");

        // Input e Validação das Horas trabalhadas

        do
        {
            try
            {
                Write("Horas trabalhadas no mês: ");
                horasTrabalhadas = double.Parse(Console.ReadLine());
                validacaoHorasTrabalhadas = true;
            }
            catch (Exception ex)
            {
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                WriteLine(ex.Message);
                WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
            }
        }
        while (!validacaoHorasTrabalhadas);

        // Input e Validação do Valor da Hora de Trabalho

        do
        {
            try
            {
                Write("Salário por hora: R$ ");
                salario = double.Parse(Console.ReadLine());
                validacaoSalario = true;
            }
            catch (Exception ex)
            {
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                WriteLine(ex.Message);
                WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
            }
        }
        while (!validacaoSalario);

        // Cálculo da Hora Extra

        if (horasTrabalhadas > 160)
        {
            horasExtras = horasTrabalhadas - 160;
            salarioHorasExtras = horasExtras * salario * 1.5;
            salarioMes = (salario * 160) + (salarioHorasExtras);
        }
        else
        {
            salarioMes = salario * horasTrabalhadas;
        }

        WriteLine($"\u001b[36m{Environment.NewLine}-------- SALÁRIO MENSAL --------{Environment.NewLine}\u001b[0m");
        WriteLine($"Horas trabalhadas no mês: {horasTrabalhadas} horas");
        WriteLine($"Horas extras: {horasExtras} horas");
        WriteLine($"Valor recebido por horas extras: R$ {salarioHorasExtras.ToString("F2")}");
        WriteLine($"Valor total recebido: R$ {salarioMes.ToString("F2")}");


        ReadKey();
    }
}