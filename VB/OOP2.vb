Imports System

Module OOP2
    Sub Main(args As String())
        Dim Response As Char
        Dim reply As Char

        While Response <> "Q"
            Console.WriteLine("Student DataBase:")
            Console.WriteLine()
            Console.WriteLine("Add a student: A")
            Console.WriteLine("View Student data: V")
            Console.WriteLine("Compute my grade: C")
            Console.WriteLine("Quit: Q")

            Console.WriteLine()
            Console.Write("ENTER YOUR CHOICE: ")
            Response = Console.ReadLine.ToUpper
            Dim Student1 As New Student
            Select Case Response
                Case "A"
                    Console.Write("Enter forename:")
                    Student1.Forename = Console.ReadLine()
                    Console.Write("Enter the surname:")
                    Student1.Surname = Console.ReadLine()
                    Console.Write("Rnter the GPA:")
                    Student1.GPA = Console.ReadLine()

                    Console.WriteLine("Entry data complete")
                    Console.ReadLine()
                    Console.Clear()
                Case "V"
                    Console.WriteLine("First Name: {0}", Student1.Forename)
                    Console.WriteLine("Sur name : {0}", Student1.Surname)
                    Console.WriteLine("GPA : {0}", Student1.GPA)
                    Console.ReadLine()
                    Console.Clear()
                Case "C"
                    Console.WriteLine("ENTRY, UnderGrade, Gradut, E, U, G")
                    Console.Write("ENTER YOUR CHOICE: ")
                    reply = Console.ReadLine.ToUpper
                    Select Case reply
                        Case "E"
                            Student1.Grade()
                        Case "U"
                            Dim UnderGrade1 As New UndeGrade
                            UnderGrade1.GPA = Student1.GPA
                            UnderGrade1.Grade()
                        Case "G"
                            Dim Gradu As New Graduate
                            Gradu.GPA = Student1.GPA
                            Gradu.Grade()
                    End Select

                    'Student1.Grade()
                    Console.ReadLine()
                    Console.Clear()
            End Select
        End While
    End Sub


Class Student
    Protected _forename As String
    Protected _surname As String
    Protected _GPA As Double
    Public Property Forename As String
        Get
            Return _forename
        End Get
        Set(value As String)
            _forename = value
        End Set
    End Property
    Public Property Surname As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property
    Public Property GPA As Double
        Get
            Return _GPA
        End Get
        Set(value As Double)
            _GPA = value
        End Set
    End Property
    Sub New()
        _GPA = 0
        _forename = " "
        _surname = ""
    End Sub
    Public Overridable Sub Grade() 'Overridable
        If GPA > 50 Then
            Console.WriteLine("stude PASS")
        Else
            Console.WriteLine("stude FAIL")
        End If
    End Sub
End Class
Class Graduate
    Inherits Student
    Public Overrides Sub Grade()
        ' have not used a construtor, only need methods
        If GPA > 75 Then
            Console.WriteLine("Gradu pass")
        Else
            Console.WriteLine("Gradu FAIL")
        End If
    End Sub
End Class
Class UndeGrade
    Inherits Student
    Public Overrides Sub Grade()
        If GPA > 65 Then
            Console.WriteLine("under PASS")
        Else
            Console.WriteLine("under FAIL")
        End If

    End Sub
End Class
End Module