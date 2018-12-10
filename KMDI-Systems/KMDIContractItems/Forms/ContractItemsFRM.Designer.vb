<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContractItemsFRM
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
        Me.ContractRecordsLBL = New MetroFramework.Controls.MetroLabel()
        Me.CIF_TCTRL = New MetroFramework.Controls.MetroTabControl()
        Me.FramesTAB = New System.Windows.Forms.TabPage()
        Me.FBack_PNL = New System.Windows.Forms.Panel()
        Me.FMid_PNL = New System.Windows.Forms.Panel()
        Me.FBot_PNL = New System.Windows.Forms.Panel()
        Me.FSubPrice_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FSub_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FTop_PNL = New System.Windows.Forms.Panel()
        Me.FNetPrice_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FDiscount_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FPrice_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FQty_LBL = New MetroFramework.Controls.MetroLabel()
        Me.ScreenTAB = New System.Windows.Forms.TabPage()
        Me.SBack_PNL = New System.Windows.Forms.Panel()
        Me.SMid_PNL = New System.Windows.Forms.Panel()
        Me.SBot_PNL = New System.Windows.Forms.Panel()
        Me.STotalQTY_LBL = New MetroFramework.Controls.MetroLabel()
        Me.SSubPrice_LBL = New MetroFramework.Controls.MetroLabel()
        Me.SSub_LBL = New MetroFramework.Controls.MetroLabel()
        Me.GlassTAB = New System.Windows.Forms.TabPage()
        Me.GBack_PNL = New System.Windows.Forms.Panel()
        Me.GMid_PNL = New System.Windows.Forms.Panel()
        Me.GBot_PNL = New System.Windows.Forms.Panel()
        Me.GSubTotal_LBL = New MetroFramework.Controls.MetroLabel()
        Me.GSub_LBL = New MetroFramework.Controls.MetroLabel()
        Me.GTop_PNL = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.GNetPrice_LBL = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.FilmTAB = New System.Windows.Forms.TabPage()
        Me.FilmBack_PNL = New System.Windows.Forms.Panel()
        Me.FilmMid_PNL = New System.Windows.Forms.Panel()
        Me.FilmBot_PNL = New System.Windows.Forms.Panel()
        Me.FilmSubTotal_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FilmSub_LBL = New MetroFramework.Controls.MetroLabel()
        Me.FilmTop_PNL = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MechanismTAB = New System.Windows.Forms.TabPage()
        Me.AddOnTAB = New System.Windows.Forms.TabPage()
        Me.SummaryTAB = New System.Windows.Forms.TabPage()
        Me.Load_LBL = New MetroFramework.Controls.MetroLabel()
        Me.Load_PB = New MetroFramework.Controls.MetroProgressBar()
        Me.CIF_TCTRL.SuspendLayout()
        Me.FramesTAB.SuspendLayout()
        Me.FBack_PNL.SuspendLayout()
        Me.FBot_PNL.SuspendLayout()
        Me.FTop_PNL.SuspendLayout()
        Me.ScreenTAB.SuspendLayout()
        Me.SBack_PNL.SuspendLayout()
        Me.SBot_PNL.SuspendLayout()
        Me.GlassTAB.SuspendLayout()
        Me.GBack_PNL.SuspendLayout()
        Me.GBot_PNL.SuspendLayout()
        Me.GTop_PNL.SuspendLayout()
        Me.FilmTAB.SuspendLayout()
        Me.FilmBack_PNL.SuspendLayout()
        Me.FilmBot_PNL.SuspendLayout()
        Me.FilmTop_PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContractRecordsLBL
        '
        Me.ContractRecordsLBL.AutoSize = True
        Me.ContractRecordsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ContractRecordsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ContractRecordsLBL.Location = New System.Drawing.Point(20, 41)
        Me.ContractRecordsLBL.Name = "ContractRecordsLBL"
        Me.ContractRecordsLBL.Size = New System.Drawing.Size(55, 25)
        Me.ContractRecordsLBL.TabIndex = 607
        Me.ContractRecordsLBL.Text = "J O #"
        '
        'CIF_TCTRL
        '
        Me.CIF_TCTRL.Controls.Add(Me.FramesTAB)
        Me.CIF_TCTRL.Controls.Add(Me.ScreenTAB)
        Me.CIF_TCTRL.Controls.Add(Me.GlassTAB)
        Me.CIF_TCTRL.Controls.Add(Me.FilmTAB)
        Me.CIF_TCTRL.Controls.Add(Me.MechanismTAB)
        Me.CIF_TCTRL.Controls.Add(Me.AddOnTAB)
        Me.CIF_TCTRL.Controls.Add(Me.SummaryTAB)
        Me.CIF_TCTRL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CIF_TCTRL.Location = New System.Drawing.Point(23, 78)
        Me.CIF_TCTRL.Name = "CIF_TCTRL"
        Me.CIF_TCTRL.SelectedIndex = 2
        Me.CIF_TCTRL.Size = New System.Drawing.Size(1021, 622)
        Me.CIF_TCTRL.Style = MetroFramework.MetroColorStyle.Purple
        Me.CIF_TCTRL.TabIndex = 609
        Me.CIF_TCTRL.TabStop = False
        Me.CIF_TCTRL.UseSelectable = True
        '
        'FramesTAB
        '
        Me.FramesTAB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.FramesTAB.Controls.Add(Me.FBack_PNL)
        Me.FramesTAB.Location = New System.Drawing.Point(4, 38)
        Me.FramesTAB.Name = "FramesTAB"
        Me.FramesTAB.Size = New System.Drawing.Size(1013, 580)
        Me.FramesTAB.TabIndex = 7
        Me.FramesTAB.Text = "FRAMES"
        '
        'FBack_PNL
        '
        Me.FBack_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FBack_PNL.Controls.Add(Me.FMid_PNL)
        Me.FBack_PNL.Controls.Add(Me.FBot_PNL)
        Me.FBack_PNL.Controls.Add(Me.FTop_PNL)
        Me.FBack_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FBack_PNL.Location = New System.Drawing.Point(0, 0)
        Me.FBack_PNL.Name = "FBack_PNL"
        Me.FBack_PNL.Size = New System.Drawing.Size(1013, 580)
        Me.FBack_PNL.TabIndex = 0
        '
        'FMid_PNL
        '
        Me.FMid_PNL.AutoScroll = True
        Me.FMid_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FMid_PNL.Location = New System.Drawing.Point(0, 37)
        Me.FMid_PNL.Name = "FMid_PNL"
        Me.FMid_PNL.Size = New System.Drawing.Size(1011, 504)
        Me.FMid_PNL.TabIndex = 2
        '
        'FBot_PNL
        '
        Me.FBot_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FBot_PNL.Controls.Add(Me.FSubPrice_LBL)
        Me.FBot_PNL.Controls.Add(Me.FSub_LBL)
        Me.FBot_PNL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FBot_PNL.Location = New System.Drawing.Point(0, 541)
        Me.FBot_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.FBot_PNL.Name = "FBot_PNL"
        Me.FBot_PNL.Size = New System.Drawing.Size(1011, 37)
        Me.FBot_PNL.TabIndex = 1
        '
        'FSubPrice_LBL
        '
        Me.FSubPrice_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FSubPrice_LBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.FSubPrice_LBL.Location = New System.Drawing.Point(863, 9)
        Me.FSubPrice_LBL.Name = "FSubPrice_LBL"
        Me.FSubPrice_LBL.Size = New System.Drawing.Size(113, 19)
        Me.FSubPrice_LBL.TabIndex = 3
        Me.FSubPrice_LBL.Text = "0.00"
        Me.FSubPrice_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FSubPrice_LBL.UseCustomBackColor = True
        '
        'FSub_LBL
        '
        Me.FSub_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FSub_LBL.AutoSize = True
        Me.FSub_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FSub_LBL.Location = New System.Drawing.Point(784, 9)
        Me.FSub_LBL.Name = "FSub_LBL"
        Me.FSub_LBL.Size = New System.Drawing.Size(77, 19)
        Me.FSub_LBL.TabIndex = 2
        Me.FSub_LBL.Text = "Sub-Total:"
        Me.FSub_LBL.UseCustomBackColor = True
        '
        'FTop_PNL
        '
        Me.FTop_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FTop_PNL.Controls.Add(Me.FNetPrice_LBL)
        Me.FTop_PNL.Controls.Add(Me.FDiscount_LBL)
        Me.FTop_PNL.Controls.Add(Me.FPrice_LBL)
        Me.FTop_PNL.Controls.Add(Me.FQty_LBL)
        Me.FTop_PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.FTop_PNL.Location = New System.Drawing.Point(0, 0)
        Me.FTop_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.FTop_PNL.Name = "FTop_PNL"
        Me.FTop_PNL.Size = New System.Drawing.Size(1011, 37)
        Me.FTop_PNL.TabIndex = 0
        '
        'FNetPrice_LBL
        '
        Me.FNetPrice_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FNetPrice_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FNetPrice_LBL.Location = New System.Drawing.Point(867, 9)
        Me.FNetPrice_LBL.Name = "FNetPrice_LBL"
        Me.FNetPrice_LBL.Size = New System.Drawing.Size(109, 19)
        Me.FNetPrice_LBL.TabIndex = 3
        Me.FNetPrice_LBL.Text = "Net Price"
        Me.FNetPrice_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FNetPrice_LBL.UseCustomBackColor = True
        '
        'FDiscount_LBL
        '
        Me.FDiscount_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDiscount_LBL.AutoSize = True
        Me.FDiscount_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FDiscount_LBL.Location = New System.Drawing.Point(779, 9)
        Me.FDiscount_LBL.Name = "FDiscount_LBL"
        Me.FDiscount_LBL.Size = New System.Drawing.Size(82, 19)
        Me.FDiscount_LBL.TabIndex = 2
        Me.FDiscount_LBL.Text = "Discount %"
        Me.FDiscount_LBL.UseCustomBackColor = True
        '
        'FPrice_LBL
        '
        Me.FPrice_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FPrice_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FPrice_LBL.Location = New System.Drawing.Point(636, 9)
        Me.FPrice_LBL.Name = "FPrice_LBL"
        Me.FPrice_LBL.Size = New System.Drawing.Size(134, 19)
        Me.FPrice_LBL.TabIndex = 1
        Me.FPrice_LBL.Text = "Price"
        Me.FPrice_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FPrice_LBL.UseCustomBackColor = True
        '
        'FQty_LBL
        '
        Me.FQty_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FQty_LBL.AutoSize = True
        Me.FQty_LBL.BackColor = System.Drawing.Color.Transparent
        Me.FQty_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FQty_LBL.Location = New System.Drawing.Point(597, 9)
        Me.FQty_LBL.Name = "FQty_LBL"
        Me.FQty_LBL.Size = New System.Drawing.Size(33, 19)
        Me.FQty_LBL.TabIndex = 0
        Me.FQty_LBL.Text = "Qty"
        Me.FQty_LBL.UseCustomBackColor = True
        '
        'ScreenTAB
        '
        Me.ScreenTAB.Controls.Add(Me.SBack_PNL)
        Me.ScreenTAB.Location = New System.Drawing.Point(4, 38)
        Me.ScreenTAB.Name = "ScreenTAB"
        Me.ScreenTAB.Size = New System.Drawing.Size(1013, 580)
        Me.ScreenTAB.TabIndex = 1
        Me.ScreenTAB.Text = "SCREENS"
        '
        'SBack_PNL
        '
        Me.SBack_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SBack_PNL.Controls.Add(Me.SMid_PNL)
        Me.SBack_PNL.Controls.Add(Me.SBot_PNL)
        Me.SBack_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SBack_PNL.Location = New System.Drawing.Point(0, 0)
        Me.SBack_PNL.Name = "SBack_PNL"
        Me.SBack_PNL.Size = New System.Drawing.Size(1013, 580)
        Me.SBack_PNL.TabIndex = 1
        '
        'SMid_PNL
        '
        Me.SMid_PNL.AutoScroll = True
        Me.SMid_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SMid_PNL.Location = New System.Drawing.Point(0, 0)
        Me.SMid_PNL.Name = "SMid_PNL"
        Me.SMid_PNL.Size = New System.Drawing.Size(1011, 541)
        Me.SMid_PNL.TabIndex = 3
        '
        'SBot_PNL
        '
        Me.SBot_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SBot_PNL.Controls.Add(Me.STotalQTY_LBL)
        Me.SBot_PNL.Controls.Add(Me.SSubPrice_LBL)
        Me.SBot_PNL.Controls.Add(Me.SSub_LBL)
        Me.SBot_PNL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SBot_PNL.Location = New System.Drawing.Point(0, 541)
        Me.SBot_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.SBot_PNL.Name = "SBot_PNL"
        Me.SBot_PNL.Size = New System.Drawing.Size(1011, 37)
        Me.SBot_PNL.TabIndex = 1
        '
        'STotalQTY_LBL
        '
        Me.STotalQTY_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.STotalQTY_LBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.STotalQTY_LBL.Location = New System.Drawing.Point(819, 9)
        Me.STotalQTY_LBL.Name = "STotalQTY_LBL"
        Me.STotalQTY_LBL.Size = New System.Drawing.Size(36, 19)
        Me.STotalQTY_LBL.TabIndex = 8
        Me.STotalQTY_LBL.Text = "000"
        Me.STotalQTY_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.STotalQTY_LBL.UseCustomBackColor = True
        '
        'SSubPrice_LBL
        '
        Me.SSubPrice_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SSubPrice_LBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.SSubPrice_LBL.Location = New System.Drawing.Point(861, 9)
        Me.SSubPrice_LBL.Name = "SSubPrice_LBL"
        Me.SSubPrice_LBL.Size = New System.Drawing.Size(113, 19)
        Me.SSubPrice_LBL.TabIndex = 3
        Me.SSubPrice_LBL.Text = "0.00"
        Me.SSubPrice_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.SSubPrice_LBL.UseCustomBackColor = True
        '
        'SSub_LBL
        '
        Me.SSub_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SSub_LBL.AutoSize = True
        Me.SSub_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.SSub_LBL.Location = New System.Drawing.Point(738, 9)
        Me.SSub_LBL.Name = "SSub_LBL"
        Me.SSub_LBL.Size = New System.Drawing.Size(75, 19)
        Me.SSub_LBL.TabIndex = 2
        Me.SSub_LBL.Text = "Sub Total:"
        Me.SSub_LBL.UseCustomBackColor = True
        '
        'GlassTAB
        '
        Me.GlassTAB.Controls.Add(Me.GBack_PNL)
        Me.GlassTAB.Location = New System.Drawing.Point(4, 38)
        Me.GlassTAB.Name = "GlassTAB"
        Me.GlassTAB.Size = New System.Drawing.Size(1013, 580)
        Me.GlassTAB.TabIndex = 2
        Me.GlassTAB.Text = "GLASS"
        '
        'GBack_PNL
        '
        Me.GBack_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GBack_PNL.Controls.Add(Me.GMid_PNL)
        Me.GBack_PNL.Controls.Add(Me.GBot_PNL)
        Me.GBack_PNL.Controls.Add(Me.GTop_PNL)
        Me.GBack_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBack_PNL.Location = New System.Drawing.Point(0, 0)
        Me.GBack_PNL.Name = "GBack_PNL"
        Me.GBack_PNL.Size = New System.Drawing.Size(1013, 580)
        Me.GBack_PNL.TabIndex = 1
        '
        'GMid_PNL
        '
        Me.GMid_PNL.AutoScroll = True
        Me.GMid_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GMid_PNL.Location = New System.Drawing.Point(0, 52)
        Me.GMid_PNL.Name = "GMid_PNL"
        Me.GMid_PNL.Size = New System.Drawing.Size(1011, 489)
        Me.GMid_PNL.TabIndex = 2
        '
        'GBot_PNL
        '
        Me.GBot_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GBot_PNL.Controls.Add(Me.GSubTotal_LBL)
        Me.GBot_PNL.Controls.Add(Me.GSub_LBL)
        Me.GBot_PNL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBot_PNL.Location = New System.Drawing.Point(0, 541)
        Me.GBot_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.GBot_PNL.Name = "GBot_PNL"
        Me.GBot_PNL.Size = New System.Drawing.Size(1011, 37)
        Me.GBot_PNL.TabIndex = 1
        '
        'GSubTotal_LBL
        '
        Me.GSubTotal_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GSubTotal_LBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GSubTotal_LBL.Location = New System.Drawing.Point(849, 9)
        Me.GSubTotal_LBL.Name = "GSubTotal_LBL"
        Me.GSubTotal_LBL.Size = New System.Drawing.Size(113, 19)
        Me.GSubTotal_LBL.TabIndex = 3
        Me.GSubTotal_LBL.Text = "0.00"
        Me.GSubTotal_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.GSubTotal_LBL.UseCustomBackColor = True
        '
        'GSub_LBL
        '
        Me.GSub_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GSub_LBL.AutoSize = True
        Me.GSub_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.GSub_LBL.Location = New System.Drawing.Point(761, 9)
        Me.GSub_LBL.Name = "GSub_LBL"
        Me.GSub_LBL.Size = New System.Drawing.Size(77, 19)
        Me.GSub_LBL.TabIndex = 2
        Me.GSub_LBL.Text = "Sub-Total:"
        Me.GSub_LBL.UseCustomBackColor = True
        '
        'GTop_PNL
        '
        Me.GTop_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GTop_PNL.Controls.Add(Me.MetroLabel4)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel11)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel10)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel8)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel9)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel7)
        Me.GTop_PNL.Controls.Add(Me.GNetPrice_LBL)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel5)
        Me.GTop_PNL.Controls.Add(Me.MetroLabel6)
        Me.GTop_PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.GTop_PNL.Location = New System.Drawing.Point(0, 0)
        Me.GTop_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.GTop_PNL.Name = "GTop_PNL"
        Me.GTop_PNL.Size = New System.Drawing.Size(1011, 52)
        Me.GTop_PNL.TabIndex = 0
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(556, 9)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel4.TabIndex = 2
        Me.MetroLabel4.Text = "Dimension(mm)"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(528, 28)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(22, 19)
        Me.MetroLabel11.TabIndex = 8
        Me.MetroLabel11.Text = "to"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(223, 28)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel10.TabIndex = 7
        Me.MetroLabel10.Text = "from"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(844, 9)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Net Amount"
        Me.MetroLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(805, 9)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel9.TabIndex = 5
        Me.MetroLabel9.Text = "Qty"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(223, 9)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(327, 19)
        Me.MetroLabel7.TabIndex = 4
        Me.MetroLabel7.Text = "Glass Description                          "
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'GNetPrice_LBL
        '
        Me.GNetPrice_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GNetPrice_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.GNetPrice_LBL.Location = New System.Drawing.Point(701, 9)
        Me.GNetPrice_LBL.Name = "GNetPrice_LBL"
        Me.GNetPrice_LBL.Size = New System.Drawing.Size(98, 19)
        Me.GNetPrice_LBL.TabIndex = 3
        Me.GNetPrice_LBL.Text = "Net Price"
        Me.GNetPrice_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.GNetPrice_LBL.UseCustomBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(52, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(164, 19)
        Me.MetroLabel5.TabIndex = 1
        Me.MetroLabel5.Text = "Window /Door I.D."
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(7, 9)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "Item"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'FilmTAB
        '
        Me.FilmTAB.Controls.Add(Me.FilmBack_PNL)
        Me.FilmTAB.Location = New System.Drawing.Point(4, 38)
        Me.FilmTAB.Name = "FilmTAB"
        Me.FilmTAB.Size = New System.Drawing.Size(1013, 580)
        Me.FilmTAB.TabIndex = 3
        Me.FilmTAB.Text = "FILMS"
        '
        'FilmBack_PNL
        '
        Me.FilmBack_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilmBack_PNL.Controls.Add(Me.FilmMid_PNL)
        Me.FilmBack_PNL.Controls.Add(Me.FilmBot_PNL)
        Me.FilmBack_PNL.Controls.Add(Me.FilmTop_PNL)
        Me.FilmBack_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilmBack_PNL.Location = New System.Drawing.Point(0, 0)
        Me.FilmBack_PNL.Name = "FilmBack_PNL"
        Me.FilmBack_PNL.Size = New System.Drawing.Size(1013, 580)
        Me.FilmBack_PNL.TabIndex = 2
        '
        'FilmMid_PNL
        '
        Me.FilmMid_PNL.AutoScroll = True
        Me.FilmMid_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilmMid_PNL.Location = New System.Drawing.Point(0, 37)
        Me.FilmMid_PNL.Name = "FilmMid_PNL"
        Me.FilmMid_PNL.Size = New System.Drawing.Size(1011, 504)
        Me.FilmMid_PNL.TabIndex = 2
        '
        'FilmBot_PNL
        '
        Me.FilmBot_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilmBot_PNL.Controls.Add(Me.FilmSubTotal_LBL)
        Me.FilmBot_PNL.Controls.Add(Me.FilmSub_LBL)
        Me.FilmBot_PNL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FilmBot_PNL.Location = New System.Drawing.Point(0, 541)
        Me.FilmBot_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.FilmBot_PNL.Name = "FilmBot_PNL"
        Me.FilmBot_PNL.Size = New System.Drawing.Size(1011, 37)
        Me.FilmBot_PNL.TabIndex = 1
        '
        'FilmSubTotal_LBL
        '
        Me.FilmSubTotal_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilmSubTotal_LBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.FilmSubTotal_LBL.Location = New System.Drawing.Point(849, 9)
        Me.FilmSubTotal_LBL.Name = "FilmSubTotal_LBL"
        Me.FilmSubTotal_LBL.Size = New System.Drawing.Size(113, 19)
        Me.FilmSubTotal_LBL.TabIndex = 3
        Me.FilmSubTotal_LBL.Text = "0.00"
        Me.FilmSubTotal_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.FilmSubTotal_LBL.UseCustomBackColor = True
        '
        'FilmSub_LBL
        '
        Me.FilmSub_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilmSub_LBL.AutoSize = True
        Me.FilmSub_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.FilmSub_LBL.Location = New System.Drawing.Point(761, 9)
        Me.FilmSub_LBL.Name = "FilmSub_LBL"
        Me.FilmSub_LBL.Size = New System.Drawing.Size(77, 19)
        Me.FilmSub_LBL.TabIndex = 2
        Me.FilmSub_LBL.Text = "Sub-Total:"
        Me.FilmSub_LBL.UseCustomBackColor = True
        '
        'FilmTop_PNL
        '
        Me.FilmTop_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel1)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel12)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel15)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel16)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel17)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel18)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel19)
        Me.FilmTop_PNL.Controls.Add(Me.MetroLabel20)
        Me.FilmTop_PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.FilmTop_PNL.Location = New System.Drawing.Point(0, 0)
        Me.FilmTop_PNL.Margin = New System.Windows.Forms.Padding(0)
        Me.FilmTop_PNL.Name = "FilmTop_PNL"
        Me.FilmTop_PNL.Size = New System.Drawing.Size(1011, 37)
        Me.FilmTop_PNL.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(478, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Thickness"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.Location = New System.Drawing.Point(556, 9)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel12.TabIndex = 2
        Me.MetroLabel12.Text = "Dimension(mm)"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel15.Location = New System.Drawing.Point(844, 9)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel15.TabIndex = 6
        Me.MetroLabel15.Text = "Net Amount"
        Me.MetroLabel15.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel15.UseCustomBackColor = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel16.Location = New System.Drawing.Point(805, 9)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel16.TabIndex = 5
        Me.MetroLabel16.Text = "Qty"
        Me.MetroLabel16.UseCustomBackColor = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.Location = New System.Drawing.Point(253, 9)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(219, 19)
        Me.MetroLabel17.TabIndex = 4
        Me.MetroLabel17.Text = "Film Description"
        Me.MetroLabel17.UseCustomBackColor = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel18.Location = New System.Drawing.Point(701, 9)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel18.TabIndex = 3
        Me.MetroLabel18.Text = "Net Price"
        Me.MetroLabel18.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel18.UseCustomBackColor = True
        '
        'MetroLabel19
        '
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel19.Location = New System.Drawing.Point(52, 9)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(164, 19)
        Me.MetroLabel19.TabIndex = 1
        Me.MetroLabel19.Text = "Window /Door I.D."
        Me.MetroLabel19.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel19.UseCustomBackColor = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel20.Location = New System.Drawing.Point(7, 9)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel20.TabIndex = 0
        Me.MetroLabel20.Text = "Item"
        Me.MetroLabel20.UseCustomBackColor = True
        '
        'MechanismTAB
        '
        Me.MechanismTAB.Location = New System.Drawing.Point(4, 38)
        Me.MechanismTAB.Name = "MechanismTAB"
        Me.MechanismTAB.Size = New System.Drawing.Size(1013, 580)
        Me.MechanismTAB.TabIndex = 4
        Me.MechanismTAB.Text = "MECHANISMS"
        '
        'AddOnTAB
        '
        Me.AddOnTAB.Location = New System.Drawing.Point(4, 38)
        Me.AddOnTAB.Name = "AddOnTAB"
        Me.AddOnTAB.Size = New System.Drawing.Size(1013, 580)
        Me.AddOnTAB.TabIndex = 5
        Me.AddOnTAB.Text = "ADD-ONS"
        '
        'SummaryTAB
        '
        Me.SummaryTAB.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SummaryTAB.Location = New System.Drawing.Point(4, 38)
        Me.SummaryTAB.Name = "SummaryTAB"
        Me.SummaryTAB.Size = New System.Drawing.Size(1013, 580)
        Me.SummaryTAB.TabIndex = 6
        Me.SummaryTAB.Text = "SUMMARY"
        '
        'Load_LBL
        '
        Me.Load_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Load_LBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Load_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Load_LBL.Location = New System.Drawing.Point(568, 41)
        Me.Load_LBL.Name = "Load_LBL"
        Me.Load_LBL.Size = New System.Drawing.Size(364, 25)
        Me.Load_LBL.TabIndex = 612
        Me.Load_LBL.Text = "Retrieving information. Please wait"
        Me.Load_LBL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Load_PB
        '
        Me.Load_PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Load_PB.Location = New System.Drawing.Point(932, 41)
        Me.Load_PB.Name = "Load_PB"
        Me.Load_PB.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.Load_PB.Size = New System.Drawing.Size(121, 23)
        Me.Load_PB.Style = MetroFramework.MetroColorStyle.Silver
        Me.Load_PB.TabIndex = 611
        '
        'ContractItemsFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 726)
        Me.Controls.Add(Me.Load_LBL)
        Me.Controls.Add(Me.Load_PB)
        Me.Controls.Add(Me.CIF_TCTRL)
        Me.Controls.Add(Me.ContractRecordsLBL)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "ContractItemsFRM"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.CIF_TCTRL.ResumeLayout(False)
        Me.FramesTAB.ResumeLayout(False)
        Me.FBack_PNL.ResumeLayout(False)
        Me.FBot_PNL.ResumeLayout(False)
        Me.FBot_PNL.PerformLayout()
        Me.FTop_PNL.ResumeLayout(False)
        Me.FTop_PNL.PerformLayout()
        Me.ScreenTAB.ResumeLayout(False)
        Me.SBack_PNL.ResumeLayout(False)
        Me.SBot_PNL.ResumeLayout(False)
        Me.SBot_PNL.PerformLayout()
        Me.GlassTAB.ResumeLayout(False)
        Me.GBack_PNL.ResumeLayout(False)
        Me.GBot_PNL.ResumeLayout(False)
        Me.GBot_PNL.PerformLayout()
        Me.GTop_PNL.ResumeLayout(False)
        Me.GTop_PNL.PerformLayout()
        Me.FilmTAB.ResumeLayout(False)
        Me.FilmBack_PNL.ResumeLayout(False)
        Me.FilmBot_PNL.ResumeLayout(False)
        Me.FilmBot_PNL.PerformLayout()
        Me.FilmTop_PNL.ResumeLayout(False)
        Me.FilmTop_PNL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContractRecordsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents CIF_TCTRL As MetroFramework.Controls.MetroTabControl
    Friend WithEvents FramesTAB As TabPage
    Friend WithEvents ScreenTAB As TabPage
    Friend WithEvents GlassTAB As TabPage
    Friend WithEvents FilmTAB As TabPage
    Friend WithEvents MechanismTAB As TabPage
    Friend WithEvents AddOnTAB As TabPage
    Friend WithEvents SummaryTAB As TabPage
    Friend WithEvents FBack_PNL As Panel
    Friend WithEvents FTop_PNL As Panel
    Friend WithEvents FNetPrice_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FDiscount_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FPrice_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FQty_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FBot_PNL As Panel
    Friend WithEvents FSubPrice_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FSub_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FMid_PNL As Panel
    Friend WithEvents Load_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents Load_PB As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents SBack_PNL As Panel
    Friend WithEvents SBot_PNL As Panel
    Friend WithEvents SSubPrice_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents SSub_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents STotalQTY_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents SMid_PNL As Panel
    Friend WithEvents GBack_PNL As Panel
    Friend WithEvents GMid_PNL As Panel
    Friend WithEvents GBot_PNL As Panel
    Friend WithEvents GSubTotal_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents GSub_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents GTop_PNL As Panel
    Friend WithEvents GNetPrice_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents FilmBack_PNL As Panel
    Friend WithEvents FilmMid_PNL As Panel
    Friend WithEvents FilmBot_PNL As Panel
    Friend WithEvents FilmSubTotal_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FilmSub_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FilmTop_PNL As Panel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
