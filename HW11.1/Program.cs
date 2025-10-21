namespace HW11._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci numbers calculation");
        Console.WriteLine("==========================================================\n");

        int[] testNumbers = { 3, 11, 1, 2, 5, 10 };

        foreach (int number in testNumbers)
        {
            int result = FibonacciHelper.GetFibonacci(number);
            Console.WriteLine($"Fibonacci({number}) = {result}");
        }
    }
}