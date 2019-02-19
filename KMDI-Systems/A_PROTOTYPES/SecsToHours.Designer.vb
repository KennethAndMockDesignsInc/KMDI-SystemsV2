<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecsToHours
    Inherits System.Windows.Forms.Form

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
        Me.secs_tbox = New System.Windows.Forms.TextBox()
        Me.hrs_tbox = New System.Windows.Forms.TextBox()
        Me.mins_tbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'secs_tbox
        '
        Me.secs_tbox.Location = New System.Drawing.Point(12, 45)
        Me.secs_tbox.Name = "secs_tbox"
        Me.secs_tbox.Size = New System.Drawing.Size(130, 20)
        Me.secs_tbox.TabIndex = 0
        '
        'hrs_tbox
        '
        Me.hrs_tbox.Location = New System.Drawing.Point(12, 99)
        Me.hrs_tbox.Name = "hrs_tbox"
        Me.hrs_tbox.Size = New System.Drawing.Size(130, 20)
        Me.hrs_tbox.TabIndex = 1
        '
        'mins_tbox
        '
        Me.mins_tbox.Location = New System.Drawing.Point(12, 125)
        Me.mins_tbox.Name = "mins_tbox"
        Me.mins_tbox.Size = New System.Drawing.Size(130, 20)
        Me.mins_tbox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 5
        '
        'SecsToHours
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 167)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mins_tbox)
        Me.Controls.Add(Me.hrs_tbox)
        Me.Controls.Add(Me.secs_tbox)
        Me.Name = "SecsToHours"
        Me.Text = "SecsToHours"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents secs_tbox As TextBox
    Friend WithEvents hrs_tbox As TextBox
    Friend WithEvents mins_tbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
