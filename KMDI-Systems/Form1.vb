Imports System.Data.SqlClient
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
End Class