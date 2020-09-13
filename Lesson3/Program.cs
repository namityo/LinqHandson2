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
            //_cacheCountryName;


            // 結果表示
            Console.WriteLine(string.Format("JP {0}", _cacheCountryName["JP"]));
            Console.ReadKey();
        }
    }
}
