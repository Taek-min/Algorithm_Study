using System;
using System.Text;

namespace kcm_5533
{
    class Program
    {
        static void Main(string[] args)
        {
            int player = int.Parse(Console.ReadLine());
            string[][] cards = new string[player][];
            int[] score = new int[player];
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < player; i++)
            {
                cards[i] = Console.ReadLine().Split();
            }

            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < player; k++)
                {
                    bool check = false;
                    for (int l = 0; l < player; l++)
                    {
                        if (cards[k][j] == cards[l][j] && k != l)
                        {
                            check = true;
                        }
                    }

                    if (!check)
                    {
                        score[k] += int.Parse(cards[k][j]);
                    }
                }
            }

            for(int m = 0; m < score.Length; m++)
            {
                strBuilder.AppendLine(score[m].ToString());
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
