using System;
using System.Text;
using System.Linq;

namespace kcm_6996
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < loop; i++)
            {
                string[] str = Console.ReadLine().Split();
                string[] convertStr = new string[2];

                for (int j = 0; j < convertStr.Length; j++)
                {
                    char[] chars = str[j].ToCharArray();
                    Array.Sort(chars);
                    convertStr[j] = new string(chars);
                }

                sb.Append(str[0] + " & " + str[1]);

                if (convertStr[0].Equals(convertStr[1]))
                {
                    sb.Append(" are anagrams.\n");
                }
                else
                {
                    sb.Append(" are NOT anagrams.\n");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
