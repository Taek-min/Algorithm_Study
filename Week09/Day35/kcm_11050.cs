using System;

namespace kcm_11050
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            Console.WriteLine(Factorial(int.Parse(num[0])) / (Factorial(int.Parse(num[0]) - int.Parse(num[1])) * Factorial(int.Parse(num[1]))));
        }

        static int Factorial(int num)
        {
            if(num <= 1)
            {
                return 1;
            }

            return num * Factorial(num -1);
        }
    }
}
