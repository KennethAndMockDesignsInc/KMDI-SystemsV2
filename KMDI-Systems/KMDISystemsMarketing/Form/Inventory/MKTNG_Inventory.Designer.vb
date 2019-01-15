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
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Inv_Pnl = New System.Windows.Forms.Panel()
        Me.MktngInv_Cmenu.SuspendLayout()
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
        'Inv_Pnl
        '
        Me.Inv_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inv_Pnl.Location = New System.Drawing.Point(21, 60)
        Me.Inv_Pnl.Name = "Inv_Pnl"
        Me.Inv_Pnl.Size = New System.Drawing.Size(982, 620)
        Me.Inv_Pnl.TabIndex = 612
        '
        'MKTNG_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.Inv_Pnl)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Mktng_InvLBL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.KeyPreview = True
        Me.Name = "MKTNG_Inventory"
        Me.Padding = New System.Windows.Forms.Padding(21, 60, 21, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MktngInv_Cmenu.ResumeLayout(False)
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Inv_Pnl As Panel
End Class
