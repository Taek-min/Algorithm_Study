using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int seq = 0;
            while (num > 0)
            {
                seq++;
                string str = seq.ToString();
                if (str.Contains("666")) num--;
            }
            Console.WriteLine(seq);
        }
    }
}