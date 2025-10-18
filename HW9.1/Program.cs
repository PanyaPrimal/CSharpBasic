//Ви отримали рядок, який містить ім’я та прізвище користувача. 
//Ваша мета - перевірити, чи починається прізвище на ту ж літеру, що й ім’я. 
//Якщо так, вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”, інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.

using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        Console.Write("Введіть ім'я та прізвище через пробіл: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Помилка: рядок не може бути порожнім!");
            return;
        }

        string[] parts = input.Trim().Split(' ');

        if (parts.Length < 2)
        {
            Console.WriteLine("Помилка: потрібно ввести і ім'я, і прізвище!");
            return;
        }

        string firstName = parts[0];
        string lastName = parts[1];

        if (char.ToLower(firstName[0]) == char.ToLower(lastName[0]))
        {
            Console.WriteLine("Прізвище починається на ту ж літеру, що і ім'я");
        }
        else
        {
            Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім'я");
        }
    }
}