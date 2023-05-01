Module Bisector
    Dim a, b, c As Single
    Dim fa, fb, fc, positivefc As Single
    Dim count As Integer = 0
    Const maxiteration As Integer = 100
    Const tol As Single = 0.000000000001
    Sub Main()
        Console.WriteLine("input a")
        a = Console.ReadLine()
        Console.WriteLine("input b")
        b = Console.ReadLine()
        putitin()
        Do While positivefc > tol And count < maxiteration
            putitin()
            Console.WriteLine("a:{0} b:{1} c:{2} count:{3}", a, b, c, count)
        Loop
        Console.WriteLine("midpoint {0}", c)
        Console.ReadLine()
    End Sub
    Function func(px As Single)
        Dim total As Single
        total = px * px * px - px - 2
        Return total
    End Function
    Sub putitin()
        Dim total As Single
        Dim ac, bc As Single
        total = a + b
        c = total / 2
        fa = func(a)
        fb = func(b)
        fc = func(c)
        ac = fa * fc
        bc = fb * fc
        If ac < 0 Then
            b = c
        End If
        If bc < 0 Then
            a = c
        End If
        positivefc = Math.Abs(fc)
        count += 1
        Console.WriteLine("a{0} b{1} c{2} f(a){3} f(b){4} f(c){5} count{6} ", a, b, c, fa, fb, fc, count)
    End Sub

End Module
