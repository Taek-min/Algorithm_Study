using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _20230207
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            sw.AutoFlush = true;
            List<Axis> axisList = new List<Axis>();
            int loop = int.Parse(sr.ReadLine());
            for(int i = 0; i < loop; i++)
            {
                var info = new Axis();
                info.input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                info.X_axis = info.input[0];
                info.Y_axis = info.input[1];
                axisList.Add(info);
            }
            axisList = axisList.OrderBy(x => x.X_axis).ThenBy(x => x.Y_axis).ToList();
            foreach (var x in axisList) sb.AppendLine(x.X_axis + " " + x.Y_axis);
            sw.Write(sb);
        }
        public class Axis
        {
            public int[] input { get; set; }
            public int X_axis { get; set; }
            public int Y_axis { get; set; }
        }
    }
}
