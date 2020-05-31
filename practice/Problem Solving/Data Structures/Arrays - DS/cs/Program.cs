using System;
using System.Linq;

internal class Solution
{
    // Complete the reverseArray function below.
    private static int[] reverseArray(int[] a)
    {
        return a.Reverse().ToArray();
    }

    private static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] res = reverseArray(arr);

        Console.WriteLine(string.Join(" ", res));
    }
}