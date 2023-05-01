Imports System

Module Fibon
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine(fib(1, 1))
        Console.ReadLine()
    End Sub

    Function fib(num1 As Integer, num2 As Integer)
        If num2 > 100 Then

        Else
            Dim num3 As Integer = num2 + num1
            Console.WriteLine(num3)
            Return fib(num2, num3)
        End If
    End Function
End Module
