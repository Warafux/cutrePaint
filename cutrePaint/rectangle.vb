Public Class rectangle
    Inherits drawing

    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color, visible As Boolean, width As Integer)
        MyBase.New(name, startPoint, endPoint, color, visible, width)

        If ((Me.endPoint.X - Me.startPoint.X) < 0 Or (Me.endPoint.Y - Me.startPoint.Y) < 0) Then
            'Problem when startPoint and endPoint are not as desired (top-left corner and bottom-right corner)
            'Solution:http://www.vbforums.com/showthread.php?566861-Rectangle-negative-integers

            Dim rectangleArea As New System.Drawing.Rectangle(Math.Min(Me.startPoint.X, Me.endPoint.X),
                          Math.Min(Me.startPoint.Y, Me.endPoint.Y),
                          Math.Abs(Me.startPoint.X - Me.endPoint.X),
                          Math.Abs(Me.startPoint.Y - Me.endPoint.Y))

            Me.startPoint = rectangleArea.Location
            Me.endPoint = New Point(rectangleArea.Location.X + rectangleArea.Width, rectangleArea.Location.Y + rectangleArea.Height)

        End If
    End Sub
    Public Overrides Sub draw(paintEvent As PaintEventArgs)
        If Not Me.visible Then
            Return
        End If

        Dim graphics = paintEvent.Graphics

        graphics.DrawRectangle(New Pen(Me.color, Me.width), Me.startPoint.X, Me.startPoint.Y, Me.endPoint.X - Me.startPoint.X, Me.endPoint.Y - Me.startPoint.Y)
    End Sub
End Class
