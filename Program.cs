using System;

namespace PlusMinus
{
    class Program
    {
        static void PlusMinus(int[] array)
        {
            // declare variables for each type as counters
            int posCount = 0;
            int negCount = 0;
            int zeroCount = 0;
            // Determine if value is +, -, 0 => increment accordingly
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    posCount++;
                }
                else if (array[i] < 0)
                {
                    negCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
        double posRatio = (double)posCount/array.Length;
        double negRatio = (double)negCount/array.Length;
        double zeroRatio = (double)zeroCount/array.Length;
        
        Console.WriteLine($"Positive Number Ratio: {posRatio}");
        Console.WriteLine($"Negative Number Ratio: {negRatio}");
         Console.WriteLine($"Zero Ratio: {zeroRatio}");
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] testArr = {1,-1,0,2,2,3,5};
            PlusMinus(testArr);
        }
    }
}

