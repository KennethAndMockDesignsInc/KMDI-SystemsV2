Imports System.Data.SqlClient
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports MetroFramework.Controls
Imports MetroFramework.Components
Imports MetroFramework

Module KMDISystemsGlobalModule
    Public TileAccessOfLoggedAccount As String
    Public AccountAutonum As String
    Public confirmQuery As Integer

    Public ContractCollumns As Boolean

    Public Query As String

    Public dt As New DataTable

    Public GlobalToolTip As New MetroToolTip

    Public sql_Err_no, sql_Err_msg, sql_Err_StackTrace, sql_Transaction_result As String
    Public sql_err_bool As Boolean = False

    Public Log_File As StreamWriter

    Public transaction As SqlTransaction
    Public QuestionPromptAnswer As Integer

    Public UnitNo As String
    Public Establishment As String
    Public HouseNo As String
    Public Street As String
    Public Village As String
    Public Brgy As String
    Public CityMunicipality As String
    Public Province As String
    Public Area As String
    Public FullAddress As String

    Public EngrSDreq = "|01", DelReciepts = "|02", DR = "|03", DrReports = "|04", EngrsItinerary = "|05", EngrSDsubm = "|06", 'Engineering
     addendum = "|07", SalesItinerary = "|08", SalesMoni = "|09", SUS = "|10", CallerInfo = "|11", Collection = "|12", ExtDMGs = "|13", CheckBalance = "|14", 'Sales and OP
     ProdSDreq = "|15", CuttList = "|16", StatsMoni = "|17", GlassSpecs = "|18", ProdSDSubm = "|19", ' Production
     ArchiFirm = "|20", Inventory = "|21", Request = "|22", 'Marketing
     WinDoor As String = "|25" ' Costing

    Public Sub RESET()
        sql_Err_msg = Nothing
        sql_Err_no = Nothing
        sql_Err_StackTrace = Nothing
        sql_Transaction_result = ""
    End Sub

    Public Sub DGV_Properties(ByVal DGV As KryptonDataGridView,
                              ByVal dgvName As String)
        With DGV
            .Name = dgvName
            .Dock = DockStyle.Fill
            .Select()
            .DefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AllowUserToOrderColumns = True
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            .CausesValidation = True
            .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
            .PaletteMode = PaletteMode.Office2010Silver
            .ColumnHeadersHeight = 30
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            With .GridStyles
                .Style = DataGridViewStyle.List
                .StyleColumn = DataGridViewStyle.List
                .StyleDataCells = DataGridViewStyle.List
                .StyleRow = DataGridViewStyle.List
            End With
            .HideOuterBorders = True
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
                .HeaderColumn.Border.Width = 0
                .HeaderColumn.Content.Color1 = Color.White
                .HeaderColumn.Content.Color2 = Color.Transparent
                .HeaderColumn.Content.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Content.Hint = PaletteTextHint.AntiAlias
            End With
        End With
    End Sub

    Public Sub RdBtn_Properties(CreationMode As String,
                                RdBtn As MetroRadioButton,
                                ItemName As String,
                                TagName As String,
                                Width As Integer,
                                Optional RowIndex As Integer = Nothing,
                                Optional ContextMenu As MetroContextMenu = Nothing,
                                Optional RdBtnSize As MetroCheckBoxSize = MetroCheckBoxSize.Tall,
                                Optional DisplayFocus_bool As Boolean = True)
        With RdBtn
            If CreationMode = "Dynamic" Then
                Dim SQL_STR As String = sqlDataSet.Tables("QUERY_DETAILS").Rows(RowIndex).Item(ItemName).ToString
                .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(RowIndex).Item(TagName).ToString
                .Name = SQL_STR & .Tag
                SQL_STR = Replace(SQL_STR, "&", "&&")
                .Text = SQL_STR
            ElseIf CreationMode = "Static" Then
                .Name = ItemName & TagName
                .Tag = TagName
                ItemName = Replace(ItemName, "&", "&&")
                .Text = ItemName
            End If
            .Width = Width
            .DisplayFocus = DisplayFocus_bool
            .ContextMenuStrip = ContextMenu
            .FontSize = RdBtnSize
            GlobalToolTip.SetToolTip(RdBtn, .Text)
        End With
    End Sub
    Public Sub Chkbox_Properties(CreationMode As String,
                                Chkbox As MetroCheckBox,
                                ItemName As String,
                                TagName As String,
                                Width As Integer,
                                Optional RowIndex As Integer = Nothing,
                                Optional ContextMenu As MetroContextMenu = Nothing,
                                Optional ChkboxSize As MetroCheckBoxSize = MetroCheckBoxSize.Tall,
                                Optional DisplayFocus_bool As Boolean = True)
        With Chkbox
            If CreationMode = "Dynamic" Then
                Dim SQL_STR As String = sqlDataSet.Tables("QUERY_DETAILS").Rows(RowIndex).Item(ItemName).ToString
                .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(RowIndex).Item(TagName).ToString
                .Name = SQL_STR & .Tag
                SQL_STR = Replace(SQL_STR, "&", "&&")
                .Text = SQL_STR
            ElseIf CreationMode = "Static" Then
                .Name = ItemName & TagName
                .Tag = TagName
                ItemName = Replace(ItemName, "&", "&&")
                .Text = ItemName
            End If
            .Width = Width
            .DisplayFocus = DisplayFocus_bool
            .ContextMenuStrip = ContextMenu
            .FontSize = ChkboxSize
            GlobalToolTip.SetToolTip(Chkbox, .Text)
        End With
    End Sub
    Public Sub KMDIPrompts(ByVal FormName As Form,
                           ByVal PromptMode As String,
                           Optional sql_Err_msg As String = "",
                           Optional sql_Err_StackTrace As String = "",
                           Optional sql_Err_no As Integer = Nothing,
                           Optional WillPrompt As Boolean = False,
                           Optional CustomPrompt As Boolean = False,
                           Optional PromptContent As String = Nothing)

        Dim PreErrorMsg As String = Nothing, PreErrorNo As String = Nothing

        Select Case PromptMode
            Case "DotNetError"
                PreErrorNo = "Error Number: "
                PreErrorMsg = "Error Message: "
            Case "SqlError"
                PreErrorNo = "SQL Transaction Error Number: "
                PreErrorMsg = "SQL Transaction Error Message: "
            Case "UserWarning"
                PreErrorNo = "Error Number: "
                PreErrorMsg = "Warning message: "
            Case "Failed"
                PreErrorNo = "Error Number: "
                PreErrorMsg = "Failed Message: "
        End Select

        Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
        Log_File.WriteLine("Logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           PreErrorNo & sql_Err_no & vbCrLf &
                                           PreErrorMsg & sql_Err_msg & vbCrLf &
                                           "Trace: " & sql_Err_StackTrace & vbCrLf)
        Log_File.Close()

        Select Case WillPrompt
            Case True
                Select Case PromptMode
                    Case "DotNetError"
                        Select Case CustomPrompt
                            Case True
                                MetroMessageBox.Show(FormName, PromptContent, "Error",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case False
                                MetroMessageBox.Show(FormName, "Please Refer to Error_Logs.txt", "Contact the Developers",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Select

                    Case "SqlError"
                        Select Case sql_Err_no
                            Case -2
                                MetroMessageBox.Show(FormName, " ", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Case 1232 Or 121
                                MetroMessageBox.Show(FormName, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case 19
                                MetroMessageBox.Show(FormName, "Server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case Else
                                MetroMessageBox.Show(FormName, "Transaction failed", "Contact the Developers",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Select
                    Case "UserWarning"
                        Select Case CustomPrompt
                            Case True
                                MetroMessageBox.Show(FormName, PromptContent, "Warning",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Case False
                                MetroMessageBox.Show(FormName, "Please Refer to Error_Logs.txt", "Contact the Developers",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    Case "Success"
                        MetroMessageBox.Show(FormName, " ", PromptMode, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case "Failed"
                        MetroMessageBox.Show(FormName, " ", PromptMode, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Case "Question"
                        QuestionPromptAnswer = MetroMessageBox.Show(FormName, sql_Err_msg, " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End Select
        End Select
    End Sub

    Public Sub rowpostpaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Public Sub AddressFormat(ByVal unitnoAF As String,
                             ByVal establishmentAF As String,
                             ByVal housenoAF As String,
                             ByVal streetAF As String,
                             ByVal villageAF As String,
                             ByVal brgyAF As String,
                             ByVal cityAF As String,
                             ByVal provinceAF As String)

        FullAddress = Nothing

        Select Case UnitNo
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = UnitNo
        End Select

        Select Case Establishment
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & Establishment
        End Select

        Select Case HouseNo
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & HouseNo
        End Select

        Select Case Street
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & Street
        End Select

        Select Case Village
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                FullAddress = FullAddress & " " & Village
                            Case Else
                                FullAddress = FullAddress & ", " & Village
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                FullAddress = FullAddress & " " & Village
                            Case Else
                                FullAddress = FullAddress & ", " & Village
                        End Select
                End Select
        End Select

        Select Case Brgy
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & " " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & ", " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & " " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & ", " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                        End Select
                End Select
        End Select

        Select Case CityMunicipality
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & " " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & " " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        Select Case Province
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & " " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & " " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        FullAddress = Trim(FullAddress)
        MsgBox(unitnoAF &
                             establishmentAF &
                             housenoAF &
                             streetAF &
                             villageAF &
                             brgyAF &
                             cityAF &
                             provinceAF)
        MsgBox("FullAddress: " & FullAddress)
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_READ_FOR_KMDI_MainFRM(ByVal UserAcctAutonum As String)
        Try
            sqlDataSet = New DataSet
            Dim tileAccessHere As String

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [TileAccess] as [Tile]
                       FROM [KMDI_ACCT_ACCESS_TB]
                     WHERE [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)
            Read = sqlCommand.ExecuteReader

            If Read.HasRows = True Then
                While Read.Read
                    tileAccessHere = Read.Item("Tile").ToString

                    If tileAccessHere <> "" Then
                        TileAccessOfLoggedAccount += "|" + tileAccessHere

                    End If

                End While

            ElseIf Read.HasRows = False Then
                TileAccessOfLoggedAccount = Nothing
            End If

            Read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

End Module
