Imports System

Module Palindrome
    Sub Main(args As String())
        Console.WriteLine("Enter your word")
        Dim input As String = Console.ReadLine()
        Dim length As Integer = input.Length()
        Console.WriteLine(reverese(input, ""))
        Console.ReadLine()
    End Sub
    Function reverese(ByVal b As String, v As String)
        Dim leng As Integer = b.Length()
        If leng = 0 Then
            'Return ""
        Else
            v += b(leng - 1)
            'Console.WriteLine(v)
            'Return reverese(b.Substring(0, leng - 1), v)
            v = reverese(b.Substring(0, leng - 1), v)
        End If
        Return v
    End Function
End Module
