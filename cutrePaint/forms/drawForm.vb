Public Class drawForm
    Private point1 As Point = New Point(0, 0)
    Private point2 As Point = New Point(0, 0)
    Private isClicking As Boolean = False
    Private mouseButton As MouseButtons
    Private isCtrlPressed As Boolean = False
    Private isAltPressed As Boolean = False
    Private drawings As List(Of drawing) = New List(Of drawing)

    Private menu As menu = My.Forms.menu

    Private tmp_drawing As drawing

    Private backgroundColor As Color = Color.White
    Private highQuality As Boolean = False

    Private counter_lines As Integer = 0
    Private counter_rectangles As Integer = 0
    Private counter_circles As Integer = 0

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'Evaluates input as uppercase because Keys.I is treated as uppercase (wtf?)
        Select Case (e.KeyChar.ToString.ToUpper.Chars(0))
            Case Microsoft.VisualBasic.ChrW(Keys.Return), Microsoft.VisualBasic.ChrW(Keys.I), Microsoft.VisualBasic.ChrW(Keys.L)
                'Keys.Return = ENTER
                Me.Text = invertString(Me.Text)
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                'Keys.Escape = ESCAPE
                Me.Text = ""
            Case Microsoft.VisualBasic.ChrW(Keys.Delete), Microsoft.VisualBasic.ChrW(Keys.Back), Microsoft.VisualBasic.ChrW(Keys.I)
                'If Me.Text is empty, be careful
                Me.Text = Me.Text.Substring(0, (If(Me.Text.Count = 0, 0, Me.Text.Count - 1)))
            Case Else
                Me.Text = Me.Text + e.KeyChar

        End Select
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.SmoothingMode = If(highQuality, Drawing2D.SmoothingMode.HighQuality, Drawing2D.SmoothingMode.Default)
        'drawings
        For Each drawing In drawings
            drawing.draw(e)
        Next
        'tmp_drawing
        If isClicking Then
            tmp_drawing.draw(e)
        End If

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If (isClicking) Then
            'If is clicking already, don't do anything
            Return
        End If

        point1 = e.Location
        isClicking = True
        mouseButton = e.Button
        Select Case (getDrawMode())
            Case "l"
                tmp_drawing = New line("TMP LINE", point1, point1, menu.getChosenColor, True, menu.getChosenWidth)
            Case "c"
                tmp_drawing = New rectangle("TMP RECTANGLE", point1, point1, menu.getChosenColor, True, menu.getChosenWidth)
            Case "r"
                tmp_drawing = New circle("TMP CIRCLE", point1, point1, menu.getChosenColor, True, menu.getChosenWidth)
        End Select

    End Sub
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            menu.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            menu.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Minimized Then
            'Minimize the menu
            menu.WindowState = FormWindowState.Minimized
        End If
    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If (isClicking And mouseButton.ToString.Equals(e.Button.ToString)) Then
            'If is clicking and the first button clicked is the same as the clicked at this event (e)
            point2 = e.Location
            'Me.Text = "Line:" + point1.ToString + " TO " + point2.ToString
            Me.Text = "Línia de " + point1.ToString + " fins a " + point2.ToString + " amb click " + e.Button.ToString
            isClicking = False
            Select Case (getDrawMode())
                Case "l"
                    drawings.Add(New line("LINE " + counter_lines.ToString, point1, point2, menu.getChosenColor, True, menu.getChosenWidth))
                    counter_lines = counter_lines + 1
                Case "c"
                    drawings.Add(New rectangle("RECTANGLE " + counter_rectangles.ToString, point1, point2, menu.getChosenColor, True, menu.getChosenWidth))
                    counter_rectangles = counter_rectangles + 1
                Case "r"
                    drawings.Add(New circle("CIRCLE " + counter_circles.ToString, point1, point2, menu.getChosenColor, True, menu.getChosenWidth))
                    counter_circles = counter_circles + 1
            End Select
        End If
        updateAll()
    End Sub

    Private Function invertString(str As String)
        Dim invertedString As String = ""
        Dim strToArray As Array = str.ToCharArray
        For i As Integer = (str.Count - 1) To 0 Step -1
            invertedString = invertedString + strToArray.GetValue(i)
        Next i

        Return invertedString
    End Function
    Private Function getDrawMode()
        If isAltPressed And (Not isCtrlPressed) Then
            Return "c"
        ElseIf (Not isAltPressed) And isCtrlPressed Then
            Return "r"
        Else
            Return "l"
        End If
    End Function

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Text = "Nou tamany: " + Me.Width.ToString + " x " + Me.Height.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmp_drawing = New drawing()
        'open menu form
        My.Forms.menu.Show()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isClicking Then
            tmp_drawing.setEndPoint(e.Location)
            updateAll()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        isAltPressed = e.Alt
        isCtrlPressed = e.Control
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        isAltPressed = e.Alt
        isCtrlPressed = e.Control
    End Sub

    Private Sub updateAll()
        'refresh paint screen
        Me.Refresh()

        If Not isClicking Then
            'update menu drawings list only when user finishes clicking
            menu.updateList(drawings)
        End If

    End Sub
    Public Sub eraseDrawing(index As Integer)
        Try
            drawings.RemoveAt(index)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        updateAll()
    End Sub
    Public Sub eraseAllDrawings()
        drawings.Clear()
        updateAll()
    End Sub
End Class
