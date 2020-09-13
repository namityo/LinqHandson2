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
            var results = country;


            // 結果表示
            foreach (var ci in results)
            {
                // 国名コードと日本語の国名を出力するように書く
                Console.WriteLine(string.Format("結果出力を書く", ci));
            }
            Console.ReadKey();
        }
    }
}
