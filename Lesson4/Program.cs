using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson2
{
    class Program
    {
        static Dictionary<string, long> _cachePopulation = new Dictionary<string, long>();

        static void Main(string[] args)
        {
            // CSV読み込み
            var country = DataGenerator.GetCountryTsv();
            var population = DataGenerator.GetPopulationTsv();


            // ここに書く
            var results1 = country
                .Select(l => l.Split('\t'))
                .Where(s => s.Length > 2)
                .Select(s => new { 国名コード = s[0], 国名 = s[1], 日本語名 = s[2] });

            var results2 = population
                .Select(l => l.Split('\t'))
                .Where(s => s.Length > 1)
                .Select(s => new { 日本語名 = s[0], 人口 = long.Parse(s[1], System.Globalization.NumberStyles.AllowThousands) });

            var results3 = results1.Join(results2,
                r1 => r1.日本語名,
                r2 => r2.日本語名,
                (r1, r2) => new { r1, r2 });

            _cachePopulation = results3
                .Select(j => new { j.r1.国名コード, j.r2.人口 })
                .ToDictionary(p => p.国名コード, p => p.人口);

            // 結果表示
            Console.WriteLine(string.Format("AU {0}", _cachePopulation["AU"]));
            Console.ReadKey();
        }
    }
}
