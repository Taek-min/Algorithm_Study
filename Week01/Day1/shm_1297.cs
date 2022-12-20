using System;

namespace _221220
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] num = input.Split(' ');
            double X = Math.Sqrt(Math.Pow(int.Parse(num[0]), 2) / (Math.Pow(int.Parse(num[1]), 2) + Math.Pow(int.Parse(num[2]), 2)));
            double H = Math.Truncate(Double.Parse(num[1]) * X);
            double W = Math.Truncate(Double.Parse(num[2]) * X);
            Console.WriteLine("{0} {1}", H, W);
        }
    }
}