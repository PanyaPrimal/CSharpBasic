using System.Text;

internal class Program
{

    private static void Main(string[] args)
    { 
        Console.OutputEncoding = Encoding.UTF8;

        const int minNumber = 0;
        const int maxNumber = 10;

        Console.Write($"Введіть номер дня тижня: ");

        int userDayNumberInput = Convert.ToInt32(Console.ReadLine());

        switch (userDayNumberInput)
        {
            case 1:
                Console.WriteLine("Понеділок");
                break;
            case 2:
                Console.WriteLine("Вівторок");
                break;
            case 3:
                Console.WriteLine("Середа");
                break;
            case 4:
                Console.WriteLine("Четвер");
                break;
            case 5:
                Console.WriteLine("П'ятниця");
                break;
            case 6:
                Console.WriteLine("Субота");
                break;
            case 7:
                Console.WriteLine("Неділя");
                break;
            default:
                Console.WriteLine($"Введене число не відповідає дню тижня. Введіть число від {minNumber} до {maxNumber}.");
                break;
        }
    }
}