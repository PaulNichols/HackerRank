using System;

public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int sum = 0;

        var factors = Factor(n);
        foreach (var factor in factors)
        {
            sum += factor;
        }

        return sum;
    }

    public int[] Factor(int number)
    {
        int index = 1;
        var factors = new int[index];

        int max = (int)Math.Sqrt(number);  //round down
        for (int factor = 1; factor <= max; ++factor)
        {
            //test from 1 to the square root, or the int below it, inclusive.
            if (number % factor == 0)
            {
                index++;
                Array.Resize<int>(ref factors, index);
                factors[index - 1] = factor;

                if (factor != number / factor)
                {
                    // Don't add the square root twice!  Thanks Jon
                    index++;
                    Array.Resize<int>(ref factors, index);
                    factors[index - 1] = number / factor;
                }
            }
        }
        return factors;
    }
}

internal class Solution
{
    private static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}