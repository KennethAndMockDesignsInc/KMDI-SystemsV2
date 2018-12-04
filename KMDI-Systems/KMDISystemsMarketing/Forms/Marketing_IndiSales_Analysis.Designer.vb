<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marketing_IndiSales_Analysis
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AE_Requested = New MetroFramework.Controls.MetroGrid()
        Me.Mode_Selector = New MetroFramework.Controls.MetroTabControl()
        Me.RegularGift = New MetroFramework.Controls.MetroTabPage()
        Me.RaffleItems = New MetroFramework.Controls.MetroTabPage()
        Me.SpecialGift = New MetroFramework.Controls.MetroTabPage()
        Me.DateLookBackCbox = New MetroFramework.Controls.MetroComboBox()
        Me.AE_Requested_BGW = New System.ComponentModel.BackgroundWorker()
        Me.Loading_Pnl = New System.Windows.Forms.Panel()
        Me.LoadingLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.TotalCPConsumed_lbl = New MetroFramework.Controls.MetroLabel()
        Me.TotalCPConsumedhere_lbl = New MetroFramework.Controls.MetroLabel()
        CType(Me.AE_Requested, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mode_Selector.SuspendLayout()
        Me.Loading_Pnl.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AE_Requested
        '
        Me.AE_Requested.AllowUserToAddRows = False
        Me.AE_Requested.AllowUserToDeleteRows = False
        Me.AE_Requested.AllowUserToOrderColumns = True
        Me.AE_Requested.AllowUserToResizeRows = False
        Me.AE_Requested.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AE_Requested.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AE_Requested.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AE_Requested.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AE_Requested.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AE_Requested.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AE_Requested.ColumnHeadersHeight = 25
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AE_Requested.DefaultCellStyle = DataGridViewCellStyle2
        Me.AE_Requested.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AE_Requested.EnableHeadersVisualStyles = False
        Me.AE_Requested.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AE_Requested.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AE_Requested.Location = New System.Drawing.Point(20, 108)
        Me.AE_Requested.MultiSelect = False
        Me.AE_Requested.Name = "AE_Requested"
        Me.AE_Requested.ReadOnly = True
        Me.AE_Requested.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AE_Requested.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AE_Requested.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AE_Requested.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AE_Requested.Size = New System.Drawing.Size(907, 312)
        Me.AE_Requested.Style = MetroFramework.MetroColorStyle.Teal
        Me.AE_Requested.TabIndex = 8
        Me.AE_Requested.UseStyleColors = True
        Me.AE_Requested.Visible = False
        '
        'Mode_Selector
        '
        Me.Mode_Selector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mode_Selector.Controls.Add(Me.RegularGift)
        Me.Mode_Selector.Controls.Add(Me.RaffleItems)
        Me.Mode_Selector.Controls.Add(Me.SpecialGift)
        Me.Mode_Selector.Location = New System.Drawing.Point(20, 63)
        Me.Mode_Selector.Name = "Mode_Selector"
        Me.Mode_Selector.SelectedIndex = 0
        Me.Mode_Selector.Size = New System.Drawing.Size(907, 43)
        Me.Mode_Selector.Style = MetroFramework.MetroColorStyle.Teal
        Me.Mode_Selector.TabIndex = 9
        Me.Mode_Selector.UseSelectable = True
        '
        'RegularGift
        '
        Me.RegularGift.HorizontalScrollbarBarColor = True
        Me.RegularGift.HorizontalScrollbarHighlightOnWheel = False
        Me.RegularGift.HorizontalScrollbarSize = 10
        Me.RegularGift.Location = New System.Drawing.Point(4, 38)
        Me.RegularGift.Name = "RegularGift"
        Me.RegularGift.Size = New System.Drawing.Size(899, 1)
        Me.RegularGift.TabIndex = 0
        Me.RegularGift.Text = "Gift Requests for Employee "
        Me.RegularGift.VerticalScrollbarBarColor = True
        Me.RegularGift.VerticalScrollbarHighlightOnWheel = False
        Me.RegularGift.VerticalScrollbarSize = 10
        '
        'RaffleItems
        '
        Me.RaffleItems.HorizontalScrollbarBarColor = True
        Me.RaffleItems.HorizontalScrollbarHighlightOnWheel = False
        Me.RaffleItems.HorizontalScrollbarSize = 10
        Me.RaffleItems.Location = New System.Drawing.Point(4, 38)
        Me.RaffleItems.Name = "RaffleItems"
        Me.RaffleItems.Size = New System.Drawing.Size(899, 1)
        Me.RaffleItems.TabIndex = 2
        Me.RaffleItems.Text = "Raffle Requests for Company"
        Me.RaffleItems.VerticalScrollbarBarColor = True
        Me.RaffleItems.VerticalScrollbarHighlightOnWheel = False
        Me.RaffleItems.VerticalScrollbarSize = 10
        '
        'SpecialGift
        '
        Me.SpecialGift.HorizontalScrollbarBarColor = True
        Me.SpecialGift.HorizontalScrollbarHighlightOnWheel = False
        Me.SpecialGift.HorizontalScrollbarSize = 10
        Me.SpecialGift.Location = New System.Drawing.Point(4, 38)
        Me.SpecialGift.Name = "SpecialGift"
        Me.SpecialGift.Size = New System.Drawing.Size(899, 1)
        Me.SpecialGift.TabIndex = 1
        Me.SpecialGift.Text = "Special Requests"
        Me.SpecialGift.VerticalScrollbarBarColor = True
        Me.SpecialGift.VerticalScrollbarHighlightOnWheel = False
        Me.SpecialGift.VerticalScrollbarSize = 10
        '
        'DateLookBackCbox
        '
        Me.DateLookBackCbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLookBackCbox.DropDownHeight = 75
        Me.DateLookBackCbox.FormattingEnabled = True
        Me.DateLookBackCbox.IntegralHeight = False
        Me.DateLookBackCbox.ItemHeight = 23
        Me.DateLookBackCbox.Location = New System.Drawing.Point(806, 28)
        Me.DateLookBackCbox.Name = "DateLookBackCbox"
        Me.DateLookBackCbox.Size = New System.Drawing.Size(121, 29)
        Me.DateLookBackCbox.TabIndex = 18
        Me.DateLookBackCbox.UseSelectable = True
        '
        'AE_Requested_BGW
        '
        Me.AE_Requested_BGW.WorkerReportsProgress = True
        Me.AE_Requested_BGW.WorkerSupportsCancellation = True
        '
        'Loading_Pnl
        '
        Me.Loading_Pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Loading_Pnl.Controls.Add(Me.LoadingLBL)
        Me.Loading_Pnl.Controls.Add(Me.LoadingPBOX)
        Me.Loading_Pnl.Location = New System.Drawing.Point(20, 108)
        Me.Loading_Pnl.Name = "Loading_Pnl"
        Me.Loading_Pnl.Size = New System.Drawing.Size(907, 312)
        Me.Loading_Pnl.TabIndex = 19
        '
        'LoadingLBL
        '
        Me.LoadingLBL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoadingLBL.AutoSize = True
        Me.LoadingLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LoadingLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LoadingLBL.Location = New System.Drawing.Point(415, 170)
        Me.LoadingLBL.Name = "LoadingLBL"
        Me.LoadingLBL.Size = New System.Drawing.Size(76, 25)
        Me.LoadingLBL.TabIndex = 831
        Me.LoadingLBL.Text = "Loading"
        Me.LoadingLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LoadingLBL.UseMnemonic = False
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoadingPBOX.Image = Global.WindowsApplication7.My.Resources.Resources.loading_page
        Me.LoadingPBOX.Location = New System.Drawing.Point(403, 127)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(100, 40)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 830
        Me.LoadingPBOX.TabStop = False
        '
        'TotalCPConsumed_lbl
        '
        Me.TotalCPConsumed_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalCPConsumed_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.TotalCPConsumed_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.TotalCPConsumed_lbl.Location = New System.Drawing.Point(477, 423)
        Me.TotalCPConsumed_lbl.Name = "TotalCPConsumed_lbl"
        Me.TotalCPConsumed_lbl.Size = New System.Drawing.Size(450, 37)
        Me.TotalCPConsumed_lbl.TabIndex = 20
        Me.TotalCPConsumed_lbl.Text = "Overall Total Credit Points Consumed: "
        Me.TotalCPConsumed_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalCPConsumedhere_lbl
        '
        Me.TotalCPConsumedhere_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalCPConsumedhere_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.TotalCPConsumedhere_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.TotalCPConsumedhere_lbl.Location = New System.Drawing.Point(23, 423)
        Me.TotalCPConsumedhere_lbl.Name = "TotalCPConsumedhere_lbl"
        Me.TotalCPConsumedhere_lbl.Size = New System.Drawing.Size(450, 37)
        Me.TotalCPConsumedhere_lbl.TabIndex = 21
        Me.TotalCPConsumedhere_lbl.Text = "Total Credit Points Consumed: "
        Me.TotalCPConsumedhere_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Marketing_IndiSales_Analysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 480)
        Me.Controls.Add(Me.TotalCPConsumedhere_lbl)
        Me.Controls.Add(Me.TotalCPConsumed_lbl)
        Me.Controls.Add(Me.DateLookBackCbox)
        Me.Controls.Add(Me.Mode_Selector)
        Me.Controls.Add(Me.Loading_Pnl)
        Me.Controls.Add(Me.AE_Requested)
        Me.Name = "Marketing_IndiSales_Analysis"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Individual Analysis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AE_Requested, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mode_Selector.ResumeLayout(False)
        Me.Loading_Pnl.ResumeLayout(False)
        Me.Loading_Pnl.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AE_Requested As MetroFramework.Controls.MetroGrid
    Friend WithEvents Mode_Selector As MetroFramework.Controls.MetroTabControl
    Friend WithEvents RegularGift As MetroFramework.Controls.MetroTabPage
    Friend WithEvents SpecialGift As MetroFramework.Controls.MetroTabPage
    Friend WithEvents RaffleItems As MetroFramework.Controls.MetroTabPage
    Friend WithEvents DateLookBackCbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents AE_Requested_BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Loading_Pnl As Panel
    Friend WithEvents LoadingLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents TotalCPConsumed_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents TotalCPConsumedhere_lbl As MetroFramework.Controls.MetroLabel
End Class
