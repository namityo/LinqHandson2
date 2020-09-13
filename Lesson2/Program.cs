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
            var country = DataGenerator.GetCountryTsv();


            // ここに書く
            var results = country
                .Select(l => l.Split('\t'))
                .Where(s => s.Length == 3)
                .Select(s => new { 国名コード = s[0], 国名 = s[1], 日本語名 = s[2] });


            // 結果表示
            foreach (var ci in results)
            {
                Console.WriteLine(string.Format("[{0}] {1}", ci.国名コード, ci.日本語名));
            }
            Console.ReadKey();
        }
    }
}
