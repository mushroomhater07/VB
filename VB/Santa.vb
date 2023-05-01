Module Santa
    Dim naughty(10000) As String
    Dim currentnaughty As Integer = -1
    Dim nice(10000) As String
    Dim currentnice As Integer = -1
    Sub Main()
        Dim choose As Integer
        Dim wronginput As Boolean = False
        'Additional function:
        ' it can search within both nice and naughty list
        ' and search multiple same name in same list
        ' store location in desktop (must be able to access)
        ' counting when print list
        ' clear UI and easy to understand
        Do
            Do
                choose = Menu(wronginput)
                Select Case choose
                    Case 1
                        wronginput = False
                        Inputnaughty()
                    Case 2
                        wronginput = False
                        Inputnice()
                    Case 3
                        wronginput = False
                        Printnaughty()
                    Case 4
                        wronginput = False
                        Printnice()
                    Case 5
                        wronginput = False
                        Printnaughty()
                        Printnice()
                    Case 6
                        wronginput = False
                        Search()
                    Case 7
                        wronginput = False
                        Output()
                    Case 0
                        Exit Sub
                    Case Else
                        wronginput = True
                End Select
            Loop Until wronginput = False
            Console.WriteLine("Program finished, Press Enter to open menu")
            Console.ReadLine()
            Console.Clear()
        Loop
    End Sub
    Function Menu(ByRef wronginput As Boolean)
        Dim input As Integer
        If wronginput = False Then
            Console.WriteLine("1.Input naughty list")
            Console.WriteLine("2.Input nice list")
            Console.WriteLine("3.Show naughty list")
            Console.WriteLine("4.Show nice list")
            Console.WriteLine("5.Show Full list")
            Console.WriteLine("6.Search for certain person")
            Console.WriteLine("7.Output as text file")
            Console.WriteLine("0.Exit")
            Console.WriteLine("Enter the number correspond to the option")
        Else
            Console.WriteLine("Wrong Input, Enter again!!")
        End If
        input = Console.ReadLine()
        Return input
    End Function
    Sub Inputnaughty()
        Dim input As String
        currentnaughty += 1
        Console.WriteLine("enter the naughty name [{0}]", currentnaughty + 1)
        input = Console.ReadLine()
        naughty(currentnaughty) = input
    End Sub
    Sub Inputnice()
        Dim input As String
        currentnice += 1
        Console.WriteLine("enter the nice name [{0}]", currentnice + 1)
        input = Console.ReadLine()
        nice(currentnice) = input
    End Sub
    Sub Printnaughty()
        Console.WriteLine("naughty list:")
        For count As Integer = 0 To currentnaughty
            Console.WriteLine("{0}: {1}", count + 1, naughty(count))
        Next
    End Sub
    Sub Printnice()
        Console.WriteLine("nice list:")
        For count As Integer = 0 To currentnice
            Console.WriteLine("{0}: {1}", count + 1, nice(count))
        Next
    End Sub
    Sub Search()
        Dim cutnaughty() As String = naughty
        Dim cutnice() As String = nice
        Dim input As String
        Console.WriteLine("Enter the name you want to search")
        input = Console.ReadLine()
        Dim searchniceresult As Integer = Array.IndexOf(cutnice, input)
        Dim searchnaughtyresult As Integer = Array.IndexOf(cutnaughty, input)
        If searchnaughtyresult = -1 Then
            Console.WriteLine("Not found in naughty list")
        Else
            Console.WriteLine("{0} in naughty list founded", input)
            Do Until searchnaughtyresult = -1
                Console.WriteLine("{0}: {1}", searchnaughtyresult + 1, naughty(searchnaughtyresult))
                Array.Clear(cutnaughty, searchnaughtyresult, 1)
                searchnaughtyresult = Array.IndexOf(cutnaughty, input)
            Loop
        End If
        If searchniceresult = -1 Then
            Console.WriteLine("Not found in nice list")
        Else
            Do Until searchniceresult = -1
                Console.WriteLine("{0} in nice list founded", input)
                Console.WriteLine("{0}: {1}", searchniceresult + 1, nice(searchniceresult))
                Array.Clear(cutnice, searchniceresult, 1)
                searchniceresult = Array.IndexOf(cutnice, input)
            Loop
        End If
    End Sub
    Sub Output()
        Dim file As System.IO.StreamWriter
        Dim input As String
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Console.WriteLine("input the save file name which saved in {0}", path)
        input = Console.ReadLine()
        Dim filelocation As String = String.Concat(path, "\", input, ".txt")
        file = My.Computer.FileSystem.OpenTextFileWriter(filelocation, True)
        file.WriteLine("naughty list:")
        For count As Integer = 0 To currentnaughty
            file.WriteLine("{0}: {1}", count + 1, naughty(count))
        Next
        file.WriteLine("nice list:")
        For count As Integer = 0 To currentnice
            file.WriteLine("{0}: {1}", count + 1, nice(count))
        Next
        file.Close()
    End Sub
End Module
