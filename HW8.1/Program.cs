using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        #region 1. Написати програму, що знаходить другий найбільший елемент масиву.
        
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int secondMaxNum = FindSecondMaxNum(array);

        if (secondMaxNum != int.MinValue)
        {
            Console.WriteLine($"Task 1 - Second largest element: {secondMaxNum}");
        }
        else
        {
            Console.WriteLine("Task 1 - Array is too small");
        }

        static int FindSecondMaxNum(int[] arr)
        {
            if (arr.Length < 2)
            {
                return int.MinValue;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in arr)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }

            return secondMax;
        }

        #endregion

        #region 2. Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

        int[,] matrix = {
            { 9, 5, 3 },
            { 8, 2, 7 },
            { 4, 6, 1 }
        };

        Console.WriteLine("\nTask 2 - Original matrix:");
        PrintMatrix(matrix);

        SortMatrix(matrix);

        Console.WriteLine("\nTask 2 - Sorted matrix:");
        PrintMatrix(matrix);

        static void SortMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int totalElements = rows * cols;

            int[] temp = new int[totalElements];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp[index++] = matrix[i, j];
                }
            }

            Array.Sort(temp);

            index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = temp[index++];
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region 3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

        int[] numbers = { 10, 20, 30, 40, 50 };
        int indexToRemove = 2;

        Console.WriteLine($"\nTask 3 - Original array: [{string.Join(", ", numbers)}]");

        int[] resultArray = RemoveElementAtIndex(numbers, indexToRemove);

        if (resultArray != null)
        {
            Console.WriteLine($"Task 3 - Array after removing element at index {indexToRemove}: [{string.Join(", ", resultArray)}]");
        }
        else
        {
            Console.WriteLine($"Task 3 - Error: index {indexToRemove} is out of bounds");
        }

        static int[] RemoveElementAtIndex(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                return null;
            }

            int[] newArray = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = index + 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }

            return newArray;
        }

        #endregion

        #region 4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

        int[,] squareMatrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.WriteLine("\nTask 4 - Matrix:");
        PrintMatrix(squareMatrix);

        int mainDiagonalSum = GetMainDiagonalSum(squareMatrix);
        int secondaryDiagonalSum = GetSecondaryDiagonalSum(squareMatrix);

        Console.WriteLine($"Task 4 - Main diagonal sum: {mainDiagonalSum}");
        Console.WriteLine($"Task 4 - Secondary diagonal sum: {secondaryDiagonalSum}");

        static int GetMainDiagonalSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int minSize = Math.Min(rows, cols);
            int sum = 0;

            for (int i = 0; i < minSize; i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }

        static int GetSecondaryDiagonalSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int minSize = Math.Min(rows, cols);
            int sum = 0;

            for (int i = 0; i < minSize; i++)
            {
                sum += matrix[i, cols - 1 - i];
            }

            return sum;
        }

        #endregion
    }
}