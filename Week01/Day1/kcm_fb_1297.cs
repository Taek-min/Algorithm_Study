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

            OneRatio = Math.Sqrt(Math.Pow(double.Parse(str[0]), 2) / (Math.Pow(double.Parse(str[1]), 2) + Math.Pow(double.Parse(str[2]), 2)));
            Console.WriteLine(Math.Truncate(double.Parse(str[1]) * OneRatio) + " " + Math.Truncate(double.Parse(str[2]) * OneRatio));
        }
    }
}
