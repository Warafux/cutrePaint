Public Class drawing
    Protected name As String
    Protected startPoint As Point
    Protected endPoint As Point
    Protected color As Color
    Protected shape As String
    Protected visible As Boolean = True
    Protected pen As Pen = New Pen(Color.Black)

    Public Sub New(name As String, startPoint As Point, endPoint As Point, color As Color, visible As Boolean)
        Me.name = name
        Me.startPoint = startPoint
        Me.endPoint = endPoint
        Me.color = color
        Me.visible = visible

    End Sub
    Public Sub draw(paintEvent As PaintEventArgs)
    End Sub


End Class
