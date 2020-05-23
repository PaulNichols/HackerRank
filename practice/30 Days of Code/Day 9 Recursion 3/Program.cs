using System;

internal class Solution
{
    // Complete the factorial function below.
    private static int factorial(int n)
    {
        var result = n;
        for (int i = n - 1; i >= 1; i--)
        {
            result *= i;
        }
        return result;
    }

    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int result = factorial(n);

        Console.WriteLine(result);
    }
}