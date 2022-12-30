using System;

namespace kcm_1789
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            uint num2 = num;
            int count = 0;

            for(uint i = 1; i <= num2; i++)
            {
                num2 = num2 - i;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
