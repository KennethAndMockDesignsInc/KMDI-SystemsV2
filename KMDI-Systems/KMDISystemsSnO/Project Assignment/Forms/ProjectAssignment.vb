Public Class ProjectAssignment

    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangeVisibility As PBVisibilityDelegate


    Public Delegate Sub ArchDesignPBVisibilityDelegate(ByVal ArchDesignVisibility As Boolean)
    Dim ArchDesignChangeVisibility As ArchDesignPBVisibilityDelegate

    Dim BGWReported As Boolean = True   'Flag to check progress report completed or not
    Public SearchPATboxString As String = ""
    Public SearchADTboxString As String = ""

    Sub StartLoadProjAssignDGV_BGW()
        If LoadProjAssignDGV_BGW.IsBusy <> True Then
            ProjAssignDGV.Columns.Clear()
            ProjAssignDGV.DataSource = Nothing
            ProjAssignDGV.DataMember = Nothing
            LoadProjAssignDGV_BGW.RunWorkerAsync()
        End If
    End Sub
    Sub StartLoadArchDesignDGV_BGW()
        If LoadArchDesignDGV_BGW.IsBusy <> True Then
            ArchDesignDGV.Columns.Clear()
            ArchDesignDGV.DataSource = Nothing
            ArchDesignDGV.DataMember = Nothing
            LoadArchDesignDGV_BGW.RunWorkerAsync()
        End If
    End Sub

    Public Sub ArchLoadingPbox_LBL_VISIBILITY(ByVal ArchDesignVisibility As Boolean)
        ArchLoadingPbox.Enabled = ArchDesignVisibility
        ArchLoadingPbox.Visible = ArchDesignVisibility
        ArchLoadingLBL.Visible = ArchDesignVisibility
    End Sub

    Public Sub LoadingPBOX_LBL_VISIBILITY(ByVal Visibility As Boolean)
        LoadingPBOX.Enabled = Visibility
        LoadingPBOX.Visible = Visibility
        LoadingLBL.Visible = Visibility
    End Sub

    Private Sub ProjectAssignment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        KMDI_MainFRM.Enabled = True
    End Sub

    Private Sub ProjectAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 600

        '' call this method to start your asynchronous Task.
        ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
        StartLoadProjAssignDGV_BGW()

        ArchDesignChangeVisibility = AddressOf ArchLoadingPbox_LBL_VISIBILITY
        StartLoadArchDesignDGV_BGW()
    End Sub

    Public ColumnToInvi As Integer = 0
    Private Sub LoadProjAssignDGV_BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadProjAssignDGV_BGW.DoWork
        Me.Invoke(ChangeVisibility, True)

        Try
            SearchORLoadProjAssignDGV(SearchPATboxString)
            For ColumnToInvi = -1 To sqlDataSet.Tables("PROJ_ASSIGN").Columns.Count - 5
                If LoadProjAssignDGV_BGW.CancellationPending Then
                    'LoadProjAssignDGV_BGW.ReportProgress(ColumnToInvi)
                    e.Cancel = True
                Else
                    While Not BGWReported
                        Application.DoEvents()
                    End While

                    'Add some sleep to simulate a long running operation
                    Threading.Thread.Sleep(10)

                    BGWReported = False
                End If
                LoadProjAssignDGV_BGW.ReportProgress(ColumnToInvi)
            Next
        Catch ex As Exception
            LoadProjAssignDGV_BGW.CancelAsync()
            MsgBox(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try

        If LoadProjAssignDGV_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadArchDesignDGV_BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadArchDesignDGV_BGW.DoWork
        Me.Invoke(ArchDesignChangeVisibility, True)
        Try
            SearchORLoadArchDesignDGV(SearchADTboxString)
            If LoadArchDesignDGV_BGW.CancellationPending Then
                e.Cancel = True
            End If
        Catch ex As Exception
            LoadArchDesignDGV_BGW.CancelAsync()
            MsgBox(ex.ToString)
        Finally
            archsqlConnection.Close()
        End Try
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
                    .Visible = True
                End With

                Me.Invoke(ChangeVisibility, False)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadArchDesignDGV_BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadArchDesignDGV_BGW.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                ArchLoadingPbox.Enabled = False
                LoadingLBL.Text = "Error Occured"
            ElseIf e.Cancelled Then
                '' otherwise if it was cancelled
                ArchLoadingPbox.Enabled = False
                ArchLoadingLBL.Text = "An error occured"
            Else
                '' otherwise it completed normally

                With ArchDesignDGV
                    .DataSource = archsqlBindingSource
                    .Columns(0).Visible = False
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .Visible = True
                End With

                Me.Invoke(ArchDesignChangeVisibility, False)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProjAssignDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ProjAssignDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub LoadProjAssignDGV_BGW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadProjAssignDGV_BGW.ProgressChanged
        Try
            If ProjAssignDGV.DataSource Is Nothing Then
                ProjAssignDGV.DataSource = sqlBindingSource
            End If

            ProjAssignDGV.Columns(ColumnToInvi).Visible = False
            BGWReported = True
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProjectAssignment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If LoadProjAssignDGV_BGW.IsBusy Or LoadArchDesignDGV_BGW.IsBusy Then
            If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?" & vbCrLf & "Current Operation will be cancelled!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                LoadProjAssignDGV_BGW.CancelAsync()
                LoadArchDesignDGV_BGW.CancelAsync()
                BGWReported = True
            Else
                e.Cancel = True
            End If
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub SearchPATbox_ButtonClick(sender As Object, e As EventArgs) Handles SearchPATbox.ButtonClick
        ProjAssignDGV.Visible = False
        ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
        StartLoadProjAssignDGV_BGW()
    End Sub

    Private Sub SearchPATbox_TextChanged(sender As Object, e As EventArgs) Handles SearchPATbox.TextChanged
        SearchPATboxString = SearchPATbox.Text
    End Sub

    Private Sub SearchPATbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchPATbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProjAssignDGV.Visible = False
            ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
            StartLoadProjAssignDGV_BGW()
        End If
    End Sub

    Private Sub SearchArch_TextChanged(sender As Object, e As EventArgs) Handles SearchArch.TextChanged
        SearchADTboxString = SearchArch.Text
    End Sub

    Private Sub ArchDesignDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ArchDesignDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub
End Class