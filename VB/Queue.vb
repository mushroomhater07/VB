Module Queue
    Sub Main()
        Dim list As System.Collections.Queue = New System.Collections.Queue()
        list.Enqueue("1")
        list.Enqueue("2")
        list.Enqueue("3")
        list.Enqueue("4")
        Console.WriteLine("Current queue: ")
        Dim c As Char
        For Each c In list
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        list.Enqueue("5")
        list.Enqueue("6")
        Console.WriteLine("Current queue: ")

        For Each c In list
            Console.Write(c + " ")
        Next c
        Console.WriteLine()
        Console.WriteLine("Removing some values ")
        Dim ch As Char
        ch = list.Dequeue()
        Console.WriteLine("The removed value: {0}", ch)
        ch = list.Dequeue()
        Console.WriteLine("The removed value: {0}", ch)
        Console.WriteLine("Current queue: ")

        For Each c In list
            Console.Write(c + " ")
        Next c
        Console.ReadKey()
    End Sub
End Module
