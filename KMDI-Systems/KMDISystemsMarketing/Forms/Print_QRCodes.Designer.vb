<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_QRCodes
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.QRCODESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Marketing_Inventory = New WindowsApplication7.Marketing_Inventory()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.QRCODESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Marketing_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRCODESBindingSource
        '
        Me.QRCODESBindingSource.DataMember = "QRCODES"
        Me.QRCODESBindingSource.DataSource = Me.Marketing_Inventory
        '
        'Marketing_Inventory
        '
        Me.Marketing_Inventory.DataSetName = "Marketing_Inventory"
        Me.Marketing_Inventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QRCODESBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.EnableHyperlinks = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication7.QR_Report.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(509, 308)
        Me.ReportViewer1.TabIndex = 0
        '
        'Print_QRCodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 388)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print_QRCodes"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        CType(Me.QRCODESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Marketing_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Marketing_Inventory As Marketing_Inventory
    Friend WithEvents QRCODESBindingSource As BindingSource
End Class
