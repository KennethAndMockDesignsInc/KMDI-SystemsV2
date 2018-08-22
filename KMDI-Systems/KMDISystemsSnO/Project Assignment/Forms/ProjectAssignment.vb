Public Class ProjectAssignment

    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangeVisibility As PBVisibilityDelegate

    Sub StartLoadProjAssignDGV_BGW()
        If LoadProjAssignDGV_BGW.IsBusy <> True Then
            ProjAssignDGV.Columns.Clear()
            ProjAssignDGV.DataSource = Nothing
            ProjAssignDGV.DataMember = Nothing
            LoadProjAssignDGV_BGW.WorkerSupportsCancellation = True
            LoadProjAssignDGV_BGW.RunWorkerAsync()
        End If
    End Sub

    Public Sub LoadingPBOX_LBL_VISIBILITY(ByVal Visibility As Boolean)
        LoadingPBOX.Enabled = Visibility
        LoadingPBOX.Visible = Visibility
        LoadingLBL.Visible = Visibility
    End Sub

    Private Sub ProjectAssignment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub ProjectAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 600

        '' call this method to start your asynchronous Task.
        ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
        StartLoadProjAssignDGV_BGW()
    End Sub

    Private Sub LoadProjAssignDGV_BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadProjAssignDGV_BGW.DoWork
        Me.Invoke(ChangeVisibility, True)
        Try
            SearchORLoadProjAssignDGV()
        Catch ex As Exception
            MsgBox(ex.ToString)
            LoadProjAssignDGV_BGW.WorkerSupportsCancellation = True
            LoadProjAssignDGV_BGW.CancelAsync()
        End Try

        If LoadProjAssignDGV_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadProjAssignDGV_BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadProjAssignDGV_BGW.RunWorkerCompleted
        Try


            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                LoadingPBOX.Enabled = False
                LoadingLBL.Text = "Error Occured"
            ElseIf e.Cancelled Then
                '' otherwise if it was cancelled
                LoadingPBOX.Enabled = False
                LoadingLBL.Text = "An error occured"
            Else
                '' otherwise it completed normally

                With ProjAssignDGV
                    .DataSource = sqlBindingSource
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .Columns("PA_AUTONUMBER").Visible = False
                    .Columns("JOB_ORDER_NO_PARENT").Visible = False
                    .Columns("QUOTE_NO").Visible = False
                    .Columns("QUOTE_DATE").Visible = False
                    .Columns("CUST_REF_NO").Visible = False
                    .Columns("PROJECT_LABEL").Visible = False
                    .Columns("PROJECT_TYPE").Visible = False
                    .Columns("SOURCE").Visible = False
                    .Columns("REFFERED_BY").Visible = False
                    .Columns("CLIENTS_CONTACT_NO").Visible = False
                    .Columns("CLIENTS_CONTACT_NO_OFFICE").Visible = False
                    .Columns("CLIENTS_CONTACT_NO_MOBILE").Visible = False
                    .Columns("CLIENTS_EMAIL_ADD").Visible = False
                    .Columns("UNIT_NO").Visible = False
                    .Columns("ESTABLISHMENT").Visible = False
                    .Columns("HOUSE_NO").Visible = False
                    .Columns("STREET").Visible = False
                    .Columns("VILLAGE").Visible = False
                    .Columns("BARANGAY").Visible = False
                    .Columns("TOWN").Visible = False
                    .Columns("PROVINCE").Visible = False
                    .Columns("AREA").Visible = False
                    .Columns("PROJECT_STATUS").Visible = False
                    .Columns("PRESENTATION").Visible = False
                    .Columns("SITE_MEETINGS").Visible = False
                    .Columns("ARCHITECTURAL_DISCUSSIONS").Visible = False
                    .Columns("SUBMITTAL_REVISION_OF_QUOTES").Visible = False
                    .Columns("TRIAL_CLOSING").Visible = False
                    .Columns("CLOSING_NEGOTIATION").Visible = False
                    .Columns("CLOSED").Visible = False
                    .Columns("CLOSED_OPTION").Visible = False
                    .Columns("CLOSED_FULL_PARTIAL").Visible = False
                    .Columns("AE_ASSIGNED_CODE").Visible = False
                    .Columns("COMPETITORS").Visible = False
                    .Columns("PROFILE_FINISH").Visible = False
                    .Columns("PROJECT_CLASSIFICATION").Visible = False
                    .Columns("CONSTRUCTION_STAGE").Visible = False
                    .Columns("SITE_MEETING_SCHEDULE").Visible = False
                    .Columns("WIP").Visible = False
                End With

                Me.Invoke(ChangeVisibility, False)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProjAssignDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ProjAssignDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        LoadProjAssignDGV_BGW.CancelAsync()
    End Sub

End Class