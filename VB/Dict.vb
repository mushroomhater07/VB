Imports System

Module Dict
    Sub Main(args As String())
        Dim dict As  new dictionary(Of String, Integer)
        dict.Add("bird",20)
        Console.Write(dict.Count)
        If dict.ContainsKey("") Then
            Console.ReadLine()
        End If                    
        
        
        
    End Sub
End Module
