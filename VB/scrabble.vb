Module scrabble
    Structure game
        Dim name As String
        Dim score As Integer
    End Structure
    Sub Main()
        Randomize()

        Dim letter, chac As String
        Dim score As Integer
        Dim replay As Boolean = True
        Dim total, multi As Integer
        Do Until replay = False
            Console.WriteLine("enter the words")
            letter = Console.ReadLine().ToUpper()
            For Each chac In letter
                Console.WriteLine()
                multi = Int(Rnd() * 3) + 1
                score = Scoreboard(chac)
                Console.Write("{0} with {1} score", chac, score)
                score = Multiplefunction(multi, score)
                total += score
                score = 0
            Next
            Console.WriteLine()
            Console.WriteLine("your score: {0}", total)
            replay = Replaysub()
        Loop
        Console.WriteLine("thanks for playing")
        Console.ReadLine()
    End Sub
    Function Scoreboard(x As String)
        Dim point As String
        Select Case x
            Case "D", "G"
                point = 2
            Case "B", "C", "M", "P"
                point = 3
            Case "F", "H", "V", "W", "Y"
                point = 4
            Case "K"
                point = 5
            Case "J", "X"
                point = 8
            Case "Q", "Z"
                point = 10
            Case Else
                point = 1
        End Select
        Return point
    End Function
    Function Multiplefunction(pmulti As Integer, pscore As Integer)
        Select Case pmulti
            Case 2
                pscore *= 2
                Console.Write(", and double point :{0}", pscore)
            Case 3
                pscore *= 3
                Console.Write(", and triple point :{0}", pscore)
        End Select
        Return pscore
    End Function
    Function Replaysub()
        Dim replayinput As String
        Dim chose As Boolean
        Console.WriteLine("replay? (T or F)")
        replayinput = Console.ReadLine().ToUpper()
        If replayinput = "T" Then
            chose = True
        Else
            chose = False
        End If
        Return chose
    End Function
End Module
