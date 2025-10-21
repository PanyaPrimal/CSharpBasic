namespace HW11._1;
public static class FibonacciHelper
{
    public static int GetFibonacci(int n)
    {
        if (n == 1)
        {
            return 0;
        }
        
        if (n == 2)
        {
            return 1;
        }
        
        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }
}

