Imports System

Module GuessNumber
    Sub Main(args As String())
        Console.WriteLine("Player One enter your chosen number; ")
        Dim NumberToGuess As Integer = Console.ReadLine()
        Do While (NumberToGuess < 1 Or NumberToGuess > 10)
            Console.WriteLine("not a valid choice, please enter another number")
            NumberToGuess = Console.ReadLine()
        Loop
        Dim guess As Integer = 0
        Dim numberofguess As Integer = 0
        Do While guess <> NumberToGuess And numberofguess < 5
            Console.WriteLine("Plater two have a guess: ")
            guess = Console.ReadLine()
            numberofguess = numberofguess + 1

        Loop
        If guess = NumberToGuess Then
            Console.WriteLine("player one wins")
        Else
            Console.WriteLine("player two wins")
        End If
    End Sub
End Module
