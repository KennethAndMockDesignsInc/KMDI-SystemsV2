<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchContract
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
        Me.SearchAllTbox = New MetroFramework.Controls.MetroTextBox()
        Me.FindBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SuspendLayout()
        '
        'SearchAllTbox
        '
        '
        '
        '
        Me.SearchAllTbox.CustomButton.Image = Nothing
        Me.SearchAllTbox.CustomButton.Location = New System.Drawing.Point(245, 1)
        Me.SearchAllTbox.CustomButton.Name = ""
        Me.SearchAllTbox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.SearchAllTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchAllTbox.CustomButton.TabIndex = 1
        Me.SearchAllTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchAllTbox.CustomButton.UseSelectable = True
        Me.SearchAllTbox.CustomButton.Visible = False
        Me.SearchAllTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.SearchAllTbox.ForeColor = System.Drawing.Color.Black
        Me.SearchAllTbox.Lines = New String(-1) {}
        Me.SearchAllTbox.Location = New System.Drawing.Point(23, 41)
        Me.SearchAllTbox.MaxLength = 32767
        Me.SearchAllTbox.Name = "SearchAllTbox"
        Me.SearchAllTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchAllTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchAllTbox.SelectedText = ""
        Me.SearchAllTbox.SelectionLength = 0
        Me.SearchAllTbox.SelectionStart = 0
        Me.SearchAllTbox.Size = New System.Drawing.Size(279, 35)
        Me.SearchAllTbox.Style = MetroFramework.MetroColorStyle.Pink
        Me.SearchAllTbox.TabIndex = 2
        Me.SearchAllTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SearchAllTbox.UseCustomBackColor = True
        Me.SearchAllTbox.UseCustomForeColor = True
        Me.SearchAllTbox.UseSelectable = True
        Me.SearchAllTbox.UseStyleColors = True
        Me.SearchAllTbox.WaterMark = "Search All"
        Me.SearchAllTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchAllTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FindBtn
        '
        Me.FindBtn.BackColor = System.Drawing.Color.Black
        Me.FindBtn.ForeColor = System.Drawing.Color.Black
        Me.FindBtn.Image = Nothing
        Me.FindBtn.Location = New System.Drawing.Point(308, 44)
        Me.FindBtn.Name = "FindBtn"
        Me.FindBtn.Size = New System.Drawing.Size(68, 29)
        Me.FindBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.FindBtn.TabIndex = 5
        Me.FindBtn.Text = "Find"
        Me.FindBtn.UseCustomBackColor = True
        Me.FindBtn.UseCustomForeColor = True
        Me.FindBtn.UseSelectable = True
        Me.FindBtn.UseStyleColors = True
        Me.FindBtn.UseVisualStyleBackColor = False
        '
        'SearchContract
        '
        Me.AcceptButton = Me.FindBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 119)
        Me.Controls.Add(Me.FindBtn)
        Me.Controls.Add(Me.SearchAllTbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchContract"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchAllTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FindBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
