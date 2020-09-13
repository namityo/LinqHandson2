using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // CSV読み込み
            var population = DataGenerator.GetPopulationTsv();


            // ここに書く
            var str = population
                .Select(l => l.Split('\t'))
                .Where(s => s.Length > 1)
                .Select(s => new { 日本語名 = s[0], 人口 = long.Parse(s[1], System.Globalization.NumberStyles.AllowThousands) })
                .OrderByDescending(p => p.人口)
                .Take(5)
                .Aggregate("", (s, p) => string.Concat(s, p.日本語名, ","));


            // 結果表示
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
