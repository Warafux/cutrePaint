Public Class line
    Inherits drawing

    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color)
        MyBase.New(name, startPoint, endPoint, color, True)

    End Sub
    Public Overrides Sub draw(paintEvent As PaintEventArgs)
        If Not Me.visible Then
            Return
        End If

        Dim graphics = paintEvent.Graphics
        Console.WriteLine("Drawing " + Me.name)
        graphics.DrawLine(Me.pen, Me.startPoint, Me.endPoint)
    End Sub
End Class
