using System;
using System.Linq;
using System.Collections.Generic;


namespace kcm_2456
{
    class Program
    {
        static void Main(string[] args)
        {
            int voters = int.Parse(Console.ReadLine());
            int[] candidate = new int[3];
            int[,] score = new int[3,3];
            bool check = false;

            for (int i = 0; i < voters; i++)
            {
                string[] point = Console.ReadLine().Split();

                for(int j = 0; j < point.Length; j++)
                {
                    candidate[j] += int.Parse(point[j]);

                    for (int k = 2; k >= 0; k--)
                    {
                        if(int.Parse(point[j]) % (k + 1)  == 0)
                        {
                            score[j, k] += 1;
                            break;
                        }
                    }
                }
            }

            if (candidate.Length != candidate.Distinct().Count())
            {
                List<int> index = new List<int>();    

                for (int z = 0; z < candidate.Length; z++) 
                { 
                    if(candidate[z] == candidate.Max())
                    {
                        index.Add(z);
                    }
                }

                int maxscore;
                int maxindex = 1;

                for (int a = score.GetLength(1) - 1; a > 0; a--)
                {
                    maxscore = score[index[0], a];
                    int count = 0;

                    for (int u  = 0; u < index.Count; u++) 
                    {
                        if(maxscore == score[index[u], a])
                        {
                            count++;
                        }
                        else if(maxscore < score[index[u], a])
                        {
                            maxscore = score[index[u], a];
                            maxindex = index[u] + 1;
                        }
                    }

                    if(count != index.Count)
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                {
                    Console.WriteLine(maxindex + " " + candidate.Max());
                }
                else
                {
                    Console.WriteLine("0 " + candidate.Max());
                }

            }
            else
            {
                int index = Array.IndexOf(candidate, candidate.Max()) + 1;
                Console.WriteLine(index + " " + candidate.Max());
            }
        }
    }
}
