Module OOP3

    Sub Main()
        Dim studentenrollleddd As Integer
        Dim Mystudent As New Student()
        Mystudent.AddStudent("9hey", "on9")
        Mystudent.AddStudent("wtf", "theHK")
        studentenrollleddd = Mystudent.NoOfStudentEnrolled()


        ' below is just for the test class
        Test.Write()
        Dim mytext As New Test
        mytext.WriteClassMethod()
        Console.Read()
    End Sub



Class Test
    Public Shared Sub Write() 'as staic in c# and java
        Console.WriteLine("Shared Sub called")
    End Sub
    Public Sub WriteClassMethod()
        Console.WriteLine("Class Method called")
    End Sub
End Class

Interface Studentinfo
    Sub AddStudent(FirstName As String, Lastname As String)
    Function NoOfStudentEnrolled() As Integer
    Sub DisplayInfo()
End Interface

Public Class Student : Implements Studentinfo

    Private FirstName, LastName As String
    Private StudentEnrolled As Integer = 0

    Public Sub New()

    End Sub


    Public Sub AddStudent(FirstName As String, Lastname As String) Implements Studentinfo.AddStudent
        Me.FirstName = FirstName
        Me.LastName = Lastname
        StudentEnrolled += 1
        DisplayInfo()
        'Throw New NotImplementedException()
    End Sub

    Public Sub DisplayInfo() Implements Studentinfo.DisplayInfo
        Console.WriteLine("student, {0} {1}", FirstName, LastName)
    End Sub

    Public Function NoOfStudentEnrolled() As Integer Implements Studentinfo.NoOfStudentEnrolled
        Console.WriteLine("NumberOFstudent {0}", StudentEnrolled)
        Return StudentEnrolled
        'Throw New NotImplementedException()
    End Function
End Class
End Module