Module Stack
    Sub Main()
        Dim st As Collections.Stack = New Collections.Stack()
        st.Push("4")
        st.Push("3")
        st.Push("2")
        st.Push("1")
        Console.WriteLine("Current stack: ")
        Dim c As Char

        For Each c In st
            Console.WriteLine(" " + c)
        Next c
        Console.WriteLine()
        st.Push("5")
        Console.WriteLine("The next poppable value in stack: {0}", st.Peek())
        st.Push("6")
        Console.WriteLine("The next poppable value in stack: {0}", st.Peek())
        Console.WriteLine("Current stack: ")

        For Each c In st
            Console.WriteLine(" " + c)
        Next c
        Dim ch As Integer
        Console.WriteLine()
        Console.WriteLine("Removing values ")
        Console.WriteLine(st.Pop())
        Console.WriteLine(st.Pop())
        Console.WriteLine(st.Pop())
        Console.WriteLine("Current stack: ")

        For Each c In st
            Console.WriteLine(" " + c)
        Next c
        Console.ReadKey()

    End Sub

End Module
