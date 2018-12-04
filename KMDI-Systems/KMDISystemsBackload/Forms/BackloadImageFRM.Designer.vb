<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackloadImageFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackloadImageFRM))
        Me.AddUpdateImage_BTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Browse_BTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.BackloadImage_Pbox = New System.Windows.Forms.PictureBox()
        Me.BackloadImage_CMS = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackloadImage_Pbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackloadImage_CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddUpdateImage_BTN
        '
        Me.AddUpdateImage_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddUpdateImage_BTN.Image = Nothing
        Me.AddUpdateImage_BTN.Location = New System.Drawing.Point(435, 7)
        Me.AddUpdateImage_BTN.Name = "AddUpdateImage_BTN"
        Me.AddUpdateImage_BTN.Size = New System.Drawing.Size(75, 36)
        Me.AddUpdateImage_BTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddUpdateImage_BTN.TabIndex = 39
        Me.AddUpdateImage_BTN.Text = "Add/Update"
        Me.AddUpdateImage_BTN.UseSelectable = True
        Me.AddUpdateImage_BTN.UseVisualStyleBackColor = True
        '
        'Browse_BTN
        '
        Me.Browse_BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browse_BTN.Image = Nothing
        Me.Browse_BTN.Location = New System.Drawing.Point(354, 7)
        Me.Browse_BTN.Name = "Browse_BTN"
        Me.Browse_BTN.Size = New System.Drawing.Size(75, 36)
        Me.Browse_BTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.Browse_BTN.TabIndex = 40
        Me.Browse_BTN.Text = "Browse"
        Me.Browse_BTN.UseSelectable = True
        Me.Browse_BTN.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.AddUpdateImage_BTN)
        Me.Panel2.Controls.Add(Me.Browse_BTN)
        Me.Panel2.Location = New System.Drawing.Point(37, 360)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 46)
        Me.Panel2.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.LoadingPB)
        Me.Panel1.Controls.Add(Me.BackloadImage_Pbox)
        Me.Panel1.Location = New System.Drawing.Point(37, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 322)
        Me.Panel1.TabIndex = 43
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(204, 122)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(131, 59)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 44
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'BackloadImage_Pbox
        '
        Me.BackloadImage_Pbox.ImageLocation = ""
        Me.BackloadImage_Pbox.Location = New System.Drawing.Point(117, 3)
        Me.BackloadImage_Pbox.Name = "BackloadImage_Pbox"
        Me.BackloadImage_Pbox.Size = New System.Drawing.Size(301, 295)
        Me.BackloadImage_Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackloadImage_Pbox.TabIndex = 38
        Me.BackloadImage_Pbox.TabStop = False
        '
        'BackloadImage_CMS
        '
        Me.BackloadImage_CMS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BackloadImage_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.BackloadImage_CMS.Name = "BackloadImage_CMS"
        Me.BackloadImage_CMS.Size = New System.Drawing.Size(113, 70)
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
        'BackloadImageFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 439)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BackloadImageFRM"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackloadImage_Pbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackloadImage_CMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackloadImage_Pbox As PictureBox
    Friend WithEvents AddUpdateImage_BTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Browse_BTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents BackloadImage_CMS As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
