<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MKTNG_Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MKTNG_Inventory))
        Me.Mktng_InvLBL = New MetroFramework.Controls.MetroLabel()
        Me.MktngInv_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Frm_PNL = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.AddNewItem_Sidebar = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MktngInv_Cmenu.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddNewItem_Sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mktng_InvLBL
        '
        Me.Mktng_InvLBL.AutoSize = True
        Me.Mktng_InvLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mktng_InvLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mktng_InvLBL.Location = New System.Drawing.Point(15, 24)
        Me.Mktng_InvLBL.Name = "Mktng_InvLBL"
        Me.Mktng_InvLBL.Size = New System.Drawing.Size(156, 25)
        Me.Mktng_InvLBL.TabIndex = 608
        Me.Mktng_InvLBL.Text = "I N V E N T O R Y"
        '
        'MktngInv_Cmenu
        '
        Me.MktngInv_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MktngInv_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColumnToolStripMenuItem, Me.ItemToolStripMenuItem, Me.AddQuantityToolStripMenuItem})
        Me.MktngInv_Cmenu.Name = "MktngInv_Cmenu"
        Me.MktngInv_Cmenu.Size = New System.Drawing.Size(146, 70)
        '
        'ColumnToolStripMenuItem
        '
        Me.ColumnToolStripMenuItem.Name = "ColumnToolStripMenuItem"
        Me.ColumnToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ColumnToolStripMenuItem.Text = "Columns"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem1, Me.UpdateItemToolStripMenuItem1, Me.DeleteItemToolStripMenuItem1})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'AddItemToolStripMenuItem1
        '
        Me.AddItemToolStripMenuItem1.Name = "AddItemToolStripMenuItem1"
        Me.AddItemToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.AddItemToolStripMenuItem1.Text = "Add"
        '
        'UpdateItemToolStripMenuItem1
        '
        Me.UpdateItemToolStripMenuItem1.Name = "UpdateItemToolStripMenuItem1"
        Me.UpdateItemToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.UpdateItemToolStripMenuItem1.Text = "Update"
        '
        'DeleteItemToolStripMenuItem1
        '
        Me.DeleteItemToolStripMenuItem1.Name = "DeleteItemToolStripMenuItem1"
        Me.DeleteItemToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.DeleteItemToolStripMenuItem1.Text = "Delete"
        '
        'AddQuantityToolStripMenuItem
        '
        Me.AddQuantityToolStripMenuItem.Name = "AddQuantityToolStripMenuItem"
        Me.AddQuantityToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AddQuantityToolStripMenuItem.Text = "Add Quantity"
        '
        'Frm_PNL
        '
        Me.Frm_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_PNL.Location = New System.Drawing.Point(21, 60)
        Me.Frm_PNL.Name = "Frm_PNL"
        Me.Frm_PNL.Size = New System.Drawing.Size(982, 620)
        Me.Frm_PNL.TabIndex = 612
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.BackgroundImage = Global.KMDI_Systems.My.Resources.Resources.icons8_add_to_inbox_96
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(93, 92)
        Me.Panel1.TabIndex = 613
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(939, 29)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 611
        Me.LoadingPB.TabStop = False
        '
        'AddNewItem_Sidebar
        '
        Me.AddNewItem_Sidebar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddNewItem_Sidebar.Controls.Add(Me.Panel1)
        Me.AddNewItem_Sidebar.Controls.Add(Me.Panel3)
        Me.AddNewItem_Sidebar.Location = New System.Drawing.Point(540, 60)
        Me.AddNewItem_Sidebar.Name = "AddNewItem_Sidebar"
        Me.AddNewItem_Sidebar.Size = New System.Drawing.Size(484, 619)
        Me.AddNewItem_Sidebar.TabIndex = 614
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Location = New System.Drawing.Point(96, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(388, 619)
        Me.Panel3.TabIndex = 614
        Me.Panel3.Visible = False
        '
        'MKTNG_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.Frm_PNL)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Mktng_InvLBL)
        Me.Controls.Add(Me.AddNewItem_Sidebar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.KeyPreview = True
        Me.Name = "MKTNG_Inventory"
        Me.Padding = New System.Windows.Forms.Padding(21, 60, 21, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MktngInv_Cmenu.ResumeLayout(False)
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddNewItem_Sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mktng_InvLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents MktngInv_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ColumnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddQuantityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Frm_PNL As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddNewItem_Sidebar As Panel
    Friend WithEvents Panel3 As Panel
End Class
