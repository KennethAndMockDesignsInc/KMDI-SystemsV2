<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeletedInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletedInventory))
        Me.DeletedInventoryDGV = New MetroFramework.Controls.MetroGrid()
        Me.AdminsContextMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ReviveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchInvTbox = New MetroFramework.Controls.MetroTextBox()
        CType(Me.DeletedInventoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminsContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeletedInventoryDGV
        '
        Me.DeletedInventoryDGV.AllowUserToAddRows = False
        Me.DeletedInventoryDGV.AllowUserToDeleteRows = False
        Me.DeletedInventoryDGV.AllowUserToOrderColumns = True
        Me.DeletedInventoryDGV.AllowUserToResizeRows = False
        Me.DeletedInventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DeletedInventoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DeletedInventoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeletedInventoryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DeletedInventoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeletedInventoryDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DeletedInventoryDGV.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DeletedInventoryDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DeletedInventoryDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeletedInventoryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DeletedInventoryDGV.EnableHeadersVisualStyles = False
        Me.DeletedInventoryDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DeletedInventoryDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.DeletedInventoryDGV.Location = New System.Drawing.Point(20, 60)
        Me.DeletedInventoryDGV.MultiSelect = False
        Me.DeletedInventoryDGV.Name = "DeletedInventoryDGV"
        Me.DeletedInventoryDGV.ReadOnly = True
        Me.DeletedInventoryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeletedInventoryDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DeletedInventoryDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DeletedInventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DeletedInventoryDGV.Size = New System.Drawing.Size(984, 195)
        Me.DeletedInventoryDGV.Style = MetroFramework.MetroColorStyle.Teal
        Me.DeletedInventoryDGV.TabIndex = 8
        Me.DeletedInventoryDGV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.DeletedInventoryDGV.UseStyleColors = True
        '
        'AdminsContextMenu
        '
        Me.AdminsContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AdminsContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReviveToolStripMenuItem})
        Me.AdminsContextMenu.Name = "AdminsContextMenu"
        Me.AdminsContextMenu.Size = New System.Drawing.Size(109, 26)
        '
        'ReviveToolStripMenuItem
        '
        Me.ReviveToolStripMenuItem.Name = "ReviveToolStripMenuItem"
        Me.ReviveToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ReviveToolStripMenuItem.Text = "Revive"
        '
        'SearchInvTbox
        '
        Me.SearchInvTbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchInvTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.SearchInvTbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInvTbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SearchInvTbox.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.SearchInvTbox.CustomButton.Name = ""
        Me.SearchInvTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.SearchInvTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchInvTbox.CustomButton.TabIndex = 1
        Me.SearchInvTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchInvTbox.CustomButton.UseSelectable = True
        Me.SearchInvTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.SearchInvTbox.ForeColor = System.Drawing.Color.Teal
        Me.SearchInvTbox.Lines = New String(-1) {}
        Me.SearchInvTbox.Location = New System.Drawing.Point(803, 27)
        Me.SearchInvTbox.MaxLength = 32767
        Me.SearchInvTbox.Name = "SearchInvTbox"
        Me.SearchInvTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchInvTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchInvTbox.SelectedText = ""
        Me.SearchInvTbox.SelectionLength = 0
        Me.SearchInvTbox.SelectionStart = 0
        Me.SearchInvTbox.ShowButton = True
        Me.SearchInvTbox.ShowClearButton = True
        Me.SearchInvTbox.Size = New System.Drawing.Size(201, 27)
        Me.SearchInvTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.SearchInvTbox.TabIndex = 827
        Me.SearchInvTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SearchInvTbox.UseCustomForeColor = True
        Me.SearchInvTbox.UseSelectable = True
        Me.SearchInvTbox.WaterMark = "Search Marketing Inventory"
        Me.SearchInvTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchInvTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DeletedInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 275)
        Me.Controls.Add(Me.SearchInvTbox)
        Me.Controls.Add(Me.DeletedInventoryDGV)
        Me.MinimizeBox = False
        Me.Name = "DeletedInventory"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.DeletedInventoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminsContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeletedInventoryDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents AdminsContextMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ReviveToolStripMenuItem As ToolStripMenuItem
    Public WithEvents SearchInvTbox As MetroFramework.Controls.MetroTextBox
End Class
