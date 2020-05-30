using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Solution
{
    private static void Main(String[] args)
    {
        string s = Console.ReadLine();

        try
        {
            var integrer = int.Parse(s);
            Console.WriteLine(integrer);
        }
        catch
        {
            Console.WriteLine("Bad String");
        }
    }
}