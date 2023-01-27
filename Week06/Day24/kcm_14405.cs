using System;
using System.Text.RegularExpressions;

namespace kcm_14405
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pikachu = { "pi", "ka", "chu" };
            string str = Console.ReadLine();

            for(int i = 0; i < pikachu.Length; i++)
            {
                str = Regex.Replace(str, pikachu[i], " ");
            }

            str = Regex.Replace(str, " ", "");

            if (str.Equals(""))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
