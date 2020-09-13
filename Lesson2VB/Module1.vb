Module Module1

    Sub Main()
        ' CSV読み込み
        Dim country = DataGenerator.GetCountryTsv()


        ' ここに書く
        Dim results = country


        '結果表示
        For Each ci In results
            ' 国名コードと日本語の国名を出力するように書く
            Console.WriteLine(String.Format("結果出力を書く", ci))
        Next
        Console.ReadKey()
    End Sub

End Module
