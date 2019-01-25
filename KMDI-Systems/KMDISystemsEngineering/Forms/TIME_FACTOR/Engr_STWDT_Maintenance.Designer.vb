<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Engr_STWDT_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Engr_STWDT_Maintenance))
        Me.Mktng_InvLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Frm_PNL = New System.Windows.Forms.Panel()
        Me.STRdBtn_FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.WindowType_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.WDT_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TFactorSecs_Num = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TFactorMins_Num = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.WDTRdBtn_FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.TFactorHrs_Num = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.SystemType_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.STWDT_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frm_PNL.SuspendLayout()
        Me.WDT_Pnl.SuspendLayout()
        Me.STWDT_Cmenu.SuspendLayout()
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
        Me.Frm_PNL.Controls.Add(Me.STRdBtn_FLP)
        Me.Frm_PNL.Controls.Add(Me.WindowType_Tbox)
        Me.Frm_PNL.Controls.Add(Me.WDT_Pnl)
        Me.Frm_PNL.Controls.Add(Me.SystemType_Tbox)
        Me.Frm_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_PNL.Location = New System.Drawing.Point(20, 60)
        Me.Frm_PNL.Name = "Frm_PNL"
        Me.Frm_PNL.Padding = New System.Windows.Forms.Padding(5, 40, 5, 5)
        Me.Frm_PNL.Size = New System.Drawing.Size(610, 307)
        Me.Frm_PNL.TabIndex = 614
        '
        'STRdBtn_FLP
        '
        Me.STRdBtn_FLP.AutoScroll = True
        Me.STRdBtn_FLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.STRdBtn_FLP.Dock = System.Windows.Forms.DockStyle.Left
        Me.STRdBtn_FLP.Location = New System.Drawing.Point(5, 40)
        Me.STRdBtn_FLP.Name = "STRdBtn_FLP"
        Me.STRdBtn_FLP.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.STRdBtn_FLP.Size = New System.Drawing.Size(298, 260)
        Me.STRdBtn_FLP.TabIndex = 600
        '
        'WindowType_Tbox
        '
        Me.WindowType_Tbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.WindowType_Tbox.CustomButton.Image = Nothing
        Me.WindowType_Tbox.CustomButton.Location = New System.Drawing.Point(271, 2)
        Me.WindowType_Tbox.CustomButton.Name = ""
        Me.WindowType_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.WindowType_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.WindowType_Tbox.CustomButton.TabIndex = 1
        Me.WindowType_Tbox.CustomButton.Text = "+"
        Me.WindowType_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.WindowType_Tbox.CustomButton.UseSelectable = True
        Me.WindowType_Tbox.CustomButton.UseStyleColors = True
        Me.WindowType_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.WindowType_Tbox.Lines = New String(-1) {}
        Me.WindowType_Tbox.Location = New System.Drawing.Point(306, 7)
        Me.WindowType_Tbox.MaxLength = 32767
        Me.WindowType_Tbox.Name = "WindowType_Tbox"
        Me.WindowType_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WindowType_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.WindowType_Tbox.SelectedText = ""
        Me.WindowType_Tbox.SelectionLength = 0
        Me.WindowType_Tbox.SelectionStart = 0
        Me.WindowType_Tbox.ShowButton = True
        Me.WindowType_Tbox.Size = New System.Drawing.Size(297, 28)
        Me.WindowType_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.WindowType_Tbox.TabIndex = 617
        Me.WindowType_Tbox.UseSelectable = True
        Me.WindowType_Tbox.WaterMark = "Window Type"
        Me.WindowType_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.WindowType_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'WDT_Pnl
        '
        Me.WDT_Pnl.AutoScroll = True
        Me.WDT_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WDT_Pnl.Controls.Add(Me.MetroLabel3)
        Me.WDT_Pnl.Controls.Add(Me.TFactorSecs_Num)
        Me.WDT_Pnl.Controls.Add(Me.MetroLabel2)
        Me.WDT_Pnl.Controls.Add(Me.TFactorMins_Num)
        Me.WDT_Pnl.Controls.Add(Me.MetroLabel1)
        Me.WDT_Pnl.Controls.Add(Me.WDTRdBtn_FLP)
        Me.WDT_Pnl.Controls.Add(Me.TFactorHrs_Num)
        Me.WDT_Pnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.WDT_Pnl.Location = New System.Drawing.Point(306, 40)
        Me.WDT_Pnl.Name = "WDT_Pnl"
        Me.WDT_Pnl.Padding = New System.Windows.Forms.Padding(10)
        Me.WDT_Pnl.Size = New System.Drawing.Size(297, 260)
        Me.WDT_Pnl.TabIndex = 616
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
        'WDTRdBtn_FLP
        '
        Me.WDTRdBtn_FLP.AutoScroll = True
        Me.WDTRdBtn_FLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WDTRdBtn_FLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.WDTRdBtn_FLP.Location = New System.Drawing.Point(10, 10)
        Me.WDTRdBtn_FLP.Name = "WDTRdBtn_FLP"
        Me.WDTRdBtn_FLP.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.WDTRdBtn_FLP.Size = New System.Drawing.Size(275, 201)
        Me.WDTRdBtn_FLP.TabIndex = 621
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
        'SystemType_Tbox
        '
        Me.SystemType_Tbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.SystemType_Tbox.CustomButton.Image = Nothing
        Me.SystemType_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.SystemType_Tbox.CustomButton.Name = ""
        Me.SystemType_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.SystemType_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SystemType_Tbox.CustomButton.TabIndex = 1
        Me.SystemType_Tbox.CustomButton.Text = "+"
        Me.SystemType_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SystemType_Tbox.CustomButton.UseSelectable = True
        Me.SystemType_Tbox.CustomButton.UseStyleColors = True
        Me.SystemType_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.SystemType_Tbox.Lines = New String(-1) {}
        Me.SystemType_Tbox.Location = New System.Drawing.Point(5, 7)
        Me.SystemType_Tbox.MaxLength = 32767
        Me.SystemType_Tbox.Name = "SystemType_Tbox"
        Me.SystemType_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SystemType_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SystemType_Tbox.SelectedText = ""
        Me.SystemType_Tbox.SelectionLength = 0
        Me.SystemType_Tbox.SelectionStart = 0
        Me.SystemType_Tbox.ShowButton = True
        Me.SystemType_Tbox.Size = New System.Drawing.Size(298, 28)
        Me.SystemType_Tbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.SystemType_Tbox.TabIndex = 615
        Me.SystemType_Tbox.UseSelectable = True
        Me.SystemType_Tbox.WaterMark = "System Type"
        Me.SystemType_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SystemType_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'STWDT_Cmenu
        '
        Me.STWDT_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.STWDT_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.STWDT_Cmenu.Name = "MetroContextMenu1"
        Me.STWDT_Cmenu.Size = New System.Drawing.Size(108, 48)
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
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Engr_STWDT_Maintenance
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
        Me.Name = "Engr_STWDT_Maintenance"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frm_PNL.ResumeLayout(False)
        Me.WDT_Pnl.ResumeLayout(False)
        Me.WDT_Pnl.PerformLayout()
        Me.STWDT_Cmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mktng_InvLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents Frm_PNL As Panel
    Friend WithEvents WindowType_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents WDT_Pnl As Panel
    Friend WithEvents SystemType_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents STRdBtn_FLP As FlowLayoutPanel
    Friend WithEvents WDTRdBtn_FLP As FlowLayoutPanel
    Friend WithEvents STWDT_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TFactorHrs_Num As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TFactorSecs_Num As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TFactorMins_Num As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
