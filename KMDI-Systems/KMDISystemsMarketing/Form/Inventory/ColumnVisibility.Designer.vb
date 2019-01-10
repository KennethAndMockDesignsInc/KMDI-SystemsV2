<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColumnVisibility
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
        Me.OkBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FLP_ColumnInvi = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkBtn
        '
        Me.OkBtn.BackColor = System.Drawing.Color.Black
        Me.OkBtn.ForeColor = System.Drawing.Color.Black
        Me.OkBtn.Image = Nothing
        Me.OkBtn.Location = New System.Drawing.Point(346, 126)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(138, 29)
        Me.OkBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.OkBtn.TabIndex = 5
        Me.OkBtn.Text = "&Ok"
        Me.OkBtn.UseCustomBackColor = True
        Me.OkBtn.UseCustomForeColor = True
        Me.OkBtn.UseSelectable = True
        Me.OkBtn.UseStyleColors = True
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FLP_ColumnInvi)
        Me.GroupBox1.Controls.Add(Me.OkBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 161)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Column"
        '
        'FLP_ColumnInvi
        '
        Me.FLP_ColumnInvi.AutoScroll = True
        Me.FLP_ColumnInvi.Location = New System.Drawing.Point(3, 21)
        Me.FLP_ColumnInvi.Name = "FLP_ColumnInvi"
        Me.FLP_ColumnInvi.Size = New System.Drawing.Size(481, 100)
        Me.FLP_ColumnInvi.TabIndex = 6
        '
        'ColumnVisibility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ColumnVisibility"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OkBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FLP_ColumnInvi As FlowLayoutPanel
End Class
