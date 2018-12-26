Public Class PD_SearchFRM
    Private Sub SearchBTN_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click
        is_CTD_bool = False
        is_SalesJobOrder_bool = False
        Project_Details.ProjectDetailsLBL.Text = "P R O J E C T   D E T A I L S"
        SearchStr = SearchTbox.Text
        If Replace(SearchTbox.Text, " ", "") = "" Then
            Project_Details.PD_BGW_TODO = "Onload"
        ElseIf Replace(SearchTbox.Text, " ", "") <> "" Then
            Project_Details.PD_BGW_TODO = "Search"
        End If
        'QUERY_INSTANCE = "Loading_using_SearchString"
        'QueryBUILD = QuerySearchHeadArrays(0) & QueryMidArrays(0) & QueryConditionArrays(0) & " " & QueryORDERArrays(0)
        Project_Details.Start_ProjectDetailsBGW()
        Project_Details.ProjectDetailsDGV.Focus()
        Project_Details.ProjectDetailsDGV.Select()
    End Sub

    Private Sub PD_SearchFRM_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        SearchTbox.Select()
        SearchTbox.Focus()
    End Sub

    Private Sub PD_SearchFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, SearchTbox.KeyDown, SearchBTN.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class