using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {

        bool validacao = false;
        string selecao;
        int valorSelecionado;
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;


        do
        {
            WriteLine($"\u001b[36m{Environment.NewLine}-------- PESQUISA DE PREFERÊNCIA --------\u001b[0m{Environment.NewLine}");

            WriteLine($"Selecione o combustível de preferência{Environment.NewLine}");

            WriteLine("1. Álcool");
            WriteLine("2. Gasolina");
            WriteLine("3. Díesel");
            WriteLine("4. fim");
            WriteLine();

            /*valorSelecionado = ;*/

            if (int.TryParse(ReadLine(), out valorSelecionado) && valorSelecionado > 0 && valorSelecionado < 5)
            {
                validacao = true;
                WriteLine("");
                Clear();


                switch (valorSelecionado)
                {
                    case 1:
                        alcool += 1;
                        WriteLine($"Registramos sua escolha: álcool{Environment.NewLine}");
                        break;
                    case 2:
                        gasolina += 1;
                        WriteLine($"Registramos sua escolha: gasolina{Environment.NewLine}");
                        break;
                    case 3:
                        diesel += 1;
                        WriteLine($"Registramos sua escolha: diesel{Environment.NewLine}");
                        break;
                    case 4:
                        WriteLine($"\u001b[36m{Environment.NewLine}-------- RESULTADO PESQUISA DE PREFERÊNCIA --------\u001b[0m{Environment.NewLine}");
                        WriteLine("MUITO OBRIGADO!");
                        WriteLine($"Alcool: {alcool}");
                        WriteLine($"Gasolina: {gasolina}");
                        WriteLine($"Diesel: {diesel}");
                        break;
                    default:
                        WriteLine("Valor Invalido");
                        break;
                }
            }
            else
            {
                Clear();
                WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
            }

        }
        while (!validacao || valorSelecionado != 4);


        ReadKey();


    }
}