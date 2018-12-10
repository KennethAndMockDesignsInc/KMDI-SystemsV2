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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KMDISystemsLogin))
        Me.Password_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.UserName_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.LoginBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Login_TTP = New MetroFramework.Components.MetroToolTip()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Password_TBX
        '
        '
        '
        '
        Me.Password_TBX.CustomButton.Image = Nothing
        Me.Password_TBX.CustomButton.Location = New System.Drawing.Point(259, 1)
        Me.Password_TBX.CustomButton.Name = ""
        Me.Password_TBX.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Password_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password_TBX.CustomButton.TabIndex = 1
        Me.Password_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password_TBX.CustomButton.UseSelectable = True
        Me.Password_TBX.CustomButton.Visible = False
        Me.Password_TBX.DisplayIcon = True
        Me.Password_TBX.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Password_TBX.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.Password_TBX.Icon = CType(resources.GetObject("Password_TBX.Icon"), System.Drawing.Image)
        Me.Password_TBX.IconRight = True
        Me.Password_TBX.Lines = New String(-1) {}
        Me.Password_TBX.Location = New System.Drawing.Point(23, 187)
        Me.Password_TBX.MaxLength = 32767
        Me.Password_TBX.Name = "Password_TBX"
        Me.Password_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password_TBX.SelectedText = ""
        Me.Password_TBX.SelectionLength = 0
        Me.Password_TBX.SelectionStart = 0
        Me.Password_TBX.Size = New System.Drawing.Size(295, 37)
        Me.Password_TBX.TabIndex = 1
        Me.Password_TBX.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Password_TBX.UseSelectable = True
        Me.Password_TBX.WaterMark = "Password"
        Me.Password_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Password_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UserName_TBX
        '
        '
        '
        '
        Me.UserName_TBX.CustomButton.Image = Nothing
        Me.UserName_TBX.CustomButton.Location = New System.Drawing.Point(257, 2)
        Me.UserName_TBX.CustomButton.Name = ""
        Me.UserName_TBX.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.UserName_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserName_TBX.CustomButton.TabIndex = 1
        Me.UserName_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UserName_TBX.CustomButton.UseSelectable = True
        Me.UserName_TBX.CustomButton.Visible = False
        Me.UserName_TBX.DisplayIcon = True
        Me.UserName_TBX.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.UserName_TBX.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.UserName_TBX.Icon = CType(resources.GetObject("UserName_TBX.Icon"), System.Drawing.Image)
        Me.UserName_TBX.IconRight = True
        Me.UserName_TBX.Lines = New String(-1) {}
        Me.UserName_TBX.Location = New System.Drawing.Point(23, 135)
        Me.UserName_TBX.MaxLength = 32767
        Me.UserName_TBX.Name = "UserName_TBX"
        Me.UserName_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserName_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UserName_TBX.SelectedText = ""
        Me.UserName_TBX.SelectionLength = 0
        Me.UserName_TBX.SelectionStart = 0
        Me.UserName_TBX.Size = New System.Drawing.Size(295, 40)
        Me.UserName_TBX.TabIndex = 0
        Me.UserName_TBX.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UserName_TBX.UseSelectable = True
        Me.UserName_TBX.WaterMark = "Username"
        Me.UserName_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserName_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPBOX.Location = New System.Drawing.Point(258, 23)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(60, 26)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 3
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.Image = Nothing
        Me.LoginBtn.Location = New System.Drawing.Point(212, 240)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(106, 32)
        Me.LoginBtn.TabIndex = 2
        Me.LoginBtn.Text = "LOGIN"
        Me.LoginBtn.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LoginBtn.UseSelectable = True
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Login_TTP
        '
        Me.Login_TTP.Style = MetroFramework.MetroColorStyle.Blue
        Me.Login_TTP.StyleManager = Nothing
        Me.Login_TTP.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'KMDISystemsLogin
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 287)
        Me.Controls.Add(Me.Password_TBX)
        Me.Controls.Add(Me.LoadingPBOX)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.UserName_TBX)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MinimizeBox = False
        Me.Name = "KMDISystemsLogin"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Password_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UserName_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents LoginBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Login_TTP As MetroFramework.Components.MetroToolTip
End Class
