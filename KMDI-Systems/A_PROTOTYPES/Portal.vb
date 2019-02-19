Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit
Public Class Portal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Query = "
Begin Transaction

	Begin Try
	INSERT INTO [A_NEW_A_SAMPLE_TBL] ([SAMPLE_COL1])
	                         VALUES  (@SAMPLE_COL1)

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage,
            'Commited' AS [Transaction]
            --Commit Transaction
            ROLLBACK TRANSACTION
	End Try

	Begin Catch
	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage,
            'Rollback' AS [Transaction]
			ROLLBACK TRANSACTION
	End Catch"
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(TextBox1.Text, sqlcon)
                sqlCommand.Parameters.AddWithValue("@SAMPLE_COL1", TextBox2.Text)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    If (read.Item("ErrorNumber").ToString = "" Or read.Item("ErrorNumber").ToString = Nothing) AndAlso
                       (read.Item("ErrorMessage").ToString = "" Or read.Item("ErrorMessage").ToString = Nothing) Then
                        If read.Item("Transaction").ToString = "Commited" Then
                            MsgBox("SUCCESS")
                        ElseIf read.Item("Transaction").ToString = "Rollback" Then
                            MsgBox("FAILED")
                        End If
                    Else
                        MsgBox("ErrorNumber: " & read.Item("ErrorNumber").ToString & vbCrLf &
                              "ErrorMessage: " & read.Item("ErrorMessage").ToString & vbCrLf)
                    End If
                    'If read.HasRows Then
                    '    MsgBox("FAILED")
                    '    MsgBox("ErrorNumber: " & read.Item("ErrorNumber").ToString & vbCrLf &
                    '           "ErrorMessage: " & read.Item("ErrorMessage").ToString & vbCrLf)
                    'Else
                    '    MsgBox("SUCCESS")
                    '    MsgBox("ErrorNumber: " & read.Item("ErrorNumber").ToString & vbCrLf &
                    '           "ErrorMessage: " & read.Item("ErrorMessage").ToString & vbCrLf)
                    'End If
                End Using
                'confirmQuery = sqlCommand.ExecuteNonQuery()
                '    If confirmQuery <> 0 Then
                '        MsgBox("SUCCESS")
                '    Else
                '        MsgBox("FAILED")
                '    End If
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim file As IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\LOGS.txt", True)
        file.WriteLine(vbCrLf & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & " Here is the first string.")
        file.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Contains(TextBox2.Text) Then
            MsgBox("Same")
        Else
            MsgBox("Not Same")
        End If
    End Sub
    'Private Sub ExecuteSqlTransaction(ByVal connectionString As String)
    '    Using connection As New SqlConnection(connectionString)
    '        connection.Open()

    '        Dim command As SqlCommand = connection.CreateCommand()
    '        Dim transaction As SqlTransaction

    '        ' Start a local transaction
    '        transaction = connection.BeginTransaction("SampleTransaction")

    '        ' Must assign both transaction object and connection
    '        ' to Command object for a pending local transaction.
    '        command.Connection = connection
    '        command.Transaction = transaction
    '        Dim list_int As New List(Of Integer)(New Integer() {1, 2, 3})
    '        Try
    '            For Each i_list_int As Integer In list_int
    '                command.Parameters.AddWithValue("@list_int" & i_list_int, i_list_int)
    '                command.CommandText = "Insert into [A_NEW_A_SAMPLE_TBL] ([SAMPLE_COL1]) VALUES (@list_int" & i_list_int & ")"
    '                command.ExecuteNonQuery()
    '                MsgBox("EXECUTE #" & i_list_int)
    '            Next
    '            'command.CommandText =
    '            '  "waitfor delay '00:00:02' Insert into [A_NEW_A_SAMPLE_TBL] ([SAMPLE_COL1]) VALUES ('asdasdd')"

    '            'command.ExecuteNonQuery()
    '            'MsgBox("EXECUTE #2")

    '            ' Attempt to commit the transaction.
    '            transaction.Commit()
    '            Console.WriteLine("Both records are written to database.")

    '        Catch ex As Exception
    '            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
    '            Console.WriteLine("  Message: {0}", ex.Message)

    '            ' Attempt to roll back the transaction.
    '            Try
    '                transaction.Rollback()

    '            Catch ex2 As Exception
    '                ' This catch block will handle any errors that may have occurred
    '                ' on the server that would cause the rollback to fail, such as
    '                ' a closed connection.
    '                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
    '                Console.WriteLine("  Message: {0}", ex2.Message)
    '            End Try
    '        End Try
    '    End Using
    'End Sub

    Public txt2 As String
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            INSERT_SAMPLE()
        Catch ex As SqlException
        'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
        If ex.Number = -2 Then
            MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BackgroundWorker1.CancelAsync()
        ElseIf ex.Number = 1232 Or ex.Number = 121 Then
            MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ex.Number = 19 Then
            MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 And ex.Number <> 121 Then
            MetroFramework.MetroMessageBox.Show(Me, "Transaction Failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine(vbCrLf & "Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "SQL Transaction Error Number: " & ex.Number & vbCrLf &
                                       "SQL Transaction Error Message: " & ex.Message)
            Log_File.Close()
        End If
        sql_Err_msg = ex.Message
        sql_Err_no = ex.Number
        Try
            transaction.Rollback()
            sql_Transaction_result = "Rollback"
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message)
        End Try
        'Catch ex2 As Exception
        '    MessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            If (sql_Err_no = "" Or sql_Err_no = Nothing) AndAlso
                       (sql_Err_msg = "" Or sql_Err_msg = Nothing) Then
                If sql_Transaction_result = "Committed" Then
                    'If UPDATE_ADDENDUM_QuoteRefNo_WD_ID_counter < arr_WD_ID.Count - 1 Then
                    '    ADDENDUM_BGW_TODO = "UPDATE_ADDENDUM_QuoteRefNo"
                    '    Start_PD_Addendum_BGW(False, True)
                    '    UPDATE_ADDENDUM_QuoteRefNo_WD_ID_counter += 1
                    'ElseIf UPDATE_ADDENDUM_QuoteRefNo_WD_ID_counter = arr_WD_ID.Count - 1 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Success", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'arr_WD_ID.Clear()
                    'UPDATE_ADDENDUM_QuoteRefNo_WD_ID_counter = 0
                    'PD_Addendum_Update_QuoteRefNo_counter = 0
                    'End If
                ElseIf sql_Transaction_result = "Rollback" Then
                    MetroFramework.MetroMessageBox.Show(Me, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Transaction failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                Log_File.WriteLine(vbCrLf & "Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                               "SQL Transaction Error Number: " & sql_Err_no & vbCrLf &
                               "SQL Transaction Error Message: " & sql_Err_msg & vbCrLf)
                Log_File.Close()
                sql_Err_msg = Nothing
                sql_Err_no = Nothing
                sql_Transaction_result = ""
            End If
            LoadingPboxRNP.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Dim list_int As New List(Of Integer)(New Integer() {1, 2, 3})
    Dim arr_sample As New List(Of Integer)(New Integer() {11, 22, 33})
    Public Sub INSERT_SAMPLE()
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction("SampleTransaction")
                sqlcmd.Connection = sqlcon
                sqlcmd.Transaction = transaction
                sqlcmd.CommandText = "SampleInsert_SAMPLE_TBL"
                sqlcmd.CommandType = CommandType.StoredProcedure

                sqlcmd.Parameters.AddWithValue("@SAMPLE_COL1", "asdasd")
                sqlcmd.ExecuteNonQuery()

                'sqlcmd.CommandText = "INSERT INTO A_NEW_A_SAMPLE_TBL ([SAMPLE_COL1]) VALUES (@SAMPLE_COL11)"
                'sqlcmd.Parameters.AddWithValue("@SAMPLE_COL11", "zxczxczxc")
                'sqlcmd.ExecuteNonQuery()

                'sqlcmd.CommandType = CommandType.StoredProcedure

                For Each arr_sample_int As Integer In arr_sample
                    sqlcmd.CommandText = "INSERT INTO A_NEW_A_SAMPLE_TBL ([SAMPLE_COL1]) VALUES (@SAMPLE_COL1" & arr_sample_int & ")"
                    sqlcmd.CommandType = CommandType.Text
                    sqlcmd.Parameters.AddWithValue("@SAMPLE_COL1" & arr_sample_int, arr_sample_int)
                    sqlcmd.ExecuteNonQuery()
                Next

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt2 = TextBox2.Text
        LoadingPboxRNP.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Project_Details.Show()
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        MetroFramework.MetroMessageBox.Show(Me, "Asterisk", "AbortRetryIgnore", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles MetroTextButton2.Click
        MetroFramework.MetroMessageBox.Show(Me, "Error", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub MetroTextButton3_Click(sender As Object, e As EventArgs) Handles MetroTextButton3.Click
        MetroFramework.MetroMessageBox.Show(Me, "Exclamation", "OKCancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub MetroTextButton4_Click(sender As Object, e As EventArgs) Handles MetroTextButton4.Click
        MetroFramework.MetroMessageBox.Show(Me, "Hand", "RetryCancel", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand)
    End Sub

    Private Sub MetroTextButton6_Click(sender As Object, e As EventArgs) Handles MetroTextButton6.Click
        MetroFramework.MetroMessageBox.Show(Me, "None", "YesNo", MessageBoxButtons.YesNo, MessageBoxIcon.None)
    End Sub

    Private Sub MetroTextButton7_Click(sender As Object, e As EventArgs) Handles MetroTextButton7.Click
        MetroFramework.MetroMessageBox.Show(Me, "Question", "YesNoCancel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
    End Sub

    Private Sub MetroTextButton8_Click(sender As Object, e As EventArgs) Handles MetroTextButton8.Click
        MetroFramework.MetroMessageBox.Show(Me, "Stop", " ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Private Sub MetroTextButton9_Click(sender As Object, e As EventArgs) Handles MetroTextButton9.Click
        MetroFramework.MetroMessageBox.Show(Me, "Warning", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub MetroTextButton5_Click(sender As Object, e As EventArgs) Handles MetroTextButton5.Click
        MetroFramework.MetroMessageBox.Show(Me, "Information", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            'Project_Details.Dispose()
            Dim a As Integer
            a /= 0
            MsgBox(a)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
        End Try
    End Sub
    Dim Inv_DGV As New KryptonDataGridView

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Controls.Clear()
        DGV_Properties(Inv_DGV, "Inv_DGV")
        Panel1.Controls.Add(Inv_DGV)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim inv_dgvCol As DataGridViewColumn
            Dim cell As DataGridViewCell = New DataGridViewTextBoxCell()
            inv_dgvCol = New DataGridViewColumn
            With inv_dgvCol
                .Name = "Text Column"
                .HeaderText = inv_dgvCol.Name
                .CellTemplate = cell
                .SortMode = DataGridViewColumnSortMode.Automatic
                .ValueType = GetType(String)
            End With
            Inv_DGV.Columns.Add(inv_dgvCol)
            inv_dgvCol = New DataGridViewColumn
            With inv_dgvCol
                .Name = "Date Column"
                .HeaderText = inv_dgvCol.Name
                .CellTemplate = cell
                .SortMode = DataGridViewColumnSortMode.Automatic
                .ValueType = GetType(Date)
                .DefaultCellStyle.Format = "MMM. dd, yyyy"
            End With
            Inv_DGV.Columns.Add(inv_dgvCol)
            inv_dgvCol = New DataGridViewColumn
            With inv_dgvCol
                .Name = "Decimal Column"
                .HeaderText = inv_dgvCol.Name
                .CellTemplate = cell
                .SortMode = DataGridViewColumnSortMode.Automatic
                .ValueType = GetType(Decimal)
                .DefaultCellStyle.Format = "N2"
            End With
            Inv_DGV.Columns.Add(inv_dgvCol)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            'Dim deyt As Date = #12/24/1997#
            'Dim deyt2 As Date = Convert.ToDateTime(TextBox1.Text)
            'Dim deci As Decimal = CDec(TextBox2.Text)
            Dim list_obj As New List(Of Object) '({"Sample", deyt2})
            list_obj.Add("Sample")
            list_obj.Add(Convert.ToDateTime(TextBox1.Text))
            list_obj.Add(Convert.ToDecimal(TextBox2.Text))
            'Dim list_str As New List(Of String)({"Sample", deyt2})
            'Dim arr_str As String() = list_str.ToArray
            'Dim arr_obj As Object() = list_obj.ToArray
            Inv_DGV.Rows.Add(list_obj.ToArray)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Class DGVRows

    End Class

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox(Inv_DGV.Columns("Date Column").GetType.ToString)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MHC_Prototype.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Transition_Prototype.Show()
        Me.Hide()
    End Sub
    Dim list As List(Of KeyValuePair(Of Integer, Integer)) =
            New List(Of KeyValuePair(Of Integer, Integer))
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        list.Add(New KeyValuePair(Of Integer, Integer)(TextBox1.Text, TextBox2.Text))
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ' Loop over pairs.
        For Each pair As KeyValuePair(Of Integer, Integer) In list
            ' Get key.
            Dim key As Integer = pair.Key
            ' Get value.
            Dim value As Integer = pair.Value
            ' Display.
            Console.WriteLine(key & vbCrLf & value)
        Next
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PieChart.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        DistinctDataTables.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        SecsToHours.Show()
    End Sub
End Class