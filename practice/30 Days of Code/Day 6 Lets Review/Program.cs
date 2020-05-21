using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var size = int.Parse(Console.ReadLine());
        var strings = new List<string>();

        for (int i = 0; i < size; i++)
        {
            strings.Add(Console.ReadLine());
        }

        var splitStrings = Split(strings);

        foreach (var item in splitStrings)
        {
            Console.WriteLine(item);
        }
    }

    private static List<string> Split(List<string> strings)
    {
        var retrunStrings = new List<string>();

        foreach (var item in strings)
        {
            var letters = item.ToCharArray();
            var odds = "";
            var evens = "";

            for (int i = 0; i < letters.Length; i++)
            {
                var currentLetter = letters[i].ToString();

                if (i % 2 == 0)
                {
                    evens += currentLetter;
                }
                else
                {
                    odds += currentLetter;
                }
            }

            retrunStrings.Add($"{evens} {odds}");
        }

        return retrunStrings;
    }
}