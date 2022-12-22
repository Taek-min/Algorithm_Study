using System;

namespace _221221
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split();
            String[] num = Console.ReadLine().Split();
            int[] score = new int[int.Parse(input[0])];

            for(int i = 0; i < score.Length; i++)
            {
                score[i] = int.Parse(num[i]);
            }
            Array.Sort(score);
            Array.Reverse(score);

            Console.WriteLine(score[int.Parse(input[1]) - 1]);
        }
    }
}
