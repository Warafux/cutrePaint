Public Class drawing
    Protected name As String
    Protected startPoint As Point
    Protected endPoint As Point
    Protected color As Color
    Protected shape As String
    Protected visible As Boolean = True
    Protected width As Integer = 1

    Public Sub New()
        'Empty drawing
    End Sub
    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color, visible As Boolean, width As Integer)
        Me.name = name
        Me.startPoint = startPoint
        Me.endPoint = endPoint
        Me.color = color
        Me.visible = visible
        Me.width = width
    End Sub
    Public Overridable Sub draw(paintEvent As PaintEventArgs)

    End Sub
    Public Function getName()
        Return Me.name
    End Function
    Public Sub setEndPoint(endPoint As Point)
        Me.endPoint = endPoint
    End Sub
End Class
