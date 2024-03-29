﻿Public Class circle
    Inherits drawing

    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color, visible As Boolean, width As Integer)
        MyBase.New(name, startPoint, endPoint, color, visible, width)

    End Sub
    Public Overrides Sub draw(paintEvent As PaintEventArgs)
        If Not Me.visible Then
            Return
        End If

        Dim graphics = paintEvent.Graphics

        graphics.DrawEllipse(New Pen(Me.color, Me.width), Me.startPoint.X, Me.startPoint.Y, Me.endPoint.X - Me.startPoint.X, Me.endPoint.Y - Me.startPoint.Y)
    End Sub
End Class
