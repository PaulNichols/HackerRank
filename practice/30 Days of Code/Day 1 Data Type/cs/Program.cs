using System;

namespace Day_1_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2;

            // Read and save an integer, double, and String to your variables.
            i2 = int.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
            s2 = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);

            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + d2).ToString("0.##"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);
        }
    }
}
