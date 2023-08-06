using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        int quantidade = 0;
        int dentro = 0;
        int fora = 0;
        bool validacaoQuantidade = false;
        bool validacaoValor = false;

        // Validação da Quantidade

        do
        {
            try
            {
                Write("Digite uma quantidade de valores a serem digitados: ");
                quantidade = int.Parse(Console.ReadLine());
                WriteLine();
                validacaoQuantidade = true;
            }
            catch (Exception ex)
            {
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                WriteLine(ex.Message);
                WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
            }
        }
        while (!validacaoQuantidade);

        // Criação do Vetor para receber os valores

        int[] valores = new int[quantidade];

        // Input e Validação dos Valores

        for (int i = 0; i < valores.Length; i++)
        {
            do
            {
                validacaoValor = false;

                try
                {
                    Write($"Valor {i + 1 }: ");
                    valores[i] = int.Parse(Console.ReadLine());
                    validacaoValor = true;
                }
                catch (Exception ex)
                {
                    WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                    WriteLine(ex.Message);
                    WriteLine($"{Environment.NewLine} -------------------------- {Environment.NewLine}");
                }
            }
            while (!validacaoValor);
        }

        // Verificando se estão dentro do intervalo [10, 20]

        for (int i = 0;i < valores.Length;i++)
        {
            if (valores[i] >= 10 && valores[i] <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }

        // Resultado

        WriteLine(" ");
        WriteLine($"{dentro}  in");
        WriteLine($"{fora} out");

        ReadKey();
    }
}