<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contracts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ViewLockedContracts = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.LockedContractsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractsDGV = New MetroFramework.Controls.MetroGrid()
        Me.ContractsDGV_Panel = New System.Windows.Forms.Panel()
        Me.ViewLockedContracts.SuspendLayout()
        CType(Me.ContractsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContractsDGV_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewLockedContracts
        '
        Me.ViewLockedContracts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockedContractsToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.ViewLockedContracts.Name = "MetroContextMenu1"
        Me.ViewLockedContracts.Size = New System.Drawing.Size(199, 48)
        Me.ViewLockedContracts.Text = "View Locked Contracts"
        '
        'LockedContractsToolStripMenuItem
        '
        Me.LockedContractsToolStripMenuItem.CheckOnClick = True
        Me.LockedContractsToolStripMenuItem.Name = "LockedContractsToolStripMenuItem"
        Me.LockedContractsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LockedContractsToolStripMenuItem.Text = "Show Locked Contracts"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ContractsDGV
        '
        Me.ContractsDGV.AllowUserToAddRows = False
        Me.ContractsDGV.AllowUserToDeleteRows = False
        Me.ContractsDGV.AllowUserToOrderColumns = True
        Me.ContractsDGV.AllowUserToResizeRows = False
        Me.ContractsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ContractsDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContractsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContractsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ContractsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(189, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContractsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ContractsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContractsDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.ContractsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContractsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ContractsDGV.EnableHeadersVisualStyles = False
        Me.ContractsDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ContractsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContractsDGV.Location = New System.Drawing.Point(0, 0)
        Me.ContractsDGV.MultiSelect = False
        Me.ContractsDGV.Name = "ContractsDGV"
        Me.ContractsDGV.ReadOnly = True
        Me.ContractsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(189, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContractsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ContractsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ContractsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ContractsDGV.Size = New System.Drawing.Size(747, 410)
        Me.ContractsDGV.Style = MetroFramework.MetroColorStyle.Pink
        Me.ContractsDGV.TabIndex = 8
        Me.ContractsDGV.UseStyleColors = True
        '
        'ContractsDGV_Panel
        '
        Me.ContractsDGV_Panel.Controls.Add(Me.ContractsDGV)
        Me.ContractsDGV_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContractsDGV_Panel.Location = New System.Drawing.Point(20, 60)
        Me.ContractsDGV_Panel.Name = "ContractsDGV_Panel"
        Me.ContractsDGV_Panel.Size = New System.Drawing.Size(747, 410)
        Me.ContractsDGV_Panel.TabIndex = 9
        '
        'Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 490)
        Me.Controls.Add(Me.ContractsDGV_Panel)
        Me.Name = "Contracts"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ViewLockedContracts.ResumeLayout(False)
        CType(Me.ContractsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContractsDGV_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewLockedContracts As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents LockedContractsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContractsDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents ContractsDGV_Panel As Panel
End Class
