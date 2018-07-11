<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountUpdate
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.UsernameLbl = New MetroFramework.Controls.MetroLabel()
        Me.AccountLbl = New MetroFramework.Controls.MetroLabel()
        Me.NicknameLbl = New MetroFramework.Controls.MetroLabel()
        Me.FullnameLlbl = New MetroFramework.Controls.MetroLabel()
        Me.userPbox = New System.Windows.Forms.PictureBox()
        Me.changePicChk = New MetroFramework.Controls.MetroCheckBox()
        Me.BrowseBtn = New MetroFramework.Controls.MetroButton()
        Me.changeUserChk = New MetroFramework.Controls.MetroCheckBox()
        Me.NewUserTbox = New MetroFramework.Controls.MetroTextBox()
        Me.OldPasswordTbox = New MetroFramework.Controls.MetroTextBox()
        Me.changePassChk = New MetroFramework.Controls.MetroCheckBox()
        Me.NewPassTbox = New MetroFramework.Controls.MetroTextBox()
        Me.RetypePassTbox = New MetroFramework.Controls.MetroTextBox()
        Me.UpdateUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.userPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(184, 91)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Fullname:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(179, 114)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Nickname:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(190, 137)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Account:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(178, 160)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Username:"
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.UsernameLbl.Location = New System.Drawing.Point(255, 160)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(76, 19)
        Me.UsernameLbl.TabIndex = 7
        Me.UsernameLbl.Text = "Username"
        '
        'AccountLbl
        '
        Me.AccountLbl.AutoSize = True
        Me.AccountLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.AccountLbl.Location = New System.Drawing.Point(255, 137)
        Me.AccountLbl.Name = "AccountLbl"
        Me.AccountLbl.Size = New System.Drawing.Size(63, 19)
        Me.AccountLbl.TabIndex = 6
        Me.AccountLbl.Text = "Account"
        '
        'NicknameLbl
        '
        Me.NicknameLbl.AutoSize = True
        Me.NicknameLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.NicknameLbl.Location = New System.Drawing.Point(255, 114)
        Me.NicknameLbl.Name = "NicknameLbl"
        Me.NicknameLbl.Size = New System.Drawing.Size(76, 19)
        Me.NicknameLbl.TabIndex = 5
        Me.NicknameLbl.Text = "Nickname"
        '
        'FullnameLlbl
        '
        Me.FullnameLlbl.AutoSize = True
        Me.FullnameLlbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FullnameLlbl.Location = New System.Drawing.Point(255, 91)
        Me.FullnameLlbl.Name = "FullnameLlbl"
        Me.FullnameLlbl.Size = New System.Drawing.Size(69, 19)
        Me.FullnameLlbl.TabIndex = 4
        Me.FullnameLlbl.Text = "Fullname"
        '
        'userPbox
        '
        Me.userPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userPbox.Location = New System.Drawing.Point(23, 63)
        Me.userPbox.Name = "userPbox"
        Me.userPbox.Size = New System.Drawing.Size(144, 144)
        Me.userPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userPbox.TabIndex = 8
        Me.userPbox.TabStop = False
        '
        'changePicChk
        '
        Me.changePicChk.AutoSize = True
        Me.changePicChk.Location = New System.Drawing.Point(23, 42)
        Me.changePicChk.Name = "changePicChk"
        Me.changePicChk.Size = New System.Drawing.Size(104, 15)
        Me.changePicChk.TabIndex = 9
        Me.changePicChk.Text = "Change Picture"
        Me.changePicChk.UseSelectable = True
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Enabled = False
        Me.BrowseBtn.Location = New System.Drawing.Point(23, 213)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseBtn.TabIndex = 10
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseSelectable = True
        '
        'changeUserChk
        '
        Me.changeUserChk.AutoSize = True
        Me.changeUserChk.Location = New System.Drawing.Point(23, 256)
        Me.changeUserChk.Name = "changeUserChk"
        Me.changeUserChk.Size = New System.Drawing.Size(120, 15)
        Me.changeUserChk.TabIndex = 11
        Me.changeUserChk.Text = "Change Username"
        Me.changeUserChk.UseSelectable = True
        '
        'NewUserTbox
        '
        '
        '
        '
        Me.NewUserTbox.CustomButton.Image = Nothing
        Me.NewUserTbox.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.NewUserTbox.CustomButton.Name = ""
        Me.NewUserTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.NewUserTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NewUserTbox.CustomButton.TabIndex = 1
        Me.NewUserTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NewUserTbox.CustomButton.UseSelectable = True
        Me.NewUserTbox.CustomButton.Visible = False
        Me.NewUserTbox.Enabled = False
        Me.NewUserTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.NewUserTbox.Lines = New String(-1) {}
        Me.NewUserTbox.Location = New System.Drawing.Point(23, 277)
        Me.NewUserTbox.MaxLength = 32767
        Me.NewUserTbox.Name = "NewUserTbox"
        Me.NewUserTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewUserTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NewUserTbox.SelectedText = ""
        Me.NewUserTbox.SelectionLength = 0
        Me.NewUserTbox.SelectionStart = 0
        Me.NewUserTbox.Size = New System.Drawing.Size(308, 23)
        Me.NewUserTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.NewUserTbox.TabIndex = 12
        Me.NewUserTbox.UseCustomBackColor = True
        Me.NewUserTbox.UseCustomForeColor = True
        Me.NewUserTbox.UseSelectable = True
        Me.NewUserTbox.UseStyleColors = True
        Me.NewUserTbox.WaterMark = "New Username"
        Me.NewUserTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NewUserTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'OldPasswordTbox
        '
        '
        '
        '
        Me.OldPasswordTbox.CustomButton.Image = Nothing
        Me.OldPasswordTbox.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.OldPasswordTbox.CustomButton.Name = ""
        Me.OldPasswordTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.OldPasswordTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.OldPasswordTbox.CustomButton.TabIndex = 1
        Me.OldPasswordTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.OldPasswordTbox.CustomButton.UseSelectable = True
        Me.OldPasswordTbox.CustomButton.Visible = False
        Me.OldPasswordTbox.Enabled = False
        Me.OldPasswordTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.OldPasswordTbox.Lines = New String(-1) {}
        Me.OldPasswordTbox.Location = New System.Drawing.Point(23, 327)
        Me.OldPasswordTbox.MaxLength = 32767
        Me.OldPasswordTbox.Name = "OldPasswordTbox"
        Me.OldPasswordTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.OldPasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OldPasswordTbox.SelectedText = ""
        Me.OldPasswordTbox.SelectionLength = 0
        Me.OldPasswordTbox.SelectionStart = 0
        Me.OldPasswordTbox.Size = New System.Drawing.Size(308, 23)
        Me.OldPasswordTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.OldPasswordTbox.TabIndex = 14
        Me.OldPasswordTbox.UseCustomBackColor = True
        Me.OldPasswordTbox.UseCustomForeColor = True
        Me.OldPasswordTbox.UseSelectable = True
        Me.OldPasswordTbox.UseStyleColors = True
        Me.OldPasswordTbox.UseSystemPasswordChar = True
        Me.OldPasswordTbox.WaterMark = "Old Password"
        Me.OldPasswordTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OldPasswordTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'changePassChk
        '
        Me.changePassChk.AutoSize = True
        Me.changePassChk.Location = New System.Drawing.Point(23, 306)
        Me.changePassChk.Name = "changePassChk"
        Me.changePassChk.Size = New System.Drawing.Size(117, 15)
        Me.changePassChk.TabIndex = 13
        Me.changePassChk.Text = "Change Password"
        Me.changePassChk.UseSelectable = True
        '
        'NewPassTbox
        '
        '
        '
        '
        Me.NewPassTbox.CustomButton.Image = Nothing
        Me.NewPassTbox.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.NewPassTbox.CustomButton.Name = ""
        Me.NewPassTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.NewPassTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NewPassTbox.CustomButton.TabIndex = 1
        Me.NewPassTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NewPassTbox.CustomButton.UseSelectable = True
        Me.NewPassTbox.CustomButton.Visible = False
        Me.NewPassTbox.Enabled = False
        Me.NewPassTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.NewPassTbox.Lines = New String(-1) {}
        Me.NewPassTbox.Location = New System.Drawing.Point(23, 356)
        Me.NewPassTbox.MaxLength = 32767
        Me.NewPassTbox.Name = "NewPassTbox"
        Me.NewPassTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.NewPassTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NewPassTbox.SelectedText = ""
        Me.NewPassTbox.SelectionLength = 0
        Me.NewPassTbox.SelectionStart = 0
        Me.NewPassTbox.Size = New System.Drawing.Size(308, 23)
        Me.NewPassTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.NewPassTbox.TabIndex = 15
        Me.NewPassTbox.UseCustomBackColor = True
        Me.NewPassTbox.UseCustomForeColor = True
        Me.NewPassTbox.UseSelectable = True
        Me.NewPassTbox.UseStyleColors = True
        Me.NewPassTbox.UseSystemPasswordChar = True
        Me.NewPassTbox.WaterMark = "New Password"
        Me.NewPassTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NewPassTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'RetypePassTbox
        '
        '
        '
        '
        Me.RetypePassTbox.CustomButton.Image = Nothing
        Me.RetypePassTbox.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.RetypePassTbox.CustomButton.Name = ""
        Me.RetypePassTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.RetypePassTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.RetypePassTbox.CustomButton.TabIndex = 1
        Me.RetypePassTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.RetypePassTbox.CustomButton.UseSelectable = True
        Me.RetypePassTbox.CustomButton.Visible = False
        Me.RetypePassTbox.Enabled = False
        Me.RetypePassTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.RetypePassTbox.Lines = New String(-1) {}
        Me.RetypePassTbox.Location = New System.Drawing.Point(23, 385)
        Me.RetypePassTbox.MaxLength = 32767
        Me.RetypePassTbox.Name = "RetypePassTbox"
        Me.RetypePassTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.RetypePassTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RetypePassTbox.SelectedText = ""
        Me.RetypePassTbox.SelectionLength = 0
        Me.RetypePassTbox.SelectionStart = 0
        Me.RetypePassTbox.Size = New System.Drawing.Size(308, 23)
        Me.RetypePassTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.RetypePassTbox.TabIndex = 16
        Me.RetypePassTbox.UseCustomBackColor = True
        Me.RetypePassTbox.UseCustomForeColor = True
        Me.RetypePassTbox.UseSelectable = True
        Me.RetypePassTbox.UseStyleColors = True
        Me.RetypePassTbox.UseSystemPasswordChar = True
        Me.RetypePassTbox.WaterMark = "Retype Password"
        Me.RetypePassTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RetypePassTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UpdateUserBtn
        '
        Me.UpdateUserBtn.Image = Nothing
        Me.UpdateUserBtn.Location = New System.Drawing.Point(23, 414)
        Me.UpdateUserBtn.Name = "UpdateUserBtn"
        Me.UpdateUserBtn.Size = New System.Drawing.Size(55, 23)
        Me.UpdateUserBtn.TabIndex = 17
        Me.UpdateUserBtn.Text = "Up&date"
        Me.UpdateUserBtn.UseSelectable = True
        Me.UpdateUserBtn.UseVisualStyleBackColor = True
        '
        'AccountUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 473)
        Me.Controls.Add(Me.UpdateUserBtn)
        Me.Controls.Add(Me.RetypePassTbox)
        Me.Controls.Add(Me.NewPassTbox)
        Me.Controls.Add(Me.OldPasswordTbox)
        Me.Controls.Add(Me.changePassChk)
        Me.Controls.Add(Me.NewUserTbox)
        Me.Controls.Add(Me.changeUserChk)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.changePicChk)
        Me.Controls.Add(Me.userPbox)
        Me.Controls.Add(Me.UsernameLbl)
        Me.Controls.Add(Me.AccountLbl)
        Me.Controls.Add(Me.NicknameLbl)
        Me.Controls.Add(Me.FullnameLlbl)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.Name = "AccountUpdate"
        Me.Resizable = False
        CType(Me.userPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsernameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents AccountLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents NicknameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents FullnameLlbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents userPbox As PictureBox
    Friend WithEvents changePicChk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents BrowseBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents changeUserChk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents NewUserTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents OldPasswordTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents changePassChk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents NewPassTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents RetypePassTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UpdateUserBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
