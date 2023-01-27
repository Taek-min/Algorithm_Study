using System;
using System.Collections.Generic;
using System.Text;

namespace kcm_7568
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strBuilder = new StringBuilder();
            int loop = int.Parse(Console.ReadLine());
            List<List<int>> list = new List<List<int>>();

            for (int i = 0; i < loop; i++)
            {
                string[] num = Console.ReadLine().Split();
                list.Add(new List<int> { int.Parse(num[0]), int.Parse(num[1]) });
            }

            for(int j = 0; j < loop; j++)
            {
                int count = 1;

                for(int k = 0; k < loop; k++)
                {
                    if(list[k][0] > list[j][0])
                    {
                        if(list[k][1] > list[j][1])
                        {
                            count++;
                        }
                    }
                }

                strBuilder.Append(count + " ");
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
