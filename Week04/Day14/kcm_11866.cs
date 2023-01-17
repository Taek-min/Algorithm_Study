using System;
using System.Text;

namespace kcm_11866
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            bool[] circle = new bool[int.Parse(num[0])];
            StringBuilder strBuilder = new StringBuilder();
            int count = 0;

            while (count < int.Parse(num[1]) * int.Parse(num[0]))
            {
                for (int i = 0; i < circle.Length; i++)
                {
                    if (!circle[i])
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }

                    if(count % int.Parse(num[1]) == 0)
                    {
                        if(count == int.Parse(num[1]) * int.Parse(num[0]))
                        { 
                            strBuilder.Append(i + 1);
                            break;
                        }
                        circle[i] = true;
                        strBuilder.Append(i + 1);
                        strBuilder.Append(", ");
                    }
                }
            }

            Console.WriteLine("<" + strBuilder + ">");
        }//피드백이 필요 없군요
    }
}
