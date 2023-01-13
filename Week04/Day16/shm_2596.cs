using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230113
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string[,] code = {
                {"A", "000000" },
                {"B", "001111" },
                {"C", "010011" },
                {"D", "011100" },
                {"E", "100110" },
                {"F", "101001" },
                {"G", "110101" },
                {"H", "111010" }
            };
            string send = Console.ReadLine();
            int chk = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < code.GetLength(0); j++)
                {
                    int cnt = 0;
                    for (int k = 0; k < 6; k++) if (code[j, 1].Substring(k, 1).Equals(send.Substring(i * 6 + k, 1))) cnt++;
                    if (cnt > 4)
                    {
                        sb.Append(code[j, 0]);
                        chk++;
                    }
                }
                if (chk == i)
                {
                    sb.Clear();
                    sb.Append(i + 1);
                    break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
