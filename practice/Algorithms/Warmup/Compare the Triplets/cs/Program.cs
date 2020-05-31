using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Solution
{
    // Complete the compareTriplets function below.
    private static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var bobsTotal = 0;
        var alicessTotal = 0;

        for (int i = 0; i < a.Count(); i++)
        {
            var bobsScore = a[i];
            var alicesScore = b[i];

            bobsTotal += bobsScore > alicesScore ? 1 : 0;
            alicessTotal += bobsScore < alicesScore ? 1 : 0;
        }

        return new List<int> { bobsTotal, alicessTotal };
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
