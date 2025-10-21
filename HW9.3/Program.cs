internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string example = "Ви отримали рядок, який містить декілька слів, розділених комами. Ваша мета - видалити всі пробіли з цього рядка та вивести результат.";

        string result = example.Replace(" ", "");

        Console.WriteLine($"Результат: {result}");
    }
}