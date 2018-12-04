<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewInventoryImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewInventoryImage))
        Me.Browse_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.UpdateInvImage_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.InventoryImage_Pbox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.InventoryImage_Pbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Browse_btn
        '
        Me.Browse_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browse_btn.Image = Nothing
        Me.Browse_btn.Location = New System.Drawing.Point(354, 7)
        Me.Browse_btn.Name = "Browse_btn"
        Me.Browse_btn.Size = New System.Drawing.Size(75, 36)
        Me.Browse_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.Browse_btn.TabIndex = 40
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.UseSelectable = True
        Me.Browse_btn.UseVisualStyleBackColor = True
        '
        'UpdateInvImage_btn
        '
        Me.UpdateInvImage_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateInvImage_btn.Image = Nothing
        Me.UpdateInvImage_btn.Location = New System.Drawing.Point(435, 7)
        Me.UpdateInvImage_btn.Name = "UpdateInvImage_btn"
        Me.UpdateInvImage_btn.Size = New System.Drawing.Size(75, 36)
        Me.UpdateInvImage_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.UpdateInvImage_btn.TabIndex = 39
        Me.UpdateInvImage_btn.Text = "Update"
        Me.UpdateInvImage_btn.UseSelectable = True
        Me.UpdateInvImage_btn.UseVisualStyleBackColor = True
        '
        'InventoryImage_Pbox
        '
        Me.InventoryImage_Pbox.BackColor = System.Drawing.Color.Transparent
        Me.InventoryImage_Pbox.ImageLocation = ""
        Me.InventoryImage_Pbox.Location = New System.Drawing.Point(70, 3)
        Me.InventoryImage_Pbox.Name = "InventoryImage_Pbox"
        Me.InventoryImage_Pbox.Size = New System.Drawing.Size(301, 295)
        Me.InventoryImage_Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InventoryImage_Pbox.TabIndex = 38
        Me.InventoryImage_Pbox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.InventoryImage_Pbox)
        Me.Panel1.Location = New System.Drawing.Point(58, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 322)
        Me.Panel1.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.UpdateInvImage_btn)
        Me.Panel2.Controls.Add(Me.Browse_btn)
        Me.Panel2.Location = New System.Drawing.Point(20, 371)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 46)
        Me.Panel2.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(501, 158)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'ViewInventoryImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewInventoryImage"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        CType(Me.InventoryImage_Pbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Browse_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents UpdateInvImage_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents InventoryImage_Pbox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
