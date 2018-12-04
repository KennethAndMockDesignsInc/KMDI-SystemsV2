Imports System.ComponentModel
Imports MetroFramework
Imports MetroFramework.Controls
Imports ComponentFactory.Krypton.Toolkit

Public Class ContractItemsFRM
    Dim sql As New KMDIContractItemsClass
    Public SearchString As String
    Public ActionTaken As String
    Public SearchItemFN As String

    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Public GenerateOutput As Boolean
    Public FrameEntry As Boolean
    Public ScreenEntry As Boolean
    Public GlassEntry As Boolean
    Public FilmEntry As Boolean
    Public MechEntry As Boolean
    Public AddOnEntry As Boolean

    Private m_PanStartPoint As New Point

    Public FDataTable As New DataTable

    Public FSubTotal As Decimal
    Public GSubTotal As Decimal

    Dim CIF_Screen_DGV As New KryptonDataGridView

    Public ContractItemsBGW As BackgroundWorker = New BackgroundWorker
    Private Sub ContractItemEditingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            AddHandler ContractItemsBGW.DoWork, AddressOf ContractItemsBGW_DoWork
            AddHandler ContractItemsBGW.RunWorkerCompleted, AddressOf ContractItemsBGW_RunWorkerCompleted
            AddHandler ContractItemsBGW.ProgressChanged, AddressOf ContractItemsBGW_ProgressChanged

            LoadInitialSetUp()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub LoadInitialSetUp()
        CIF_TCTRL.SelectedTab = FramesTAB
        GenerateOutput = False
        ResetEntry()
        ActionTaken = "Search"
        SearchItemFN = "Frames"
        StartWorker()
    End Sub

    Public Sub StartWorker()
        Try
            If ContractItemsBGW.IsBusy <> True Then
                Select Case ActionTaken
                    Case "Search"
                        Select Case SearchItemFN
                            Case "Frames"
                            Case "Screens"
                                CIF_Screen_DGV.Columns.Clear()
                                CIF_Screen_DGV.DataSource = Nothing
                                CIF_Screen_DGV.DataMember = Nothing
                            Case "Glass"
                            Case "Films"
                            Case "Mechanisms"
                            Case "Add-Ons"
                            Case "Summary"
                        End Select
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                End Select
                Load_LBL.Visible = True
                Load_PB.Visible = True
                ContractItemsBGW.WorkerReportsProgress = True
                ContractItemsBGW.WorkerSupportsCancellation = True
                ContractItemsBGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ContractItemsBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Try
            Select Case GenerateOutput
                Case True


                    Select Case ActionTaken
                        Case "Search"
                            Select Case SearchItemFN
                                Case "Frames"
                                    If sql.ds.Tables("Frames").Rows.Count > 0 Then
                                        For i As Integer = 0 To sql.ds.Tables("Frames").Rows.Count - 1
                                            Threading.Thread.Sleep(100)
                                            ContractItemsBGW.ReportProgress(i)
                                        Next i
                                    Else
                                        'ContractItemsBGW.WorkerSupportsCancellation = True
                                        'ContractItemsBGW.CancelAsync()
                                    End If
                                Case "Screens"
                                    If sql.ds.Tables("Screens").Rows.Count > 0 Then
                                        For i As Integer = 0 To 1 - 1
                                            Threading.Thread.Sleep(100)
                                            ContractItemsBGW.ReportProgress(i)
                                        Next i
                                    Else
                                        MessageBox.Show("Walang screen")
                                    End If

                                Case "Glass"
                                    If sql.ds.Tables("Glass").Rows.Count > 0 Then
                                        For i As Integer = 0 To sql.ds.Tables("Glass").Rows.Count - 1
                                            Threading.Thread.Sleep(100)
                                            ContractItemsBGW.ReportProgress(i)
                                        Next i
                                    Else
                                        'ContractItemsBGW.WorkerSupportsCancellation = True
                                        'ContractItemsBGW.CancelAsync()
                                    End If
                                Case "Films"
                                Case "Mechanisms"
                                Case "Add-Ons"
                                Case "Summary"
                            End Select
                        Case "Add"
                        Case "Update"
                        Case "Delete"
                    End Select


                Case False
                    ActionTakenByUser()

                    For i As Integer = 0 To 1 - 1
                        sql.ContractItemsLoad(QueryFunction,
                                              QueryBody,
                                              QueryCondition,
                                              ActionTaken,
                                              SearchItemFN,
                                              SearchString)
                        Threading.Thread.Sleep(100)
                        ContractItemsBGW.ReportProgress(i)
                    Next i

            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
            ContractItemsBGW.WorkerSupportsCancellation = True
            ContractItemsBGW.CancelAsync()
        End Try


        If ContractItemsBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "Frames"
                        QueryFunction = "SELECT "
                        QueryBody = " AUTONUM,
                                      JOB_ORDER_NO,
                                      ITEM_NO as ITEM#,
                                      WDW_NO AS WDW#,
                                      LOCATION,
                                      COLOR,
                                      WIDTH,
                                      HEIGHT,
                                      DESCRIPTION,
                                      GLASS_SPECS,
                                      QTY,
                                      format(PRICE,'N2') as PRICE,
                                      DISCOUNT,
                                      format(NET_PRICE,'n2') as NET_PRICE,
                                      POINTS,
                                      SYSTEM_USED,
                                      REMARKS,
                                      STATUS,
                                      IMG
                                    FROM KMDI_ASPERCONTRACT_TB "
                        QueryCondition = " WHERE JOB_ORDER_NO = @SearchString
                                           ORDER BY ITEM_NO DESC"
                    Case "Screens"
                        QueryFunction = "DECLARE @Sub_Total as DECIMAL(18,2)
                                         DECLARE @Sub_Total_QTY as DECIMAL(18,2)
                                         DECLARE @Sub_Total_per_QTY as DECIMAL(18,2) "
                        QueryBody = " SELECT @Sub_Total = SUM(PRICE)
                                      FROM [KMDI_SCREENASPERCONTRACT_TB]
                                      WHERE [JOB_ORDER_NO] = @SearchString

                                      SELECT @Sub_Total_QTY = SUM(QTY)
                                      FROM [KMDI_SCREENASPERCONTRACT_TB]
                                      WHERE [JOB_ORDER_NO]= @SearchString

                                      SELECT [ITEM_NO] as [Item],
	                                         [DESCRIPTION] as [Type of Insect Screen],                                           
                                             CONCAT([WIDTH],'" & "w x " & "',[HEIGHT],'" & "h - " & "',[COLOR]) as [Dimension(mm) - P.Color],
	                                         CONCAT([WDW_NO],' ',[LOCATION]) as [Window/Door I.D.],
                                             FORMAT(PRICE,'N2') as [Unit Price],                                        
                                             [QTY] as [Qty],
                                             FORMAT(NET_PRICE,'N2') as [Total Amount],
                                             [AUTONUM],
                                             [JOB_ORDER_NO],
                                             [WDW_NO],
                                             [LOCATION],
                                             [COLOR],
                                             [WIDTH],
                                             [HEIGHT],
                                             [DISCOUNT],
                                             [POINTS],
                                             [SYSTEM_USED],
                                             [REMARKS],
                                             [STATUS],
                                             FORMAT(@Sub_Total_QTY,'N0') as [Total QTY], 
	                                         FORMAT(@Sub_Total,'N2') as [Sub Total]	                                          
                                     FROM [KMDI_SCREENASPERCONTRACT_TB] "
                        QueryCondition = " WHERE [JOB_ORDER_NO] = @SearchString
                                           ORDER BY ITEM_NO ASC"
                    Case "Glass"
                        QueryFunction = "SELECT"
                        QueryBody = "  [AUTONUM]
                                      ,[JOB_ORDER_NO]
                                      ,[ADDITIONAL]
                                      ,[ITEM_NO]
                                      ,[WDW_DOOR_ID]
                                      ,[THICKNESS]
                                      ,[DIMENSION]
                                      ,[NET_PRICE]
                                      ,[QTY]
                                      ,[DISCOUNT]
                                      ,[NET_AMOUNT]
                                      ,[REMARKS]
                                      ,[SELECTED_ITEMS]
                                  FROM [KMDI_ADDITIONAL_TB] "
                        QueryCondition = "WHERE ([ADDITIONAL] = 'Tempering' or [ADDITIONAL] = 'Frosting') AND
		                                        [JOB_ORDER_NO] = @SearchString
                                          ORDER BY ITEM_NO ASC"
                    Case "Films"
                        QueryFunction = ""
                        QueryBody = ""
                        QueryCondition = ""
                    Case "Mechanisms"
                        QueryFunction = ""
                        QueryBody = ""
                        QueryCondition = ""
                    Case "Add-Ons"
                        QueryFunction = ""
                        QueryBody = ""
                        QueryCondition = ""
                    Case "Summary"
                        QueryFunction = ""
                        QueryBody = ""
                        QueryCondition = ""
                End Select
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Private Sub ContractItemsBGW_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        Try
            Select Case GenerateOutput
                Case True

                    '// Start loading bar.
                    With Load_PB
                        .ProgressBarStyle = ProgressBarStyle.Blocks
                        Select Case ActionTaken
                            Case "Search"
                                Select Case SearchItemFN
                                    Case "Frames"
                                        .Value = (100 * e.ProgressPercentage / sql.ds.Tables("Frames").Rows.Count)
                                    Case "Screens"
                                        .Value = (100 * e.ProgressPercentage / sql.ds.Tables("Screens").Rows.Count)
                                    Case "Glass"
                                        .Value = (100 * e.ProgressPercentage / sql.ds.Tables("Glass").Rows.Count)
                                    Case "Films"
                                    Case "Mechanisms"
                                    Case "Add-Ons"
                                    Case "Summary"
                                End Select
                            Case "Add"
                            Case "Update"
                            Case "Delete"
                        End Select
                    End With

                    '// Start creating controls
                    Select Case ActionTaken
                        Case "Search"
                            Select Case SearchItemFN
                                Case "Frames"
                                    '// Clear all controls inside the panel.
                                    Select Case e.ProgressPercentage
                                        Case 0
                                            FMid_PNL.Controls.Clear()
                                    End Select

                                    CreateFrameOutput(e)
                                Case "Screens"
                                    Select Case e.ProgressPercentage
                                        Case 0
                                            SMid_PNL.Controls.Clear()
                                    End Select


                                    Try
                                        CreateDGVOutput()

                                        SMid_PNL.Controls.Add(CIF_Screen_DGV)

                                        With CIF_Screen_DGV
                                            For i As Integer = 0 To CIF_Screen_DGV.ColumnCount - 1
                                                If i <= 6 Then
                                                    .Columns(i).Visible = True
                                                ElseIf i >= 7 Then
                                                    .Columns(i).Visible = False
                                                End If
                                            Next

                                            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                                            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                                            STotalQTY_LBL.Text = sql.ds.Tables("Screens").Rows(0).Item(19).ToString()
                                            SSubPrice_LBL.Text = sql.ds.Tables("Screens").Rows(0).Item(20).ToString()

                                            CIF_Screen_DGV.Focus()
                                        End With

                                    Catch ex As Exception
                                        If MetroMessageBox.Show(Me, "The system has encountered an error during output of contract screen information. Would you like to refresh the system?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                            LoadInitialSetUp()
                                        Else
                                            Me.Close()
                                        End If
                                    End Try
                                Case "Glass"
                                    '// Clear all controls inside the panel.
                                    Select Case e.ProgressPercentage
                                        Case 0
                                            GMid_PNL.Controls.Clear()
                                    End Select

                                    CreateGlassOutput(e)
                                Case "Films"
                                Case "Mechanisms"
                                Case "Add-Ons"
                                Case "Summary"
                            End Select
                        Case "Add"
                        Case "Update"
                        Case "Delete"
                    End Select
                Case False

                    '// Start loading bar.
                    With Load_PB
                        .ProgressBarStyle = ProgressBarStyle.Blocks
                        .Value = (100 * e.ProgressPercentage / 1)
                    End With

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ContractItemsBGW.WorkerSupportsCancellation = True
            ContractItemsBGW.CancelAsync()
        End Try

    End Sub

    Private Sub ContractItemsBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)

        Select Case GenerateOutput
            Case True

                Try
                    If e.Cancelled = True Then
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of contract information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    ElseIf e.Error IsNot Nothing Then
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of contract information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    Else
                        Load_LBL.Visible = False
                        Load_PB.Visible = False
                        Load_PB.Value = 0
                        GenerateOutput = False

                        Select Case ActionTaken
                            Case "Search"
                                Select Case SearchItemFN
                                    Case "Frames"
                                        FrameEntry = False
                                        FSubPrice_LBL.Text = FSubTotal.ToString("N2")
                                    Case "Screens"
                                        ScreenEntry = False
                                    Case "Glass"
                                        GlassEntry = False
                                    Case "Mechanisms"
                                    Case "Add-Ons"
                                    Case "Summary"
                                End Select
                            Case "Add"
                            Case "Update"
                            Case "Delete"
                        End Select
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case False
                Try
                    If e.Cancelled = True Then
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of contract information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    ElseIf e.Error IsNot Nothing Then
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of contract information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    Else
                        Select Case ActionTaken
                            Case "Search"
                                Select Case SearchItemFN
                                    Case "Frames"
                                        If Read.HasRows = True Then
                                            CheckDataValues()
                                        Else

                                        End If
                                    Case "Screens"
                                        If Read.HasRows = True Then
                                            CheckDataValues()
                                        Else

                                        End If
                                    Case "Glass"
                                        If Read.HasRows = True Then
                                            CheckDataValues()
                                        Else

                                        End If
                                    Case "Films"
                                    Case "Mechanisms"
                                    Case "Add-Ons"
                                    Case "Summary"
                                End Select
                            Case "Add"
                            Case "Update"
                            Case "Delete"
                        End Select
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
        End Select
    End Sub

    Public Sub CheckDataValues()
        Try
            Select Case ActionTaken
                Case "Search"
                    Select Case SearchItemFN
                        Case "Frames"
                            GenerateOutput = True
                            FSubTotal = "0.00"
                            StartWorker()
                        Case "Screens"
                            GenerateOutput = True
                            STotalQTY_LBL.Text = "0"
                            SSubPrice_LBL.Text = "0.00"
                            StartWorker()
                        Case "Glass"
                            GenerateOutput = True
                            GSubTotal = "0.00"
                            StartWorker()
                        Case "Films"
                        Case "Mechanisms"
                        Case "Add-Ons"
                        Case "Summary"
                    End Select
                Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub CreateFrameOutput(ByVal e As ProgressChangedEventArgs)

        '// Generate new panel
        Dim panel As New Panel
        With panel
            .Name = "FPanel_" & CStr(e.ProgressPercentage)
            .Width = 1127
            .Height = 165
            .Dock = DockStyle.Top
            .BorderStyle = 1
            .TabStop = False
        End With

        '// Add created panel to container
        FMid_PNL.Controls.Add(panel)

        '// Generate new item details
        Dim Lbl_Name As String

        For i As Integer = 0 To 13 - 1
            Lbl_Name = "FLbl_" & CStr(e.ProgressPercentage) & CStr(i)
            Dim Labels As New MetroLabel

            With Labels
                .Name = Lbl_Name
                .FontSize = MetroLabelSize.Medium
                .FontWeight = MetroLabelWeight.Regular
                If i <= 8 Then
                    .AutoSize = True
                    Select Case i
                        Case 0
                            .Location = New Point(3, 9)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(2).ToString
                        Case 1
                            .Location = New Point(61, 9)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(4).ToString
                        Case 2
                            .Location = New Point(215, 9)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(3).ToString
                        Case 3
                            .Location = New Point(215, 28)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(6).ToString & "w x " & sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(7).ToString & "h - " & sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(5).ToString
                        Case 4
                            .Location = New Point(215, 47)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(8).ToString
                        Case 5
                            .Location = New Point(215, 66)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(8).ToString
                        Case 6
                            .Location = New Point(215, 85)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(9).ToString
                        Case 7
                            .Location = New Point(215, 104)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(9).ToString
                        Case 8
                            .Location = New Point(215, 123)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(16).ToString
                    End Select
                    .TextAlign = ContentAlignment.TopLeft
                ElseIf i <= 12 Then
                    .AutoSize = False
                    .Anchor = AnchorStyles.Right
                    '// Set x location for qty, price, discount, net price
                    '// Answer for the bug of uneven spacing for the last 3 rows of the output.
                    Dim locationx As Integer

                    If e.ProgressPercentage <= 2 And sql.ds.Tables("Frames").Rows.Count > 3 Then
                        locationx = FQty_LBL.Location.X + 17
                    Else
                        locationx = FQty_LBL.Location.X
                    End If

                    Select Case i
                        Case 9
                            .Size = New Size(33, 19)
                            .Location = New Point(locationx, 9)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(10).ToString
                        Case 10
                            .Size = New Size(134, 19)
                            .Location = New Point(locationx + 39, 9)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(11).ToString
                        Case 11
                            .Size = New Size(70, 19)
                            .Location = New Point(locationx + 182, 9)
                            Try
                                Select Case sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(12).ToString
                                    Case ""
                                        .Text = "0.00"
                                    Case Nothing
                                        .Text = "0.00"
                                    Case Else
                                        .Text = CDec(sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(12)).ToString("N2")
                                End Select
                            Catch ex As Exception

                            End Try
                        Case 12
                            .Size = New Size(109, 19)
                            .Location = New Point(locationx + 270, 9)
                            .Text = sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(13).ToString
                            Try
                                FSubTotal = FSubTotal + sql.ds.Tables("Frames").Rows(e.ProgressPercentage).Item(13)
                            Catch ex As Exception

                            End Try
                    End Select
                    .Top = 9
                    .TextAlign = ContentAlignment.TopRight
                End If
                .UseCustomBackColor = True
            End With
            '// Add generated controls to panel
            panel.Controls.Add(Labels)
        Next i
    End Sub

    Public Sub CreateDGVOutput()
        Try
            '// Create new datagridview
            Select Case ActionTaken
                Case "Search"
                    Select Case SearchItemFN
                        Case "Frames"
                        Case "Screens"
                            With CIF_Screen_DGV
                                .Dock = DockStyle.Fill
                                .Name = "ScreensDGV"
                                .DataSource = sql.ds
                                .DataMember = "Screens"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AllowUserToOrderColumns = True
                                .AllowUserToResizeColumns = True
                                .AllowUserToResizeRows = True
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                                .CausesValidation = True
                                .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
                                .PaletteMode = PaletteMode.Office2010Silver
                                .ColumnHeadersHeight = 30
                                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                                .ReadOnly = True
                                .ScrollBars = ScrollBars.Both
                                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                                .ShowCellErrors = True
                                .ShowCellToolTips = True
                                .ShowRowErrors = True
                                .StandardTab = False
                                .MultiSelect = True
                                With .StateCommon
                                    .Background.Color1 = Color.White
                                    .Background.Color2 = Color.Transparent
                                    .DataCell.Content.Color1 = Color.Black
                                    .DataCell.Content.Color2 = Color.Transparent
                                    .DataCell.Content.ColorAngle = -1
                                    .DataCell.Content.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                                    .HeaderColumn.Back.Color1 = Color.FromArgb(11, 19, 36)
                                    .HeaderColumn.Back.Color2 = Color.FromArgb(11, 19, 36)
                                    .HeaderColumn.Back.ColorAngle = -1
                                    .HeaderColumn.Back.ColorStyle = PaletteColorStyle.Dashed
                                    .HeaderColumn.Content.Color1 = Color.White
                                    .HeaderColumn.Content.Color2 = Color.Transparent
                                    .HeaderColumn.Content.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                                    .HeaderColumn.Content.Hint = PaletteTextHint.AntiAlias
                                End With
                            End With
                        Case "Glass"
                        Case "Films"
                        Case "Mechanisms"
                        Case "Add-Ons"
                        Case "Summary"
                    End Select
                Case "Add"
                Case "Update"
                Case "Delete"
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub CIF_TCTRL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CIF_TCTRL.SelectedIndexChanged
        Try
            Select Case CIF_TCTRL.SelectedIndex
                Case 0
                Case 1
                    Select Case ScreenEntry
                        Case True
                            ActionTaken = "Search"
                            SearchItemFN = "Screens"
                            GenerateOutput = False
                            StartWorker()
                        Case False
                    End Select
                Case 2
                    Select Case GlassEntry
                        Case True
                            ActionTaken = "Search"
                            SearchItemFN = "Glass"
                            GenerateOutput = False
                            StartWorker()
                        Case False
                    End Select
                Case 3
                Case 4
                Case 5
                Case 6
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ResetEntry()
        Dim Bool As Boolean
        Bool = True
        FrameEntry = Bool
        ScreenEntry = Bool
        GlassEntry = Bool
        FilmEntry = Bool
        MechEntry = Bool
        AddOnEntry = Bool
    End Sub

    Public Sub CreateGlassOutput(ByVal e As ProgressChangedEventArgs)

        '// Generate new panel
        Dim panel As New Panel
        With panel
            .Name = "GPanel_" & CStr(e.ProgressPercentage)
            .Width = 1127
            .Height = 165
            .Dock = DockStyle.Top
            .BorderStyle = 1
            .TabStop = False
        End With

        '// Add created panel to container
        GMid_PNL.Controls.Add(panel)

        '// Generate new item details
        Dim Lbl_Name As String

        For i As Integer = 0 To 8 - 1
            Lbl_Name = "GLbl_" & CStr(e.ProgressPercentage) & CStr(i)
            Dim Labels As New MetroLabel

            With Labels
                .Name = Lbl_Name
                .FontSize = MetroLabelSize.Medium
                .FontWeight = MetroLabelWeight.Regular
                If i <= 4 Then
                    .AutoSize = True
                    .TextAlign = ContentAlignment.TopLeft
                    Select Case i
                        Case 0
                            .Location = New Point(8, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(3).ToString
                        Case 1
                            .Location = New Point(53, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(4).ToString
                        Case 2
                            .Location = New Point(224, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(5).ToString
                        Case 3
                            .AutoSize = False
                            .Size = New Size(143, 19)
                            .TextAlign = ContentAlignment.TopRight
                            .Location = New Point(408, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(6).ToString
                        Case 4
                            .Location = New Point(567, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(1).ToString
                    End Select
                ElseIf i <= 7 Then
                    .AutoSize = False
                    .Anchor = AnchorStyles.Right
                    '// Set x location for qty, price, discount, net price
                    '// Answer for the bug of uneven spacing for the last 3 rows of the output.
                    Dim locationx As Integer

                    If e.ProgressPercentage <= 2 And sql.ds.Tables("Glass").Rows.Count > 3 Then
                        locationx = MetroLabel3.Location.X + 17
                    Else
                        locationx = MetroLabel3.Location.X
                    End If

                    Select Case i
                        Case 5
                            .Size = New Size(98, 19)
                            .Location = New Point(locationx, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(1).ToString
                        Case 6
                            .Size = New Size(33, 19)
                            .Location = New Point(locationx + 104, 10)
                            .Text = sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(1).ToString
                        Case 7
                            .Size = New Size(146, 19)
                            .Location = New Point(locationx + 143, 10)
                            Try
                                Select Case sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(7).ToString
                                    Case ""
                                        .Text = "0.00"
                                    Case Nothing
                                        .Text = "0.00"
                                    Case Else
                                        .Text = CDec(sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(1)).ToString("N2")
                                End Select

                                GSubTotal = GSubTotal + sql.ds.Tables("Glass").Rows(e.ProgressPercentage).Item(1)
                            Catch ex As Exception

                            End Try
                    End Select
                    .Top = 10
                    .TextAlign = ContentAlignment.TopRight
                End If
                .UseCustomBackColor = True
            End With
            '// Add generated controls to panel
            panel.Controls.Add(Labels)
        Next i
    End Sub
End Class