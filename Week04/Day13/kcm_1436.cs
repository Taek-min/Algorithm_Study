using System;

namespace kcm_1436
{
    class Program
    {
        static void Main(string[] args)
        {
            int series = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 666; ; i++)
            {
                if (i.ToString().Contains("666"))
                {
                    count++;

                    if (count == series)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
