Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BackloadRequestFRM
    Dim sql As New KMDISystemsBackloadRequestClass


    Public JO As String
    Public ProjectLabel As String
    Dim SelectedIndexBackload As String = "0"

    Dim ForBackloadSide As String

    Public ReasonforBackload As String

    Public Autonum As String
    Public JONo As String
    Public ItemNo As String
    Public Kno As String
    Public ItemDescription As String
    Public Reason As String
    Public OtherDetails As String
    Public RequestedBy As String
    Public RequestedByIdentifier As String
    Public DateRequested As String
    Public RequestStatus As String
    Public ItemType As String

    Dim ReasonRecut As String
    Dim ReasonReplacement As String
    Dim ReasonSpare As String
    Dim ReasonSafeKeeping As String
    Dim ReasonOthers As String
    Dim ReasonOtherDetails As String

    Public BackloadRequestBGW As BackgroundWorker = New BackgroundWorker
    Public DatabaseBackloadRequestBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub BackloadRequestFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleLBL.Text = "Request for backload for " & ProjectLabel & " with JO#" & JO
        AddHandler BackloadRequestBGW.DoWork, AddressOf BackloadRequest_DoWork
        AddHandler BackloadRequestBGW.RunWorkerCompleted, AddressOf BackloadRequestBGW_RunWorkerCompleted
        AddHandler DatabaseBackloadRequestBGW.DoWork, AddressOf DatabaseBackloadRequestBGW_DoWork
        AddHandler DatabaseBackloadRequestBGW.RunWorkerCompleted, AddressOf DatabaseBackloadRequestDGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility

        RequestedBy = nickname
        RequestedByIdentifier = AccountAutonum
        DateRequested = Now.ToString

        StartWorker()
    End Sub

    Public Sub DatabaseStartWorker()
        If DatabaseBackloadRequestBGW.IsBusy <> True Then
            DatabaseBackloadRequestBGW.WorkerSupportsCancellation = True
            DatabaseBackloadRequestBGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Database is updating information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DatabaseBackloadRequestBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)

        Try
            sql.RequestBackload(JONo,
                                ItemNo,
                                Kno,
                                ItemDescription,
                                Reason,
                                OtherDetails,
                                RequestedBy,
                                RequestedByIdentifier,
                                DateRequested,
                                RequestStatus,
                                ItemType)
            MessageBox.Show("Nagquerry")
        Catch ex As Exception
            MsgBox(ex.ToString)
            DatabaseBackloadRequestBGW.WorkerSupportsCancellation = True
            DatabaseBackloadRequestBGW.CancelAsync()
        End Try

        If DatabaseBackloadRequestBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DatabaseBackloadRequestDGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)

        If e.Cancelled = True Then
            Me.Invoke(ChangePBVisibility, False)
            MetroFramework.MetroMessageBox.Show(Me, "An error has occured during insertion of data into the database. Please retry insertion.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf e.Error IsNot Nothing Then
            Me.Invoke(ChangePBVisibility, False)
            MetroFramework.MetroMessageBox.Show(Me, "An error has occured during insertion of data into the database. Please retry insertion.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try

                StartWorker()

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub

    Public Sub StartWorker()
        If BackloadRequestBGW.IsBusy <> True Then
            SelectItemForBackloadDGV.Columns.Clear()
            SelectItemForBackloadDGV.DataSource = Nothing
            BackloadRequestBGW.WorkerSupportsCancellation = True
            BackloadRequestBGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BackloadRequest_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)

        Try
            Select Case ForBackloadSide
                Case "True"
                    Select Case SelectedIndexBackload
                        Case "0"
                            sql.BackloadRequestLoadFrameSash(JO)
                            'sql.CheckRequestedBackloads()
                        Case "1"
                            sql.BackloadRequestLoadScreen(JO)
                            'sql.CheckRequestedBackloads()
                    End Select
                Case "False"

            End Select


        Catch ex As Exception
            MsgBox(ex.ToString)
            BackloadRequestBGW.WorkerSupportsCancellation = True
            BackloadRequestBGW.CancelAsync()
        End Try

        If BackloadRequestBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BackloadRequestBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)

        If e.Cancelled = True Then
            Me.Invoke(ChangePBVisibility, False)
            MetroFramework.MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf e.Error IsNot Nothing Then
            Me.Invoke(ChangePBVisibility, False)
            MetroFramework.MetroMessageBox.Show(Me, "Please button or press the Enter key then press F5 to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                If Read.HasRows = True Then
                    Select Case SelectedIndexBackload
                        Case "0"
                            With SelectItemForBackloadDGV
                                .DataSource = sql.ds
                                .DataMember = "KMDI_FABRICATION_TB"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("JOB_ORDER_NO").Visible = False
                                .Columns("STATUS").Visible = False
                            End With

                            'With RequestedItemsDGV
                            '    .DataSource = sql.ds2
                            '    .DataMember = "BACKLOADS"
                            '    .DefaultCellStyle.BackColor = Color.White
                            '    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            '    .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                            'End With

                        Case "1"
                            With SelectItemForBackloadDGV
                                .DataSource = sql.ds
                                .DataMember = "KMDI_SCREENFAB_TB"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("JOB_ORDER_NO").Visible = False
                                .Columns("STATUS").Visible = False
                            End With

                            'With RequestedItemsDGV
                            '    .DataSource = sql.ds2
                            '    .DataMember = "BACKLOADS"
                            '    .DefaultCellStyle.BackColor = Color.White
                            '    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            '    .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                            'End With
                    End Select

                    Me.Invoke(ChangePBVisibility, False)

                Else
                    Me.Invoke(ChangePBVisibility, False)
                    'MetroFramework.MetroMessageBox.Show(Me, "No items where delivered with this JO in the database.", "No items found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Private Sub ForBackloadTCTRL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ForBackloadTCTRL.SelectedIndexChanged
        ForBackloadTCTRLSelectionTAB()
    End Sub

    Private Sub RequestForBackloadTCTRL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RequestForBackloadTCTRL.SelectedIndexChanged
        RequestForBackloadTCTRLSelectionTAB()
    End Sub

    Public Sub ForBackloadTCTRLSelectionTAB()
        Select Case ForBackloadTCTRL.SelectedIndex
            Case 0
                RequestForBackloadTCTRL.SelectedIndex = 0
                SelectedIndexBackload = "0"
                StartWorker()
            Case 1
                RequestForBackloadTCTRL.SelectedIndex = 1
                SelectedIndexBackload = "1"
                StartWorker()
        End Select
    End Sub

    Public Sub RequestForBackloadTCTRLSelectionTAB()
        Select Case RequestForBackloadTCTRL.SelectedIndex
            Case 0
                ForBackloadTCTRL.SelectedIndex = 0
                SelectedIndexBackload = "0"
            Case 1
                ForBackloadTCTRL.SelectedIndex = 1
                SelectedIndexBackload = "1"
        End Select
    End Sub

    Private Sub SelectItemForBackloadDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles SelectItemForBackloadDGV.RowPostPaint
        sql.RowPostPaintBackloadRequest(sender, e)
    End Sub

    Private Sub FrameScreenBTN_Click(sender As Object, e As EventArgs) Handles FrameScreenBTN.Click

        MessageBox.Show(ForBackloadSide)
        Select Case ForBackloadSide
            Case "True"
                If OthersCBX.Checked = True And OtherDetailsTBOX.Text = Nothing Then
                    MetroFramework.MetroMessageBox.Show(Me, "Please specify other details.", "No input found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf OthersCBX.Checked = False And OtherDetailsTBOX.Text <> Nothing Then
                    MetroFramework.MetroMessageBox.Show(Me, "Please check others checkbox.", "Invalid input found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    MessageBox.Show("Nandito na sya")
                    ReasonforBackload = Trim(ReasonRecut + " " + ReasonReplacement + " " + ReasonSpare + " " + ReasonSafeKeeping + " " + ReasonOthers)
                    OtherDetails = Trim(OtherDetailsTBOX.Text)
                    RequestStatus = "Pending"
                    Select Case SelectedIndexBackload
                        Case "0"
                            ItemType = FrameScreenBTN.Text
                        Case "1"
                            ItemType = FrameScreenBTN.Text
                    End Select
                    DatabaseStartWorker()
                End If
            Case "False"
                MessageBox.Show("Nasa False")
        End Select
    End Sub

    Private Sub RecutCBX_CheckedChanged(sender As Object, e As EventArgs) Handles RecutCBX.CheckedChanged
        If RecutCBX.Checked = True Then
            ReasonRecut = RecutCBX.Text
        Else
            ReasonRecut = ""
        End If
    End Sub

    Private Sub ReplacementCBX_CheckedChanged(sender As Object, e As EventArgs) Handles ReplacementCBX.CheckedChanged
        If ReplacementCBX.Checked = True Then
            ReasonReplacement = ReplacementCBX.Text
        Else
            ReasonReplacement = ""
        End If
    End Sub

    Private Sub SpareCBX_CheckedChanged(sender As Object, e As EventArgs) Handles SpareCBX.CheckedChanged
        If SpareCBX.Checked = True Then
            ReasonSpare = SpareCBX.Text
        Else
            ReasonSpare = ""
        End If
    End Sub

    Private Sub SafeKeepingCBX_CheckedChanged(sender As Object, e As EventArgs) Handles SafeKeepingCBX.CheckedChanged
        If SafeKeepingCBX.Checked = True Then
            ReasonSafeKeeping = SafeKeepingCBX.Text
        Else
            ReasonSafeKeeping = ""
        End If
    End Sub

    Private Sub OthersCBX_CheckedChanged(sender As Object, e As EventArgs) Handles OthersCBX.CheckedChanged
        If OthersCBX.Checked = True Then
            ReasonOthers = OthersCBX.Text
        Else
            ReasonOthers = ""
        End If
    End Sub

    Private Sub ForBackloadTCTRL_Enter(sender As Object, e As EventArgs) Handles ForBackloadTCTRL.Enter
        ForBackloadSide = "True"
    End Sub

    Private Sub RequestForBackloadTCTRL_Enter(sender As Object, e As EventArgs) Handles RequestForBackloadTCTRL.Enter
        ForBackloadSide = "False"
    End Sub

    Private Sub SelectItemForBackloadDGV_Enter(sender As Object, e As EventArgs) Handles SelectItemForBackloadDGV.Enter
        ForBackloadSide = "True"
        ForBackloadSideOrRequestForBackloadSide()
    End Sub

    Private Sub RequestedItemsDGV_Enter(sender As Object, e As EventArgs) Handles RequestedItemsDGV.Enter
        ForBackloadSide = "False"
        ForBackloadSideOrRequestForBackloadSide()
    End Sub

    Public Sub ForBackloadSideOrRequestForBackloadSide()
        Select Case ForBackloadSide
            Case "True"
                FrameScreenBTN.Visible = True
                FrameScreenToTheRightPBOX.Visible = True
                FrameScreenToTheLeftPBOX.Visible = False
                InstallationMaterialBTN.Visible = True
                InstallationMaterialToTheRightPBOX.Visible = True
                InstallationMaterialToTheLeftPBOX.Visible = False

                Select Case SelectedIndexBackload
                    Case "0"
                        FrameScreenBTN.Text = "FRAME / SASH"
                        GlassBTN.Visible = True
                        GlassToTheRightPBOX.Visible = True
                        GlassToTheLeftPBOX.Visible = False
                    Case "1"
                        FrameScreenBTN.Text = "SCREEN"
                        GlassBTN.Visible = False
                        GlassToTheRightPBOX.Visible = False
                        GlassToTheLeftPBOX.Visible = False
                End Select
            Case "False"
                FrameScreenBTN.Visible = True
                FrameScreenToTheRightPBOX.Visible = False
                FrameScreenToTheLeftPBOX.Visible = True
                InstallationMaterialBTN.Visible = True
                InstallationMaterialToTheRightPBOX.Visible = False
                InstallationMaterialToTheLeftPBOX.Visible = True

                Select Case SelectedIndexBackload
                    Case "0"
                        FrameScreenBTN.Text = "FRAME / SASH"
                        GlassBTN.Visible = True
                        GlassToTheRightPBOX.Visible = False
                        GlassToTheLeftPBOX.Visible = True
                    Case "1"
                        FrameScreenBTN.Text = "SCREEN"
                        GlassBTN.Visible = False
                        GlassToTheRightPBOX.Visible = False
                        GlassToTheLeftPBOX.Visible = False
                End Select
        End Select

    End Sub

    Private Sub SelectItemForBackloadDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SelectItemForBackloadDGV.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            JONo = JO
            ItemNo = SelectItemForBackloadDGV.Item("Item No.", e.RowIndex).Value.ToString
            Kno = SelectItemForBackloadDGV.Item("K#", e.RowIndex).Value.ToString
            ItemDescription = SelectItemForBackloadDGV.Item("Item Description", e.RowIndex).Value.ToString
            MessageBox.Show(JONo + " " + ItemNo + " " + Kno + " " + ItemDescription)
        End If
    End Sub

    Private Sub InstallationMaterialBTN_Click(sender As Object, e As EventArgs) Handles InstallationMaterialBTN.Click

    End Sub

    Private Sub GlassBTN_Click(sender As Object, e As EventArgs) Handles GlassBTN.Click

    End Sub
End Class