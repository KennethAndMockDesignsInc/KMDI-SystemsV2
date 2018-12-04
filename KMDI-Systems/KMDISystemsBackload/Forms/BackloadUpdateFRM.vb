Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BackloadUpdateFRM
    Public OtherDetails As String
    Public BackloadedBy As String
    Public StorageLocation As String
    Public ItemClass As String
    Public DateToDismantle As String
    Public ItemID As String

    Public ActionTaken As String
    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Dim sql As New BackloadUpdateClass

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        OtherDetails = Trim(OtherDetailsTBOX.Text)
        BackloadedBy = Trim(BackloadedByTBOX.Text)
        StorageLocation = Trim(StorageLocationTBOX.Text)
        ItemClass = Trim(ItemClassCBOX.Text)
        DateToDismantle = Trim(DateToDismantleTBOX.Text)
        ItemID = BackloadFRM.ItemID
        ActionTaken = "Update"
        StartWorker()
    End Sub

    Public BackloadUpdateInfoBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub BackloadUpdateFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler BackloadUpdateInfoBGW.DoWork, AddressOf BackloadUpdateInfoBGW_DoWork
        AddHandler BackloadUpdateInfoBGW.RunWorkerCompleted, AddressOf BackloadUpdateInfoBGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility

    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub StartWorker()
        If BackloadUpdateInfoBGW.IsBusy <> True Then
            BackloadUpdateInfoBGW.WorkerSupportsCancellation = True
            BackloadUpdateInfoBGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "System is currently updating its information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BackloadUpdateInfoBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            sql.UpdateBackloadRecord(QueryFunction,
                                     QueryBody,
                                     QueryCondition)
        Catch ex As Exception
            MsgBox(ex.ToString)
            BackloadUpdateInfoBGW.WorkerSupportsCancellation = True
            BackloadUpdateInfoBGW.CancelAsync()
        End Try

        If BackloadUpdateInfoBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
            Case "Add"
            Case "Update"
                QueryFunction = "Update"
                QueryBody = " [BACKLOADS] set [Other Details] = '" & OtherDetails & "'," &
                                 "[Backloaded By] = '" & BackloadedBy & "'," &
                                 "[Storage Location] = '" & StorageLocation & "'," &
                                 "[Class] = '" & ItemClass & "'," &
                                 "[Date to Dismantle] = '" & DateToDismantle & "'"
                QueryCondition = " Where autonum = '" & ItemID & "'"
            Case "Delete"
        End Select

    End Sub

    Private Sub BackloadUpdateInfoBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Me.Invoke(ChangePBVisibility, False)
        If e.Cancelled = True Then
            MetroFramework.MetroMessageBox.Show(Me, "An error occured during update of data. Please check your connection.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Hide()
        ElseIf e.Error IsNot Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "An error occured during update of data. Please check your connection.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Hide()
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "Update successful. Do you want to close this page?", "Update successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Hide()
            Else
                Me.Focus()
            End If
        End If
    End Sub

    Private Sub BackloadUpdateFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BackloadFRM.OtherDetails = ""
        BackloadFRM.BackloadedBy = ""
        BackloadFRM.StorageLocation = ""
        BackloadFRM.ItemClass = ""
        BackloadFRM.DateToDismantle = ""
        BackloadFRM.ItemID = ""
        Me.Hide()
    End Sub

    Private Sub ItemClassCBOX_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ItemClassCBOX.SelectionChangeCommitted
        ItemClass = ItemClassCBOX.Text
        Try
            Select Case ItemClass
                Case "Class A"
                    DateToDismantleTBOX.Text = ""
                    DateToDismantleTBOX.Visible = False
                    DateToDismantleDTP.Visible = False
                Case "Class B"
                    DateToDismantleTBOX.Text = ""
                    DateToDismantleTBOX.Visible = False
                    DateToDismantleDTP.Visible = False
                Case "Class C"
                    Select Case BackloadFRM.DateToDismantle
                        Case "01/01/1900"
                            DateToDismantleDTP.Value = Date.Today
                            DateToDismantleDTP.Visible = True
                            DateToDismantleTBOX.Visible = True
                            DateToDismantleTBOX.Text = DateToDismantleDTP.Value
                        Case Else
                            DateToDismantleDTP.Value = BackloadFRM.DateToDismantle
                            DateToDismantleDTP.Visible = True
                            DateToDismantleTBOX.Visible = True
                            DateToDismantleTBOX.Text = DateToDismantleDTP.Value
                    End Select
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BackloadUpdateFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, BackloadsLBL.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            BackloadFRM.Focus()
        End If
    End Sub
End Class