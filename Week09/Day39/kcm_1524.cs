using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace kcm_1524
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < loop; i++)
            {
                Console.ReadLine();
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] n_soldier = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[] m_soldier = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                

                if(n_soldier.Max() >= m_soldier.Max())
                {
                    sb.Append("S\n");
                }
                else
                {
                    sb.Append("B\n");
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
 