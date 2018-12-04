<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_UpdateCOMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PD_UpdateCOMP))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Save_Btn = New MetroFramework.Controls.MetroButton()
        Me.EmpAF_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.EmpEmail_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.EmpCPno_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.CompName_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.LoadingPbox = New System.Windows.Forms.PictureBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(458, 336)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.Save_Btn)
        Me.MetroTabPage1.Controls.Add(Me.EmpAF_Tbox)
        Me.MetroTabPage1.Controls.Add(Me.EmpEmail_Tbox)
        Me.MetroTabPage1.Controls.Add(Me.EmpCPno_Tbox)
        Me.MetroTabPage1.Controls.Add(Me.CompName_Tbox)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(450, 294)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "                                                                                 " &
    "                                        "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Save_Btn
        '
        Me.Save_Btn.Location = New System.Drawing.Point(333, 252)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(97, 37)
        Me.Save_Btn.TabIndex = 6
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseSelectable = True
        '
        'EmpAF_Tbox
        '
        '
        '
        '
        Me.EmpAF_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAF_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.EmpAF_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.EmpAF_Tbox.CustomButton.Name = ""
        Me.EmpAF_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.EmpAF_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpAF_Tbox.CustomButton.TabIndex = 1
        Me.EmpAF_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpAF_Tbox.CustomButton.UseSelectable = True
        Me.EmpAF_Tbox.CustomButton.Visible = False
        Me.EmpAF_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpAF_Tbox.ForeColor = System.Drawing.Color.Black
        Me.EmpAF_Tbox.Lines = New String(-1) {}
        Me.EmpAF_Tbox.Location = New System.Drawing.Point(130, 119)
        Me.EmpAF_Tbox.MaxLength = 32767
        Me.EmpAF_Tbox.Name = "EmpAF_Tbox"
        Me.EmpAF_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpAF_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpAF_Tbox.SelectedText = ""
        Me.EmpAF_Tbox.SelectionLength = 0
        Me.EmpAF_Tbox.SelectionStart = 0
        Me.EmpAF_Tbox.ShowClearButton = True
        Me.EmpAF_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.EmpAF_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpAF_Tbox.TabIndex = 4
        Me.EmpAF_Tbox.UseCustomForeColor = True
        Me.EmpAF_Tbox.UseSelectable = True
        Me.EmpAF_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpAF_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EmpEmail_Tbox
        '
        '
        '
        '
        Me.EmpEmail_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpEmail_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.EmpEmail_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.EmpEmail_Tbox.CustomButton.Name = ""
        Me.EmpEmail_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.EmpEmail_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpEmail_Tbox.CustomButton.TabIndex = 1
        Me.EmpEmail_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpEmail_Tbox.CustomButton.UseSelectable = True
        Me.EmpEmail_Tbox.CustomButton.Visible = False
        Me.EmpEmail_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpEmail_Tbox.ForeColor = System.Drawing.Color.Black
        Me.EmpEmail_Tbox.Lines = New String(-1) {}
        Me.EmpEmail_Tbox.Location = New System.Drawing.Point(130, 47)
        Me.EmpEmail_Tbox.MaxLength = 32767
        Me.EmpEmail_Tbox.Name = "EmpEmail_Tbox"
        Me.EmpEmail_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpEmail_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpEmail_Tbox.SelectedText = ""
        Me.EmpEmail_Tbox.SelectionLength = 0
        Me.EmpEmail_Tbox.SelectionStart = 0
        Me.EmpEmail_Tbox.ShowClearButton = True
        Me.EmpEmail_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.EmpEmail_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpEmail_Tbox.TabIndex = 2
        Me.EmpEmail_Tbox.UseCustomForeColor = True
        Me.EmpEmail_Tbox.UseSelectable = True
        Me.EmpEmail_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpEmail_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EmpCPno_Tbox
        '
        Me.EmpCPno_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.EmpCPno_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpCPno_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.EmpCPno_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.EmpCPno_Tbox.CustomButton.Name = ""
        Me.EmpCPno_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.EmpCPno_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpCPno_Tbox.CustomButton.TabIndex = 1
        Me.EmpCPno_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpCPno_Tbox.CustomButton.UseSelectable = True
        Me.EmpCPno_Tbox.CustomButton.Visible = False
        Me.EmpCPno_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpCPno_Tbox.ForeColor = System.Drawing.Color.Black
        Me.EmpCPno_Tbox.Lines = New String(-1) {}
        Me.EmpCPno_Tbox.Location = New System.Drawing.Point(130, 83)
        Me.EmpCPno_Tbox.MaxLength = 32767
        Me.EmpCPno_Tbox.Name = "EmpCPno_Tbox"
        Me.EmpCPno_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpCPno_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpCPno_Tbox.SelectedText = ""
        Me.EmpCPno_Tbox.SelectionLength = 0
        Me.EmpCPno_Tbox.SelectionStart = 0
        Me.EmpCPno_Tbox.ShowClearButton = True
        Me.EmpCPno_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.EmpCPno_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpCPno_Tbox.TabIndex = 3
        Me.EmpCPno_Tbox.UseCustomForeColor = True
        Me.EmpCPno_Tbox.UseSelectable = True
        Me.EmpCPno_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpCPno_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CompName_Tbox
        '
        '
        '
        '
        Me.CompName_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompName_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.CompName_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.CompName_Tbox.CustomButton.Name = ""
        Me.CompName_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.CompName_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompName_Tbox.CustomButton.TabIndex = 1
        Me.CompName_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CompName_Tbox.CustomButton.UseSelectable = True
        Me.CompName_Tbox.CustomButton.Visible = False
        Me.CompName_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CompName_Tbox.ForeColor = System.Drawing.Color.Black
        Me.CompName_Tbox.Lines = New String(-1) {}
        Me.CompName_Tbox.Location = New System.Drawing.Point(130, 11)
        Me.CompName_Tbox.MaxLength = 32767
        Me.CompName_Tbox.Name = "CompName_Tbox"
        Me.CompName_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompName_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CompName_Tbox.SelectedText = ""
        Me.CompName_Tbox.SelectionLength = 0
        Me.CompName_Tbox.SelectionStart = 0
        Me.CompName_Tbox.ShowClearButton = True
        Me.CompName_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.CompName_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompName_Tbox.TabIndex = 1
        Me.CompName_Tbox.UseCustomForeColor = True
        Me.CompName_Tbox.UseSelectable = True
        Me.CompName_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CompName_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(38, 121)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(86, 25)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Secretary:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(-2, 49)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(126, 25)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Office Address:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 85)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Mobile No.:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Office Name:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(44, 155)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 25)
        Me.MetroLabel2.TabIndex = 19
        Me.MetroLabel2.Text = "Remarks:"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(210, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(89, 89)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.ForeColor = System.Drawing.Color.Black
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(130, 155)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShowClearButton = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(300, 91)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.TabIndex = 5
        Me.MetroTextBox1.UseCustomForeColor = True
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LoadingPbox
        '
        Me.LoadingPbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPbox.BackColor = System.Drawing.Color.Transparent
        Me.LoadingPbox.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPbox.Location = New System.Drawing.Point(413, 65)
        Me.LoadingPbox.Name = "LoadingPbox"
        Me.LoadingPbox.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPbox.TabIndex = 18
        Me.LoadingPbox.TabStop = False
        Me.LoadingPbox.Visible = False
        '
        'PD_UpdateCOMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 416)
        Me.Controls.Add(Me.LoadingPbox)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.Name = "PD_UpdateCOMP"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Company"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Public WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Save_Btn As MetroFramework.Controls.MetroButton
    Public WithEvents EmpAF_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents EmpEmail_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents EmpCPno_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents CompName_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPbox As PictureBox
End Class
