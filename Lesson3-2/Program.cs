using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson2
{
    class Program
    {
        // 国名キャッシュ
        static Dictionary<string, string> _cacheCountryName = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            // CSV読み込み
            var country = DataGenerator.GetCountryTsv();


            // ここに書く
            var _cacheCountryName = country
                .Select(l => l.Split('\t'))
                .Where(s => s.Length > 2)
                .Select(s => s[0] == "KR" ? new string[] { "CR", s[1], s[2] } : s)
                .Select(s => new { 国名コード = s[0], 国名 = s[1], 日本語名 = s[2] })
                .GroupBy(ci => ci.国名コード, ci => ci)
                .Select(g => g.First())
                .ToDictionary(ci => ci.国名コード, ci => ci.日本語名);


            // 結果表示
            Console.WriteLine(string.Format("JP {0}", _cacheCountryName["JP"]));
            Console.ReadKey();
        }
    }
}
