<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PD_PertDetails
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.SavePert_Btn = New MetroFramework.Controls.MetroButton()
        Me.AddPert_Btn = New MetroFramework.Controls.MetroButton()
        Me.PertDetails_RTbox = New System.Windows.Forms.RichTextBox()
        Me.SubCategory_Cbox2 = New MetroFramework.Controls.MetroComboBox()
        Me.SubCategory_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.MainCategory_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.LoadingPbox = New System.Windows.Forms.PictureBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(492, 288)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.SavePert_Btn)
        Me.MetroTabPage1.Controls.Add(Me.AddPert_Btn)
        Me.MetroTabPage1.Controls.Add(Me.PertDetails_RTbox)
        Me.MetroTabPage1.Controls.Add(Me.SubCategory_Cbox2)
        Me.MetroTabPage1.Controls.Add(Me.SubCategory_Cbox)
        Me.MetroTabPage1.Controls.Add(Me.MainCategory_Cbox)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(484, 246)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "                                                                                 " &
    "                                     "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'SavePert_Btn
        '
        Me.SavePert_Btn.Location = New System.Drawing.Point(411, 3)
        Me.SavePert_Btn.Name = "SavePert_Btn"
        Me.SavePert_Btn.Size = New System.Drawing.Size(68, 29)
        Me.SavePert_Btn.TabIndex = 12
        Me.SavePert_Btn.Text = "Save"
        Me.SavePert_Btn.UseSelectable = True
        '
        'AddPert_Btn
        '
        Me.AddPert_Btn.Location = New System.Drawing.Point(293, 3)
        Me.AddPert_Btn.Name = "AddPert_Btn"
        Me.AddPert_Btn.Size = New System.Drawing.Size(112, 29)
        Me.AddPert_Btn.TabIndex = 11
        Me.AddPert_Btn.Text = "Add"
        Me.AddPert_Btn.UseSelectable = True
        '
        'PertDetails_RTbox
        '
        Me.PertDetails_RTbox.AcceptsTab = True
        Me.PertDetails_RTbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PertDetails_RTbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PertDetails_RTbox.Location = New System.Drawing.Point(3, 73)
        Me.PertDetails_RTbox.Name = "PertDetails_RTbox"
        Me.PertDetails_RTbox.Size = New System.Drawing.Size(476, 168)
        Me.PertDetails_RTbox.TabIndex = 10
        Me.PertDetails_RTbox.Text = ""
        '
        'SubCategory_Cbox2
        '
        Me.SubCategory_Cbox2.FormattingEnabled = True
        Me.SubCategory_Cbox2.ItemHeight = 23
        Me.SubCategory_Cbox2.Location = New System.Drawing.Point(241, 38)
        Me.SubCategory_Cbox2.Name = "SubCategory_Cbox2"
        Me.SubCategory_Cbox2.Size = New System.Drawing.Size(238, 29)
        Me.SubCategory_Cbox2.TabIndex = 4
        Me.SubCategory_Cbox2.UseSelectable = True
        '
        'SubCategory_Cbox
        '
        Me.SubCategory_Cbox.FormattingEnabled = True
        Me.SubCategory_Cbox.ItemHeight = 23
        Me.SubCategory_Cbox.Location = New System.Drawing.Point(2, 38)
        Me.SubCategory_Cbox.Name = "SubCategory_Cbox"
        Me.SubCategory_Cbox.Size = New System.Drawing.Size(237, 29)
        Me.SubCategory_Cbox.TabIndex = 3
        Me.SubCategory_Cbox.UseSelectable = True
        '
        'MainCategory_Cbox
        '
        Me.MainCategory_Cbox.FormattingEnabled = True
        Me.MainCategory_Cbox.ItemHeight = 23
        Me.MainCategory_Cbox.Location = New System.Drawing.Point(3, 3)
        Me.MainCategory_Cbox.Name = "MainCategory_Cbox"
        Me.MainCategory_Cbox.Size = New System.Drawing.Size(284, 29)
        Me.MainCategory_Cbox.TabIndex = 2
        Me.MainCategory_Cbox.UseSelectable = True
        '
        'LoadingPbox
        '
        Me.LoadingPbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPbox.BackColor = System.Drawing.Color.Transparent
        Me.LoadingPbox.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPbox.Location = New System.Drawing.Point(447, 70)
        Me.LoadingPbox.Name = "LoadingPbox"
        Me.LoadingPbox.Size = New System.Drawing.Size(57, 22)
        Me.LoadingPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPbox.TabIndex = 13
        Me.LoadingPbox.TabStop = False
        '
        'PD_PertDetails
        '
        Me.AcceptButton = Me.SavePert_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 368)
        Me.Controls.Add(Me.LoadingPbox)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "PD_PertDetails"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Pertinent Detail(s) / Specialification(s) "
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MainCategory_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents SubCategory_Cbox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents SubCategory_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PertDetails_RTbox As RichTextBox
    Friend WithEvents AddPert_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents SavePert_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents LoadingPbox As PictureBox
End Class
