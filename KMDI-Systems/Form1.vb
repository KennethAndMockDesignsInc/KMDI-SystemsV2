Public Class Form1
    Dim ADDENDUM_BGW_TODO As String

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Select Case ADDENDUM_BGW_TODO
                Case "Onload"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = QuerySearchHeadArrays(5) & QueryMidArrays(4) & QueryConditionArrays(1) & " AND [CTD].JOB_ORDER_NO = [CTD].PARENTJONO"
                    Query_Select(PD_ID)
                Case "AEIC_LBL_LOAD"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = "SELECT AE_TBL.FULLNAME FROM (" & QuerySearchHeadArrays(4) &
                        QueryMidArrays(3) & " ) AS AE_TBL
                    JOIN A_NEW_PROJECT_DETAILS [PD]
                    ON	AE_TBL.PD_ID_REF = PD.PD_ID
                    WHERE PD_ID = @EqualSearch AND AE_TBL.[AE_STATUS] = 1 AND PD.[PD_STATUS] = 1"
                    Query_Select(PD_ID)
                Case "CompanyName"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = QuerySearchHeadArrays(6) & QueryMidArrays(5) & QueryConditionArrays(1) & " AND OWN.[CLIENT_STATUS] = 'Current Owner'"
                    Query_Select(PD_ID)
                Case "TechnicalPartners"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = "SELECT	TP.OFFICENAME,
		                                TP.NAME,
		                                TP.POSITION,
		                                TP.MOBILENO,
		                                TP_NATURE.NATURE 
                              FROM    ( SELECT * " & QueryMidArrays(7) & ") AS [TP] " &
                                  QueryMidArrays(6) & " ON TP_NATURE.TP_ID_REF = TP.TP_ID " &
                                  QueryConditionArrays(1) & " AND CD.JOB_ORDER_NO = CD.PARENTJONO AND STATUS_AVAILABILITY = 1 AND EMP_STATUS = 1 AND COMP_STATUS = 1 AND PD_STATUS = 1"
                    Query_Select(PD_ID)
                Case "QuoteRefNo"
                    QueryBUILD = "SELECT WD_ID, QUOTE_NO FROM [A_NEW_WINDOOR_DETAILS]"
                    Query_Select("")
                Case "QuoteRefNo_Sel"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = "SELECT * FROM [A_NEW_WINDOOR_DETAILS] WHERE WD_ID = @EqualSearch AND [WD_STATUS] = 1"
                    'Query_Select(WD_ID)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

            End If

            'PD_Addendum_Pnl.Visible = True
            LoadingPbox.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
        LoadingPbox.Visible = True
    End Sub
End Class