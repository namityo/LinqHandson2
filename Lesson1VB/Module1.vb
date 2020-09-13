Module Module1

    Sub Main()
        ' CSV読み込み
        Dim country = DataGenerator.GetCountryTsv()


        ' ここに書く
        Dim results = country _
            .Select(Function(l) l.Split(vbTab)) _
            .Where(Function(s) s.Length > 2) _
            .Select(Function(s) New CountryInfo() With {.国名コード = s(0), .国名 = s(1), .日本語名 = s(2)})


        '結果表示
        For Each ci In results
            Console.WriteLine(String.Format("[{0}] {1}", ci.国名コード, ci.日本語名))
        Next
        Console.ReadKey()
    End Sub

End Module
