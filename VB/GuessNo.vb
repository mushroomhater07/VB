Module GuessNo

    Sub Main()
        Dim NewWord As String
        Dim UserWordGuess As String
        Console.WriteLine("The new word?")
        NewWord = Console.ReadLine()
        Console.WriteLine("Your guess?")
        UserWordGuess = Console.ReadLine()
        If UserWordGuess = NewWord Then
            Console.WriteLine("correct")
        Else
            Console.WriteLine("Incorrect")
        End If
        Console.ReadLine()
    End Sub


End Module
