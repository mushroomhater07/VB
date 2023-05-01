Module GuessWord

    Sub Main()
        Console.WriteLine("ENTER THE FIRST WORD")
        Dim input As String = Console.ReadLine()
        Console.WriteLine("ENTER THE SECOND WORD")
        Dim input2 As String = Console.ReadLine()
        Dim accept As Boolean = True
        For coount As Integer = 0 To input.Length - 1
            If input2.IndexOf(input(coount)) = -1 Then
                accept = False
            End If
        Next
        If accept = True Then
            Console.WriteLine("OK")
        Else
            Console.WriteLine("Not OK")
        End If
        Console.ReadLine()
    End Sub

End Module
