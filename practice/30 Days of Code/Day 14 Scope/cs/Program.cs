using System;
using System.Linq;

internal class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] a)
    {
        this.elements = a;
    }

    internal void computeDifference()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 1; j < elements.Length; j++)
            {
                var diff = Math.Abs(elements[i] - elements[j]);
                if (diff > maximumDifference)
                {
                    maximumDifference = diff;
                }
            }
        }
    }
} // End of Difference Class

internal class Solution
{
    private static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}