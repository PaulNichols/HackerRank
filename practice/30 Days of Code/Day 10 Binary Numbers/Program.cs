using System;
using System.Linq;
using System.Collections.Generic;

public class ConversionExample
{
    public static void Main(string[] args)
    {
        int n, i;
        var binaryDigits = new List<int>();

        n = int.Parse(Console.ReadLine());
        for (i = 0; n > 0; i++)
        {
            binaryDigits.Add(n % 2);
            n = n / 2;
        }

        string binaryString = "";

        for (i = i - 1; i >= 0; i--)
        {
            binaryString += binaryDigits [i];
        }

      Console.WriteLine( binaryString.Split('0').Select(x=>x.Length).Max());
    }
}