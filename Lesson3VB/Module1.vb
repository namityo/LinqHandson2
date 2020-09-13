Module Module1

    Private _cacheCountryName As New Dictionary(Of String, String)

    Sub Main()
        ' CSV読み込み
        Dim country = DataGenerator.GetCountryTsv()


        ' ここに書く
        '_cacheCountryName


        '結果表示
        Console.WriteLine(String.Format("JP {0}", _cacheCountryName("JP")))
        Console.ReadKey()
    End Sub

End Module
