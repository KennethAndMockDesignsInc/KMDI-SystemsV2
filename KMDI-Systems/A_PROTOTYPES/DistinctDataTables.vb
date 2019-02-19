Imports System.Data.SqlClient
Public Class DistinctDataTables
    Dim sqlconnString = "Data Source = 121.58.229.248,49107; Network Library=DBMSSOCN;Initial Catalog='KMDIDATA';User ID=kmdiadmin;Password=kmdiadmin;"

    Public Sub Generate_PWorkload_Query_Select_STP(ByVal SearchString As String,
                                                   ByVal StoredProcedureName As String,
                                                   Optional WillUseReader As Boolean = False)

        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        sqlDataSet.Clear()
        sqlBindingSource.Clear()

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@EqualSearch", SearchString)

                transaction.Commit()
                sql_Transaction_result = "Committed"

                Select Case WillUseReader
                    Case False
                        sqlDataAdapter.SelectCommand = sqlCommand
                        sqlDataAdapter.Fill(sqlDataSet, "Generate_PWorkload")
                        sqlBindingSource.DataSource = sqlDataSet
                        sqlBindingSource.DataMember = "Generate_PWorkload"
                End Select
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Generate_PWorkload_Query_Select_STP(TextBox1.Text, "TE_stp_InsightReport_MERGE")
            DataGridView1.DataSource = sqlBindingSource
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim JO_list As New List(Of String)
    Dim counter As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim distinctCounts As IEnumerable(Of String) = sqlDataSet.Tables("Generate_PWorkload").AsEnumerable().
        'Select(Function(row) row.Field(Of String)("SUB_JO")).
        'Distinct()
        Try
            'If sampleDT.Rows.Count <> 0 And sampleDT.Columns.Count <> 0 Then
            '    sampleDT.Clear()
            'End If
            'If sampleDT.Columns.Count = 0 Then
            '    sampleDT.Columns.Add("SUB_JO")
            'End If
            For i = 0 To sqlDataSet.Tables("Generate_PWorkload").Rows.Count - 1
                Dim Sub_Jo As String = sqlDataSet.Tables("Generate_PWorkload").Rows(i).Item("SUB_JO")
                If Not JO_list.Contains(Sub_Jo) Then
                    JO_list.Add(Sub_Jo)
                End If
                'If sampleDT.Rows.Count = 0 Then
                '    sampleDT.Rows.Add(Sub_Jo)
                'ElseIf sampleDT.Rows.Count <> 0 Then
                '    counter += 1
                '    For j = 0 To sampleDT.Rows.Count - 1
                '        If Sub_Jo <> sampleDT.Rows(j).Item(0) Then
                '            Console.WriteLine("counter:" & counter)
                '            Console.WriteLine("Before:" & sampleDT.Rows.Count)
                '            sampleDT.Rows.Add(Sub_Jo)
                '            Console.WriteLine("After:" & sampleDT.Rows.Count)
                '            Exit For
                '        End If
                '    Next
                'End If
            Next
            For Each str As String In JO_list
                Console.WriteLine(str)
            Next
            'DataGridView1.DataSource = sampleDT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            DataGridView1.Columns.Clear()
            DataGridView1.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class