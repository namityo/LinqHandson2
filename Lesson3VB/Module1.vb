Module Module1

    Private _cacheCountryName As New Dictionary(Of String, String)

    Sub Main()
        ' CSV読み込み
        Dim country = DataGenerator.GetCountryTsv()


        ' ここに書く
        _cacheCountryName = country _
            .Select(Function(l) l.Split(vbTab)) _
            .Where(Function(s) s.Length > 2) _
            .Select(Function(s) New With {.国名コード = s(0), .国名 = s(1), .日本語名 = s(2)}) _
            .ToDictionary(Function(ci) ci.国名コード, Function(ci) ci.日本語名)


        '結果表示
        Console.WriteLine(String.Format("JP {0}", _cacheCountryName("JP")))
        Console.ReadKey()
    End Sub

End Module
