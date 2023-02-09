using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace kcm_9093
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < loop; i++)
            {
                string[] input = Console.ReadLine().Split();

                for(int j = 0; j < input.Length; j++)
                {
                    for(int k = input[j].Length - 1; k >= 0; k--)
                    {
                        string str = input[j];
                        sb.Append(str[k]);
                    }
                    sb.Append(" ");
                }
                sb.Append("\n");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
