using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221227
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split();
            int[] list = new int[int.Parse(input[0]) + int.Parse(input[1]) + int.Parse(input[2]) + 1];

            for (int i = 1; i <= int.Parse(input[0]); i++)
            {
                for(int j = 1; j <= int.Parse(input[1]); j++)
                {
                    for(int k = 1; k <= int.Parse(input[2]); k++)
                    {
                        list[i + j + k]++; 
                    }
                }
            }
            Console.WriteLine(Array.IndexOf(list, list.Max()));
        }
    }
}
