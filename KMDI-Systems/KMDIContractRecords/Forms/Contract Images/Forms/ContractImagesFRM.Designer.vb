<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContractImagesFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContractImagesFRM))
        Me.ContractImages_PNL = New System.Windows.Forms.Panel()
        Me.ContractImages_LBL = New MetroFramework.Controls.MetroLabel()
        Me.Load_PB = New MetroFramework.Controls.MetroProgressBar()
        Me.Load_LBL = New MetroFramework.Controls.MetroLabel()
        Me.ScannedMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintCtrlPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDoc_PDC = New System.Drawing.Printing.PrintDocument()
        Me.PrintPage_PDG = New System.Windows.Forms.PrintDialog()
        Me.PageNo_LBL = New MetroFramework.Controls.MetroLabel()
        Me.PrintSetup_PSD = New System.Windows.Forms.PageSetupDialog()
        Me.ScannedMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContractImages_PNL
        '
        Me.ContractImages_PNL.AutoScroll = True
        Me.ContractImages_PNL.BackColor = System.Drawing.Color.LightSlateGray
        Me.ContractImages_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContractImages_PNL.Location = New System.Drawing.Point(20, 60)
        Me.ContractImages_PNL.Name = "ContractImages_PNL"
        Me.ContractImages_PNL.Size = New System.Drawing.Size(918, 538)
        Me.ContractImages_PNL.TabIndex = 0
        '
        'ContractImages_LBL
        '
        Me.ContractImages_LBL.AutoSize = True
        Me.ContractImages_LBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ContractImages_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ContractImages_LBL.Location = New System.Drawing.Point(20, 32)
        Me.ContractImages_LBL.Name = "ContractImages_LBL"
        Me.ContractImages_LBL.Size = New System.Drawing.Size(274, 25)
        Me.ContractImages_LBL.TabIndex = 607
        Me.ContractImages_LBL.Text = "S C A N N E D   C O N T R A C T"
        '
        'Load_PB
        '
        Me.Load_PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Load_PB.Location = New System.Drawing.Point(817, 32)
        Me.Load_PB.Name = "Load_PB"
        Me.Load_PB.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.Load_PB.Size = New System.Drawing.Size(121, 23)
        Me.Load_PB.Style = MetroFramework.MetroColorStyle.Silver
        Me.Load_PB.TabIndex = 609
        '
        'Load_LBL
        '
        Me.Load_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Load_LBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Load_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Load_LBL.Location = New System.Drawing.Point(451, 32)
        Me.Load_LBL.Name = "Load_LBL"
        Me.Load_LBL.Size = New System.Drawing.Size(364, 25)
        Me.Load_LBL.TabIndex = 610
        Me.Load_LBL.Text = "Retrieving scanned contracts. Please wait"
        Me.Load_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ScannedMenuStrip
        '
        Me.ScannedMenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ScannedMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintCtrlPToolStripMenuItem})
        Me.ScannedMenuStrip.Name = "ScannedMenuStrip"
        Me.ScannedMenuStrip.Size = New System.Drawing.Size(145, 26)
        '
        'PrintCtrlPToolStripMenuItem
        '
        Me.PrintCtrlPToolStripMenuItem.Name = "PrintCtrlPToolStripMenuItem"
        Me.PrintCtrlPToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PrintCtrlPToolStripMenuItem.Text = "Print (Ctrl+P)"
        '
        'PrintDoc_PDC
        '
        Me.PrintDoc_PDC.OriginAtMargins = True
        '
        'PrintPage_PDG
        '
        Me.PrintPage_PDG.Document = Me.PrintDoc_PDC
        Me.PrintPage_PDG.UseEXDialog = True
        '
        'PageNo_LBL
        '
        Me.PageNo_LBL.AutoSize = True
        Me.PageNo_LBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.PageNo_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.PageNo_LBL.Location = New System.Drawing.Point(300, 32)
        Me.PageNo_LBL.Name = "PageNo_LBL"
        Me.PageNo_LBL.Size = New System.Drawing.Size(0, 0)
        Me.PageNo_LBL.TabIndex = 611
        '
        'PrintSetup_PSD
        '
        Me.PrintSetup_PSD.AllowMargins = False
        Me.PrintSetup_PSD.Document = Me.PrintDoc_PDC
        '
        'ContractImagesFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 618)
        Me.Controls.Add(Me.PageNo_LBL)
        Me.Controls.Add(Me.Load_LBL)
        Me.Controls.Add(Me.Load_PB)
        Me.Controls.Add(Me.ContractImages_LBL)
        Me.Controls.Add(Me.ContractImages_PNL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContractImagesFRM"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.ScannedMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContractImages_PNL As Panel
    Friend WithEvents ContractImages_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents Load_PB As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Load_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents ScannedMenuStrip As ContextMenuStrip
    Friend WithEvents PrintCtrlPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDoc_PDC As Printing.PrintDocument
    Friend WithEvents PrintPage_PDG As PrintDialog
    Friend WithEvents PageNo_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents PrintSetup_PSD As PageSetupDialog
End Class
