using System.Text;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        #region  1. Обчислення середнього заробітку:
        // List<double> salaries = new List<double>();

        //while (true) {
        //     Console.WriteLine("Введіть зарплату працівника або 'q' для завершення вводу:");

        //     string userInput = Console.ReadLine();

        //     if(userInput.ToLower() == "q")
        //     {
        //        break;
        //     }

        //     if (double.TryParse(userInput, out double salary))
        //     {
        //         salaries.Add(salary);
        //     }
        //     else { Console.WriteLine("Помилка, введіть число.");
        //     }
        // }

        // if (salaries.Count > 0) {
        //     double sumOfSalaries = 0;

        //     for (int i = 0; i < salaries.Count; i++)
        //     {
        //         sumOfSalaries += salaries[i];
        //     }

        //     double averageSalary = sumOfSalaries / salaries.Count;
        //     Console.WriteLine($"Середня зарплата працівників: {averageSalary}");
        // }
        #endregion

        #region  2. Побудова графіку зірочками:

        //int stars = 0;

        //while (true)
        //{
        //    Console.WriteLine("Введіть кількість рядків граафіка або 'q' для завершення вводу:");

        //    string userInput = Console.ReadLine();

        //    if (userInput.ToLower() == "q")
        //    {
        //        break;
        //    }
        //    if (double.TryParse(userInput, out double starLinesInput) && starLinesInput >= 0)
        //    {
        //        stars = (int)starLinesInput;

        //        for (int i = 0; i < stars; i++)
        //        {
        //            string line = "";

        //            for (int j = 0; j <= i; j++)
        //            {
        //                line += "*";
        //            }
        //            Console.WriteLine(line);
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("Помилка, введіть число.");
        //    }
        //}



        #endregion

        #region  3. Генерація простих чисел:
        //while (true)
        //{
        //    Console.WriteLine("Введіть число або 'q' для завершення вводу:");

        //    string userInput = Console.ReadLine();

        //    if (userInput.ToLower() == "q")
        //    {
        //        break;
        //    }
        //    if (int.TryParse(userInput, out int teNumber) && teNumber >= 1)
        //    {
        //        Console.WriteLine($"Прості числа від 0 до {teNumber}:");
        //        bool hasPrimes = false;

        //        for (int i = 2; i < teNumber; i++) {
        //            bool isPrime = true;
        //            for (int j = 2; j <= i / 2; j++) { 
        //                if (i % j == 0) {
        //                    isPrime = false;
        //                    break;
        //                }
        //            }

        //            if (isPrime) {
        //                Console.Write(i + " ");
        //                hasPrimes = true;
        //            }

        //        }
        //        if (!hasPrimes) {
        //            Console.WriteLine("Простих чисел немає.");
        //        } else {
        //            Console.WriteLine();
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("Помилка, введіть число.");
        //    }
        //}
        #endregion

        #region  4. Перевірка паролю:

        //while (true)
        //{
        //   Console.WriteLine();
        //   Console.WriteLine("Введіть пароль для перевірки або 'q' для завершення вводу:");

        //    string password = Console.ReadLine();

        //    bool hasEightChars = false;
        //    bool hasDigit = false;
        //    bool hasSpecialChar = false;
        //    char[] specialSymbolsList = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+' };

        //    if (password.ToLower() == "q")  break;

        //    if (password.Length > 8) { 
        //            hasEightChars = true;
        //    }

        //    foreach (char c in password)
        //    {
        //        if (char.IsDigit(c)) hasDigit = true;

        //        for (int i = 0; i < specialSymbolsList.Length; i++)
        //        {
        //            if (c == specialSymbolsList[i])
        //            {
        //                hasSpecialChar = true;
        //                break;
        //            }
        //        }
        //    }

        //    if (hasEightChars && hasDigit && hasSpecialChar) Console.WriteLine($"Пароль коректний!");

        //    if (!hasEightChars) Console.WriteLine("Пароль має містити не менше 8 символів.");
        //    if (!hasDigit) Console.WriteLine("Пароль має містити хоча б одну цифру.");
        //    if (!hasSpecialChar)
        //    {
        //        string specialSymbolsString = "";
        //        for (int i = 0; i < specialSymbolsList.Length; i++)
        //        {
        //            specialSymbolsString += specialSymbolsList[i];
        //            if (i < specialSymbolsList.Length - 1)
        //            {
        //                specialSymbolsString += ", ";
        //            }
        //        }
        //        Console.WriteLine($"Пароль має містити хоча б один спеціальний символ: {specialSymbolsString}.");
        //    }

        //    continue;
        //}
        #endregion

        #region  5. Генерація фібоначчівської послідовності:
        //while (true)
        //{

        //    Console.WriteLine();
        //    Console.WriteLine("Введіть кількість символів для послідовності Фібоначчі або 'q' для завершення вводу:");

        //    string userInput = Console.ReadLine();

        //    if (userInput.ToLower() == "q") break;

        //    if (int.TryParse(userInput, out int num)) { 
        //        Console.WriteLine();
        //        int previous = 0;
        //        int current = 1;

        //        for (int i = 0; i < num; i++) {
        //            if (i == 0) Console.WriteLine(0);
        //            Console.WriteLine(current);

        //            int next = previous + current;
        //            previous = current;
        //            current = next;
        //        }
        //    }
        //    continue;
        //}
        #endregion

        #region  6. Калькулятор оплати праці за годину::
        //while (true)
        //{

        //    Console.WriteLine();

        //    Console.WriteLine("Введіть кількість годин, відпрацюваних за день або 'q' для завершення вводу:");
        //    string userHoursInput = Console.ReadLine();

        //    Console.WriteLine("Введіть розмір годинної ставки або 'q' для завершення вводу:");
        //    string userRateInput = Console.ReadLine();

        //    if (userHoursInput.ToLower() == "q" || userRateInput.ToLower() == "q") break;

        //    if (int.TryParse(userHoursInput, out int hours) && double.TryParse(userRateInput, out double rate))
        //    {
        //        Console.WriteLine($"Оплата за сьогодні - ${(hours * rate)}");
        //    }
        //    continue;
        //}
        #endregion

        #region  7. Генерація таблиці множення для конкретного числа:
        //while (true)
        //{

        //    Console.WriteLine(); 
        //    Console.WriteLine("Введіть число або 'q' для завершення вводу:");
        //    string userInput = Console.ReadLine();

        //    if (userInput.ToLower() == "q") break;

        //    if (int.TryParse(userInput, out int num))
        //    {
        //        for (int j = 1; j <= 10; j++) {
        //            Console.WriteLine($"{num} * {j} = {(num * j)}");
        //        }
        //    }
        //    continue;
        //}
        #endregion

        #region  8. Перевірка на простоту:
       
        //while (true)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Введіть число для перевірки на простоту або 'q' для завершення вводу:");
        //    string userInput = Console.ReadLine();

        //    if (userInput.ToLower() == "q") break;

        //    if (int.TryParse(userInput, out int num)) {
        //        if (num <= 1) {
        //            Console.WriteLine($"Число {num} не є простим числом");
        //            continue;
        //        }

        //        if (num == 2) {
        //            Console.WriteLine($"Число {num} є простим числом");
        //            continue;
        //        }

        //        bool isPrime = true;
        //        for (int i = 3; i <= num / 2; i +=2) {
        //            if (num % i == 0) {
        //                isPrime = false;
        //                break;
        //            }
        //        }


        //        if (isPrime) {
        //            Console.WriteLine($"Число {num} є простим числом");
        //        }  else Console.WriteLine($"Число {num} не є простим числом");
        //    } else  Console.WriteLine("Помилка: введіть коректне ціле число або 'q' для виходу."); 


        //    continue;
        //}
        #endregion
    }
}