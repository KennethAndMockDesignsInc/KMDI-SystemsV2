﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KMDI_MainFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KMDI_MainFRM))
        Me.DbNameCbox = New MetroFramework.Controls.MetroComboBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainFRMBody_FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContractsPanel = New MetroFramework.Controls.MetroPanel()
        Me.ContractsLBL = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContractListTile = New MetroFramework.Controls.MetroTile()
        Me.RecycleTile = New MetroFramework.Controls.MetroTile()
        Me.AccountsPanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.InboxTile = New MetroFramework.Controls.MetroTile()
        Me.NotifTile = New MetroFramework.Controls.MetroTile()
        Me.UpdSecTile = New MetroFramework.Controls.MetroTile()
        Me.MngeAccTile = New MetroFramework.Controls.MetroTile()
        Me.AcctsLBL = New MetroFramework.Controls.MetroLabel()
        Me.SNOpanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ProjAssesmentTile = New MetroFramework.Controls.MetroTile()
        Me.CheckBalTile = New MetroFramework.Controls.MetroTile()
        Me.SUSTile = New MetroFramework.Controls.MetroTile()
        Me.CallerInfoTile = New MetroFramework.Controls.MetroTile()
        Me.ExterrnalDamagesTile = New MetroFramework.Controls.MetroTile()
        Me.CollectionTile = New MetroFramework.Controls.MetroTile()
        Me.SalesMonitoringTile = New MetroFramework.Controls.MetroTile()
        Me.SalesItineraryTile = New MetroFramework.Controls.MetroTile()
        Me.SalesNOperationLBL = New MetroFramework.Controls.MetroLabel()
        Me.ProductionPanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.StatusMonitoringTile = New MetroFramework.Controls.MetroTile()
        Me.CuttingListTile = New MetroFramework.Controls.MetroTile()
        Me.GlassSpecsTile = New MetroFramework.Controls.MetroTile()
        Me.ProdSDRequestTile = New MetroFramework.Controls.MetroTile()
        Me.ProdSDSubmittalTile = New MetroFramework.Controls.MetroTile()
        Me.ProdLBL = New MetroFramework.Controls.MetroLabel()
        Me.EngrPanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeliveryRecieptsTile = New MetroFramework.Controls.MetroTile()
        Me.EngrsItineraryTIle = New MetroFramework.Controls.MetroTile()
        Me.DRTile = New MetroFramework.Controls.MetroTile()
        Me.DRReportTile = New MetroFramework.Controls.MetroTile()
        Me.EngrSDRequestTile = New MetroFramework.Controls.MetroTile()
        Me.EngrSDSubmittalTile = New MetroFramework.Controls.MetroTile()
        Me.EngrLBL = New MetroFramework.Controls.MetroLabel()
        Me.MarketingPanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MarketingRequestTile = New MetroFramework.Controls.MetroTile()
        Me.InventoryTile = New MetroFramework.Controls.MetroTile()
        Me.ArchiFirmTile = New MetroFramework.Controls.MetroTile()
        Me.MarketingLabel = New MetroFramework.Controls.MetroLabel()
        Me.CostingPanel = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.WinDoorMakerTile = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NicknameLbl = New MetroFramework.Controls.MetroLabel()
        Me.ChangeDB_BGW = New System.ComponentModel.BackgroundWorker()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.PrototypeTile = New MetroFramework.Controls.MetroTile()
        Me.MainFRMBody_FLP.SuspendLayout()
        Me.ContractsPanel.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        Me.AccountsPanel.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.SNOpanel.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.ProductionPanel.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.EngrPanel.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.MarketingPanel.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.CostingPanel.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbNameCbox
        '
        Me.DbNameCbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DbNameCbox.FormattingEnabled = True
        Me.DbNameCbox.ItemHeight = 23
        Me.DbNameCbox.Location = New System.Drawing.Point(1217, 35)
        Me.DbNameCbox.Name = "DbNameCbox"
        Me.DbNameCbox.Size = New System.Drawing.Size(143, 29)
        Me.DbNameCbox.TabIndex = 1
        Me.DbNameCbox.UseSelectable = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(20, 60)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(20, 680)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'MainFRMBody_FLP
        '
        Me.MainFRMBody_FLP.AutoScroll = True
        Me.MainFRMBody_FLP.Controls.Add(Me.ContractsPanel)
        Me.MainFRMBody_FLP.Controls.Add(Me.AccountsPanel)
        Me.MainFRMBody_FLP.Controls.Add(Me.SNOpanel)
        Me.MainFRMBody_FLP.Controls.Add(Me.ProductionPanel)
        Me.MainFRMBody_FLP.Controls.Add(Me.EngrPanel)
        Me.MainFRMBody_FLP.Controls.Add(Me.MarketingPanel)
        Me.MainFRMBody_FLP.Controls.Add(Me.CostingPanel)
        Me.MainFRMBody_FLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFRMBody_FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MainFRMBody_FLP.Location = New System.Drawing.Point(20, 60)
        Me.MainFRMBody_FLP.Name = "MainFRMBody_FLP"
        Me.MainFRMBody_FLP.Size = New System.Drawing.Size(1320, 680)
        Me.MainFRMBody_FLP.TabIndex = 5
        '
        'ContractsPanel
        '
        Me.ContractsPanel.Controls.Add(Me.ContractsLBL)
        Me.ContractsPanel.Controls.Add(Me.FlowLayoutPanel9)
        Me.ContractsPanel.HorizontalScrollbarBarColor = True
        Me.ContractsPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.ContractsPanel.HorizontalScrollbarSize = 10
        Me.ContractsPanel.Location = New System.Drawing.Point(3, 3)
        Me.ContractsPanel.Name = "ContractsPanel"
        Me.ContractsPanel.Size = New System.Drawing.Size(635, 170)
        Me.ContractsPanel.TabIndex = 6
        Me.ContractsPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ContractsPanel.VerticalScrollbarBarColor = True
        Me.ContractsPanel.VerticalScrollbarHighlightOnWheel = False
        Me.ContractsPanel.VerticalScrollbarSize = 10
        '
        'ContractsLBL
        '
        Me.ContractsLBL.AutoSize = True
        Me.ContractsLBL.ForeColor = System.Drawing.Color.White
        Me.ContractsLBL.Location = New System.Drawing.Point(15, 10)
        Me.ContractsLBL.Name = "ContractsLBL"
        Me.ContractsLBL.Size = New System.Drawing.Size(64, 19)
        Me.ContractsLBL.TabIndex = 20
        Me.ContractsLBL.Text = "Contracts"
        Me.ContractsLBL.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ContractsLBL.UseCustomForeColor = True
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.ContractListTile)
        Me.FlowLayoutPanel9.Controls.Add(Me.RecycleTile)
        Me.FlowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(635, 140)
        Me.FlowLayoutPanel9.TabIndex = 22
        '
        'ContractListTile
        '
        Me.ContractListTile.ActiveControl = Nothing
        Me.ContractListTile.ForeColor = System.Drawing.Color.Black
        Me.ContractListTile.Location = New System.Drawing.Point(69, 3)
        Me.ContractListTile.Name = "ContractListTile"
        Me.ContractListTile.Size = New System.Drawing.Size(262, 132)
        Me.ContractListTile.Style = MetroFramework.MetroColorStyle.Pink
        Me.ContractListTile.TabIndex = 21
        Me.ContractListTile.Text = "Contract Records"
        Me.ContractListTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ContractListTile.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ContractListTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.ContractListTile.UseSelectable = True
        '
        'RecycleTile
        '
        Me.RecycleTile.ActiveControl = Nothing
        Me.RecycleTile.Location = New System.Drawing.Point(337, 3)
        Me.RecycleTile.Name = "RecycleTile"
        Me.RecycleTile.Size = New System.Drawing.Size(262, 132)
        Me.RecycleTile.Style = MetroFramework.MetroColorStyle.Pink
        Me.RecycleTile.TabIndex = 34
        Me.RecycleTile.Text = "Recycle"
        Me.RecycleTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.RecycleTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.RecycleTile.UseSelectable = True
        '
        'AccountsPanel
        '
        Me.AccountsPanel.Controls.Add(Me.FlowLayoutPanel8)
        Me.AccountsPanel.Controls.Add(Me.AcctsLBL)
        Me.AccountsPanel.HorizontalScrollbarBarColor = True
        Me.AccountsPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.AccountsPanel.HorizontalScrollbarSize = 10
        Me.AccountsPanel.Location = New System.Drawing.Point(3, 179)
        Me.AccountsPanel.Name = "AccountsPanel"
        Me.AccountsPanel.Size = New System.Drawing.Size(635, 170)
        Me.AccountsPanel.TabIndex = 16
        Me.AccountsPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AccountsPanel.VerticalScrollbarBarColor = True
        Me.AccountsPanel.VerticalScrollbarHighlightOnWheel = False
        Me.AccountsPanel.VerticalScrollbarSize = 10
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.InboxTile)
        Me.FlowLayoutPanel8.Controls.Add(Me.NotifTile)
        Me.FlowLayoutPanel8.Controls.Add(Me.UpdSecTile)
        Me.FlowLayoutPanel8.Controls.Add(Me.MngeAccTile)
        Me.FlowLayoutPanel8.Controls.Add(Me.PrototypeTile)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(635, 140)
        Me.FlowLayoutPanel8.TabIndex = 25
        '
        'InboxTile
        '
        Me.InboxTile.ActiveControl = Nothing
        Me.InboxTile.Location = New System.Drawing.Point(69, 3)
        Me.InboxTile.Name = "InboxTile"
        Me.InboxTile.Size = New System.Drawing.Size(172, 63)
        Me.InboxTile.Style = MetroFramework.MetroColorStyle.Blue
        Me.InboxTile.TabIndex = 34
        Me.InboxTile.Text = "Inbox"
        Me.InboxTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.InboxTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.InboxTile.UseSelectable = True
        '
        'NotifTile
        '
        Me.NotifTile.ActiveControl = Nothing
        Me.NotifTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.NotifTile.Location = New System.Drawing.Point(247, 3)
        Me.NotifTile.Name = "NotifTile"
        Me.NotifTile.Size = New System.Drawing.Size(172, 63)
        Me.NotifTile.TabIndex = 32
        Me.NotifTile.Text = "Notification"
        Me.NotifTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.NotifTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.NotifTile.UseCustomBackColor = True
        Me.NotifTile.UseSelectable = True
        '
        'UpdSecTile
        '
        Me.UpdSecTile.ActiveControl = Nothing
        Me.UpdSecTile.Location = New System.Drawing.Point(425, 3)
        Me.UpdSecTile.Name = "UpdSecTile"
        Me.UpdSecTile.Size = New System.Drawing.Size(172, 63)
        Me.UpdSecTile.Style = MetroFramework.MetroColorStyle.Blue
        Me.UpdSecTile.TabIndex = 31
        Me.UpdSecTile.Text = "Account Update"
        Me.UpdSecTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.UpdSecTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.UpdSecTile.UseSelectable = True
        '
        'MngeAccTile
        '
        Me.MngeAccTile.ActiveControl = Nothing
        Me.MngeAccTile.Location = New System.Drawing.Point(69, 72)
        Me.MngeAccTile.Name = "MngeAccTile"
        Me.MngeAccTile.Size = New System.Drawing.Size(262, 63)
        Me.MngeAccTile.Style = MetroFramework.MetroColorStyle.Blue
        Me.MngeAccTile.TabIndex = 36
        Me.MngeAccTile.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Accounts"
        Me.MngeAccTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MngeAccTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MngeAccTile.UseSelectable = True
        Me.MngeAccTile.Visible = False
        '
        'AcctsLBL
        '
        Me.AcctsLBL.AutoSize = True
        Me.AcctsLBL.ForeColor = System.Drawing.Color.White
        Me.AcctsLBL.Location = New System.Drawing.Point(25, 9)
        Me.AcctsLBL.Name = "AcctsLBL"
        Me.AcctsLBL.Size = New System.Drawing.Size(61, 19)
        Me.AcctsLBL.TabIndex = 24
        Me.AcctsLBL.Text = "Accounts"
        Me.AcctsLBL.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AcctsLBL.UseCustomForeColor = True
        '
        'SNOpanel
        '
        Me.SNOpanel.Controls.Add(Me.FlowLayoutPanel4)
        Me.SNOpanel.Controls.Add(Me.SalesNOperationLBL)
        Me.SNOpanel.HorizontalScrollbarBarColor = True
        Me.SNOpanel.HorizontalScrollbarHighlightOnWheel = False
        Me.SNOpanel.HorizontalScrollbarSize = 10
        Me.SNOpanel.Location = New System.Drawing.Point(3, 355)
        Me.SNOpanel.Name = "SNOpanel"
        Me.SNOpanel.Size = New System.Drawing.Size(635, 170)
        Me.SNOpanel.TabIndex = 24
        Me.SNOpanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SNOpanel.VerticalScrollbarBarColor = True
        Me.SNOpanel.VerticalScrollbarHighlightOnWheel = False
        Me.SNOpanel.VerticalScrollbarSize = 10
        Me.SNOpanel.Visible = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.ProjAssesmentTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.CheckBalTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.SUSTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.CallerInfoTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.ExterrnalDamagesTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.CollectionTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.SalesMonitoringTile)
        Me.FlowLayoutPanel4.Controls.Add(Me.SalesItineraryTile)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(635, 140)
        Me.FlowLayoutPanel4.TabIndex = 4
        '
        'ProjAssesmentTile
        '
        Me.ProjAssesmentTile.ActiveControl = Nothing
        Me.ProjAssesmentTile.Location = New System.Drawing.Point(69, 3)
        Me.ProjAssesmentTile.Name = "ProjAssesmentTile"
        Me.ProjAssesmentTile.Size = New System.Drawing.Size(128, 63)
        Me.ProjAssesmentTile.Style = MetroFramework.MetroColorStyle.Green
        Me.ProjAssesmentTile.TabIndex = 19
        Me.ProjAssesmentTile.Text = "Project" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Assessment"
        Me.ProjAssesmentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ProjAssesmentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.ProjAssesmentTile.UseSelectable = True
        Me.ProjAssesmentTile.Visible = False
        '
        'CheckBalTile
        '
        Me.CheckBalTile.ActiveControl = Nothing
        Me.CheckBalTile.Location = New System.Drawing.Point(203, 3)
        Me.CheckBalTile.Name = "CheckBalTile"
        Me.CheckBalTile.Size = New System.Drawing.Size(128, 63)
        Me.CheckBalTile.Style = MetroFramework.MetroColorStyle.Green
        Me.CheckBalTile.TabIndex = 26
        Me.CheckBalTile.Text = "Check Balance"
        Me.CheckBalTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CheckBalTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.CheckBalTile.UseSelectable = True
        Me.CheckBalTile.Visible = False
        '
        'SUSTile
        '
        Me.SUSTile.ActiveControl = Nothing
        Me.SUSTile.Location = New System.Drawing.Point(337, 3)
        Me.SUSTile.Name = "SUSTile"
        Me.SUSTile.Size = New System.Drawing.Size(128, 63)
        Me.SUSTile.Style = MetroFramework.MetroColorStyle.Green
        Me.SUSTile.TabIndex = 25
        Me.SUSTile.Text = "System Used " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sales"
        Me.SUSTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.SUSTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.SUSTile.UseSelectable = True
        Me.SUSTile.Visible = False
        '
        'CallerInfoTile
        '
        Me.CallerInfoTile.ActiveControl = Nothing
        Me.CallerInfoTile.Location = New System.Drawing.Point(471, 3)
        Me.CallerInfoTile.Name = "CallerInfoTile"
        Me.CallerInfoTile.Size = New System.Drawing.Size(128, 63)
        Me.CallerInfoTile.Style = MetroFramework.MetroColorStyle.Green
        Me.CallerInfoTile.TabIndex = 24
        Me.CallerInfoTile.Text = "Caller Info"
        Me.CallerInfoTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CallerInfoTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.CallerInfoTile.UseSelectable = True
        Me.CallerInfoTile.Visible = False
        '
        'ExterrnalDamagesTile
        '
        Me.ExterrnalDamagesTile.ActiveControl = Nothing
        Me.ExterrnalDamagesTile.Location = New System.Drawing.Point(69, 72)
        Me.ExterrnalDamagesTile.Name = "ExterrnalDamagesTile"
        Me.ExterrnalDamagesTile.Size = New System.Drawing.Size(128, 63)
        Me.ExterrnalDamagesTile.Style = MetroFramework.MetroColorStyle.Green
        Me.ExterrnalDamagesTile.TabIndex = 23
        Me.ExterrnalDamagesTile.Text = "Exterrnal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Damages"
        Me.ExterrnalDamagesTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ExterrnalDamagesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.ExterrnalDamagesTile.UseSelectable = True
        Me.ExterrnalDamagesTile.Visible = False
        '
        'CollectionTile
        '
        Me.CollectionTile.ActiveControl = Nothing
        Me.CollectionTile.Location = New System.Drawing.Point(203, 72)
        Me.CollectionTile.Name = "CollectionTile"
        Me.CollectionTile.Size = New System.Drawing.Size(128, 63)
        Me.CollectionTile.Style = MetroFramework.MetroColorStyle.Green
        Me.CollectionTile.TabIndex = 22
        Me.CollectionTile.Text = "Collection"
        Me.CollectionTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CollectionTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.CollectionTile.UseSelectable = True
        Me.CollectionTile.Visible = False
        '
        'SalesMonitoringTile
        '
        Me.SalesMonitoringTile.ActiveControl = Nothing
        Me.SalesMonitoringTile.Location = New System.Drawing.Point(337, 72)
        Me.SalesMonitoringTile.Name = "SalesMonitoringTile"
        Me.SalesMonitoringTile.Size = New System.Drawing.Size(128, 63)
        Me.SalesMonitoringTile.Style = MetroFramework.MetroColorStyle.Green
        Me.SalesMonitoringTile.TabIndex = 21
        Me.SalesMonitoringTile.Text = "Sales Monitoring"
        Me.SalesMonitoringTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.SalesMonitoringTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.SalesMonitoringTile.UseSelectable = True
        Me.SalesMonitoringTile.Visible = False
        '
        'SalesItineraryTile
        '
        Me.SalesItineraryTile.ActiveControl = Nothing
        Me.SalesItineraryTile.Location = New System.Drawing.Point(471, 72)
        Me.SalesItineraryTile.Name = "SalesItineraryTile"
        Me.SalesItineraryTile.Size = New System.Drawing.Size(128, 63)
        Me.SalesItineraryTile.Style = MetroFramework.MetroColorStyle.Green
        Me.SalesItineraryTile.TabIndex = 20
        Me.SalesItineraryTile.Text = "Sales Itinerary"
        Me.SalesItineraryTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.SalesItineraryTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.SalesItineraryTile.UseSelectable = True
        Me.SalesItineraryTile.Visible = False
        '
        'SalesNOperationLBL
        '
        Me.SalesNOperationLBL.AutoSize = True
        Me.SalesNOperationLBL.ForeColor = System.Drawing.Color.White
        Me.SalesNOperationLBL.Location = New System.Drawing.Point(15, 10)
        Me.SalesNOperationLBL.Name = "SalesNOperationLBL"
        Me.SalesNOperationLBL.Size = New System.Drawing.Size(133, 19)
        Me.SalesNOperationLBL.TabIndex = 3
        Me.SalesNOperationLBL.Text = "Sales and Operations"
        Me.SalesNOperationLBL.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SalesNOperationLBL.UseCustomForeColor = True
        '
        'ProductionPanel
        '
        Me.ProductionPanel.Controls.Add(Me.FlowLayoutPanel6)
        Me.ProductionPanel.Controls.Add(Me.ProdLBL)
        Me.ProductionPanel.HorizontalScrollbarBarColor = True
        Me.ProductionPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.ProductionPanel.HorizontalScrollbarSize = 10
        Me.ProductionPanel.Location = New System.Drawing.Point(644, 3)
        Me.ProductionPanel.Name = "ProductionPanel"
        Me.ProductionPanel.Size = New System.Drawing.Size(635, 170)
        Me.ProductionPanel.TabIndex = 28
        Me.ProductionPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ProductionPanel.VerticalScrollbarBarColor = True
        Me.ProductionPanel.VerticalScrollbarHighlightOnWheel = False
        Me.ProductionPanel.VerticalScrollbarSize = 10
        Me.ProductionPanel.Visible = False
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.StatusMonitoringTile)
        Me.FlowLayoutPanel6.Controls.Add(Me.CuttingListTile)
        Me.FlowLayoutPanel6.Controls.Add(Me.GlassSpecsTile)
        Me.FlowLayoutPanel6.Controls.Add(Me.ProdSDRequestTile)
        Me.FlowLayoutPanel6.Controls.Add(Me.ProdSDSubmittalTile)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(635, 140)
        Me.FlowLayoutPanel6.TabIndex = 18
        '
        'StatusMonitoringTile
        '
        Me.StatusMonitoringTile.ActiveControl = Nothing
        Me.StatusMonitoringTile.Location = New System.Drawing.Point(69, 3)
        Me.StatusMonitoringTile.Name = "StatusMonitoringTile"
        Me.StatusMonitoringTile.Size = New System.Drawing.Size(172, 63)
        Me.StatusMonitoringTile.Style = MetroFramework.MetroColorStyle.Orange
        Me.StatusMonitoringTile.TabIndex = 27
        Me.StatusMonitoringTile.Text = "Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monitoring"
        Me.StatusMonitoringTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.StatusMonitoringTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.StatusMonitoringTile.UseSelectable = True
        Me.StatusMonitoringTile.Visible = False
        '
        'CuttingListTile
        '
        Me.CuttingListTile.ActiveControl = Nothing
        Me.CuttingListTile.Location = New System.Drawing.Point(247, 3)
        Me.CuttingListTile.Name = "CuttingListTile"
        Me.CuttingListTile.Size = New System.Drawing.Size(173, 63)
        Me.CuttingListTile.Style = MetroFramework.MetroColorStyle.Orange
        Me.CuttingListTile.TabIndex = 25
        Me.CuttingListTile.Text = "Cutting list"
        Me.CuttingListTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.CuttingListTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.CuttingListTile.UseSelectable = True
        Me.CuttingListTile.Visible = False
        '
        'GlassSpecsTile
        '
        Me.GlassSpecsTile.ActiveControl = Nothing
        Me.GlassSpecsTile.Location = New System.Drawing.Point(426, 3)
        Me.GlassSpecsTile.Name = "GlassSpecsTile"
        Me.GlassSpecsTile.Size = New System.Drawing.Size(173, 63)
        Me.GlassSpecsTile.Style = MetroFramework.MetroColorStyle.Orange
        Me.GlassSpecsTile.TabIndex = 26
        Me.GlassSpecsTile.Text = "Glass Specs"
        Me.GlassSpecsTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.GlassSpecsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.GlassSpecsTile.UseSelectable = True
        Me.GlassSpecsTile.Visible = False
        '
        'ProdSDRequestTile
        '
        Me.ProdSDRequestTile.ActiveControl = Nothing
        Me.ProdSDRequestTile.Location = New System.Drawing.Point(69, 72)
        Me.ProdSDRequestTile.Name = "ProdSDRequestTile"
        Me.ProdSDRequestTile.Size = New System.Drawing.Size(262, 63)
        Me.ProdSDRequestTile.Style = MetroFramework.MetroColorStyle.Orange
        Me.ProdSDRequestTile.TabIndex = 24
        Me.ProdSDRequestTile.Text = "SD Request"
        Me.ProdSDRequestTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ProdSDRequestTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.ProdSDRequestTile.UseSelectable = True
        Me.ProdSDRequestTile.Visible = False
        '
        'ProdSDSubmittalTile
        '
        Me.ProdSDSubmittalTile.ActiveControl = Nothing
        Me.ProdSDSubmittalTile.Location = New System.Drawing.Point(337, 72)
        Me.ProdSDSubmittalTile.Name = "ProdSDSubmittalTile"
        Me.ProdSDSubmittalTile.Size = New System.Drawing.Size(262, 63)
        Me.ProdSDSubmittalTile.Style = MetroFramework.MetroColorStyle.Orange
        Me.ProdSDSubmittalTile.TabIndex = 28
        Me.ProdSDSubmittalTile.Text = "SD Submittal"
        Me.ProdSDSubmittalTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ProdSDSubmittalTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.ProdSDSubmittalTile.UseSelectable = True
        Me.ProdSDSubmittalTile.Visible = False
        '
        'ProdLBL
        '
        Me.ProdLBL.AutoSize = True
        Me.ProdLBL.ForeColor = System.Drawing.Color.White
        Me.ProdLBL.Location = New System.Drawing.Point(15, 10)
        Me.ProdLBL.Name = "ProdLBL"
        Me.ProdLBL.Size = New System.Drawing.Size(73, 19)
        Me.ProdLBL.TabIndex = 17
        Me.ProdLBL.Text = "Production"
        Me.ProdLBL.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ProdLBL.UseCustomForeColor = True
        '
        'EngrPanel
        '
        Me.EngrPanel.Controls.Add(Me.FlowLayoutPanel7)
        Me.EngrPanel.Controls.Add(Me.EngrLBL)
        Me.EngrPanel.HorizontalScrollbarBarColor = True
        Me.EngrPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.EngrPanel.HorizontalScrollbarSize = 10
        Me.EngrPanel.Location = New System.Drawing.Point(644, 179)
        Me.EngrPanel.Name = "EngrPanel"
        Me.EngrPanel.Size = New System.Drawing.Size(635, 170)
        Me.EngrPanel.TabIndex = 29
        Me.EngrPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.EngrPanel.VerticalScrollbarBarColor = True
        Me.EngrPanel.VerticalScrollbarHighlightOnWheel = False
        Me.EngrPanel.VerticalScrollbarSize = 10
        Me.EngrPanel.Visible = False
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.DeliveryRecieptsTile)
        Me.FlowLayoutPanel7.Controls.Add(Me.EngrsItineraryTIle)
        Me.FlowLayoutPanel7.Controls.Add(Me.DRTile)
        Me.FlowLayoutPanel7.Controls.Add(Me.DRReportTile)
        Me.FlowLayoutPanel7.Controls.Add(Me.EngrSDRequestTile)
        Me.FlowLayoutPanel7.Controls.Add(Me.EngrSDSubmittalTile)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(635, 140)
        Me.FlowLayoutPanel7.TabIndex = 18
        '
        'DeliveryRecieptsTile
        '
        Me.DeliveryRecieptsTile.ActiveControl = Nothing
        Me.DeliveryRecieptsTile.Location = New System.Drawing.Point(69, 3)
        Me.DeliveryRecieptsTile.Name = "DeliveryRecieptsTile"
        Me.DeliveryRecieptsTile.Size = New System.Drawing.Size(128, 63)
        Me.DeliveryRecieptsTile.Style = MetroFramework.MetroColorStyle.Silver
        Me.DeliveryRecieptsTile.TabIndex = 12
        Me.DeliveryRecieptsTile.Text = "Delivery " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reciepts"
        Me.DeliveryRecieptsTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DeliveryRecieptsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.DeliveryRecieptsTile.UseSelectable = True
        Me.DeliveryRecieptsTile.Visible = False
        '
        'EngrsItineraryTIle
        '
        Me.EngrsItineraryTIle.ActiveControl = Nothing
        Me.EngrsItineraryTIle.Location = New System.Drawing.Point(203, 3)
        Me.EngrsItineraryTIle.Name = "EngrsItineraryTIle"
        Me.EngrsItineraryTIle.Size = New System.Drawing.Size(128, 63)
        Me.EngrsItineraryTIle.Style = MetroFramework.MetroColorStyle.Silver
        Me.EngrsItineraryTIle.TabIndex = 13
        Me.EngrsItineraryTIle.Text = "Engr's Itinerary"
        Me.EngrsItineraryTIle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.EngrsItineraryTIle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.EngrsItineraryTIle.UseSelectable = True
        Me.EngrsItineraryTIle.Visible = False
        '
        'DRTile
        '
        Me.DRTile.ActiveControl = Nothing
        Me.DRTile.Location = New System.Drawing.Point(337, 3)
        Me.DRTile.Name = "DRTile"
        Me.DRTile.Size = New System.Drawing.Size(128, 63)
        Me.DRTile.Style = MetroFramework.MetroColorStyle.Silver
        Me.DRTile.TabIndex = 15
        Me.DRTile.Text = "DR"
        Me.DRTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DRTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.DRTile.UseSelectable = True
        Me.DRTile.Visible = False
        '
        'DRReportTile
        '
        Me.DRReportTile.ActiveControl = Nothing
        Me.DRReportTile.Location = New System.Drawing.Point(471, 3)
        Me.DRReportTile.Name = "DRReportTile"
        Me.DRReportTile.Size = New System.Drawing.Size(128, 63)
        Me.DRReportTile.Style = MetroFramework.MetroColorStyle.Silver
        Me.DRReportTile.TabIndex = 16
        Me.DRReportTile.Text = "DR Report"
        Me.DRReportTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DRReportTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.DRReportTile.UseSelectable = True
        Me.DRReportTile.Visible = False
        '
        'EngrSDRequestTile
        '
        Me.EngrSDRequestTile.ActiveControl = Nothing
        Me.EngrSDRequestTile.Location = New System.Drawing.Point(69, 72)
        Me.EngrSDRequestTile.Name = "EngrSDRequestTile"
        Me.EngrSDRequestTile.Size = New System.Drawing.Size(262, 63)
        Me.EngrSDRequestTile.Style = MetroFramework.MetroColorStyle.Silver
        Me.EngrSDRequestTile.TabIndex = 11
        Me.EngrSDRequestTile.Text = "SD Request"
        Me.EngrSDRequestTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.EngrSDRequestTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.EngrSDRequestTile.UseSelectable = True
        Me.EngrSDRequestTile.Visible = False
        '
        'EngrSDSubmittalTile
        '
        Me.EngrSDSubmittalTile.ActiveControl = Nothing
        Me.EngrSDSubmittalTile.Location = New System.Drawing.Point(337, 72)
        Me.EngrSDSubmittalTile.Name = "EngrSDSubmittalTile"
        Me.EngrSDSubmittalTile.Size = New System.Drawing.Size(262, 63)
        Me.EngrSDSubmittalTile.Style = MetroFramework.MetroColorStyle.Silver
        Me.EngrSDSubmittalTile.TabIndex = 17
        Me.EngrSDSubmittalTile.Text = "SD Submittal"
        Me.EngrSDSubmittalTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.EngrSDSubmittalTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.EngrSDSubmittalTile.UseSelectable = True
        Me.EngrSDSubmittalTile.Visible = False
        '
        'EngrLBL
        '
        Me.EngrLBL.AutoSize = True
        Me.EngrLBL.ForeColor = System.Drawing.Color.White
        Me.EngrLBL.Location = New System.Drawing.Point(15, 10)
        Me.EngrLBL.Name = "EngrLBL"
        Me.EngrLBL.Size = New System.Drawing.Size(78, 19)
        Me.EngrLBL.TabIndex = 3
        Me.EngrLBL.Text = "Engineering"
        Me.EngrLBL.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.EngrLBL.UseCustomForeColor = True
        '
        'MarketingPanel
        '
        Me.MarketingPanel.Controls.Add(Me.FlowLayoutPanel5)
        Me.MarketingPanel.Controls.Add(Me.MarketingLabel)
        Me.MarketingPanel.HorizontalScrollbarBarColor = True
        Me.MarketingPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.MarketingPanel.HorizontalScrollbarSize = 10
        Me.MarketingPanel.Location = New System.Drawing.Point(644, 355)
        Me.MarketingPanel.Name = "MarketingPanel"
        Me.MarketingPanel.Size = New System.Drawing.Size(635, 170)
        Me.MarketingPanel.TabIndex = 30
        Me.MarketingPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MarketingPanel.VerticalScrollbarBarColor = True
        Me.MarketingPanel.VerticalScrollbarHighlightOnWheel = False
        Me.MarketingPanel.VerticalScrollbarSize = 10
        Me.MarketingPanel.Visible = False
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.MarketingRequestTile)
        Me.FlowLayoutPanel5.Controls.Add(Me.InventoryTile)
        Me.FlowLayoutPanel5.Controls.Add(Me.ArchiFirmTile)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(635, 140)
        Me.FlowLayoutPanel5.TabIndex = 19
        '
        'MarketingRequestTile
        '
        Me.MarketingRequestTile.ActiveControl = Nothing
        Me.MarketingRequestTile.ForeColor = System.Drawing.Color.Black
        Me.MarketingRequestTile.Location = New System.Drawing.Point(69, 3)
        Me.MarketingRequestTile.Name = "MarketingRequestTile"
        Me.MarketingRequestTile.Size = New System.Drawing.Size(262, 63)
        Me.MarketingRequestTile.Style = MetroFramework.MetroColorStyle.Teal
        Me.MarketingRequestTile.TabIndex = 26
        Me.MarketingRequestTile.Text = "Request"
        Me.MarketingRequestTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.MarketingRequestTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MarketingRequestTile.UseSelectable = True
        Me.MarketingRequestTile.Visible = False
        '
        'InventoryTile
        '
        Me.InventoryTile.ActiveControl = Nothing
        Me.InventoryTile.ForeColor = System.Drawing.Color.Black
        Me.InventoryTile.Location = New System.Drawing.Point(337, 3)
        Me.InventoryTile.Name = "InventoryTile"
        Me.InventoryTile.Size = New System.Drawing.Size(128, 63)
        Me.InventoryTile.Style = MetroFramework.MetroColorStyle.Teal
        Me.InventoryTile.TabIndex = 25
        Me.InventoryTile.Text = "Inventory"
        Me.InventoryTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.InventoryTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.InventoryTile.UseSelectable = True
        Me.InventoryTile.Visible = False
        '
        'ArchiFirmTile
        '
        Me.ArchiFirmTile.ActiveControl = Nothing
        Me.ArchiFirmTile.ForeColor = System.Drawing.Color.Black
        Me.ArchiFirmTile.Location = New System.Drawing.Point(471, 3)
        Me.ArchiFirmTile.Name = "ArchiFirmTile"
        Me.ArchiFirmTile.Size = New System.Drawing.Size(128, 63)
        Me.ArchiFirmTile.Style = MetroFramework.MetroColorStyle.Teal
        Me.ArchiFirmTile.TabIndex = 24
        Me.ArchiFirmTile.Text = "Architectural" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Firm"
        Me.ArchiFirmTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ArchiFirmTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.ArchiFirmTile.UseSelectable = True
        Me.ArchiFirmTile.Visible = False
        '
        'MarketingLabel
        '
        Me.MarketingLabel.AutoSize = True
        Me.MarketingLabel.ForeColor = System.Drawing.Color.White
        Me.MarketingLabel.Location = New System.Drawing.Point(15, 10)
        Me.MarketingLabel.Name = "MarketingLabel"
        Me.MarketingLabel.Size = New System.Drawing.Size(68, 19)
        Me.MarketingLabel.TabIndex = 17
        Me.MarketingLabel.Text = "Marketing"
        Me.MarketingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MarketingLabel.UseCustomForeColor = True
        '
        'CostingPanel
        '
        Me.CostingPanel.Controls.Add(Me.FlowLayoutPanel10)
        Me.CostingPanel.Controls.Add(Me.MetroLabel1)
        Me.CostingPanel.HorizontalScrollbarBarColor = True
        Me.CostingPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.CostingPanel.HorizontalScrollbarSize = 10
        Me.CostingPanel.Location = New System.Drawing.Point(1285, 3)
        Me.CostingPanel.Name = "CostingPanel"
        Me.CostingPanel.Size = New System.Drawing.Size(620, 170)
        Me.CostingPanel.TabIndex = 31
        Me.CostingPanel.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CostingPanel.VerticalScrollbarBarColor = True
        Me.CostingPanel.VerticalScrollbarHighlightOnWheel = False
        Me.CostingPanel.VerticalScrollbarSize = 10
        Me.CostingPanel.Visible = False
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.WinDoorMakerTile)
        Me.FlowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Padding = New System.Windows.Forms.Padding(66, 0, 0, 0)
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(620, 140)
        Me.FlowLayoutPanel10.TabIndex = 19
        '
        'WinDoorMakerTile
        '
        Me.WinDoorMakerTile.ActiveControl = Nothing
        Me.WinDoorMakerTile.BackColor = System.Drawing.Color.SlateBlue
        Me.WinDoorMakerTile.ForeColor = System.Drawing.Color.DarkGray
        Me.WinDoorMakerTile.Location = New System.Drawing.Point(69, 3)
        Me.WinDoorMakerTile.Name = "WinDoorMakerTile"
        Me.WinDoorMakerTile.Size = New System.Drawing.Size(262, 132)
        Me.WinDoorMakerTile.Style = MetroFramework.MetroColorStyle.Red
        Me.WinDoorMakerTile.TabIndex = 32
        Me.WinDoorMakerTile.Text = "WinDoor Maker"
        Me.WinDoorMakerTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.WinDoorMakerTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.WinDoorMakerTile.UseCustomBackColor = True
        Me.WinDoorMakerTile.UseSelectable = True
        Me.WinDoorMakerTile.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel1.TabIndex = 18
        Me.MetroLabel1.Text = "Costing"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1320, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(20, 680)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'NicknameLbl
        '
        Me.NicknameLbl.AutoSize = True
        Me.NicknameLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.NicknameLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.NicknameLbl.Location = New System.Drawing.Point(20, 19)
        Me.NicknameLbl.Name = "NicknameLbl"
        Me.NicknameLbl.Size = New System.Drawing.Size(113, 25)
        Me.NicknameLbl.TabIndex = 6
        Me.NicknameLbl.Text = "NicknameLbl"
        Me.NicknameLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.NicknameLbl.UseStyleColors = True
        '
        'ChangeDB_BGW
        '
        Me.ChangeDB_BGW.WorkerReportsProgress = True
        Me.ChangeDB_BGW.WorkerSupportsCancellation = True
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPBOX.Location = New System.Drawing.Point(1153, 35)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(79, 29)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 7
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'PrototypeTile
        '
        Me.PrototypeTile.ActiveControl = Nothing
        Me.PrototypeTile.Location = New System.Drawing.Point(337, 72)
        Me.PrototypeTile.Name = "PrototypeTile"
        Me.PrototypeTile.Size = New System.Drawing.Size(172, 63)
        Me.PrototypeTile.Style = MetroFramework.MetroColorStyle.Blue
        Me.PrototypeTile.TabIndex = 37
        Me.PrototypeTile.Text = "Prototypes"
        Me.PrototypeTile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.PrototypeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.PrototypeTile.UseSelectable = True
        '
        'KMDI_MainFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 760)
        Me.Controls.Add(Me.DbNameCbox)
        Me.Controls.Add(Me.LoadingPBOX)
        Me.Controls.Add(Me.NicknameLbl)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MainFRMBody_FLP)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KMDI_MainFRM"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainFRMBody_FLP.ResumeLayout(False)
        Me.ContractsPanel.ResumeLayout(False)
        Me.ContractsPanel.PerformLayout()
        Me.FlowLayoutPanel9.ResumeLayout(False)
        Me.AccountsPanel.ResumeLayout(False)
        Me.AccountsPanel.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.SNOpanel.ResumeLayout(False)
        Me.SNOpanel.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.ProductionPanel.ResumeLayout(False)
        Me.ProductionPanel.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.EngrPanel.ResumeLayout(False)
        Me.EngrPanel.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.MarketingPanel.ResumeLayout(False)
        Me.MarketingPanel.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.CostingPanel.ResumeLayout(False)
        Me.CostingPanel.PerformLayout()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbNameCbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents MainFRMBody_FLP As FlowLayoutPanel
    Friend WithEvents ContractsPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents ContractsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents ContractListTile As MetroFramework.Controls.MetroTile
    Friend WithEvents NicknameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents AccountsPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents InboxTile As MetroFramework.Controls.MetroTile
    Friend WithEvents NotifTile As MetroFramework.Controls.MetroTile
    Friend WithEvents UpdSecTile As MetroFramework.Controls.MetroTile
    Friend WithEvents MngeAccTile As MetroFramework.Controls.MetroTile
    Friend WithEvents AcctsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents RecycleTile As MetroFramework.Controls.MetroTile
    Friend WithEvents SNOpanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents ProjAssesmentTile As MetroFramework.Controls.MetroTile
    Friend WithEvents CheckBalTile As MetroFramework.Controls.MetroTile
    Friend WithEvents SUSTile As MetroFramework.Controls.MetroTile
    Friend WithEvents CallerInfoTile As MetroFramework.Controls.MetroTile
    Friend WithEvents ExterrnalDamagesTile As MetroFramework.Controls.MetroTile
    Friend WithEvents CollectionTile As MetroFramework.Controls.MetroTile
    Friend WithEvents SalesMonitoringTile As MetroFramework.Controls.MetroTile
    Friend WithEvents SalesItineraryTile As MetroFramework.Controls.MetroTile
    Friend WithEvents SalesNOperationLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProductionPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents StatusMonitoringTile As MetroFramework.Controls.MetroTile
    Friend WithEvents CuttingListTile As MetroFramework.Controls.MetroTile
    Friend WithEvents GlassSpecsTile As MetroFramework.Controls.MetroTile
    Friend WithEvents ProdSDRequestTile As MetroFramework.Controls.MetroTile
    Friend WithEvents ProdSDSubmittalTile As MetroFramework.Controls.MetroTile
    Friend WithEvents ProdLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents EngrPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents DeliveryRecieptsTile As MetroFramework.Controls.MetroTile
    Friend WithEvents EngrsItineraryTIle As MetroFramework.Controls.MetroTile
    Friend WithEvents DRTile As MetroFramework.Controls.MetroTile
    Friend WithEvents DRReportTile As MetroFramework.Controls.MetroTile
    Friend WithEvents EngrSDRequestTile As MetroFramework.Controls.MetroTile
    Friend WithEvents EngrSDSubmittalTile As MetroFramework.Controls.MetroTile
    Friend WithEvents EngrLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents MarketingPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents MarketingRequestTile As MetroFramework.Controls.MetroTile
    Friend WithEvents InventoryTile As MetroFramework.Controls.MetroTile
    Friend WithEvents ArchiFirmTile As MetroFramework.Controls.MetroTile
    Friend WithEvents MarketingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents CostingPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents WinDoorMakerTile As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ChangeDB_BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents PrototypeTile As MetroFramework.Controls.MetroTile
End Class
