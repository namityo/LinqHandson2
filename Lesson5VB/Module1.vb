Module Module1

    Sub Main()
        ' CSV読み込み
        Dim population = DataGenerator.GetPopulationTsv()


        ' ここに書く
        Dim str = population


        ' 結果表示
        Console.WriteLine(str)
        Console.ReadKey()
    End Sub

End Module
