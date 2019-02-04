<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TE_Installation_CPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TE_Installation_CPanel))
        Me.Mktng_InvLBL = New MetroFramework.Controls.MetroLabel()
        Me.Frm_PNL = New System.Windows.Forms.Panel()
        Me.DGV_Pnl = New System.Windows.Forms.Panel()
        Me.XL_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.L_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.M_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.S_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.XS_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ProfileType_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.ProfileType_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Frm_PNL.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mktng_InvLBL
        '
        Me.Mktng_InvLBL.AutoSize = True
        Me.Mktng_InvLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mktng_InvLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mktng_InvLBL.Location = New System.Drawing.Point(15, 24)
        Me.Mktng_InvLBL.Name = "Mktng_InvLBL"
        Me.Mktng_InvLBL.Size = New System.Drawing.Size(197, 25)
        Me.Mktng_InvLBL.TabIndex = 610
        Me.Mktng_InvLBL.Text = "T I M E   E L E M E N T"
        '
        'Frm_PNL
        '
        Me.Frm_PNL.Controls.Add(Me.DGV_Pnl)
        Me.Frm_PNL.Controls.Add(Me.XL_Tbox)
        Me.Frm_PNL.Controls.Add(Me.L_Tbox)
        Me.Frm_PNL.Controls.Add(Me.M_Tbox)
        Me.Frm_PNL.Controls.Add(Me.S_Tbox)
        Me.Frm_PNL.Controls.Add(Me.XS_Tbox)
        Me.Frm_PNL.Controls.Add(Me.MetroLabel5)
        Me.Frm_PNL.Controls.Add(Me.MetroLabel4)
        Me.Frm_PNL.Controls.Add(Me.MetroLabel3)
        Me.Frm_PNL.Controls.Add(Me.MetroLabel2)
        Me.Frm_PNL.Controls.Add(Me.MetroLabel1)
        Me.Frm_PNL.Controls.Add(Me.ProfileType_Tbox)
        Me.Frm_PNL.Controls.Add(Me.ProfileType_Cbox)
        Me.Frm_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_PNL.Location = New System.Drawing.Point(20, 60)
        Me.Frm_PNL.Name = "Frm_PNL"
        Me.Frm_PNL.Padding = New System.Windows.Forms.Padding(10)
        Me.Frm_PNL.Size = New System.Drawing.Size(879, 241)
        Me.Frm_PNL.TabIndex = 0
        '
        'DGV_Pnl
        '
        Me.DGV_Pnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.DGV_Pnl.Location = New System.Drawing.Point(342, 10)
        Me.DGV_Pnl.Name = "DGV_Pnl"
        Me.DGV_Pnl.Size = New System.Drawing.Size(527, 221)
        Me.DGV_Pnl.TabIndex = 18
        '
        'XL_Tbox
        '
        Me.XL_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.XL_Tbox.CustomButton.Image = Nothing
        Me.XL_Tbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.XL_Tbox.CustomButton.Name = ""
        Me.XL_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.XL_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.XL_Tbox.CustomButton.TabIndex = 1
        Me.XL_Tbox.CustomButton.Text = "+"
        Me.XL_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.XL_Tbox.CustomButton.UseSelectable = True
        Me.XL_Tbox.CustomButton.Visible = False
        Me.XL_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.XL_Tbox.Lines = New String(-1) {}
        Me.XL_Tbox.Location = New System.Drawing.Point(131, 202)
        Me.XL_Tbox.MaxLength = 32767
        Me.XL_Tbox.Name = "XL_Tbox"
        Me.XL_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.XL_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.XL_Tbox.SelectedText = ""
        Me.XL_Tbox.SelectionLength = 0
        Me.XL_Tbox.SelectionStart = 0
        Me.XL_Tbox.Size = New System.Drawing.Size(205, 30)
        Me.XL_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.XL_Tbox.TabIndex = 6
        Me.XL_Tbox.UseSelectable = True
        Me.XL_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.XL_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'L_Tbox
        '
        Me.L_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.L_Tbox.CustomButton.Image = Nothing
        Me.L_Tbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.L_Tbox.CustomButton.Name = ""
        Me.L_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.L_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.L_Tbox.CustomButton.TabIndex = 1
        Me.L_Tbox.CustomButton.Text = "+"
        Me.L_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.L_Tbox.CustomButton.UseSelectable = True
        Me.L_Tbox.CustomButton.Visible = False
        Me.L_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.L_Tbox.Lines = New String(-1) {}
        Me.L_Tbox.Location = New System.Drawing.Point(131, 166)
        Me.L_Tbox.MaxLength = 32767
        Me.L_Tbox.Name = "L_Tbox"
        Me.L_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.L_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.L_Tbox.SelectedText = ""
        Me.L_Tbox.SelectionLength = 0
        Me.L_Tbox.SelectionStart = 0
        Me.L_Tbox.Size = New System.Drawing.Size(205, 30)
        Me.L_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.L_Tbox.TabIndex = 5
        Me.L_Tbox.UseSelectable = True
        Me.L_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.L_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'M_Tbox
        '
        Me.M_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.M_Tbox.CustomButton.Image = Nothing
        Me.M_Tbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.M_Tbox.CustomButton.Name = ""
        Me.M_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.M_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.M_Tbox.CustomButton.TabIndex = 1
        Me.M_Tbox.CustomButton.Text = "+"
        Me.M_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.M_Tbox.CustomButton.UseSelectable = True
        Me.M_Tbox.CustomButton.Visible = False
        Me.M_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.M_Tbox.Lines = New String(-1) {}
        Me.M_Tbox.Location = New System.Drawing.Point(131, 130)
        Me.M_Tbox.MaxLength = 32767
        Me.M_Tbox.Name = "M_Tbox"
        Me.M_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.M_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.M_Tbox.SelectedText = ""
        Me.M_Tbox.SelectionLength = 0
        Me.M_Tbox.SelectionStart = 0
        Me.M_Tbox.Size = New System.Drawing.Size(205, 30)
        Me.M_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.M_Tbox.TabIndex = 4
        Me.M_Tbox.UseSelectable = True
        Me.M_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.M_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'S_Tbox
        '
        Me.S_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.S_Tbox.CustomButton.Image = Nothing
        Me.S_Tbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.S_Tbox.CustomButton.Name = ""
        Me.S_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.S_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.S_Tbox.CustomButton.TabIndex = 1
        Me.S_Tbox.CustomButton.Text = "+"
        Me.S_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.S_Tbox.CustomButton.UseSelectable = True
        Me.S_Tbox.CustomButton.Visible = False
        Me.S_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.S_Tbox.Lines = New String(-1) {}
        Me.S_Tbox.Location = New System.Drawing.Point(131, 94)
        Me.S_Tbox.MaxLength = 32767
        Me.S_Tbox.Name = "S_Tbox"
        Me.S_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.S_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.S_Tbox.SelectedText = ""
        Me.S_Tbox.SelectionLength = 0
        Me.S_Tbox.SelectionStart = 0
        Me.S_Tbox.Size = New System.Drawing.Size(205, 30)
        Me.S_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.S_Tbox.TabIndex = 3
        Me.S_Tbox.UseSelectable = True
        Me.S_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.S_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'XS_Tbox
        '
        Me.XS_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.XS_Tbox.CustomButton.Image = Nothing
        Me.XS_Tbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.XS_Tbox.CustomButton.Name = ""
        Me.XS_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.XS_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.XS_Tbox.CustomButton.TabIndex = 1
        Me.XS_Tbox.CustomButton.Text = "+"
        Me.XS_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.XS_Tbox.CustomButton.UseSelectable = True
        Me.XS_Tbox.CustomButton.Visible = False
        Me.XS_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.XS_Tbox.Lines = New String(-1) {}
        Me.XS_Tbox.Location = New System.Drawing.Point(131, 58)
        Me.XS_Tbox.MaxLength = 32767
        Me.XS_Tbox.Name = "XS_Tbox"
        Me.XS_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.XS_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.XS_Tbox.SelectedText = ""
        Me.XS_Tbox.SelectionLength = 0
        Me.XS_Tbox.SelectionStart = 0
        Me.XS_Tbox.Size = New System.Drawing.Size(205, 30)
        Me.XS_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.XS_Tbox.TabIndex = 2
        Me.XS_Tbox.UseSelectable = True
        Me.XS_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.XS_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(13, 203)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Extra Large : "
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(56, 169)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Large : "
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(33, 132)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Medium : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(56, 95)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 25)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Small : "
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 58)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Extra Small : "
        '
        'ProfileType_Tbox
        '
        '
        '
        '
        Me.ProfileType_Tbox.CustomButton.Image = Nothing
        Me.ProfileType_Tbox.CustomButton.Location = New System.Drawing.Point(139, 2)
        Me.ProfileType_Tbox.CustomButton.Name = ""
        Me.ProfileType_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.ProfileType_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ProfileType_Tbox.CustomButton.TabIndex = 1
        Me.ProfileType_Tbox.CustomButton.Text = "+"
        Me.ProfileType_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ProfileType_Tbox.CustomButton.UseSelectable = True
        Me.ProfileType_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.ProfileType_Tbox.Lines = New String(-1) {}
        Me.ProfileType_Tbox.Location = New System.Drawing.Point(169, 13)
        Me.ProfileType_Tbox.MaxLength = 32767
        Me.ProfileType_Tbox.Name = "ProfileType_Tbox"
        Me.ProfileType_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProfileType_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProfileType_Tbox.SelectedText = ""
        Me.ProfileType_Tbox.SelectionLength = 0
        Me.ProfileType_Tbox.SelectionStart = 0
        Me.ProfileType_Tbox.ShowButton = True
        Me.ProfileType_Tbox.Size = New System.Drawing.Size(167, 30)
        Me.ProfileType_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.ProfileType_Tbox.TabIndex = 1
        Me.ProfileType_Tbox.UseSelectable = True
        Me.ProfileType_Tbox.WaterMark = "Profile Type"
        Me.ProfileType_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ProfileType_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProfileType_Cbox
        '
        Me.ProfileType_Cbox.FormattingEnabled = True
        Me.ProfileType_Cbox.ItemHeight = 23
        Me.ProfileType_Cbox.Location = New System.Drawing.Point(13, 13)
        Me.ProfileType_Cbox.Name = "ProfileType_Cbox"
        Me.ProfileType_Cbox.Size = New System.Drawing.Size(150, 29)
        Me.ProfileType_Cbox.TabIndex = 7
        Me.ProfileType_Cbox.UseSelectable = True
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(830, 26)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 612
        Me.LoadingPB.TabStop = False
        '
        'TE_Installation_CPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 321)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Mktng_InvLBL)
        Me.Controls.Add(Me.Frm_PNL)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TE_Installation_CPanel"
        Me.Resizable = False
        Me.Frm_PNL.ResumeLayout(False)
        Me.Frm_PNL.PerformLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mktng_InvLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents Frm_PNL As Panel
    Friend WithEvents ProfileType_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents ProfileType_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents XL_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents L_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents M_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents S_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents XS_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DGV_Pnl As Panel
End Class
