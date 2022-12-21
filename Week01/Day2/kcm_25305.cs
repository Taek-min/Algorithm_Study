using System;

namespace kcm_25305
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int[] Score = new int[int.Parse(str[0])];

            string[] splitStr = Console.ReadLine().Split();

            for(int i = 0; i < splitStr.Length; i++)
            {
                Score[i] = int.Parse(splitStr[i]);
            }

            Array.Sort(Score);
            Array.Reverse(Score);

            Console.Write(Score[int.Parse(str[1]) - 1]);
        }
    }
}
