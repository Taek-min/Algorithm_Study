using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonProject.Class
{
    class syh_2805
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static StringBuilder sb = new StringBuilder();
        static void Main()
        {
            Dictionary<long, long> treeDic;
            List<long> treeList;
            long sumTree = 0;
            long sumCnt = 0;
            long res = 0;

            sw.AutoFlush = true;

            long[] intBuf = sr.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long N = intBuf[0];
            long M = intBuf[1];

            treeDic = InputTreeDicMethod(N);
            treeList = new List<long>(treeDic.Keys);
            treeList.Sort();

            long treeDiff;
            for (int idx = treeList.Count-1; idx >= 0; idx--)
            {
                treeDiff = idx != 0 ? treeList[idx] - treeList[idx - 1] : treeList[0];
                sumCnt += treeDic[treeList[idx]];
                sumTree += treeDiff * sumCnt;
                
                if (sumTree >= M)
                {
                    for (long i = treeDiff;  i >= 0; i--)
                    {
                        if (idx != 0) res = sumTree - i * sumCnt >= M ? treeList[idx-1] + i : 0;
                        else          res = sumTree - i * sumCnt >= M ? i : 0;

                        if(res > 0) break;
                    }
                    break;
                }
            }
            sb.Append(res.ToString());
            sw.WriteLine(sb);
        }

        static Dictionary<long, long> InputTreeDicMethod(long N)
        {
            Dictionary<long, long> treeDic = new Dictionary<long, long>();
            int[] treeBuf = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                if (treeDic.ContainsKey(treeBuf[i]))
                    treeDic[treeBuf[i]]++;
                else
                    treeDic.Add(treeBuf[i], 1);
            }
            return treeDic;
        }
    }
}
