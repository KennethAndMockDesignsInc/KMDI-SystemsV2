Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BackloadFrameSash
    Dim sql As New BackloadUpdateClass

    Public JobOrderNoID As String
    Public TypeOfBackload As String

    Public ActionTaken As String
    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Dim ItemNo As String
    Dim KNo As String
    Dim Description As String
    Dim ItemWidth As String
    Dim ItemHeight As String
    Dim ItemColor As String
    Dim BackloadedBy As String
    Dim StorageLocation As String
    Dim DBStatus As String
    Dim GNo As String

    Dim ReasonRecut As String
    Dim ReasonReplacement As String
    Dim ReasonSpare As String
    Dim ReasonSafeKeeping As String
    Dim ReasonOther As String
    Dim OtherDetails As String
    Dim ReasonforBackload As String
    Dim RequestStatus As String

    Public BackloadBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub BackloadFrameSash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler BackloadBGW.DoWork, AddressOf BackloadBGW_DoWork
        AddHandler BackloadBGW.RunWorkerCompleted, AddressOf BackloadBGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility

    End Sub
    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub LoadInitialSetUp()
        RefreshUI()
        ActionTaken = "Search"
        StartWorker()
    End Sub

    Public Sub StartWorker()
        If BackloadBGW.IsBusy <> True Then
            Select Case ActionTaken
                Case "Search"
                    BackloadFrameSashDGV.Columns.Clear()
                    BackloadFrameSashDGV.DataSource = Nothing
                    BackloadFrameSashDGV.DataMember = Nothing

                Case "Add"
                    ItemNo = ItemNoTBOX.Text
                    KNo = KNoTBOX.Text
                    Description = DescriptionTBOX.Text
                    ItemWidth = WidthTBOX.Text
                    ItemHeight = HeightTBOX.Text
                    ItemColor = ProfileColorTBOX.Text
                    ReasonforBackload = Trim(ReasonRecut + " " + ReasonReplacement + " " + ReasonSpare + " " + ReasonSafeKeeping + " " + ReasonOther)
                    OtherDetails = Trim(OtherDetailsTBOX.Text)

                    DBStatus = "Active"

                Case "Update"
                Case "Delete"

            End Select

            BackloadBGW.WorkerSupportsCancellation = True
            BackloadBGW.RunWorkerAsync()
        Else
            Select Case ActionTaken
                Case "Search"
                    MetroFramework.MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Add"
                    MetroFramework.MetroMessageBox.Show(Me, "System is adding information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Update"
                Case "Delete"
            End Select

        End If
    End Sub

    Private Sub BackloadBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            sql.Backloads(QueryFunction,
                          QueryBody,
                          QueryCondition,
                          ActionTaken,
                          TypeOfBackload)
        Catch ex As Exception
            MsgBox(ex.ToString)
            BackloadBGW.WorkerSupportsCancellation = True
            BackloadBGW.CancelAsync()
        End Try

        If BackloadBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                Select Case TypeOfBackload
                    Case "Frame/Sash"
                        QueryFunction = "Select "
                        QueryBody = " [JOB_ORDER_NO]
                                     ,[KMDI_NO] as [K#]
                                     ,[ITEM_NO] as [Item No.]
                                     ,[WIDTH] as [Width]
                                     ,[HEIGHT] as [Height]
                                     ,[COLOR] as [Profile Color]
                                     ,[DESCRIPTION] as [Description]
                                    From [KMDI_FABRICATION_TB]"
                        QueryCondition = " Where [JOB_ORDER_NO] = '" & JobOrderNoID & "' And
                                   DATE_DELIVERED <> ''"

                    Case "Screen"
                        QueryFunction = "Select "
                        QueryBody = " [JOB_ORDER_NO]
                                     ,[KMDI_NO] as [K#]
                                     ,[ITEM_NO] as [Item No.]
                                     ,[WIDTH] as [Width]
                                     ,[HEIGHT] as [Height]
                                     ,[COLOR] as [Color]
                                     ,[DESCRIPTION] as [Description]
                                    From [KMDI_SCREENFAB_TB]"
                        QueryCondition = " Where [JOB_ORDER_NO] = '" & JobOrderNoID & "' And
                                   DATE_DELIVERED <> ''"

                    Case "Glass"
                        QueryFunction = "Select "
                        QueryBody = " [JOB_ORDER_NO]
                                     ,[KMDI_NO] as [K#]
                                     ,[G_NO] as [G#]
                                     ,[ITEM_NO] as [Item No.]
                                     ,[WIDTH] as [Width]
                                     ,[HEIGHT] as [Height]
                                     ,[GLASS_SPECS] as [Description]
                                    From [KMDI_GLASSFAB_TB]"
                        QueryCondition = " Where [JOB_ORDER_NO] = '" & JobOrderNoID & "' And
                                   DATE_DELIVERED <> ''"

                    Case "Installation Material"
                        QueryFunction = "Select "
                        QueryBody = " [PROJECT_LABEL]
                                     ,[FULLADD]
                                    From [ADDENDUM_TO_CONTRACT_TB]"
                        QueryCondition = " Where [JOB_ORDER_NO] = '" & JobOrderNoID & "'"
                End Select

            Case "Add"
                QueryFunction = "Insert into "
                QueryBody = " BACKLOADS ([JO#],
                                        [Item No.],
                                        [K#],
                                        [Description],
                                        [Width],
                                        [Height],
                                        [Color],
                                        [Item Type],
                                        [Reason],
                                        [Other Details],
                                        [Requested By Identifier],
                                        [Date Requested],
                                        [Backloaded By],
                                        [Storage Location],
                                        [DB Status],
                                        [G#])                                                   
                                 VALUES ('" & JobOrderNoID & "'," &
                                         "'" & ItemNo & "'," &
                                         "'" & KNo & "'," &
                                         "'" & Description & "'," &
                                         "'" & ItemWidth & "'," &
                                         "'" & ItemHeight & "'," &
                                         "'" & ItemColor & "'," &
                                         "'" & TypeOfBackload & "'," &
                                         "'" & ReasonforBackload & "'," &
                                         "'" & ReasonOther & "'," &
                                         "'" & KMDISystemsGlobalModule.AccountAutonum & "'," &
                                         "'" & Now.ToString & "', " &
                                         "'" & BackloadedBy & "', " &
                                         "'" & StorageLocation & "', " &
                                         "'" & DBStatus & "', " &
                                         "'" & GNo & "')"
                QueryCondition = ""
            Case "Update"
            Case "Delete"
        End Select


    End Sub

    Private Sub BackloadBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)

            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        MetroFramework.MetroMessageBox.Show(Me, "Error has been found this page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Hide()
                    Case "Add"
                        RefreshUI()
                        MetroFramework.MetroMessageBox.Show(Me, "Error during saving has occured.", "Backload item was not saved.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Hide()
                    Case "Update"
                    Case "Delete"
                End Select

            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        MetroFramework.MetroMessageBox.Show(Me, "Error has been found this page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Hide()
                    Case "Add"
                        RefreshUI()
                        MetroFramework.MetroMessageBox.Show(Me, "Error during saving has occured.", "Backload item was not saved.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Hide()
                    Case "Update"
                    Case "Delete"
                End Select
            Else
                Select Case ActionTaken
                    Case "Search"
                        Try
                            If Read.HasRows = True Then
                                Grid_Display()
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "This contract does not contain items to backload. Please select other contract.", "No items to backload.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Hide()
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                        End Try

                    Case "Add"
                        Me.Invoke(ChangePBVisibility, False)
                        LoadInitialSetUp()
                        If MetroFramework.MetroMessageBox.Show(Me, "Backload entry successful. Do you want to close this page?", "Backload item has been saved.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Update"
                    Case "Delete"
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub Grid_Display()
        Select Case TypeOfBackload
            Case "Frame/Sash"
                With BackloadFrameSashDGV
                    .DataSource = sql.ds
                    .DataMember = "Frame"
                    .Select()
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                    .Columns("JOB_ORDER_NO").Visible = False
                    .Columns("K#").Frozen = True
                End With

            Case "Screen"
                With BackloadFrameSashDGV
                    .DataSource = sql.ds
                    .DataMember = "Screen"
                    .Select()
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                    .Columns("JOB_ORDER_NO").Visible = False
                    .Columns("K#").Frozen = True
                End With

            Case "Glass"
                With BackloadFrameSashDGV
                    .DataSource = sql.ds
                    .DataMember = "Glass"
                    .Select()
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                    .Columns("JOB_ORDER_NO").Visible = False
                    .Columns("K#").Frozen = True
                End With

            Case "Installation Material"
        End Select
    End Sub

    Private Sub BackloadFrameSashDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles BackloadFrameSashDGV.RowPostPaint
        sql.RowPostPaintBackloadUpdate(sender, e)
    End Sub

    Private Sub BackloadFrameSashDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BackloadFrameSashDGV.CellMouseClick
        Try
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                If e.Button = MouseButtons.Left Then
                    Select Case TypeOfBackload
                        Case "Frame/Sash"
                            ItemNoTBOX.Text = BackloadFrameSashDGV.Item("Item No.", e.RowIndex).Value.ToString
                            KNoTBOX.Text = BackloadFrameSashDGV.Item("K#", e.RowIndex).Value.ToString
                            DescriptionTBOX.Text = BackloadFrameSashDGV.Item("Description", e.RowIndex).Value.ToString
                            WidthTBOX.Text = BackloadFrameSashDGV.Item("Width", e.RowIndex).Value.ToString
                            HeightTBOX.Text = BackloadFrameSashDGV.Item("Height", e.RowIndex).Value.ToString
                            ProfileColorTBOX.Text = BackloadFrameSashDGV.Item("Profile Color", e.RowIndex).Value.ToString
                            GNo = ""
                        Case "Screen"
                            ItemNoTBOX.Text = BackloadFrameSashDGV.Item("Item No.", e.RowIndex).Value.ToString
                            KNoTBOX.Text = BackloadFrameSashDGV.Item("K#", e.RowIndex).Value.ToString
                            DescriptionTBOX.Text = BackloadFrameSashDGV.Item("Description", e.RowIndex).Value.ToString
                            WidthTBOX.Text = BackloadFrameSashDGV.Item("Width", e.RowIndex).Value.ToString
                            HeightTBOX.Text = BackloadFrameSashDGV.Item("Height", e.RowIndex).Value.ToString
                            ProfileColorTBOX.Text = BackloadFrameSashDGV.Item("Color", e.RowIndex).Value.ToString
                            GNo = ""
                        Case "Glass"
                            ItemNoTBOX.Text = BackloadFrameSashDGV.Item("Item No.", e.RowIndex).Value.ToString
                            KNoTBOX.Text = BackloadFrameSashDGV.Item("K#", e.RowIndex).Value.ToString
                            DescriptionTBOX.Text = BackloadFrameSashDGV.Item("Description", e.RowIndex).Value.ToString
                            WidthTBOX.Text = BackloadFrameSashDGV.Item("Width", e.RowIndex).Value.ToString
                            HeightTBOX.Text = BackloadFrameSashDGV.Item("Height", e.RowIndex).Value.ToString
                            GNo = BackloadFrameSashDGV.Item("G#", e.RowIndex).Value.ToString

                        Case "Installation Material"
                            GNo = ""
                    End Select

                    UseTboxStyle()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("BackloadFrameSashDGV")
        End Try
    End Sub

    Private Sub AddUpdateBTN_Click(sender As Object, e As EventArgs) Handles AddUpdateBTN.Click
        ActionTaken = "Add"
        StartWorker()
    End Sub

    Private Sub RecutCBX_CheckedChanged(sender As Object, e As EventArgs) Handles RecutCBX.CheckedChanged
        If RecutCBX.Checked = True Then
            ReasonRecut = RecutCBX.Text
        ElseIf RecutCBX.Checked = False Then
            ReasonRecut = ""
        End If
    End Sub

    Private Sub ReplacementCBX_CheckedChanged(sender As Object, e As EventArgs) Handles ReplacementCBX.CheckedChanged
        If ReplacementCBX.Checked = True Then
            ReasonReplacement = ReplacementCBX.Text
        ElseIf ReplacementCBX.Checked = False Then
            ReasonReplacement = ""
        End If
    End Sub

    Private Sub SpareCBX_CheckedChanged(sender As Object, e As EventArgs) Handles SpareCBX.CheckedChanged
        If SpareCBX.Checked = True Then
            ReasonSpare = SpareCBX.Text
        ElseIf SpareCBX.Checked = False Then
            ReasonSpare = ""
        End If
    End Sub

    Private Sub SafeKeepingCBX_CheckedChanged(sender As Object, e As EventArgs) Handles SafeKeepingCBX.CheckedChanged
        If SafeKeepingCBX.Checked = True Then
            ReasonSafeKeeping = SafeKeepingCBX.Text
        ElseIf SafeKeepingCBX.Checked = False Then
            ReasonSafeKeeping = ""
        End If
    End Sub

    Private Sub OthersCBX_CheckedChanged(sender As Object, e As EventArgs) Handles OthersCBX.CheckedChanged
        If OthersCBX.Checked = True Then
            ReasonOther = OthersCBX.Text
        ElseIf OthersCBX.Checked = False Then
            ReasonOther = ""
        End If
    End Sub

    Public Sub UseTboxStyle()
        ItemNoTBOX.UseStyleColors = True
        ItemNoTBOX.Style = MetroFramework.MetroColorStyle.Blue
        KNoTBOX.UseStyleColors = True
        KNoTBOX.Style = MetroFramework.MetroColorStyle.Blue
        DescriptionTBOX.UseStyleColors = True
        DescriptionTBOX.Style = MetroFramework.MetroColorStyle.Blue
        WidthTBOX.UseStyleColors = True
        WidthTBOX.Style = MetroFramework.MetroColorStyle.Blue
        HeightTBOX.UseStyleColors = True
        HeightTBOX.Style = MetroFramework.MetroColorStyle.Blue
        ProfileColorTBOX.UseStyleColors = True
        ProfileColorTBOX.Style = MetroFramework.MetroColorStyle.Blue
    End Sub

    Private Sub RefreshBTN_Click(sender As Object, e As EventArgs) Handles RefreshBTN.Click
        RefreshUI()
    End Sub

    Public Sub RefreshUI()
        ItemNoTBOX.Clear()
        KNoTBOX.Clear()
        DescriptionTBOX.Clear()
        WidthTBOX.Clear()
        HeightTBOX.Clear()
        ProfileColorTBOX.Clear()

        RecutCBX.Checked = False
        ReplacementCBX.Checked = False
        SpareCBX.Checked = False
        SafeKeepingCBX.Checked = False
        OthersCBX.Checked = False
        OtherDetailsTBOX.Clear()

        ItemNoTBOX.UseStyleColors = False
        KNoTBOX.UseStyleColors = False
        DescriptionTBOX.UseStyleColors = False
        WidthTBOX.UseStyleColors = False
        HeightTBOX.UseStyleColors = False
        ProfileColorTBOX.UseStyleColors = False
    End Sub

    Private Sub BackloadFrameSash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
        ContractRecordsFRM.Focus()
    End Sub
End Class