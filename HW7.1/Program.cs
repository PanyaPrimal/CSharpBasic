internal class Program
{
    enum DaysOfWeek {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }


    private static void Main(string[] args)
    {
        var rand = new Random();

        #region 1, 2.
        //int[] arr = new int[10];

        //Console.WriteLine("Five random integers between -10 and 10:");
        //for (int i = 0; i < 10; i++) { 
        //    arr[i] = rand.Next(-10, 11);

        //}

        //Console.WriteLine("even indexes of random array:");

        //bool sumOfEvenIndexesOfArrayIsPositiveNumber = false;
        //int testerOfPosNum = 0;

        //for (int i = 0; i < arr.Length; i += 2) {
        //    Console.WriteLine($"arr[{i}] = {arr[i]}");

        //    testerOfPosNum += arr[i];
        //}

        //if ( testerOfPosNum > 0) sumOfEvenIndexesOfArrayIsPositiveNumber = true;

        //Console.WriteLine($"Is sum of numbers from array is positive? {sumOfEvenIndexesOfArrayIsPositiveNumber}");
        #endregion

        #region 4.
        //    int[,] arr = new int[9, 9];

        //    for (int i = 0; i < 9; i++) {
        //        Console.WriteLine();

        //        for (int j = 0; j < 9; j++) {
        //            arr[i, j] = (i + 1) * (j + 1);
        //        }
        //    }

        //    for (int i = 0; i < 9; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            Console.Write($"{arr[i, j],4}"); 
        //        }
        //        Console.WriteLine(); 
        //    }
        //
        #endregion

        #region 5.
        //Console.Write("Enter the number of days: ");

        //string input = Console.ReadLine();

        //if (!int.TryParse(input, out int days) || days < 0)
        //{
        //    Console.WriteLine("Please enter a valid non-negative number.");
        //    return;
        //}

        //int dayIndex = days % 7;
        //DaysOfWeek resultDay = (DaysOfWeek)dayIndex;

        //Console.WriteLine($"The day after {days} days from Monday will be: {resultDay}");
        #endregion

    }
}
