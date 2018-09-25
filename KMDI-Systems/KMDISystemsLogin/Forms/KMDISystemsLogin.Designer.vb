<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KMDISystemsLogin
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
        Me.ConnectionTypeCbox = New MetroFramework.Controls.MetroComboBox()
        Me.PasswordTbox = New MetroFramework.Controls.MetroTextBox()
        Me.UserNameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordLbl = New MetroFramework.Controls.MetroLabel()
        Me.UserNameLbl = New MetroFramework.Controls.MetroLabel()
        Me.ConnectionTypeLbl = New MetroFramework.Controls.MetroLabel()
        Me.Login_BGW = New System.ComponentModel.BackgroundWorker()
        Me.Loading_Pnl = New MetroFramework.Controls.MetroPanel()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.Login_Pnl = New MetroFramework.Controls.MetroPanel()
        Me.CloseBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.LoginBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Loading_Pnl.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Login_Pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConnectionTypeCbox
        '
        Me.ConnectionTypeCbox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.ConnectionTypeCbox.FormattingEnabled = True
        Me.ConnectionTypeCbox.ItemHeight = 23
        Me.ConnectionTypeCbox.Items.AddRange(New Object() {"Local Access", "Remote Access"})
        Me.ConnectionTypeCbox.Location = New System.Drawing.Point(173, 40)
        Me.ConnectionTypeCbox.Name = "ConnectionTypeCbox"
        Me.ConnectionTypeCbox.Size = New System.Drawing.Size(184, 29)
        Me.ConnectionTypeCbox.TabIndex = 3
        Me.ConnectionTypeCbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ConnectionTypeCbox.UseSelectable = True
        '
        'PasswordTbox
        '
        '
        '
        '
        Me.PasswordTbox.CustomButton.Image = Nothing
        Me.PasswordTbox.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.PasswordTbox.CustomButton.Name = ""
        Me.PasswordTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PasswordTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTbox.CustomButton.TabIndex = 1
        Me.PasswordTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTbox.CustomButton.UseSelectable = True
        Me.PasswordTbox.CustomButton.Visible = False
        Me.PasswordTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PasswordTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.PasswordTbox.Lines = New String(-1) {}
        Me.PasswordTbox.Location = New System.Drawing.Point(173, 126)
        Me.PasswordTbox.MaxLength = 32767
        Me.PasswordTbox.Name = "PasswordTbox"
        Me.PasswordTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTbox.SelectedText = ""
        Me.PasswordTbox.SelectionLength = 0
        Me.PasswordTbox.SelectionStart = 0
        Me.PasswordTbox.Size = New System.Drawing.Size(184, 23)
        Me.PasswordTbox.TabIndex = 2
        Me.PasswordTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PasswordTbox.UseSelectable = True
        Me.PasswordTbox.WaterMark = "Password"
        Me.PasswordTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UserNameTbox
        '
        '
        '
        '
        Me.UserNameTbox.CustomButton.Image = Nothing
        Me.UserNameTbox.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.UserNameTbox.CustomButton.Name = ""
        Me.UserNameTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserNameTbox.CustomButton.TabIndex = 1
        Me.UserNameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UserNameTbox.CustomButton.UseSelectable = True
        Me.UserNameTbox.CustomButton.Visible = False
        Me.UserNameTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.UserNameTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.UserNameTbox.Lines = New String(-1) {}
        Me.UserNameTbox.Location = New System.Drawing.Point(173, 84)
        Me.UserNameTbox.MaxLength = 32767
        Me.UserNameTbox.Name = "UserNameTbox"
        Me.UserNameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UserNameTbox.SelectedText = ""
        Me.UserNameTbox.SelectionLength = 0
        Me.UserNameTbox.SelectionStart = 0
        Me.UserNameTbox.Size = New System.Drawing.Size(184, 23)
        Me.UserNameTbox.TabIndex = 1
        Me.UserNameTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UserNameTbox.UseSelectable = True
        Me.UserNameTbox.WaterMark = "User Name"
        Me.UserNameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserNameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.PasswordLbl.ForeColor = System.Drawing.Color.White
        Me.PasswordLbl.Location = New System.Drawing.Point(25, 124)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(86, 25)
        Me.PasswordLbl.Style = MetroFramework.MetroColorStyle.White
        Me.PasswordLbl.TabIndex = 10
        Me.PasswordLbl.Text = "Password:"
        Me.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PasswordLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PasswordLbl.UseCustomForeColor = True
        Me.PasswordLbl.UseStyleColors = True
        '
        'UserNameLbl
        '
        Me.UserNameLbl.AutoSize = True
        Me.UserNameLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.UserNameLbl.ForeColor = System.Drawing.Color.White
        Me.UserNameLbl.Location = New System.Drawing.Point(25, 84)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(101, 25)
        Me.UserNameLbl.Style = MetroFramework.MetroColorStyle.White
        Me.UserNameLbl.TabIndex = 9
        Me.UserNameLbl.Text = "User Name:"
        Me.UserNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UserNameLbl.UseCustomForeColor = True
        Me.UserNameLbl.UseStyleColors = True
        '
        'ConnectionTypeLbl
        '
        Me.ConnectionTypeLbl.AutoSize = True
        Me.ConnectionTypeLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ConnectionTypeLbl.ForeColor = System.Drawing.Color.White
        Me.ConnectionTypeLbl.Location = New System.Drawing.Point(25, 44)
        Me.ConnectionTypeLbl.Name = "ConnectionTypeLbl"
        Me.ConnectionTypeLbl.Size = New System.Drawing.Size(142, 25)
        Me.ConnectionTypeLbl.Style = MetroFramework.MetroColorStyle.White
        Me.ConnectionTypeLbl.TabIndex = 8
        Me.ConnectionTypeLbl.Text = "Connection Type:"
        Me.ConnectionTypeLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ConnectionTypeLbl.UseCustomForeColor = True
        Me.ConnectionTypeLbl.UseStyleColors = True
        '
        'Login_BGW
        '
        Me.Login_BGW.WorkerReportsProgress = True
        Me.Login_BGW.WorkerSupportsCancellation = True
        '
        'Loading_Pnl
        '
        Me.Loading_Pnl.Controls.Add(Me.LoadingPBOX)
        Me.Loading_Pnl.HorizontalScrollbarBarColor = True
        Me.Loading_Pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.Loading_Pnl.HorizontalScrollbarSize = 10
        Me.Loading_Pnl.Location = New System.Drawing.Point(115, 155)
        Me.Loading_Pnl.Name = "Loading_Pnl"
        Me.Loading_Pnl.Size = New System.Drawing.Size(242, 47)
        Me.Loading_Pnl.TabIndex = 11
        Me.Loading_Pnl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Loading_Pnl.UseCustomBackColor = True
        Me.Loading_Pnl.VerticalScrollbarBarColor = True
        Me.Loading_Pnl.VerticalScrollbarHighlightOnWheel = False
        Me.Loading_Pnl.VerticalScrollbarSize = 10
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPBOX.Location = New System.Drawing.Point(125, 1)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(117, 46)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 3
        Me.LoadingPBOX.TabStop = False
        '
        'Login_Pnl
        '
        Me.Login_Pnl.Controls.Add(Me.CloseBtn)
        Me.Login_Pnl.Controls.Add(Me.LoginBtn)
        Me.Login_Pnl.HorizontalScrollbarBarColor = True
        Me.Login_Pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.Login_Pnl.HorizontalScrollbarSize = 10
        Me.Login_Pnl.Location = New System.Drawing.Point(115, 155)
        Me.Login_Pnl.Name = "Login_Pnl"
        Me.Login_Pnl.Size = New System.Drawing.Size(242, 47)
        Me.Login_Pnl.TabIndex = 12
        Me.Login_Pnl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Login_Pnl.UseCustomBackColor = True
        Me.Login_Pnl.VerticalScrollbarBarColor = True
        Me.Login_Pnl.VerticalScrollbarHighlightOnWheel = False
        Me.Login_Pnl.VerticalScrollbarSize = 10
        '
        'CloseBtn
        '
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(100, 13)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(63, 23)
        Me.CloseBtn.TabIndex = 3
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseSelectable = True
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'LoginBtn
        '
        Me.LoginBtn.Image = Nothing
        Me.LoginBtn.Location = New System.Drawing.Point(169, 13)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(63, 23)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseSelectable = True
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'KMDISystemsLogin
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 215)
        Me.Controls.Add(Me.ConnectionTypeCbox)
        Me.Controls.Add(Me.PasswordTbox)
        Me.Controls.Add(Me.UserNameTbox)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.UserNameLbl)
        Me.Controls.Add(Me.ConnectionTypeLbl)
        Me.Controls.Add(Me.Login_Pnl)
        Me.Controls.Add(Me.Loading_Pnl)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Name = "KMDISystemsLogin"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Loading_Pnl.ResumeLayout(False)
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Login_Pnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionTypeCbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PasswordTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UserNameTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents UserNameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ConnectionTypeLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents Login_BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Loading_Pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents Login_Pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents LoginBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents CloseBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
