<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_UpdateEMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PD_UpdateEMP))
        Me.Emp_TabControl = New MetroFramework.Controls.MetroTabControl()
        Me.Emp_TabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Save_Btn = New MetroFramework.Controls.MetroButton()
        Me.EmpAFRel_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.EmpAFType_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.EmpAF_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.EmpEmail_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.EmpCPno_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.EmpGender_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.EmpBday_DTP = New MetroFramework.Controls.MetroDateTime()
        Me.EmpName_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPbox = New System.Windows.Forms.PictureBox()
        Me.Emp_TabControl.SuspendLayout()
        Me.Emp_TabPage.SuspendLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_TabControl
        '
        Me.Emp_TabControl.Controls.Add(Me.Emp_TabPage)
        Me.Emp_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Emp_TabControl.Location = New System.Drawing.Point(20, 60)
        Me.Emp_TabControl.Name = "Emp_TabControl"
        Me.Emp_TabControl.SelectedIndex = 0
        Me.Emp_TabControl.Size = New System.Drawing.Size(458, 349)
        Me.Emp_TabControl.TabIndex = 0
        Me.Emp_TabControl.UseSelectable = True
        '
        'Emp_TabPage
        '
        Me.Emp_TabPage.Controls.Add(Me.Save_Btn)
        Me.Emp_TabPage.Controls.Add(Me.EmpAFRel_Cbox)
        Me.Emp_TabPage.Controls.Add(Me.EmpAFType_Cbox)
        Me.Emp_TabPage.Controls.Add(Me.EmpAF_Tbox)
        Me.Emp_TabPage.Controls.Add(Me.EmpEmail_Tbox)
        Me.Emp_TabPage.Controls.Add(Me.EmpCPno_Tbox)
        Me.Emp_TabPage.Controls.Add(Me.EmpGender_Cbox)
        Me.Emp_TabPage.Controls.Add(Me.EmpBday_DTP)
        Me.Emp_TabPage.Controls.Add(Me.EmpName_Tbox)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel8)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel7)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel6)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel5)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel4)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel3)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel2)
        Me.Emp_TabPage.Controls.Add(Me.MetroLabel1)
        Me.Emp_TabPage.HorizontalScrollbarBarColor = True
        Me.Emp_TabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.Emp_TabPage.HorizontalScrollbarSize = 10
        Me.Emp_TabPage.Location = New System.Drawing.Point(4, 38)
        Me.Emp_TabPage.Name = "Emp_TabPage"
        Me.Emp_TabPage.Size = New System.Drawing.Size(450, 307)
        Me.Emp_TabPage.TabIndex = 0
        Me.Emp_TabPage.Text = "                                                                                 " &
    "                                        "
        Me.Emp_TabPage.VerticalScrollbarBarColor = True
        Me.Emp_TabPage.VerticalScrollbarHighlightOnWheel = False
        Me.Emp_TabPage.VerticalScrollbarSize = 10
        '
        'Save_Btn
        '
        Me.Save_Btn.Location = New System.Drawing.Point(286, 225)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(144, 64)
        Me.Save_Btn.TabIndex = 18
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseSelectable = True
        '
        'EmpAFRel_Cbox
        '
        Me.EmpAFRel_Cbox.FormattingEnabled = True
        Me.EmpAFRel_Cbox.ItemHeight = 23
        Me.EmpAFRel_Cbox.Items.AddRange(New Object() {"Full", "APP"})
        Me.EmpAFRel_Cbox.Location = New System.Drawing.Point(130, 260)
        Me.EmpAFRel_Cbox.Name = "EmpAFRel_Cbox"
        Me.EmpAFRel_Cbox.Size = New System.Drawing.Size(150, 29)
        Me.EmpAFRel_Cbox.TabIndex = 17
        Me.EmpAFRel_Cbox.UseSelectable = True
        '
        'EmpAFType_Cbox
        '
        Me.EmpAFType_Cbox.FormattingEnabled = True
        Me.EmpAFType_Cbox.ItemHeight = 23
        Me.EmpAFType_Cbox.Items.AddRange(New Object() {"Variable", "Fixed"})
        Me.EmpAFType_Cbox.Location = New System.Drawing.Point(130, 225)
        Me.EmpAFType_Cbox.Name = "EmpAFType_Cbox"
        Me.EmpAFType_Cbox.Size = New System.Drawing.Size(150, 29)
        Me.EmpAFType_Cbox.TabIndex = 16
        Me.EmpAFType_Cbox.UseSelectable = True
        '
        'EmpAF_Tbox
        '
        '
        '
        '
        Me.EmpAF_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAF_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
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
        Me.EmpAF_Tbox.Location = New System.Drawing.Point(130, 189)
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
        Me.EmpAF_Tbox.TabIndex = 15
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
        Me.EmpEmail_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
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
        Me.EmpEmail_Tbox.Location = New System.Drawing.Point(130, 153)
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
        Me.EmpEmail_Tbox.TabIndex = 14
        Me.EmpEmail_Tbox.UseCustomForeColor = True
        Me.EmpEmail_Tbox.UseSelectable = True
        Me.EmpEmail_Tbox.WaterMark = "e.g sampleEmail@gmail.com"
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
        Me.EmpCPno_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
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
        Me.EmpCPno_Tbox.Location = New System.Drawing.Point(130, 117)
        Me.EmpCPno_Tbox.MaxLength = 13
        Me.EmpCPno_Tbox.Name = "EmpCPno_Tbox"
        Me.EmpCPno_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpCPno_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpCPno_Tbox.SelectedText = ""
        Me.EmpCPno_Tbox.SelectionLength = 0
        Me.EmpCPno_Tbox.SelectionStart = 0
        Me.EmpCPno_Tbox.ShowClearButton = True
        Me.EmpCPno_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.EmpCPno_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpCPno_Tbox.TabIndex = 13
        Me.EmpCPno_Tbox.UseCustomForeColor = True
        Me.EmpCPno_Tbox.UseSelectable = True
        Me.EmpCPno_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpCPno_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EmpGender_Cbox
        '
        Me.EmpGender_Cbox.FormattingEnabled = True
        Me.EmpGender_Cbox.ItemHeight = 23
        Me.EmpGender_Cbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.EmpGender_Cbox.Location = New System.Drawing.Point(130, 82)
        Me.EmpGender_Cbox.Name = "EmpGender_Cbox"
        Me.EmpGender_Cbox.Size = New System.Drawing.Size(150, 29)
        Me.EmpGender_Cbox.TabIndex = 12
        Me.EmpGender_Cbox.UseSelectable = True
        '
        'EmpBday_DTP
        '
        Me.EmpBday_DTP.Location = New System.Drawing.Point(130, 47)
        Me.EmpBday_DTP.MinimumSize = New System.Drawing.Size(0, 29)
        Me.EmpBday_DTP.Name = "EmpBday_DTP"
        Me.EmpBday_DTP.Size = New System.Drawing.Size(300, 29)
        Me.EmpBday_DTP.TabIndex = 11
        '
        'EmpName_Tbox
        '
        '
        '
        '
        Me.EmpName_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.EmpName_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.EmpName_Tbox.CustomButton.Name = ""
        Me.EmpName_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.EmpName_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpName_Tbox.CustomButton.TabIndex = 1
        Me.EmpName_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmpName_Tbox.CustomButton.UseSelectable = True
        Me.EmpName_Tbox.CustomButton.Visible = False
        Me.EmpName_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.EmpName_Tbox.ForeColor = System.Drawing.Color.Black
        Me.EmpName_Tbox.Lines = New String(-1) {}
        Me.EmpName_Tbox.Location = New System.Drawing.Point(130, 11)
        Me.EmpName_Tbox.MaxLength = 32767
        Me.EmpName_Tbox.Name = "EmpName_Tbox"
        Me.EmpName_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmpName_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmpName_Tbox.SelectedText = ""
        Me.EmpName_Tbox.SelectionLength = 0
        Me.EmpName_Tbox.SelectionStart = 0
        Me.EmpName_Tbox.ShowClearButton = True
        Me.EmpName_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.EmpName_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmpName_Tbox.TabIndex = 10
        Me.EmpName_Tbox.UseCustomForeColor = True
        Me.EmpName_Tbox.UseSelectable = True
        Me.EmpName_Tbox.WaterMark = "e.g Arch. Juan D. La Cruz"
        Me.EmpName_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmpName_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.Location = New System.Drawing.Point(50, 228)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(74, 25)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "AF Type:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(12, 262)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel7.TabIndex = 8
        Me.MetroLabel7.Text = "AF Releasing:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(89, 192)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(35, 25)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "AF:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(60, 155)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(64, 25)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "E-mail:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 119)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Mobile No.:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(51, 84)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 25)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Gender:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(45, 49)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Birthday:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(62, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Name:"
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
        Me.LoadingPbox.TabIndex = 19
        Me.LoadingPbox.TabStop = False
        Me.LoadingPbox.Visible = False
        '
        'PD_UpdateEMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 429)
        Me.Controls.Add(Me.LoadingPbox)
        Me.Controls.Add(Me.Emp_TabControl)
        Me.MaximizeBox = False
        Me.Name = "PD_UpdateEMP"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Employee"
        Me.Emp_TabControl.ResumeLayout(False)
        Me.Emp_TabPage.ResumeLayout(False)
        Me.Emp_TabPage.PerformLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Emp_TabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Emp_TabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Public WithEvents EmpName_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents EmpAFRel_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents EmpAFType_Cbox As MetroFramework.Controls.MetroComboBox
    Public WithEvents EmpAF_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents EmpEmail_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents EmpCPno_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents EmpGender_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents EmpBday_DTP As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Save_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents LoadingPbox As PictureBox
End Class
