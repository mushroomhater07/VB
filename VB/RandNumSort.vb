Module RandNumSort

    Sub Main()
        Dim num(99) As Integer
        Dim k, count, b, i As Integer
        Randomize()
        For i = 0 To 99
            num(i) = int(Rnd() * 100) + 1
        Next
        Array.Sort(num)
        For i = 10 To 100 Step 10

            count = 0
            b = i - 9
            Console.WriteLine("the numbers in the range {0} - {1} are:", b, i)

            Do
                count += 1
                Console.Write(num(k) & " ")
                k += 1
            Loop While num(k) <= i
            Console.WriteLine(" - {0} numbers", count)
        Next
        Console.ReadLine()

    End Sub

End Module
