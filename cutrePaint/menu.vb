Public Class menu
    Private drawForm As drawForm
    Private chosenColor As Color = Color.Black
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drawForm = My.Forms.drawForm
    End Sub

    Public Sub updateList(drawings As List(Of drawing))
        listView_drawings.Items.Clear()
        listView_drawings.Clear()

        For i As Integer = 0 To drawings.Count - 1 Step 1
            listView_drawings.Items.Add(i.ToString, drawings(i).getName, 0)
        Next
        For Each drawing In drawings

        Next
    End Sub

    Private Sub listView_drawings_MouseClick(sender As Object, e As MouseEventArgs) Handles listView_drawings.MouseClick
        Dim selectedItems As ListView.SelectedIndexCollection = listView_drawings.SelectedIndices
        For Each selectedItemIndex In selectedItems
            drawForm.eraseDrawing(selectedItemIndex)
        Next
    End Sub

    Private Sub button_eraseAll_Click(sender As Object, e As EventArgs) Handles button_eraseAll.Click
        drawForm.eraseAllDrawings()
    End Sub

    Private Sub button_chooseColor_Click(sender As Object, e As EventArgs) Handles button_chooseColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            chosenColor = ColorDialog1.Color
        End If

    End Sub
    Public Function getChosenColor()
        Return Me.chosenColor
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_colorRed.Click
        chosenColor = DirectCast(sender, Button).BackColor
    End Sub

    Private Sub button_colorLime_Click(sender As Object, e As EventArgs) Handles button_colorLime.Click
        chosenColor = DirectCast(sender, Button).BackColor
    End Sub

    Private Sub button_colorBlue_Click(sender As Object, e As EventArgs) Handles button_colorBlue.Click
        chosenColor = DirectCast(sender, Button).BackColor
    End Sub

    Private Sub button_colorBlack_Click(sender As Object, e As EventArgs) Handles button_colorBlack.Click
        chosenColor = DirectCast(sender, Button).BackColor
    End Sub
End Class