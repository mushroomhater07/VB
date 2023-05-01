Module ISBN

    Sub Main()
        Dim ISBN(13) As Integer
        Dim count As Integer
        Dim calculatedDigit As Integer
        For count = 1 To 13
            Console.WriteLine("Please enter next digit of ISBN")
            ISBN(count) = Console.ReadLine()
        Next
        count = 1
        Do While count < 13
            calculatedDigit += ISBN(count)
            count += 1
            calculatedDigit += ISBN(count) * 3
            count += 1
        Loop
        Do While calculatedDigit >= 10
            calculatedDigit -= 10
        Loop
        calculatedDigit = 10 - calculatedDigit
        If calculatedDigit = 10 Then
            calculatedDigit = 0
        End If
        If calculatedDigit = ISBN(13) Then
            Console.WriteLine("Valid ISBN")
        Else
            Console.WriteLine("Invalid ISBN")
        End If
        Console.ReadLine()


    End Sub

End Module
