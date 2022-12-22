using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject
{
    class syh_25305
    {
        static void Main()
        {
            string[] inputStrBuf;
            int N, k;
            int[] stdScores;

            inputStrBuf = InputMethod(2);
            N = int.Parse(inputStrBuf[0]);
            k = int.Parse(inputStrBuf[1]);

            inputStrBuf = InputMethod(N);
            stdScores = Array.ConvertAll(inputStrBuf, int.Parse);
            //stdScores = Array.ConvertAll(inputStrBuf, s => int.Parse(s));
            //stdScores = inputStrBuf.Select(int.Parse).ToArray();

            Array.Sort(stdScores);
            Console.WriteLine($"{stdScores[N - k]}");
        }
        static string[] InputMethod(int length = 0)
        {
            string[] inputStrBuf;
            while(true)
            {
                inputStrBuf = Console.ReadLine().Split(' ');
                if (inputStrBuf.Length != length && length < 0)
                    continue;
                else
                    return inputStrBuf;
            }
        }
    }
}
// 이렇게 입력 받아서 처리 하는것도 있네 배워가네요, 함수 잘만드네 