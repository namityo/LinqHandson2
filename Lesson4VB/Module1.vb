Module Module1

    Private _cachePopulation As New Dictionary(Of String, Long)

    Sub Main()
        ' CSV読み込み
        Dim country = DataGenerator.GetCountryTsv()
        Dim population = DataGenerator.GetPopulationTsv()


        ' ここに書く
        Dim results1 = country _
            .Select(Function(l) l.Split(vbTab)) _
            .Where(Function(s) s.Length > 2) _
            .Select(Function(s) New With {.国名コード = s(0), .国名 = s(1), .日本語名 = s(2)})

        Dim results2 = population _
            .Select(Function(l) l.Split(vbTab)) _
            .Where(Function(s) s.Length > 1) _
            .Select(Function(s) New With {.日本語名 = s(0), .人口 = Long.Parse(s(1), System.Globalization.NumberStyles.AllowThousands)})

        Dim results3 = results1.Join(results2,
                Function(r1) r1.日本語名,
                Function(r2) r2.日本語名,
                Function(r1, r2) New With {r1, r2})

        _cachePopulation = results3 _
            .Select(Function(j) New With {j.r1.国名コード, j.r2.人口}) _
            .ToDictionary(Function(p) p.国名コード, Function(p) p.人口)

        ' 結果表示
        Console.WriteLine(String.Format("AU {0}", _cachePopulation("AU")))
        Console.ReadKey()
    End Sub

End Module
