public class Program
{
    public static void Main(string[] args)
    {
        /*
         exercicio 1 e 2
         Console.WriteLine("Digite seu nome: ");
         var nome = Console.ReadLine();

         Console.WriteLine("Digite seu sobrenome: ");
         var sobrenome = Console.ReadLine();

         Console.WriteLine($"olá, {nome}! Seja muito bem-vindo!/n");

         Console.WriteLine($"seu nome é {nome} {sobrenome}");
         */


        /* double value1 = 10;

        double value2 = 20;

        Console.WriteLine("Enter your choice (1-5): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {

            case 1:
                Console.WriteLine(value1 + value2);
                break;
            case 2:
                Console.WriteLine(value1 - value2);
                break;
            case 3:
                Console.WriteLine(value1 * value2);
                break;
            case 4:
                if (value2 == 0)
                {
                    break;
                }
                Console.WriteLine(value1 / value2);
                break;
            case 5:
                Console.WriteLine((value1 + value2) / 2);
                break;
        }
         exercicio 3*/

        /* var message = Console.ReadLine();
         int count = 0;

         foreach (var items in message)
         {
             if (char.IsWhiteSpace(items))
             {
                 count--;
             }
             count++;
         }
         Console.WriteLine(count);
         exercicio 4*/

        /*Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine().Trim();

        bool placaValida = VerificarPlaca(placa);

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
         exercicio5*/
        
        //ex 5
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha uma das opções para exibir a data/hora atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine(dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;
            case "2":
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(dataAtual.ToString("HH:mm:ss"));
                break;
            case "4":
                Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    /*static bool VerificarPlaca(string placa)
    {
        if (placa.Length != 7)
            return false;

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
                return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
                return false;
        }

        return true;
    }
    */
}