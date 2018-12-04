<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminConfirmation
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AdminsCodeTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'AdminsCodeTbox
        '
        Me.AdminsCodeTbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.AdminsCodeTbox.CustomButton.Image = Nothing
        Me.AdminsCodeTbox.CustomButton.Location = New System.Drawing.Point(245, 1)
        Me.AdminsCodeTbox.CustomButton.Name = ""
        Me.AdminsCodeTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.AdminsCodeTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AdminsCodeTbox.CustomButton.TabIndex = 1
        Me.AdminsCodeTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AdminsCodeTbox.CustomButton.UseSelectable = True
        Me.AdminsCodeTbox.CustomButton.Visible = False
        Me.AdminsCodeTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.AdminsCodeTbox.ForeColor = System.Drawing.Color.Black
        Me.AdminsCodeTbox.Lines = New String(-1) {}
        Me.AdminsCodeTbox.Location = New System.Drawing.Point(23, 88)
        Me.AdminsCodeTbox.MaxLength = 32767
        Me.AdminsCodeTbox.Name = "AdminsCodeTbox"
        Me.AdminsCodeTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.AdminsCodeTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AdminsCodeTbox.SelectedText = ""
        Me.AdminsCodeTbox.SelectionLength = 0
        Me.AdminsCodeTbox.SelectionStart = 0
        Me.AdminsCodeTbox.Size = New System.Drawing.Size(273, 29)
        Me.AdminsCodeTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.AdminsCodeTbox.TabIndex = 4
        Me.AdminsCodeTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AdminsCodeTbox.UseCustomBackColor = True
        Me.AdminsCodeTbox.UseSelectable = True
        Me.AdminsCodeTbox.UseStyleColors = True
        Me.AdminsCodeTbox.UseSystemPasswordChar = True
        Me.AdminsCodeTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AdminsCodeTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(302, 90)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(89, 23)
        Me.MetroTextButton1.TabIndex = 5
        Me.MetroTextButton1.Text = "Confirm"
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(10, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(385, 50)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "If you're not an ADMIN, please exit this form now." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'AdminConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 136)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroTextButton1)
        Me.Controls.Add(Me.AdminsCodeTbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminConfirmation"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdminsCodeTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
