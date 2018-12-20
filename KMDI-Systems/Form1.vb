﻿Imports System.Data.SqlClient
Public Class Form1
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
        Using sqlcon As New SqlConnection(sqlcnstr)
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
        Using sqlcon As New SqlConnection(sqlcnstr)
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class