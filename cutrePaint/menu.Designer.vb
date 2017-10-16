<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listView_drawings = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button_eraseAll = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.button_chooseColor = New System.Windows.Forms.Button()
        Me.button_colorRed = New System.Windows.Forms.Button()
        Me.button_colorBlue = New System.Windows.Forms.Button()
        Me.button_colorLime = New System.Windows.Forms.Button()
        Me.button_colorBlack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numericUpDown_chosenWidth = New System.Windows.Forms.NumericUpDown()
        CType(Me.numericUpDown_chosenWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listView_drawings
        '
        Me.listView_drawings.GridLines = True
        Me.listView_drawings.Location = New System.Drawing.Point(12, 55)
        Me.listView_drawings.Name = "listView_drawings"
        Me.listView_drawings.Size = New System.Drawing.Size(193, 395)
        Me.listView_drawings.TabIndex = 0
        Me.listView_drawings.UseCompatibleStateImageBehavior = False
        Me.listView_drawings.View = System.Windows.Forms.View.Tile
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.29!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of drawings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Click to erase"
        '
        'button_eraseAll
        '
        Me.button_eraseAll.Location = New System.Drawing.Point(12, 466)
        Me.button_eraseAll.Name = "button_eraseAll"
        Me.button_eraseAll.Size = New System.Drawing.Size(193, 35)
        Me.button_eraseAll.TabIndex = 3
        Me.button_eraseAll.Text = "Erase ALL"
        Me.button_eraseAll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 16.29!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 513)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Colors"
        '
        'button_chooseColor
        '
        Me.button_chooseColor.Location = New System.Drawing.Point(12, 596)
        Me.button_chooseColor.Name = "button_chooseColor"
        Me.button_chooseColor.Size = New System.Drawing.Size(194, 36)
        Me.button_chooseColor.TabIndex = 5
        Me.button_chooseColor.Text = "Choose color"
        Me.button_chooseColor.UseVisualStyleBackColor = True
        '
        'button_colorRed
        '
        Me.button_colorRed.BackColor = System.Drawing.Color.Red
        Me.button_colorRed.ForeColor = System.Drawing.Color.Red
        Me.button_colorRed.Location = New System.Drawing.Point(111, 546)
        Me.button_colorRed.Name = "button_colorRed"
        Me.button_colorRed.Size = New System.Drawing.Size(48, 44)
        Me.button_colorRed.TabIndex = 6
        Me.button_colorRed.UseVisualStyleBackColor = False
        '
        'button_colorBlue
        '
        Me.button_colorBlue.BackColor = System.Drawing.Color.Blue
        Me.button_colorBlue.ForeColor = System.Drawing.Color.Blue
        Me.button_colorBlue.Location = New System.Drawing.Point(165, 546)
        Me.button_colorBlue.Name = "button_colorBlue"
        Me.button_colorBlue.Size = New System.Drawing.Size(40, 44)
        Me.button_colorBlue.TabIndex = 7
        Me.button_colorBlue.UseVisualStyleBackColor = False
        '
        'button_colorLime
        '
        Me.button_colorLime.BackColor = System.Drawing.Color.Lime
        Me.button_colorLime.ForeColor = System.Drawing.Color.Lime
        Me.button_colorLime.Location = New System.Drawing.Point(57, 546)
        Me.button_colorLime.Name = "button_colorLime"
        Me.button_colorLime.Size = New System.Drawing.Size(48, 44)
        Me.button_colorLime.TabIndex = 8
        Me.button_colorLime.UseVisualStyleBackColor = False
        '
        'button_colorBlack
        '
        Me.button_colorBlack.BackColor = System.Drawing.Color.Black
        Me.button_colorBlack.ForeColor = System.Drawing.Color.Black
        Me.button_colorBlack.Location = New System.Drawing.Point(12, 546)
        Me.button_colorBlack.Name = "button_colorBlack"
        Me.button_colorBlack.Size = New System.Drawing.Size(39, 44)
        Me.button_colorBlack.TabIndex = 9
        Me.button_colorBlack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 16.29!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 644)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Shape Width"
        '
        'numericUpDown_chosenWidth
        '
        Me.numericUpDown_chosenWidth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numericUpDown_chosenWidth.Location = New System.Drawing.Point(15, 687)
        Me.numericUpDown_chosenWidth.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericUpDown_chosenWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown_chosenWidth.Name = "numericUpDown_chosenWidth"
        Me.numericUpDown_chosenWidth.Size = New System.Drawing.Size(190, 16)
        Me.numericUpDown_chosenWidth.TabIndex = 11
        Me.numericUpDown_chosenWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 743)
        Me.Controls.Add(Me.numericUpDown_chosenWidth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.button_colorBlack)
        Me.Controls.Add(Me.button_colorLime)
        Me.Controls.Add(Me.button_colorBlue)
        Me.Controls.Add(Me.button_colorRed)
        Me.Controls.Add(Me.button_chooseColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.button_eraseAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listView_drawings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(0, 50)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CutrePaint Menu"
        Me.TopMost = True
        CType(Me.numericUpDown_chosenWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listView_drawings As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents button_eraseAll As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents button_chooseColor As Button
    Friend WithEvents button_colorRed As Button
    Friend WithEvents button_colorBlue As Button
    Friend WithEvents button_colorLime As Button
    Friend WithEvents button_colorBlack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents numericUpDown_chosenWidth As NumericUpDown
End Class
