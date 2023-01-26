using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kcm_2751
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < loop; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            list = list.Distinct().ToList();
            list.Sort();

            for(int j = 0; j < list.Count; j++)
            {
                strBuilder.Append(list[j] + "\n");
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
