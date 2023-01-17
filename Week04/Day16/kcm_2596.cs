using System;
using System.Text;

namespace kcm_2596
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codes =
            {
                "A", "000000",
                "B", "001111",
                "C", "010011",
                "D", "011100",
                "E", "100110",
                "F", "101001",
                "G", "110101",
                "H", "111010",
            };

            StringBuilder strBuilder = new StringBuilder();
            int num = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int max = 0;

            for (int i = 1; i <= num; i++)
            {
                char[] chars = str.Substring((i - 1) * 6, 6).ToCharArray();
                bool check = true;

                for (int j = 1; j < codes.Length; j += 2)
                {
                    char[] code = codes[j].ToCharArray();
                    int count = 0;
                    for (int k = 0; k < chars.Length; k++)
                    {
                        if(chars[k].Equals(code[k]))
                        {
                            count++;
                        }                    
                    }
                    if (count >= 5)
                    {
                        strBuilder.Append(codes[j - 1]);
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
