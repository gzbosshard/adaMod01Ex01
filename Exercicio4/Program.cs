using System.Runtime.ExceptionServices;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] cem = new int[100];
        Random randNum = new Random();
        int max = 0;
        int min = 1001;
        int posicaoMax = 0;
        int posicaoMin = 0;

        // preenchendo o vetor

        for (int i = 0; i < cem.Length; i++)
        {
            cem[i] = randNum.Next(1000);
        }



        // identificando os valores máximo e mínimo

        for (int i = 0; i < cem.Length; i++)
        {
            if (cem[i] > max)
            {
                max = cem[i];
                posicaoMax = i;
            }
            else if (cem[i] < min)
            {
                min = cem[i];
                posicaoMin = i;
            }
        }

        // Imprimindo Vetor

        Write($"\u001b[36mVetor:\u001b[0m{Environment.NewLine}{Environment.NewLine}[");
        for (int i = 0; i < cem.Length - 1; i++)
        {
            if (cem[i] == max || cem[i] == min)
            {
                Write($"\u001b[36m{cem[i]}\u001b[0m, ");
            }
            else
            {
                Write($"{cem[i]}, ");
            }

        }

        if (cem[cem.Length - 1] == max || cem[cem.Length - 1] == min)
        {
            Write($"\u001b[36m{cem[cem.Length - 1]}\u001b[0m]{Environment.NewLine}");
        }
        else
        {
            Write($"{cem[cem.Length - 1]}]{Environment.NewLine}");
        }


        // Imprimindo Destaques

        WriteLine($"\u001b[36m{Environment.NewLine}-------- DESTAQUES DO VETOR --------\u001b[0m{Environment.NewLine}");

        WriteLine($"Valor máximo: {max}");
        WriteLine($"Posição do valor máximo: {posicaoMax}{Environment.NewLine}");
        WriteLine($"Valor mínimo: {min}");
        WriteLine($"Posição do valor mínimo: {posicaoMin}{Environment.NewLine}");

        ReadKey();

    }
}