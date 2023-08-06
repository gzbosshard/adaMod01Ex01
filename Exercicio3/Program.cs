using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        int estoqueAtual = 0;
        int estoqueMax = 0;
        int estoqueMin = 0;
        int estoqueMedio = 0;
        bool validacaoAtual = false;
        bool validacaoMax = false;
        bool validacaoMin = false;

        WriteLine($"\u001b[36m{Environment.NewLine}-------- ESTOQUE --------\u001b[0m{Environment.NewLine}");

        // Input e Validação do Estoque Atual
        do
        {
            try
            {
                Write("Estoque Atual: ");
                estoqueAtual = int.Parse(Console.ReadLine());
                validacaoAtual = true;
            }
            catch (Exception ex)
            {
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                WriteLine(ex.Message);
                WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
            }
        }
        while (!validacaoAtual);

        // Input e Validação do Estoque Máximo
        do
        {
            try
            {
                Write("Estoque Máximo: ");
                estoqueMax = int.Parse(Console.ReadLine());
                validacaoMax = true;
            }
            catch (Exception ex)
            {
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                WriteLine(ex.Message);
                WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
            }
        }
        while (!validacaoMax);

        // Input e Validação do Estoque Mínimo
        do
        {
            try
            {
                Write("Estoque Mínimo: ");
                estoqueMin = int.Parse(Console.ReadLine());
                validacaoMin = true;
            }
            catch (Exception ex)
            {
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                WriteLine(ex.Message);
                WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
            }
        }
        while (!validacaoMin);


        // Cálculo do Estoque Médio

        estoqueMedio = (estoqueMax + estoqueMin) / 2;


        // Conferência do Estoque

        if (estoqueAtual > estoqueMedio)
        {
            WriteLine($"{Environment.NewLine}--------------------------------------");
            WriteLine($"{Environment.NewLine}Quantidade Média: {estoqueMedio}.{Environment.NewLine}Não efetuar compra");
        }
        else
        {
            WriteLine($"{Environment.NewLine}--------------------------------------");
            WriteLine($"{Environment.NewLine}Quantidade Média: {estoqueMedio}");
            WriteLine($"\u001b[31mEfetuar compra\u001b[0m");
        }

        ReadKey();



    }





}
