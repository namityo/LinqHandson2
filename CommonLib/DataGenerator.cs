using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson2
{
    public class DataGenerator
    {
        public static IEnumerable<string> GetCountryTsv()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LinqHandson2.country_codes.tsv"))
            using (var sr = new System.IO.StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    yield return sr.ReadLine();
                }
            }
        }

        public static IEnumerable<string> GetPopulationTsv()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("LinqHandson2.population.tsv"))
            using (var sr = new System.IO.StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    yield return sr.ReadLine();
                }
            }
        }
    }
}
