Public Class menu
    Private drawForm As Form
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drawForm = My.Forms.Form1
    End Sub

    Public Sub updateList(drawings As ArrayList)
        listView_drawings.Items.Clear()
        listView_drawings.Clear()

        For Each drawing In drawings
            listView_drawings.Items.Add(drawing.getName())
        Next
    End Sub
End Class