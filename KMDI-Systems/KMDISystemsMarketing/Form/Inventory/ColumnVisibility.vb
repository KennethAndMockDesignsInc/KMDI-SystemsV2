Imports System.ComponentModel
Imports ComponentFactory.Krypton.Toolkit
Public Class ColumnVisibility
    Public ColumnVisibility_BGW As BackgroundWorker = New BackgroundWorker
    Dim columnChkToolTip As New MetroFramework.Components.MetroToolTip
    Dim DGVName As New KryptonDataGridView
    Public Sub Start_MktngInventoryBGW()
        If ColumnVisibility_BGW.IsBusy <> True Then
            FLP_ColumnInvi.Controls.Clear()
            LoadingPB.Visible = True
            ColumnVisibility_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub CreateMetroChkBoxes()
        For Each Obj In OpenedByFormName.Controls
            If Obj Is ObjContainingDGV Then
                For Each dgv In Obj.Controls
                    If dgv.Name = DGVStrGlobal Then
                        DGVName = dgv
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        MKTNG_Inventory.Enabled = True
        MKTNG_Inventory.BringToFront()
        Hide()
    End Sub

    Private Sub ColumnVisibility_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub columnChks_CheckedChanged(sender As Object, e As EventArgs)
        For Each Obj In OpenedByFormName.Controls
            If Obj Is ObjContainingDGV Then
                For Each dgv In Obj.Controls
                    If dgv.Name = DGVStrGlobal Then
                        dgv.Columns(sender.Name).Visible = sender.Checked
                        'DGVName = dgv
                    End If
                Next
            End If
        Next
        'For Each ctrl In OpenedByFormName.Controls
        '    If ctrl.Name = DGVStrGlobal Then
        '        ctrl.Columns(sender.Name).Visible = sender.Checked
        '    End If
        'Next
    End Sub

    Private Sub ColumnVisibility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ColumnVisibility_BGW.WorkerSupportsCancellation = True
            ColumnVisibility_BGW.WorkerReportsProgress = True
            AddHandler ColumnVisibility_BGW.DoWork, AddressOf ColumnVisibility_DoWork
            AddHandler ColumnVisibility_BGW.RunWorkerCompleted, AddressOf ColumnVisibility_RunWorkerCompleted
            Start_MktngInventoryBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub ColumnVisibility_DoWork(ByVal sender As Object, e As DoWorkEventArgs)
        Try
            CreateMetroChkBoxes()
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
    Private Sub ColumnVisibility_RunWorkerCompleted(ByVal sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                '' otherwise it completed normally
                For i = 0 To DGVName.ColumnCount - 1
                    Dim columnChks As New MetroFramework.Controls.MetroCheckBox
                    Dim DGVHeaderTxt As String = DGVName.Columns(i).HeaderText
                    Dim DGVVisibility As Boolean = DGVName.Columns(i).Visible
                    With columnChks
                        If (Not DGVHeaderTxt.Contains("STATUS")) And (Not DGVHeaderTxt.Contains("PICTURE")) And
                           (Not DGVHeaderTxt = "MIP_ID_REF") And (Not DGVHeaderTxt = "MIT_ID_REF") Then 'Or Not DGVHeaderTxt.Contains("PICTURE") = True Then
                            .Name = DGVHeaderTxt
                            .Text = DGVHeaderTxt
                            .Checked = DGVVisibility
                            columnChkToolTip.SetToolTip(columnChks, .Text)
                            AddHandler .CheckedChanged, AddressOf columnChks_CheckedChanged
                            FLP_ColumnInvi.Controls.Add(columnChks)
                        End If
                    End With
                Next

                LoadingPB.Visible = False
            End If
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
End Class