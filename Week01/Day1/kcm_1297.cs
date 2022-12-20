using System;

namespace week01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            double[] TV = new double[str.Length];
            double OneRatio;

            for (int i = 0; i < str.Length; i++)
            {
                TV[i] = double.Parse(str[i]);
            }

            OneRatio = Math.Sqrt(Math.Pow(TV[0], 2) / (Math.Pow(TV[1], 2) + Math.Pow(TV[2], 2)));

            for (int j = 1; j < str.Length; j++)
            {
                TV[j] = TV[j] * OneRatio;
            }
            Console.WriteLine(Math.Truncate(TV[1]) + " " + Math.Truncate(TV[2]));
        }
    }
}
