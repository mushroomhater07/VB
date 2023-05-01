Module MinMax

    Sub Main()
        Dim num(9) As Integer
        For i As Integer = 0 To 9
            Console.Write("{0} :", i)
            num(i) = Console.ReadLine()
        Next
        Dim max As Integer = num(0)
        Dim min As Integer = num(0)
        For Each i In num
            If i > max Then
                max = i
            ElseIf i < min Then
                min = i
            End If
        Next
        Console.WriteLine(max)
        Console.WriteLine(min)
        Console.Read()


    End Sub

End Module
