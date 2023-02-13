using System;
using System.Linq;
namespace _221229
{
    class Program
    {
        static string[] InputBoard()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] board = new string[input[0]];
            for (int i = 0; i < input[0]; i++) board[i] = Console.ReadLine();
            return board;
        }
        static void Solve(string[] board)
        {
            int min = int.MaxValue;
            string[] cutboard = new string[8];
            for(int i = 0; i < board[0].Length - 7; i++)
            {
                for(int j = 0; j < board.Length - 7; j++)
                {
                    for(int k = 0; k < 8; k++) cutboard[k] = board[j + k].Substring(i, 8);
                    min = Math.Min(min, CntDiff(cutboard)); 
                }
            }
            Console.WriteLine(min);
        }
        static int CntDiff(string[] str) 
        {
            int result = int.MaxValue;
            int[] min = new int[2];
            string[] chess = { "BWBWBWBW", "WBWBWBWB" };
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (!str[i].Substring(j, 1).Equals(chess[i % 2].Substring(j, 1))) min[0]++;
                    else if(!str[i].Substring(j, 1).Equals(chess[(i + 1) % 2].Substring(j, 1))) min[1]++;
                }
            }
            result = Math.Min(result, min[0]);
            result = Math.Min(result, min[1]);
            return result;
        }
        static void Main(string[] args)
        {
            Solve(InputBoard());
        }
    }
}
