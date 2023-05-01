Imports System

Module Sum
    Sub Main(args As String())
        Console.WriteLine("Enter your number")
        Dim num As Integer = Console.ReadLine()
        Console.WriteLine(SumTo(num))
        Console.ReadLine()
    End Sub
    Function SumTo(ByVal x As Integer)
        If x = 0 Or x = 1 Then

        Else
            x = x * SumTo(x - 1)
        End If
        Return x
    End Function
End Module
