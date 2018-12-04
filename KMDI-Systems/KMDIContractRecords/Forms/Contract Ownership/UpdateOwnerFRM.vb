Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class UpdateOwnerFRM
    Dim sql As New KMDIContractRecordsClass

    Public NODProjectLabel As String
    Public NODOwnersName As String
    Public NODCompanyName As String
    Public NODClientsName As String
    Public NODFLA As String
    Public NODABT As String
    Public NODABTSelected As String

    Public PODProjectLabel As String
    Public PODOwnersName As String
    Public PODCompanyName As String
    Public PODClientsName As String
    Public PODFLA As String
    Public PODABT As String
    Public PrevOwnerFormat As String

    Public ActionTaken As String
    Public JobOrderNoID As String
    Public SearchItemFN As String

    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Public FormattingFailed As Boolean

    Public UpdateOwnerBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub UpdateOwnerFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler UpdateOwnerBGW.DoWork, AddressOf UpdateOwnerBGW_DoWork
        AddHandler UpdateOwnerBGW.RunWorkerCompleted, AddressOf UpdateOwnerBGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility
    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub RefreshUI()
        NODProjectLabelTBOX.Clear()
        NODOwnersNameTBOX.Clear()
        NODCompanyNameTBOX.Clear()
        NODClientsNameTBOX.Clear()

        NODFLACliNRBTN.Checked = False
        NODFLACompNRBTN.Checked = False
        NODABTCliNRBTN.Checked = False
        NODABTCompNRBTN.Checked = False

        PODProjectLabelTBOX.Clear()
        PODOwnersNameTBOX.Clear()
        PODCompanyNameTBOX.Clear()
        PODClientsNameTBOX.Clear()

        PODFLACliNRBTN.Checked = False
        PODFLACompNRBTN.Checked = False
        PODABTCliNRBTN.Checked = False
        PODABTCompNRBTN.Checked = False


        ActionTaken = "Search"
    End Sub

    Public Sub LoadInitialSetUp()
        RefreshUI()
        ActionTaken = "Search"
        StartWorker()
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                QueryFunction = "Select"
                QueryBody = " [PROJECT_LABEL]
                              ,[CLIENTS_NAME]
                              ,[OWNERS_NAME]
                              ,[COMPANY_NAME]
                              ,[FILE_LABEL_AS]
                              ,[ADDRESS_BILLING]
                              From [ADDENDUM_TO_CONTRACT_TB]"
                QueryCondition = " Where [PARENTJONO] = '" & JobOrderNoID & "' and
                                                 [PARENTJONO] = [JOB_ORDER_NO]"
            Case "Add"
            Case "Update"
                QueryFunction = "Update "
                QueryBody = " [ADDENDUM_TO_CONTRACT_TB] set [PROJECT_LABEL] = '" & NODProjectLabel & "'," &
                                                 "[CLIENTS_NAME] = '" & NODClientsName & "'," &
                                                 "[OWNERS_NAME] = '" & NODOwnersName & "'," &
                                                 "[COMPANY_NAME] = '" & NODCompanyName & "'," &
                                                 "[FILE_LABEL_AS] = '" & NODFLA & "'," &
                                                 "[ADDRESS_BILLING] = '" & NODABT & "'," &
                                                 "[ADDRESS_TO] = '" & NODABTSelected & "'," &
                                                 "[PREV_OWNER] = '" & PrevOwnerFormat & "'"
                QueryCondition = " Where [PARENTJONO] = '" & JobOrderNoID & "'"
            Case "Delete"
        End Select
    End Sub

    Public Sub StartWorker()
        If UpdateOwnerBGW.IsBusy <> True Then
            UpdateOwnerBGW.WorkerSupportsCancellation = True
            UpdateOwnerBGW.RunWorkerAsync()
        Else
            Select Case ActionTaken
                Case "Search"
                    MetroFramework.MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Add"
                Case "Update"
                    MetroFramework.MetroMessageBox.Show(Me, "System is updating its information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Delete"
            End Select
        End If
    End Sub

    Private Sub UpdateOwnerBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            'sql.ProjectInfo(QueryFunction,
            '                QueryBody,
            '                QueryCondition,
            '                ActionTaken,
            '                SearchItemFN)

        Catch ex As Exception
            MsgBox(ex.ToString)
            UpdateOwnerBGW.WorkerSupportsCancellation = True
            UpdateOwnerBGW.CancelAsync()
        End Try

        If UpdateOwnerBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub UpdateOwnerBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Add"
                    Case "Update"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error while updating information to the database. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Delete"
                End Select
            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Add"
                    Case "Update"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error while updating information to the database. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Delete"
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            If Read.HasRows = True Then
                                UI_Display()
                            Else
                                If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                    Me.Hide()
                                End If
                            End If
                        Case "Add"
                        Case "Update"
                            If MetroFramework.MetroMessageBox.Show(Me, "Information has been succesfully updated in the database. Do you want to close this page?", "Information has been saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Me.Hide()
                            End If
                            ContractRecordsFRM.StartWorker()
                        Case "Delete"
                    End Select
                Catch ex As Exception
                    Me.TopMost = False
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            Me.TopMost = False
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub UI_Display()
        Select Case ActionTaken
            Case "Search"
                With Read
                    .Read()
                    PODProjectLabelTBOX.Text = Replace(.Item("PROJECT_LABEL").ToString, "`", "'")
                    PODOwnersNameTBOX.Text = Replace(.Item("OWNERS_NAME").ToString, "`", "'")
                    PODClientsNameTBOX.Text = Replace(.Item("CLIENTS_NAME").ToString, "`", "'")
                    PODCompanyNameTBOX.Text = Replace(.Item("COMPANY_NAME").ToString, "`", "'")
                    PODFLA = .Item("FILE_LABEL_AS").ToString
                    PODABT = .Item("ADDRESS_BILLING").ToString
                    .Close()
                End With

                Select Case PODFLA
                    Case "Proj/Client`s Name"
                        NODFLA = "Proj/Client`s Name"
                        NODFLACliNRBTN.Checked = True
                        PODFLACliNRBTN.Checked = True
                    Case "Company Name"
                        NODFLA = "Company Name"
                        NODFLACompNRBTN.Checked = True
                        PODFLACompNRBTN.Checked = True
                End Select

                Select Case PODABT
                    Case "Proj/Client`s Name"
                        PODABT = "Proj/Client`s Name"
                        NODABTCliNRBTN.Checked = True
                        PODABTCliNRBTN.Checked = True
                    Case "Company Name"
                        PODABT = "Company Name"
                        NODABTCompNRBTN.Checked = True
                        PODABTCompNRBTN.Checked = True
                End Select

            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Public Sub Format()
        Try
            NODProjectLabel = Trim(Replace(NODProjectLabelTBOX.Text, "'", "`"))
            NODOwnersName = Trim(Replace(NODOwnersNameTBOX.Text, "'", "`"))
            NODCompanyName = Trim(Replace(NODCompanyNameTBOX.Text, "'", "`"))
            NODClientsName = Trim(Replace(NODClientsNameTBOX.Text, "'", "`"))

            PODProjectLabel = Trim(Replace(PODProjectLabelTBOX.Text, "'", "`"))
            PODOwnersName = Trim(Replace(PODOwnersNameTBOX.Text, "'", "`"))
            PODCompanyName = Trim(Replace(PODCompanyNameTBOX.Text, "'", "`"))


            Select Case NODFLACliNRBTN.Checked
                Case True
                    NODFLA = "Proj/Client`s Name"
                    NODProjectLabel = NODClientsName
            End Select

            Select Case NODFLACompNRBTN.Checked
                Case True
                    NODFLA = "Company Name"
                    NODProjectLabel = NODCompanyName
            End Select

            Select Case NODABTCliNRBTN.Checked
                Case True
                    NODABT = "Proj/Client`s Name"
                    NODABTSelected = NODClientsName
            End Select

            Select Case NODABTCompNRBTN.Checked
                Case True
                    NODABT = "Company Name"
                    NODABTSelected = NODCompanyName
            End Select

            Select Case PODOwnersName
                Case ""
                    Select Case PODCompanyName
                        Case ""
                            MetroFramework.MetroMessageBox.Show(Me, "System has detected a null information.", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            FormattingFailed = True
                            Exit Sub
                        Case Else
                            PrevOwnerFormat = PODCompanyName
                    End Select
                Case Else
                    Select Case PODCompanyName
                        Case ""
                            PrevOwnerFormat = PODOwnersName
                        Case Else
                            PrevOwnerFormat = PODOwnersName & "(" & PODCompanyName & ")"
                    End Select
            End Select

            Select Case NODProjectLabel
                Case ""
                    MetroFramework.MetroMessageBox.Show(Me, "project label System has detected a null information.", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormattingFailed = True
                    Exit Sub
                    Select Case NODOwnersName
                        Case ""
                            Select Case NODCompanyName
                                Case ""
                                    MetroFramework.MetroMessageBox.Show(Me, "Company name System has detected a null information.", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    FormattingFailed = True
                                    Exit Sub
                            End Select
                    End Select
            End Select

            Select Case NODFLA
                Case ""
                    MetroFramework.MetroMessageBox.Show(Me, "nodfla System has detected a null information.", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormattingFailed = True
                    Exit Sub
            End Select

            Select Case NODABT
                Case ""
                    MetroFramework.MetroMessageBox.Show(Me, "nodabt System has detected a null information.", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormattingFailed = True
                    Exit Sub
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        Try
            FormattingFailed = False
            ActionTaken = "Update"
            Format()
            If FormattingFailed = True Then
                Exit Sub
            Else
                StartWorker()
            End If
        Catch ex As Exception
            Me.TopMost = False
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshBTN_Click(sender As Object, e As EventArgs) Handles RefreshBTN.Click
        RefreshUI()
        StartWorker()
    End Sub

    Private Sub UpdateOwnerFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            ContractRecordsFRM.Focus()
        End If
    End Sub

    Private Sub UpdateOwnerFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
        ContractRecordsFRM.Focus()
    End Sub

    Private Sub NODFLACliNRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles NODFLACliNRBTN.CheckedChanged
        Select Case NODFLACliNRBTN.Checked
            Case True
                NODProjectLabelTBOX.Text = NODClientsNameTBOX.Text
        End Select
    End Sub

    Private Sub NODFLACompNRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles NODFLACompNRBTN.CheckedChanged
        Select Case NODFLACompNRBTN.Checked
            Case True
                NODProjectLabelTBOX.Text = NODCompanyNameTBOX.Text
        End Select
    End Sub

    Private Sub NODABTCliNRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles NODABTCliNRBTN.CheckedChanged
        Select Case NODABTCliNRBTN.Checked
            Case True
                NODABT = "Proj/Client`s Name"
                NODABTSelected = NODClientsName
        End Select
    End Sub

    Private Sub NODABTCompNRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles NODABTCompNRBTN.CheckedChanged
        Select Case NODABTCompNRBTN.Checked
            Case True
                NODABT = "Company Name"
                NODABTSelected = NODCompanyName
        End Select
    End Sub
End Class