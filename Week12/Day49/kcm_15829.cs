using System;

namespace kcm_15829
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[] chars = new char[size];
            int[] nums = new int[size];
            long mod = 1234567891;
            long sum = 0;
            string str = Console.ReadLine();

            chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                long pow = 1;
                for (int j = 0; j < i; j++)
                {
                    pow *= 31;
                    pow %= mod;
                }

                sum += (Convert.ToInt32(chars[i]) - 96) * pow % mod;
            }

            Console.WriteLine(sum % mod);
        }
    }
}
