Imports System

Module Modal
    Sub Main(args As String())
        Dim inputdigit As Integer
        console.writeline("enter the digit")
        inputdigit = console.readline()
        Dim num(9) As Integer
        Dim input As Integer
        Dim modal As Integer
        Dim modalnum As Integer
        Dim multimodal As Integer = 0
        For count As Integer = 0 To inputdigit - 1
            Console.WriteLine("input the {0} digit", count + 1)
            input = Console.ReadLine()
            num(input) += 1
        Next
        For coun As Integer = 1 To 9
            If num(coun) > num(coun - 1) Then
                modal = num(coun)
            End If
            ' use elseif num(coun) = num(coun -1) to skip those multimodal checking part
        Next
        For con As Integer = 0 To 9
            If num(con) = modal Then
                multimodal += 1
                modalnum = con
            End If
        Next
        If multimodal = 1 Then
            Console.WriteLine("THe number {0} has appear {1}times", modalnum, modal)
        Else
            Console.WriteLine("the number is multimodal")
        End If
        Console.ReadLine()
    End Sub
End Module
