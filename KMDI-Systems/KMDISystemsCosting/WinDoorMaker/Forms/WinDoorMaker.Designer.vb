<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinDoorMaker
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
        Me.MainPanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.HorizontalScrollbarBarColor = True
        Me.MainPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.MainPanel.HorizontalScrollbarSize = 10
        Me.MainPanel.Location = New System.Drawing.Point(20, 60)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(678, 332)
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.VerticalScrollbarBarColor = True
        Me.MainPanel.VerticalScrollbarHighlightOnWheel = False
        Me.MainPanel.VerticalScrollbarSize = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(678, 34)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'WinDoorMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 412)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "WinDoorMaker"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
