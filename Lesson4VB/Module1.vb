Module Module1

    Private _cachePopulation As New Dictionary(Of String, Long)

    Sub Main()
        ' CSV読み込み
        Dim country = DataGenerator.GetCountryTsv()
        Dim population = DataGenerator.GetPopulationTsv()


        ' ここに書く
        Dim results1 = country

        Dim results2 = population


        ' 結果表示
        Console.WriteLine(String.Format("AU {0}", _cachePopulation("AU")))
        Console.ReadKey()
    End Sub

End Module
