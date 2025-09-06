using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        while (true) { 
            Console.Write("Введіть перше число, aбо q для виходу: ");
            string input = Console.ReadLine();

            if(input.ToLower() == "q") {
                Console.WriteLine("Програма завершена.");
                break;
            }

            if (!double.TryParse(input, out double firstValue)) {
                Console.WriteLine("Помилка: Введіть коректне число.");
                continue;
            }


            Console.Write("Введіть друге число: ");
            if (!double.TryParse(Console.ReadLine(), out double secondValue)) {
                Console.WriteLine("Помилка: Введіть коректне число.");
                continue;
            }

            Console.Write("Введіть оператор (+, -, *, /): ");
            string operatorInput = Console.ReadLine();

            switch (operatorInput)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue != 0)
                        Console.WriteLine(firstValue / secondValue);
                    else
                        Console.WriteLine("Помилка: Хіба можна ділити на нуль?!");
                    break;
                default:
                    Console.WriteLine("Щось пішло не так.");
                    break;
            }

            Console.Write("Хочете продовжити? (y/n): ");
            if (Console.ReadLine().ToLower() != "y") {
                Console.WriteLine("Програма завершена.");
                break;
            }
        }
    }
}