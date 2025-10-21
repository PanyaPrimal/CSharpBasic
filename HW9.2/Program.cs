using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        StringBuilder report = new StringBuilder();

        Console.Write("Введіть заголовок звіту: ");
        string? title = Console.ReadLine();
        
        report.AppendLine(title?.ToUpper() ?? "ЗВІТ");
        report.AppendLine();

        report.AppendLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
        report.AppendLine();

        report.AppendLine("СПИСОК ПОДІЙ:");

        int eventNumber = 1;
        Console.WriteLine("\nВведіть події (для завершення введіть порожній рядок):");
        
        while (true)
        {
            Console.Write($"Подія #{eventNumber}: ");
            string? eventInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(eventInput))
            {
                break;
            }

            report.AppendLine($"{eventNumber}. {eventInput}");
            eventNumber++;
        }

        report.AppendLine("-".PadRight(50, '-'));
        report.AppendLine($"\nЗагальна кількість подій: {eventNumber - 1}");

        Console.WriteLine("\n\n*** ЗГЕНЕРОВАНИЙ ЗВІТ ***\n");
        Console.WriteLine(report.ToString());

        Console.WriteLine($"\nРозмір звіту: {report.Length} символів");
        Console.WriteLine($"Ємність StringBuilder: {report.Capacity} символів");
    }
}