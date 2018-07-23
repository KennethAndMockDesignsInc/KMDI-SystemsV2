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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContractsDGV = New MetroFramework.Controls.MetroGrid()
        Me.ViewLockedContracts = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.LockedContractsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ContractsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewLockedContracts.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContractsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ContractsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContractsDGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.ContractsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContractsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ContractsDGV.EnableHeadersVisualStyles = False
        Me.ContractsDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ContractsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContractsDGV.Location = New System.Drawing.Point(20, 60)
        Me.ContractsDGV.MultiSelect = False
        Me.ContractsDGV.Name = "ContractsDGV"
        Me.ContractsDGV.ReadOnly = True
        Me.ContractsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContractsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.ContractsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ContractsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ContractsDGV.Size = New System.Drawing.Size(747, 410)
        Me.ContractsDGV.Style = MetroFramework.MetroColorStyle.Silver
        Me.ContractsDGV.TabIndex = 7
        Me.ContractsDGV.UseStyleColors = True
        '
        'ViewLockedContracts
        '
        Me.ViewLockedContracts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockedContractsToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.ViewLockedContracts.Name = "MetroContextMenu1"
        Me.ViewLockedContracts.Size = New System.Drawing.Size(199, 70)
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
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 490)
        Me.Controls.Add(Me.ContractsDGV)
        Me.Name = "Contracts"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ContractsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewLockedContracts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContractsDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents ViewLockedContracts As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents LockedContractsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
End Class
