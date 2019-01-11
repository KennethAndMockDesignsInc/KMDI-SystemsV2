Imports System.ComponentModel
Imports System.IO
Imports System.Net
Public Class MKTNG_Inventory2
    Public MktngInventory_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngInv_TODO As String

    Public Sub Start_MktngInventoryBGW()
        If MktngInventory_BGW.IsBusy <> True Then
            'MktngInventoryDGV.Enabled = False
            LoadingPB.Visible = True
            MktngInventory_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub MKTNG_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MktngInventory_BGW.WorkerSupportsCancellation = True
            MktngInventory_BGW.WorkerReportsProgress = True
            AddHandler MktngInventory_BGW.DoWork, AddressOf MktngInventory_BGW_DoWork
            AddHandler MktngInventory_BGW.RunWorkerCompleted, AddressOf MktngInventory_BGW_RunWorkerCompleted
            MktngInv_TODO = "Onload"
            Start_MktngInventoryBGW()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub
    Private Sub MktngInventory_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MktngInv_TODO
                Case "Onload"
                    Mktng_QUERY_INSTANCE = "Loading_using_SearchString"
                    Mktng_Query_Select_STP("", "MKTNG_stp_Inv_Search")
            End Select
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub
    Private Sub MktngInventory_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                '' otherwise it completed normally
                If sql_Err_no = -2 Then
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect" & vbCrLf & "Cancel to Exit",
                                                       "Request Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    If result = DialogResult.OK Then
                        RESET()
                        Start_MktngInventoryBGW()
                        Exit Sub
                    ElseIf result = DialogResult.Cancel Then
                        RESET()
                        Dispose()
                        Exit Sub
                    End If
                ElseIf sql_Err_no = 1232 Or sql_Err_no = 121 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf sql_Err_no = 19 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (sql_Err_no = "" Or sql_Err_no = Nothing) AndAlso
                       (sql_Err_msg = "" Or sql_Err_msg = Nothing) Then
                    If sql_Transaction_result = "Committed" Then
                        For Each row In sqlBindingSource
                            PictureBox1.ImageLocation = row("ITEM_PICTURE").ToString
                            Label1.Text = row("DESCRIPTION") & vbCrLf &
                                              row("BRAND") & vbCrLf &
                                              row("COLOR") & vbCrLf &
                                              row("QUANTITY") & vbCrLf
                        Next
                    End If
                Else
                    Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                    Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           "SQL Transaction Error Number: " & sql_Err_no & vbCrLf &
                                           "SQL Transaction Error Message: " & sql_Err_msg & vbCrLf &
                                           "Trace: " & sql_Err_StackTrace & vbCrLf)
                    Log_File.Close()
                    MetroFramework.MetroMessageBox.Show(Me, "Transaction failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            RESET()

            LoadingPB.Visible = False
            'MktngInventoryDGV.Focus()
            'MktngInventoryDGV.Select()

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    'Private Sub MktngInventoryDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MktngInventoryDGV.RowPostPaint
    '    rowpostpaint(sender, e)
    'End Sub

    'Private Sub MktngInventoryDGV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MktngInventoryDGV.ColumnHeaderMouseClick
    '    If e.Button = MouseButtons.Right Then
    '        MktngInv_Cmenu.Show()
    '        MktngInv_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
    '    End If
    'End Sub

    'Private Sub ColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnToolStripMenuItem.Click
    '    Try
    '        OpenedByFormName = Me
    '        DGVStrGlobal = "MktngInventoryDGV"
    '        Dim frm As Form = ColumnVisibility
    '        Select Case frm.Visible
    '            Case True
    '                frm.BringToFront()
    '            Case False
    '                frm.Show()
    '                frm.BringToFront()
    '        End Select
    '        Enabled = False
    '    Catch ex As Exception
    '        MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
    '                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
    '        Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
    '                                   "Error Message: " & ex.Message & vbCrLf &
    '                                   "Trace: " & ex.StackTrace & vbCrLf)
    '        Log_File.Close()
    '    End Try
    'End Sub
End Class