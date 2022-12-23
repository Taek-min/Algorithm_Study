using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221223
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sentence =
            {
                "L", "O", "V", "E"
            };
            String name = Console.ReadLine();            //연두 영어 이름
            int loop = int.Parse(Console.ReadLine());    //팀 개수
            int[] cntYeondoo = new int[sentence.Length]; //연두 영어 이름 카운팅 배열 
            String[] teamName = new string[loop];        //팀 저장 배열 
            String res = "";                             //결과값
            int max = -1;                                //최댓값
            for (int i = 0; i < sentence.Length; i++)    //연두 영어 이름 중 L O V E 카운팅
            {
                int k = 0;
                while (true)
                {
                    if (k == name.Length) break;
                    if (sentence[i] == name.Substring(k, 1))
                    {
                        cntYeondoo[i]++;
                    }
                    k++;
                }
            }

            for (int i = 0; i < loop; i++)               //팀 저장 for 문 
            {
                String input = Console.ReadLine();
                teamName[i] = input;
            }
            Array.Sort(teamName);

            for (int i = 0; i < loop; i++)
            {
                int[] cntTeam = new int[sentence.Length];   // 팀 L O V E 카운팅 배열 
                int prob;                                   // 확률 저장 값 
                for (int j = 0; j < sentence.Length; j++)
                {
                    int k = 0;
                    while (true)
                    {
                        if (k == teamName[i].Length) break;
                        if (teamName[i].Substring(k, 1) == sentence[j])
                        {
                            cntTeam[j]++;
                        }
                        k++;
                    }
                }
                int L = cntTeam[0] + cntYeondoo[0];
                int O = cntTeam[1] + cntYeondoo[1];
                int V = cntTeam[2] + cntYeondoo[2];
                int E = cntTeam[3] + cntYeondoo[3];
                prob = (L + O) * (L + V) * (L + E) * (O + V) * (O + E) * (V + E) % 100;
                if (prob > max)
                {
                    max = prob;
                    res = teamName[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}
