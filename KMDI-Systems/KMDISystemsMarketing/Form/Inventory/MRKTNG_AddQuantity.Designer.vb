<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRKTNG_AddQuantity
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddBTN = New MetroFramework.Controls.MetroButton()
        Me.QTYTbox = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(234, 51)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(66, 30)
        Me.AddBTN.Style = MetroFramework.MetroColorStyle.Silver
        Me.AddBTN.TabIndex = 7
        Me.AddBTN.Text = "Add"
        Me.AddBTN.UseSelectable = True
        '
        'QTYTbox
        '
        Me.QTYTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.QTYTbox.CustomButton.Image = Nothing
        Me.QTYTbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.QTYTbox.CustomButton.Name = ""
        Me.QTYTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.QTYTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QTYTbox.CustomButton.TabIndex = 1
        Me.QTYTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QTYTbox.CustomButton.UseSelectable = True
        Me.QTYTbox.CustomButton.Visible = False
        Me.QTYTbox.Lines = New String(-1) {}
        Me.QTYTbox.Location = New System.Drawing.Point(23, 51)
        Me.QTYTbox.MaxLength = 32767
        Me.QTYTbox.Name = "QTYTbox"
        Me.QTYTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QTYTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QTYTbox.SelectedText = ""
        Me.QTYTbox.SelectionLength = 0
        Me.QTYTbox.SelectionStart = 0
        Me.QTYTbox.Size = New System.Drawing.Size(205, 30)
        Me.QTYTbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.QTYTbox.TabIndex = 6
        Me.QTYTbox.UseSelectable = True
        Me.QTYTbox.WaterMark = "Quantity"
        Me.QTYTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QTYTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MRKTNG_AddQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 113)
        Me.Controls.Add(Me.AddBTN)
        Me.Controls.Add(Me.QTYTbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MRKTNG_AddQuantity"
        Me.Resizable = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents QTYTbox As MetroFramework.Controls.MetroTextBox
End Class
