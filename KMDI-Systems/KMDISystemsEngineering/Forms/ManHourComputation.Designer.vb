<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHourComputation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManHourComputation))
        Me.Mktng_InvLBL = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SysType_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Factor_Tbox = New System.Windows.Forms.MaskedTextBox()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.MHC_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MHC_Cmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mktng_InvLBL
        '
        Me.Mktng_InvLBL.AutoSize = True
        Me.Mktng_InvLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mktng_InvLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mktng_InvLBL.Location = New System.Drawing.Point(15, 24)
        Me.Mktng_InvLBL.Name = "Mktng_InvLBL"
        Me.Mktng_InvLBL.Size = New System.Drawing.Size(179, 25)
        Me.Mktng_InvLBL.TabIndex = 609
        Me.Mktng_InvLBL.Text = "S Y S T E M   T Y P E"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_Pnl)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.SysType_Tbox)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.Factor_Tbox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(418, 351)
        Me.Panel1.TabIndex = 610
        '
        'DGV_Pnl
        '
        Me.DGV_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DGV_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV_Pnl.Location = New System.Drawing.Point(5, 5)
        Me.DGV_Pnl.Name = "DGV_Pnl"
        Me.DGV_Pnl.Size = New System.Drawing.Size(406, 268)
        Me.DGV_Pnl.TabIndex = 6
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(49, 317)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel2.TabIndex = 12
        Me.MetroLabel2.Text = "Factor:"
        '
        'SysType_Tbox
        '
        Me.SysType_Tbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.SysType_Tbox.CustomButton.Image = Nothing
        Me.SysType_Tbox.CustomButton.Location = New System.Drawing.Point(277, 2)
        Me.SysType_Tbox.CustomButton.Name = ""
        Me.SysType_Tbox.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.SysType_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SysType_Tbox.CustomButton.TabIndex = 1
        Me.SysType_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SysType_Tbox.CustomButton.UseSelectable = True
        Me.SysType_Tbox.CustomButton.Visible = False
        Me.SysType_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.SysType_Tbox.Lines = New String(-1) {}
        Me.SysType_Tbox.Location = New System.Drawing.Point(105, 279)
        Me.SysType_Tbox.MaxLength = 32767
        Me.SysType_Tbox.Name = "SysType_Tbox"
        Me.SysType_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SysType_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SysType_Tbox.SelectedText = ""
        Me.SysType_Tbox.SelectionLength = 0
        Me.SysType_Tbox.SelectionStart = 0
        Me.SysType_Tbox.Size = New System.Drawing.Size(303, 28)
        Me.SysType_Tbox.TabIndex = 11
        Me.SysType_Tbox.UseSelectable = True
        Me.SysType_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SysType_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 283)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 10
        Me.MetroLabel1.Text = "System Type:"
        '
        'Factor_Tbox
        '
        Me.Factor_Tbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Factor_Tbox.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Factor_Tbox.Location = New System.Drawing.Point(105, 313)
        Me.Factor_Tbox.Mask = "00:00:00"
        Me.Factor_Tbox.Name = "Factor_Tbox"
        Me.Factor_Tbox.Size = New System.Drawing.Size(303, 28)
        Me.Factor_Tbox.TabIndex = 13
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(374, 26)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 612
        Me.LoadingPB.TabStop = False
        '
        'MHC_Cmenu
        '
        Me.MHC_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.MHC_Cmenu.Name = "MHC_Cmenu"
        Me.MHC_Cmenu.Size = New System.Drawing.Size(113, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ManHourComputation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 431)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Mktng_InvLBL)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManHourComputation"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MHC_Cmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mktng_InvLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_Pnl As Panel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SysType_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Factor_Tbox As MaskedTextBox
    Friend WithEvents MHC_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
