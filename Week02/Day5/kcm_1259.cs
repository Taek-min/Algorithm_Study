using System;

namespace kcm_1259
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();

                char[] charArr = str.ToCharArray();
                Array.Reverse(charArr);
                string reverseStr = new string(charArr);

                if (str.Equals("0"))
                {
                    break;
                }
                else if (str.Equals(reverseStr))
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
