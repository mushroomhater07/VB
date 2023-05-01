Module Dict

    Sub Main()
        Dim dict As New Dictionary(Of String, Integer)
        dict.Add("hello", 20)               'add value
        dict.Clear() 'clear all
        Dim result As Integer = 0
        dict("hello") = 25                  'modify
        dict.TryGetValue("hello", result)   'lookup
        Console.WriteLine(result)
        dict.Remove("hello")                'remove
        Console.Read()
    End Sub

End Module
