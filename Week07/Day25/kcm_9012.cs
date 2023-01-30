using System;
using System.Text.RegularExpressions;
using System.Text;

namespace kcm_9012
{
    class Program
    {
        static void Main(string[] args)
        {
            string vps = "()";
            int loop = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < loop; i++)
            {
                string str = Console.ReadLine();

                while (str.Contains(vps))
                {
                    str = str.Replace(vps , "");
                }

                if (str.Equals("")) 
                {
                    sb.Append("YES\n");
                }
                else if (str.Length > 0)
                {
                    sb.Append("NO\n");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
