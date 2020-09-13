Module Module1

    Sub Main()
        ' CSV読み込み
        Dim population = DataGenerator.GetPopulationTsv()


        ' ここに書く
        Dim str = population _
            .Select(Function(l) l.Split(vbTab)) _
            .Where(Function(s) s.Length > 1) _
            .Select(Function(s) New With {.日本語名 = s(0), .人口 = Long.Parse(s(1), System.Globalization.NumberStyles.AllowThousands)}) _
            .OrderByDescending(Function(p) p.人口) _
            .Take(5) _
            .Aggregate("", Function(s, p) String.Concat(s, p.日本語名, ","))


        ' 結果表示
        Console.WriteLine(str)
        Console.ReadKey()
    End Sub

End Module
