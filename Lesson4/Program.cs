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
            var results1 = country;

            var results2 = population;


            // 結果表示
            Console.WriteLine(string.Format("AU {0}", _cachePopulation["AU"]));
            Console.ReadKey();
        }
    }
}
