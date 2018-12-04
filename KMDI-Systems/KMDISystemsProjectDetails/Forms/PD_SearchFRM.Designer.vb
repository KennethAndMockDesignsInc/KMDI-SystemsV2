<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_SearchFRM
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
        Me.SearchBTN = New MetroFramework.Controls.MetroButton()
        Me.SearchTbox = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'SearchBTN
        '
        Me.SearchBTN.Location = New System.Drawing.Point(265, 31)
        Me.SearchBTN.Name = "SearchBTN"
        Me.SearchBTN.Size = New System.Drawing.Size(97, 30)
        Me.SearchBTN.Style = MetroFramework.MetroColorStyle.Silver
        Me.SearchBTN.TabIndex = 3
        Me.SearchBTN.Text = "Search"
        Me.SearchBTN.UseSelectable = True
        '
        'SearchTbox
        '
        Me.SearchTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.SearchTbox.CustomButton.Image = Nothing
        Me.SearchTbox.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.SearchTbox.CustomButton.Name = ""
        Me.SearchTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.SearchTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchTbox.CustomButton.TabIndex = 1
        Me.SearchTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchTbox.CustomButton.UseSelectable = True
        Me.SearchTbox.CustomButton.Visible = False
        Me.SearchTbox.Lines = New String(-1) {}
        Me.SearchTbox.Location = New System.Drawing.Point(23, 31)
        Me.SearchTbox.MaxLength = 32767
        Me.SearchTbox.Name = "SearchTbox"
        Me.SearchTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchTbox.SelectedText = ""
        Me.SearchTbox.SelectionLength = 0
        Me.SearchTbox.SelectionStart = 0
        Me.SearchTbox.Size = New System.Drawing.Size(236, 30)
        Me.SearchTbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.SearchTbox.TabIndex = 2
        Me.SearchTbox.UseSelectable = True
        Me.SearchTbox.WaterMark = "Search"
        Me.SearchTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PD_SearchFRM
        '
        Me.AcceptButton = Me.SearchBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 86)
        Me.Controls.Add(Me.SearchBTN)
        Me.Controls.Add(Me.SearchTbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PD_SearchFRM"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents SearchTbox As MetroFramework.Controls.MetroTextBox
End Class
