using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        var pairs = 0;
        var orderedColours = ar.OrderBy(x => x).ToArray();

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine($"Checking Colour Array item: {i}");
            Console.WriteLine($"Current Colour is: { orderedColours[i]}");
            Console.WriteLine($"Next Colour is: {orderedColours[i + 1]}");

            if (i + 1 < orderedColours.Length)
            {
                if (orderedColours[i] == orderedColours[i + 1])
                {
                    pairs++;
                    Console.WriteLine($"That makes {pairs} pair(s)");
                    i++;
                    continue;
                }

            }

            Console.WriteLine($"{orderedColours[i]} is an odd one");
        }

        return pairs;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))        ;
        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
