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
            var str = population;


            // 結果表示
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
