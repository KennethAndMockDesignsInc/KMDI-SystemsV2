<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Engr_Time_Factor_Maintenance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Engr_Time_Factor_Maintenance))
        Me.Mktng_InvLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Frm_PNL = New System.Windows.Forms.Panel()
        Me.FrameScreen_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.LeftRdBtn_FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.Left_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Right_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TFactorSecs_Num = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TFactorMins_Num = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.RightRdBtn_FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.TFactorHrs_Num = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.Right_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.TFM_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frm_PNL.SuspendLayout()
        Me.Right_Pnl.SuspendLayout()
        Me.TFM_Cmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mktng_InvLBL
        '
        Me.Mktng_InvLBL.AutoSize = True
        Me.Mktng_InvLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mktng_InvLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mktng_InvLBL.Location = New System.Drawing.Point(15, 24)
        Me.Mktng_InvLBL.Name = "Mktng_InvLBL"
        Me.Mktng_InvLBL.Size = New System.Drawing.Size(195, 25)
        Me.Mktng_InvLBL.TabIndex = 610
        Me.Mktng_InvLBL.Text = "M A I N T E N A N C E"
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(565, 21)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 613
        Me.LoadingPB.TabStop = False
        '
        'Frm_PNL
        '
        Me.Frm_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frm_PNL.Controls.Add(Me.FrameScreen_Cbox)
        Me.Frm_PNL.Controls.Add(Me.LeftRdBtn_FLP)
        Me.Frm_PNL.Controls.Add(Me.Left_Tbox)
        Me.Frm_PNL.Controls.Add(Me.Right_Pnl)
        Me.Frm_PNL.Controls.Add(Me.Right_Tbox)
        Me.Frm_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_PNL.Location = New System.Drawing.Point(20, 60)
        Me.Frm_PNL.Name = "Frm_PNL"
        Me.Frm_PNL.Padding = New System.Windows.Forms.Padding(5, 40, 5, 5)
        Me.Frm_PNL.Size = New System.Drawing.Size(610, 307)
        Me.Frm_PNL.TabIndex = 614
        '
        'FrameScreen_Cbox
        '
        Me.FrameScreen_Cbox.FormattingEnabled = True
        Me.FrameScreen_Cbox.ItemHeight = 23
        Me.FrameScreen_Cbox.Items.AddRange(New Object() {"Frame", "Screen"})
        Me.FrameScreen_Cbox.Location = New System.Drawing.Point(5, 7)
        Me.FrameScreen_Cbox.Name = "FrameScreen_Cbox"
        Me.FrameScreen_Cbox.Size = New System.Drawing.Size(94, 29)
        Me.FrameScreen_Cbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.FrameScreen_Cbox.TabIndex = 615
        Me.FrameScreen_Cbox.UseSelectable = True
        Me.FrameScreen_Cbox.UseStyleColors = True
        '
        'LeftRdBtn_FLP
        '
        Me.LeftRdBtn_FLP.AutoScroll = True
        Me.LeftRdBtn_FLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LeftRdBtn_FLP.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRdBtn_FLP.Location = New System.Drawing.Point(5, 40)
        Me.LeftRdBtn_FLP.Name = "LeftRdBtn_FLP"
        Me.LeftRdBtn_FLP.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LeftRdBtn_FLP.Size = New System.Drawing.Size(298, 260)
        Me.LeftRdBtn_FLP.TabIndex = 600
        '
        'Left_Tbox
        '
        Me.Left_Tbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.Left_Tbox.CustomButton.Image = Nothing
        Me.Left_Tbox.CustomButton.Location = New System.Drawing.Point(271, 2)
        Me.Left_Tbox.CustomButton.Name = ""
        Me.Left_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Left_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Left_Tbox.CustomButton.TabIndex = 1
        Me.Left_Tbox.CustomButton.Text = "+"
        Me.Left_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Left_Tbox.CustomButton.UseSelectable = True
        Me.Left_Tbox.CustomButton.UseStyleColors = True
        Me.Left_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Left_Tbox.Lines = New String(-1) {}
        Me.Left_Tbox.Location = New System.Drawing.Point(306, 7)
        Me.Left_Tbox.MaxLength = 32767
        Me.Left_Tbox.Name = "Left_Tbox"
        Me.Left_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Left_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Left_Tbox.SelectedText = ""
        Me.Left_Tbox.SelectionLength = 0
        Me.Left_Tbox.SelectionStart = 0
        Me.Left_Tbox.ShowButton = True
        Me.Left_Tbox.Size = New System.Drawing.Size(297, 28)
        Me.Left_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.Left_Tbox.TabIndex = 617
        Me.Left_Tbox.UseSelectable = True
        Me.Left_Tbox.WaterMark = "Window Type"
        Me.Left_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Left_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Right_Pnl
        '
        Me.Right_Pnl.AutoScroll = True
        Me.Right_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Right_Pnl.Controls.Add(Me.MetroLabel3)
        Me.Right_Pnl.Controls.Add(Me.TFactorSecs_Num)
        Me.Right_Pnl.Controls.Add(Me.MetroLabel2)
        Me.Right_Pnl.Controls.Add(Me.TFactorMins_Num)
        Me.Right_Pnl.Controls.Add(Me.MetroLabel1)
        Me.Right_Pnl.Controls.Add(Me.RightRdBtn_FLP)
        Me.Right_Pnl.Controls.Add(Me.TFactorHrs_Num)
        Me.Right_Pnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Right_Pnl.Location = New System.Drawing.Point(306, 40)
        Me.Right_Pnl.Name = "Right_Pnl"
        Me.Right_Pnl.Padding = New System.Windows.Forms.Padding(10)
        Me.Right_Pnl.Size = New System.Drawing.Size(297, 260)
        Me.Right_Pnl.TabIndex = 616
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(195, 226)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel3.TabIndex = 625
        Me.MetroLabel3.Text = "Secs."
        '
        'TFactorSecs_Num
        '
        Me.TFactorSecs_Num.Location = New System.Drawing.Point(240, 226)
        Me.TFactorSecs_Num.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.TFactorSecs_Num.Name = "TFactorSecs_Num"
        Me.TFactorSecs_Num.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.TFactorSecs_Num.Size = New System.Drawing.Size(47, 22)
        Me.TFactorSecs_Num.TabIndex = 3
        Me.TFactorSecs_Num.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(97, 226)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 623
        Me.MetroLabel2.Text = "Mins."
        '
        'TFactorMins_Num
        '
        Me.TFactorMins_Num.Location = New System.Drawing.Point(142, 226)
        Me.TFactorMins_Num.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.TFactorMins_Num.Name = "TFactorMins_Num"
        Me.TFactorMins_Num.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.TFactorMins_Num.Size = New System.Drawing.Size(47, 22)
        Me.TFactorMins_Num.TabIndex = 2
        Me.TFactorMins_Num.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(7, 226)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel1.TabIndex = 621
        Me.MetroLabel1.Text = "Hrs."
        '
        'RightRdBtn_FLP
        '
        Me.RightRdBtn_FLP.AutoScroll = True
        Me.RightRdBtn_FLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RightRdBtn_FLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.RightRdBtn_FLP.Location = New System.Drawing.Point(10, 10)
        Me.RightRdBtn_FLP.Name = "RightRdBtn_FLP"
        Me.RightRdBtn_FLP.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.RightRdBtn_FLP.Size = New System.Drawing.Size(275, 201)
        Me.RightRdBtn_FLP.TabIndex = 621
        '
        'TFactorHrs_Num
        '
        Me.TFactorHrs_Num.Location = New System.Drawing.Point(44, 226)
        Me.TFactorHrs_Num.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.TFactorHrs_Num.Name = "TFactorHrs_Num"
        Me.TFactorHrs_Num.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.TFactorHrs_Num.Size = New System.Drawing.Size(47, 22)
        Me.TFactorHrs_Num.TabIndex = 1
        Me.TFactorHrs_Num.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        '
        'Right_Tbox
        '
        Me.Right_Tbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.Right_Tbox.CustomButton.Image = Nothing
        Me.Right_Tbox.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.Right_Tbox.CustomButton.Name = ""
        Me.Right_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.Right_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Right_Tbox.CustomButton.TabIndex = 1
        Me.Right_Tbox.CustomButton.Text = "+"
        Me.Right_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Right_Tbox.CustomButton.UseSelectable = True
        Me.Right_Tbox.CustomButton.UseStyleColors = True
        Me.Right_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Right_Tbox.Lines = New String(-1) {}
        Me.Right_Tbox.Location = New System.Drawing.Point(105, 7)
        Me.Right_Tbox.MaxLength = 32767
        Me.Right_Tbox.Name = "Right_Tbox"
        Me.Right_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Right_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Right_Tbox.SelectedText = ""
        Me.Right_Tbox.SelectionLength = 0
        Me.Right_Tbox.SelectionStart = 0
        Me.Right_Tbox.ShowButton = True
        Me.Right_Tbox.Size = New System.Drawing.Size(195, 28)
        Me.Right_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.Right_Tbox.TabIndex = 615
        Me.Right_Tbox.UseSelectable = True
        Me.Right_Tbox.WaterMark = "System Type"
        Me.Right_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Right_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TFM_Cmenu
        '
        Me.TFM_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TFM_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.TFM_Cmenu.Name = "MetroContextMenu1"
        Me.TFM_Cmenu.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Engr_Time_Factor_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 387)
        Me.Controls.Add(Me.Frm_PNL)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Mktng_InvLBL)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Engr_Time_Factor_Maintenance"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frm_PNL.ResumeLayout(False)
        Me.Right_Pnl.ResumeLayout(False)
        Me.Right_Pnl.PerformLayout()
        Me.TFM_Cmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mktng_InvLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents Frm_PNL As Panel
    Friend WithEvents Left_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Right_Pnl As Panel
    Friend WithEvents Right_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LeftRdBtn_FLP As FlowLayoutPanel
    Friend WithEvents RightRdBtn_FLP As FlowLayoutPanel
    Friend WithEvents TFM_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TFactorHrs_Num As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TFactorSecs_Num As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TFactorMins_Num As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents FrameScreen_Cbox As MetroFramework.Controls.MetroComboBox
End Class
