using System;

internal class Solution
{
    private static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here
        int numberOfSwaps = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    swap(ref a, j, j + 1, a[j], a[j + 1]);
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.GetUpperBound(0)]}");
    }

    private static void swap(ref int[] a, int position1, int position2, int value1, int value2)
    {
        a[position1] = value2;
        a[position2] = value1;
    }
}