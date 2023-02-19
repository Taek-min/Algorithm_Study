using System;
using System.IO;
namespace ThisIsCShaps
{
    class Program
    {
        static StreamReader sr = new StreamReader(Console.OpenStandardInput());
        static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        static long r,l=0,mid,amount,answer=0;
        static int n, k;
        static int[] arr;
        static string[] str;


        static void Main(string[] args)
        {
           str= sr.ReadLine().Split();
            k = int.Parse(str[0]);
            n = int.Parse(str[1]);
            arr = new int[k];
            for (int i = 0; i < k; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            r = int.MaxValue;
            
            while(l<=r)
            {
                mid = (r + l) / 2;
                amount = 0;
                for (int i = 0; i < k; i++)
                {
                    amount += (arr[i] / mid);
                }
                if(amount>=n)
                {
                    answer = mid;
                    l = mid + 1;
                }
                else
                {
                   r = mid - 1;
                }
            }
            sw.Write(answer);
            sw.Close();
        }
    }
}