Public Class Form1
    Private point1 As Point = New Point(0, 0)
    Private point2 As Point = New Point(0, 0)
    Private isClicking As Boolean = False
    Private mouseButton As MouseButtons
    Private cnt_graphics As Graphics
    Private tmp_graphics As Graphics
    Private backgroundColor As Color = Color.White

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'Evaluates input as
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

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If (isClicking) Then
            'If is clicking already, don't do anything
            Return
        End If

        point1 = e.Location
        isClicking = True
        mouseButton = e.Button

    End Sub
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If (isClicking And mouseButton.ToString.Equals(e.Button.ToString)) Then
            'If is clicking and the first button clicked is the same as the clicked at this event (e)
            point2 = e.Location
            'Me.Text = "Line:" + point1.ToString + " TO " + point2.ToString
            Me.Text = "Línia de " + point1.ToString + " fins a " + point2.ToString + " amb click " + e.Button.ToString
            isClicking = False

            cnt_graphics.DrawLine(New Pen(Color.Black), point1, point2)
        End If


    End Sub

    Private Function invertString(str As String)
        Dim invertedString As String = ""
        Dim strToArray As Array = str.ToCharArray
        For i As Integer = (str.Count - 1) To 0 Step -1
            invertedString = invertedString + strToArray.GetValue(i)
        Next i

        Return invertedString
    End Function

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Text = "Nou tamany: " + Me.Width.ToString + " x " + Me.Height.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnt_graphics = CreateGraphics()
        cnt_graphics.Clear(backgroundColor)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

    End Sub
End Class
