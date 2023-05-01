Module DateOfBirth

    Sub Main()
        Console.WriteLine("Enter date of birth as separate integers for year, then month, then day")
        Dim iyear, iday, imonth As String
        Dim DOB As Date
        Dim nowdate As Date = Date.Now
        Dim year As Integer = nowdate.Year
        Dim month As Integer = nowdate.Month
        Dim day As Integer = nowdate.Day
        Console.WriteLine("Please enter the year you were born:")
        iyear = Console.ReadLine()
        Do While iyear > year Or iyear < 1900
            Console.WriteLine("I dont think that can be possible Please try again")
            iyear = Console.ReadLine()
        Loop
        Dim leap As Boolean = Date.IsLeapYear(iyear)
        Console.WriteLine("Please enter the month you were born:")
        imonth = Console.ReadLine()
        Do While imonth >= 13 Or imonth < 1 Or (year = iyear And imonth > month)
            Console.WriteLine("Please enter the month number between 1 and 12")
            imonth = Console.ReadLine()
        Loop
        Console.WriteLine("Please enter the day you were born:")
        iday = Console.ReadLine()
        Do While iday > Date.DaysInMonth(iyear, imonth) Or iday < 1 Or (year = iyear And month = imonth And iday > day) Or (leap = True And month = 2 And day > 27) Or (leap = False And month = 2 And day > 28)
            Console.WriteLine("Please enter valid day number")
            iday = Console.ReadLine()
        Loop
        Console.WriteLine("Your DOB has been validated and is:{0}/{1}/{2}", iday, imonth, iyear)
        Console.ReadLine()
    End Sub

End Module
