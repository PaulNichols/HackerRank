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



    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int x = 0;
        int best = int.MinValue;

        while ((x + 2) < arr.Length)
        {
            int y = 0;
            while ((y + 2) < arr[0].Length)
            {
                var sum = arr[y][x] + arr[y][x + 1] + arr[y][x + 2];
                sum += arr[y + 1][x + 1];
                sum += arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];

                if (sum > best)
                {
                    best = sum;
                }
                y++;
            }
            x++;
        }

        Console.WriteLine(best);
    }
}
