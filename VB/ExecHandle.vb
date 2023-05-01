Module ExecHandle

    Sub Main()
        Dim input As Integer
        Try
            Console.WriteLine("enter integer")
            input = Console.ReadLine()
        Catch a As FormatException
            Console.WriteLine("Invalid format")
        Catch a As InvalidCastException
            Console.WriteLine("???")
        Catch e As Exception
            Console.WriteLine("Error")
        Finally
            Console.WriteLine("Done")
        End Try
        Console.ReadLine()

    End Sub

End Module
