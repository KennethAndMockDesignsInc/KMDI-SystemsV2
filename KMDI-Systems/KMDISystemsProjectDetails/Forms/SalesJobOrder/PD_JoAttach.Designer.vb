<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_JoAttach
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.JoAttach_Btn = New MetroFramework.Controls.MetroButton()
        Me.JoAttach_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.JOAttachSave_Btn = New MetroFramework.Controls.MetroButton()
        Me.JoAttach_RTbox = New System.Windows.Forms.RichTextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(436, 220)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.JoAttach_RTbox)
        Me.MetroTabPage1.Controls.Add(Me.JOAttachSave_Btn)
        Me.MetroTabPage1.Controls.Add(Me.JoAttach_Btn)
        Me.MetroTabPage1.Controls.Add(Me.JoAttach_Cbox)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(428, 178)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "                                                                                 " &
    "                       "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'JoAttach_Btn
        '
        Me.JoAttach_Btn.Location = New System.Drawing.Point(307, 16)
        Me.JoAttach_Btn.Name = "JoAttach_Btn"
        Me.JoAttach_Btn.Size = New System.Drawing.Size(63, 29)
        Me.JoAttach_Btn.Style = MetroFramework.MetroColorStyle.Silver
        Me.JoAttach_Btn.TabIndex = 9
        Me.JoAttach_Btn.Text = "Add"
        Me.JoAttach_Btn.UseSelectable = True
        Me.JoAttach_Btn.UseStyleColors = True
        '
        'JoAttach_Cbox
        '
        Me.JoAttach_Cbox.FormattingEnabled = True
        Me.JoAttach_Cbox.ItemHeight = 23
        Me.JoAttach_Cbox.Items.AddRange(New Object() {"Signed Contract", "Elevation Plans", "Purchase Order", "Signed Shopdrawings", "Letter of Award", "Floor Plans(layout)", "Window/Door Sched", "Notice to Proceed", "Change Instruction"})
        Me.JoAttach_Cbox.Location = New System.Drawing.Point(3, 16)
        Me.JoAttach_Cbox.Name = "JoAttach_Cbox"
        Me.JoAttach_Cbox.Size = New System.Drawing.Size(298, 29)
        Me.JoAttach_Cbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.JoAttach_Cbox.TabIndex = 7
        Me.JoAttach_Cbox.UseSelectable = True
        '
        'JOAttachSave_Btn
        '
        Me.JOAttachSave_Btn.Location = New System.Drawing.Point(376, 16)
        Me.JOAttachSave_Btn.Name = "JOAttachSave_Btn"
        Me.JOAttachSave_Btn.Size = New System.Drawing.Size(47, 29)
        Me.JOAttachSave_Btn.Style = MetroFramework.MetroColorStyle.Silver
        Me.JOAttachSave_Btn.TabIndex = 10
        Me.JOAttachSave_Btn.Text = "Save"
        Me.JOAttachSave_Btn.UseSelectable = True
        Me.JOAttachSave_Btn.UseStyleColors = True
        '
        'JoAttach_RTbox
        '
        Me.JoAttach_RTbox.AcceptsTab = True
        Me.JoAttach_RTbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.JoAttach_RTbox.Location = New System.Drawing.Point(3, 51)
        Me.JoAttach_RTbox.Name = "JoAttach_RTbox"
        Me.JoAttach_RTbox.Size = New System.Drawing.Size(420, 124)
        Me.JoAttach_RTbox.TabIndex = 11
        Me.JoAttach_RTbox.Text = ""
        '
        'PD_JoAttach
        '
        Me.AcceptButton = Me.JOAttachSave_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 300)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.Name = "PD_JoAttach"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "JO/Contract Attachment(s)"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents JoAttach_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents JoAttach_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents JOAttachSave_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents JoAttach_RTbox As RichTextBox
End Class
