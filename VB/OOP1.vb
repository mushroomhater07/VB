Imports System

Module OOP1
    Sub Main(args As String())
        Dim myclinder As New Cylinder
        Dim mycircle As New Circle(0)
        Console.WriteLine("area: {0} curcm: {1}", Format(mycircle.Area(), "0.00"), Format(mycircle.circum(), "0.00"))
        Console.Write("Enter the radius =>")
        Dim radius As Double = Console.ReadLine()
        Dim mycircle1 = New Circle(4)
        Console.WriteLine("area: {0} curcm: {1}", Format(mycircle1.Area(), "0.00"), Format(mycircle1.circum(), "0.00"))
        myclinder.radius = mycircle1.radius
        Console.Write("mycylinder height: ")
        myclinder.height = Console.ReadLine()
        Console.WriteLine("area: {0}", Format(myclinder.Area(), "0.00"))
        Console.ReadLine()
    End Sub
End Module

Class Circle
    'Public radius As Integer
    Protected _radius As Double
    'Private _radius As Double 'this is topic 2 visiblity
    Public Property radius As Double
        Set(value As Double)
            _radius = value
        End Set
        Get
            Return _radius
        End Get
    End Property
    Public Function Area() As Double
        'Console.WriteLine("area(): ", _radius)
        Return (_radius ^ 2) * Math.PI
    End Function
    Public Function circum() As Double
        'Console.WriteLine("circum(): ", _radius)
        Return Math.PI * (_radius * 2)
    End Function
    Public Sub New(radius As Double)
        _radius = radius
        'Console.WriteLine("_radius: {0}", _radius)
    End Sub
End Class

Class Cylinder
    Inherits Circle

    Protected _height As Double
    Public Sub New()
        MyBase.New(1)
        'call the instructor(NEW()) from the base class
        _height = 0
    End Sub
    Public Property height As Double
        Set(value As Double)
            _height = value
        End Set
        Get
            Return _height
        End Get
    End Property

    ' method of cylinder
    Public Overloads Function Area() As Double            'what is overload base method wtffffffff
        'Console.WriteLine("radius {0} and height {1}", radius(), height())
        Dim area1 As Double = (radius() ^ 2) * Math.PI * height() ' radius() and height() are using properties so _radius _height remains private
        Return area1
    End Function
End Class