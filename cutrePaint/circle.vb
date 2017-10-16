Public Class circle
    Inherits drawing

    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color)
        MyBase.New(name, startPoint, endPoint, color, True)

    End Sub
    Public Overrides Sub draw(paintEvent As PaintEventArgs)
        If Not Me.visible Then
            Return
        End If

        Dim graphics = paintEvent.Graphics

        graphics.DrawEllipse(Me.pen, Me.startPoint.X, Me.startPoint.Y, Me.endPoint.X - Me.startPoint.X, Me.endPoint.Y - Me.startPoint.Y)
    End Sub
End Class
