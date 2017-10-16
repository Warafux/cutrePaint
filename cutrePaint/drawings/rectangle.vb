Public Class rectangle
    Inherits drawing

    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color, visible As Boolean, width As Integer)
        MyBase.New(name, startPoint, endPoint, color, visible, width)

    End Sub
    Public Overrides Sub draw(paintEvent As PaintEventArgs)
        If Not Me.visible Then
            Return
        End If

        Dim graphics = paintEvent.Graphics


        Dim startPointFix = Me.startPoint
        Dim endPointFix = Me.endPoint

        'Fix coordenates
        If ((Me.endPoint.X - Me.startPoint.X) < 0 Or (Me.endPoint.Y - Me.startPoint.Y) < 0) Then
            'Problem when startPoint and endPoint are not as desired (top-left corner and bottom-right corner)
            'Solution:http://www.vbforums.com/showthread.php?566861-Rectangle-negative-integers

            Dim rectangleArea As New System.Drawing.Rectangle(Math.Min(Me.startPoint.X, Me.endPoint.X),
                          Math.Min(Me.startPoint.Y, Me.endPoint.Y),
                          Math.Abs(Me.startPoint.X - Me.endPoint.X),
                          Math.Abs(Me.startPoint.Y - Me.endPoint.Y))

            startPointFix = rectangleArea.Location
            endPointFix = New Point(rectangleArea.Location.X + rectangleArea.Width, rectangleArea.Location.Y + rectangleArea.Height)

        End If

        Graphics.DrawRectangle(New Pen(Me.color, Me.width), startPointFix.X, startPointFix.Y, endPointFix.X - startPointFix.X, endPointFix.Y - startPointFix.Y)
    End Sub
End Class
