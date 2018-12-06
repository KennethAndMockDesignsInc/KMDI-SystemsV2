<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LoadingPbox = New System.Windows.Forms.PictureBox()
        Me.QuoteRefNo_Cbox = New System.Windows.Forms.ComboBox()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'LoadingPbox
        '
        Me.LoadingPbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPbox.BackColor = System.Drawing.Color.Transparent
        Me.LoadingPbox.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPbox.Location = New System.Drawing.Point(187, 12)
        Me.LoadingPbox.Name = "LoadingPbox"
        Me.LoadingPbox.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPbox.TabIndex = 15
        Me.LoadingPbox.TabStop = False
        Me.LoadingPbox.Visible = False
        '
        'QuoteRefNo_Cbox
        '
        Me.QuoteRefNo_Cbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuoteRefNo_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.QuoteRefNo_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.QuoteRefNo_Cbox.BackColor = System.Drawing.SystemColors.Window
        Me.QuoteRefNo_Cbox.DropDownHeight = 75
        Me.QuoteRefNo_Cbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuoteRefNo_Cbox.ForeColor = System.Drawing.Color.Black
        Me.QuoteRefNo_Cbox.FormattingEnabled = True
        Me.QuoteRefNo_Cbox.IntegralHeight = False
        Me.QuoteRefNo_Cbox.Location = New System.Drawing.Point(9, 46)
        Me.QuoteRefNo_Cbox.Name = "QuoteRefNo_Cbox"
        Me.QuoteRefNo_Cbox.Size = New System.Drawing.Size(263, 29)
        Me.QuoteRefNo_Cbox.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 314)
        Me.Controls.Add(Me.QuoteRefNo_Cbox)
        Me.Controls.Add(Me.LoadingPbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LoadingPbox As PictureBox
    Friend WithEvents QuoteRefNo_Cbox As ComboBox
End Class
