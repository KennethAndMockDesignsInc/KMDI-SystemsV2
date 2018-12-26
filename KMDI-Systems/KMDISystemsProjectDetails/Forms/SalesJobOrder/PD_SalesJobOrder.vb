Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class PD_SalesJobOrder

    Dim ClientsName As String
    Public PD_SalesJobOrder_BGW As BackgroundWorker = New BackgroundWorker
    Dim QuoteRefNo_Populate_counter As Integer

    Sub Start_OnLoadBGW()
        If PD_SalesJobOrder_BGW.IsBusy <> True Then
            LoadingPbox.Visible = True
            SalesJobOrder_Pnl.Visible = False
            PD_SalesJobOrder_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Sub onformLoad()
        Reset_labels()
        BGW_Func_turn = "Onload"
        Start_OnLoadBGW()
    End Sub
    Private Sub PD_SalesJobOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PD_SalesJobOrder_BGW.WorkerSupportsCancellation = True
            PD_SalesJobOrder_BGW.WorkerReportsProgress = True
            AddHandler PD_SalesJobOrder_BGW.DoWork, AddressOf PD_SalesJobOrder_BGW_DoWork
            AddHandler PD_SalesJobOrder_BGW.RunWorkerCompleted, AddressOf PD_SalesJobOrder_BGW_RunWorkerCompleted
            onformLoad()
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = True
                EditJOContractAttachmentsToolStripMenuItem.Visible = False
                EditPertinentDetailsToolStripMenuItem.Visible = False
                SJO_CMenu.Show()
                SJO_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VatProfile_Cbox_TextChanged(sender As Object, e As EventArgs) Handles VatProfile_Cbox.TextChanged
        If VatProfile_Cbox.Text.Contains("Exclusive") Then
            VatPercent_Tbox.Visible = False
            VatPercent_Lbl.Visible = False
        ElseIf VatProfile_Cbox.Text.Contains("Inclusive") Then
            VatPercent_Tbox.Visible = True
            VatPercent_Lbl.Visible = True
            VatPercent_Tbox.Enabled = True
            If VatProfile_Cbox.Text.Contains("VAT Inclusive (30%)") Then
                VatPercent_Tbox.Enabled = False
                VatPercent_Tbox.Text = Val(12 * 0.3)
            ElseIf VatProfile_Cbox.Text.Contains("VAT Inclusive (40%)") Then
                VatPercent_Tbox.Enabled = False
                VatPercent_Tbox.Text = Val(12 * 0.4)
            ElseIf VatProfile_Cbox.Text.Contains("VAT Inclusive (50%)") Then
                VatPercent_Tbox.Enabled = False
                VatPercent_Tbox.Text = Val(12 * 0.5)
            End If
        End If
    End Sub

    Dim newInstanceOfThisFrm As PD_SalesJobOrder

    Private Sub PD_SalesJobOrder_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case BGW_Func_turn
                Case "Onload"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(SearchStr, "PD_stp_SalesJobOrder_CTDnPD")
                Case "2ndload"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(PD_ID, "PD_stp_SalesJobOrder_CLIENTS")
                Case "AEIC_LBL_POPULATE"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(PD_ID, "PD_stp_SalesJobOrder_AEIC")
                Case "QUOTE_REF_NO_CUR"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(CD_ID, "PD_stp_SalesJobOrder_QRef_Cur")
                Case "QUOTE_REF_NO_PREV"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(CD_ID, "PD_stp_SalesJobOrder_QRef_Prev")
                Case "SEARCH_FOR_SUB_JO"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(JoRefNo_OnClickUpdate, "PD_stp_SalesJobOrder_SubJoSearch")
                Case "Update"
                    PD_SalesJobOrder_Update(Sub_Jo, JoRefNo_OnClickUpdate, JoDate, FileLabelAs,
                                    JoDesc, JoAttach, Remarks, BlankPage,
                                    VatProfile, PaymentTerms, PaymentMode, DownPayment, PaymentDate,
                                    AddressTo_cmbox, AddressTo_txbox, EstdDelDate, ModeOfDel,
                                    ModeOfShip, OutOfTown, DelGoodsTo, DelAddress, SpInstr, ContractType,
                                    BalOfDP, CD_ID, CompanyName_txbox, CUST_ID, ProjectLabel, PertDetails, PD_ID, "PD_stp_SalesJobOrder_Update")
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            sql_Err_msg = ex.Message
            sql_Err_no = ex.Number
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           "Rollback Error Message: " & ex2.Message & vbCrLf)
                Log_File.Close()
            End Try
        Catch ex22 As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex22.Message & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Public BGW_Func_turn As String

    Sub Reset_labels()
        AEIC_Lbl.Text = ""
        CustRefNo_Lbl.Text = ""
        PrevJoNo_Lbl.Text = ""
        PrevOwner_Lbl.Text = ""
        PrevQuoteDate_Lbl.Text = ""
        PrevQuoteNo_Lbl.Text = ""
        ProjectType_Lbl.Text = ""
        ProjSource_Lbl.Text = ""
        QuoteDate_Lbl.Text = ""
        QuoteRefNo_Lbl.Text = ""
        BalOfDP_lbl.Text = ""
    End Sub

    Private Sub PD_SalesJobOrder_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            Me.Width = 800
            Me.Height = 600
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                '' if BackgroundWorker terminated due to error
                MessageBox.Show("Error or Cancelled")
            Else
                '' otherwise it completed normally
                Dim rownum As Integer = sqlBindingSource.Count

                If sql_Err_no = -2 Then
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect" & vbCrLf & "Cancel to Exit",
                                                       "Request Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    If result = DialogResult.OK Then
                        Start_OnLoadBGW()
                        Exit Sub
                    ElseIf result = DialogResult.Cancel Then
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
                        Select Case BGW_Func_turn
                            Case "Onload"
                                If rownum <> 0 Or rownum <> Nothing Then
                                    For Each row In sqlBindingSource
                                        PD_ID = row("PD_ID")
                                        JoRefNo_Onload = row("SUB_JO")
                                        JoRefNo_Tbox.Text = JoRefNo_Onload

                                        ProjectLabel_Tbox.Text = row("PROJECT_LABEL")
                                        JoDate_DTP.Value = row("JOB_ORDER_NO_DATE")
                                        FileLabelAs_Cbox.Text = row("FILE_LABEL_AS")
                                        ContractType_Cbox.Text = row("CONTRACT_TYPE")
                                        ProjectType_Lbl.Text = row("PROJECT_TYPE")
                                        ProjSource_Lbl.Text = row("PROJECT_SOURCE")
                                        JoDesc_Tbox.Text = row("JOB_ORDER_DESC")
                                        JoAttach_RTbox.Text = row("JO_ATTACHMENT")
                                        PrevJoNo_Lbl.Text = row("PREV_JOB_ORDER_NO")
                                        PertDetails_RTbox.Text = row("PERTINENT_DETAILS")
                                        Remarks_RTbox.Text = row("SPECIAL_COMMENTS")
                                        VatProfile_Cbox.Text = row("CONTRACT_VAT_PROFILE")
                                        VatPercent_Tbox.Text = row("VAT")
                                        PaymentTerms_Cbox.Text = row("PAYMENT_TERMS")
                                        PaymentMode_Cbox.Text = row("PAYMENT_MODE")
                                        DownPayment_Tbox.Text = row("DOWN_PAYMENT")
                                        PaymentDate_Tbox.Text = row("PAYMENT_DATE")
                                        BalOfDP_lbl.Text = row("BAL_OF_DP")
                                        AddressTo_Cbox.Text = row("ADDRESS_BILLING")
                                        AddressTo_Tbox.Text = row("ADDRESS_TO")
                                        EstdDelDate_Tbox.Text = row("ESTD_DEL_DATE")
                                        ModeOfDel_Cbox.Text = row("MODE_OF_DEL")
                                        ModeOfShip_Cbox.Text = row("MODE_OF_SHIP")
                                        OutOfTown_Cbox.Text = row("OUT_OF_TOWN_CHARGES")
                                        DelGoodsTo_Cbox.Text = row("DEL_GOODS")
                                        DelAddress_RTbox.Text = row("DELGOODS_TO")
                                        SpInstr_RTbox.Text = row("OTHER_PERTINENT_INFO")
                                        BlankPage_Tbox.Text = row("BLANK_PAGE")
                                        UnitNo = row("UnitNo")
                                        Establishment = row("ESTABLISHMENT")
                                        HouseNo = row("NO")
                                        Street = row("STREET")
                                        Village = row("VILLAGE")
                                        Brgy = row("BRGY_MUNICIPALITY")
                                        CityMunicipality = row("TOWN_DISTRICT")
                                        Province = row("PROVINCE")
                                        Area = row("AREA")
                                    Next row
                                    AddressFormat(UnitNo, Establishment, HouseNo, Street,
                                                  Village, Brgy, CityMunicipality, Province)
                                    FullAddress_Tbox.Text = FullAddress
                                    BGW_Func_turn = "2ndload"
                                    is_CTD_bool = True
                                    is_SalesJobOrder_bool = False
                                    Start_OnLoadBGW()
                                End If
                            Case "2ndload"
                                For Each row2 In sqlBindingSource
                                    Dim CLIENT_STATUS As String
                                    CLIENT_STATUS = row2("CLIENT_STATUS")
                                    If CLIENT_STATUS = "Current Owner" Then
                                        CompanyName_Tbox.Text = row2("COMPANY_NAME")
                                        CustRefNo_Lbl.Text = row2("CUST_REF_NO")
                                        ClientsName = row2("CLIENTS_NAME")
                                        CUST_ID = row2("CUST_ID")
                                    ElseIf CLIENT_STATUS = "Previous Owner" Then
                                        PrevOwner_Lbl.Text = row2("CLIENTS_NAME")
                                    End If
                                Next row2
                                BGW_Func_turn = "AEIC_LBL_POPULATE"
                                is_CTD_bool = True
                                is_SalesJobOrder_bool = False
                                Start_OnLoadBGW()
                            Case "AEIC_LBL_POPULATE"
                                Dim lbl_output_seq As Integer
                                For Each rowAEIC In sqlBindingSource
                                    lbl_output_seq += 1
                                    If AEIC_Lbl.Width > 350 Then
                                        AEIC_Lbl.FontSize = MetroFramework.MetroLabelSize.Small
                                        AEIC_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Light
                                    End If
                                    If rownum <> lbl_output_seq Then
                                        If lbl_output_seq Mod 2 = 0 Then
                                            AEIC_Lbl.Text += rowAEIC("FULLNAME") & " && " & vbCrLf
                                        Else
                                            AEIC_Lbl.Text += rowAEIC("FULLNAME") & " && "
                                        End If
                                    Else
                                        AEIC_Lbl.Text += rowAEIC("FULLNAME")
                                    End If
                                Next rowAEIC
                                BGW_Func_turn = "QUOTE_REF_NO_CUR"
                                is_CTD_bool = True
                                is_SalesJobOrder_bool = False
                                Start_OnLoadBGW()
                            Case "QUOTE_REF_NO_CUR"
                                Dim QREF_DATE As Date
                                Dim QREF_NO As String

                                For Each row In sqlBindingSource
                                    QuoteRefNo_Populate_counter += 1
                                    QREF_NO = row("QUOTE_NO")
                                    QREF_DATE = row("QUOTE_DATE")

                                    If sqlBindingSource.Count = 1 Then
                                        QuoteRefNo_Lbl.Text = QREF_NO
                                        QuoteDate_Lbl.Text = QREF_DATE.ToString("MMM-dd-yyyy")

                                    ElseIf sqlBindingSource.Count > 1 And QuoteRefNo_Populate_counter <> sqlBindingSource.Count Then
                                        QuoteRefNo_Lbl.Text += QREF_NO & ", "
                                        QuoteDate_Lbl.Text += QREF_DATE.ToString("MMM-dd-yyyy") & ", "

                                    ElseIf sqlBindingSource.Count > 1 And QuoteRefNo_Populate_counter = sqlBindingSource.Count Then
                                        QuoteRefNo_Lbl.Text += QREF_NO
                                        QuoteDate_Lbl.Text += QREF_DATE.ToString("MMM-dd-yyyy")

                                    End If
                                Next

                                QuoteRefNo_Populate_counter = 0
                                BGW_Func_turn = "QUOTE_REF_NO_PREV"
                                is_CTD_bool = True
                                is_SalesJobOrder_bool = False
                                Start_OnLoadBGW()
                            Case "QUOTE_REF_NO_PREV"
                                Dim QREF_DATE As Date
                                Dim QREF_NO As String

                                For Each row In sqlBindingSource
                                    QuoteRefNo_Populate_counter += 1
                                    QREF_NO = row("QUOTE_NO")
                                    QREF_DATE = row("QUOTE_DATE")

                                    If sqlBindingSource.Count = 1 Then
                                        PrevQuoteNo_Lbl.Text = QREF_NO
                                        PrevQuoteDate_Lbl.Text = QREF_DATE.ToString("MMM-dd-yyyy")

                                    ElseIf sqlBindingSource.Count > 1 And QuoteRefNo_Populate_counter <> sqlBindingSource.Count Then
                                        PrevQuoteNo_Lbl.Text += QREF_NO & ", "
                                        PrevQuoteDate_Lbl.Text += QREF_DATE.ToString("MMM-dd-yyyy") & ", "

                                    ElseIf sqlBindingSource.Count > 1 And QuoteRefNo_Populate_counter = sqlBindingSource.Count Then
                                        PrevQuoteNo_Lbl.Text += QREF_NO
                                        PrevQuoteDate_Lbl.Text += QREF_DATE.ToString("MMM-dd-yyyy")

                                    End If
                                Next

                                QuoteRefNo_Populate_counter = 0
                            Case "SEARCH_FOR_SUB_JO"
                                If return_bool = True Then
                                    If MetroFramework.MetroMessageBox.Show(Me, "Proceed Anyway?" & vbCrLf & "This might cause a duplicate J.O Ref. No.", "Existing J.O Ref. No.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                        BGW_Func_turn = "Update"
                                        Start_OnLoadBGW()
                                    End If
                                ElseIf return_bool = False Then
                                    BGW_Func_turn = "Update"
                                    Start_OnLoadBGW()
                                End If
                                return_bool = False
                            Case "Update"
                                If return_bool = True Then
                                    MetroFramework.MetroMessageBox.Show(Me, "Success", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Reset_labels()
                                    BGW_Func_turn = "Onload"
                                    Start_OnLoadBGW()
                                ElseIf return_bool = False Then
                                    MetroFramework.MetroMessageBox.Show(Me, "Failed", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End If
                        End Select

                    ElseIf sql_Transaction_result = "Rollback" Then
                        MetroFramework.MetroMessageBox.Show(Me, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                    Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           "SQL Transaction Error Number: " & sql_Err_no & vbCrLf &
                                           "SQL Transaction Error Message: " & sql_Err_msg)
                    Log_File.Close()
                    MetroFramework.MetroMessageBox.Show(Me, "Transaction failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                sql_Err_msg = Nothing
                sql_Err_no = Nothing
                sql_Transaction_result = ""

                LoadingPbox.Visible = False
                SalesJobOrder_Pnl.Visible = True

                If JoDate = "1900-01-01" Then
                    JoDate_DTP.Value = Now
                End If

                If JoRefNo_Tbox.Text = "" Or JoRefNo_Tbox.Text = Nothing Then
                    JoDate_DTP.Value = Now
                End If

                If ContractType_Cbox.Text = "Revised Contract" Or ContractType_Cbox.Text = "Adjustment Contract" Then
                    Note_Lbl.Text = "Note:  This Job Order supercedes original J.O. released with the above-listed Previous Reference No(s)."
                Else
                    Note_Lbl.Text = ""
                End If


                If ContractType_Cbox.Text <> "Original Contract" And ContractType_Cbox.Text <> "Dealer`s Contract" And ContractType_Cbox.Text <> "" And ContractType_Cbox.Text <> Nothing Then
                    ContractType_Cbox.Enabled = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try
    End Sub

    Private Sub PaymentDate_DTP_ValueChanged(sender As Object, e As EventArgs) Handles PaymentDate_DTP.ValueChanged
        PaymentDate_Tbox.Text = PaymentDate_DTP.Text
    End Sub

    Private Sub EditHeaderPartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditHeaderPartToolStripMenuItem.Click
        PD_UpdateHeader.UnitNo_Tbox.Text = UnitNo
        PD_UpdateHeader.Establishment_Tbox.Text = Establishment
        PD_UpdateHeader.HouseNo_Tbox.Text = HouseNo
        PD_UpdateHeader.Street_Tbox_Required.Text = Street
        PD_UpdateHeader.Village_Tbox.Text = Village
        PD_UpdateHeader.Brgy_Tbox.Text = Brgy
        PD_UpdateHeader.City_Tbox_Required.Text = CityMunicipality
        PD_UpdateHeader.Province_Tbox_Required.Text = Province
        PD_UpdateHeader.Area_Cbox_Required.Text = Area
        PD_UpdateHeader.disFormOpenedBy = "SalesJobOrder"
        PD_UpdateHeader.Show()
    End Sub

    Private Sub EditJOContractAttachmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditJOContractAttachmentsToolStripMenuItem.Click
        PD_JoAttach.JoAttach_RTbox.Text = JoAttach_RTbox.Text
        PD_JoAttach.Show()
    End Sub

    Private Sub Panel14_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel14.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = False
                EditPertinentDetailsToolStripMenuItem.Visible = False
                EditJOContractAttachmentsToolStripMenuItem.Visible = True
                SJO_CMenu.Show()
                SJO_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroLabel23_MouseClick(sender As Object, e As MouseEventArgs) Handles MetroLabel23.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = False
                EditPertinentDetailsToolStripMenuItem.Visible = False
                EditJOContractAttachmentsToolStripMenuItem.Visible = True
                SJO_CMenu.Show()
                SJO_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditPertinentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPertinentDetailsToolStripMenuItem.Click
        PD_PertDetails.PertDetails_RTbox.Text = PertDetails_RTbox.Text
        PD_PertDetails.Show()
    End Sub

    Private Sub Panel17_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel17.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = False
                EditPertinentDetailsToolStripMenuItem.Visible = True
                EditJOContractAttachmentsToolStripMenuItem.Visible = False
                SJO_CMenu.Show()
                SJO_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroLabel35_MouseClick(sender As Object, e As MouseEventArgs) Handles MetroLabel35.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = False
                EditPertinentDetailsToolStripMenuItem.Visible = True
                EditJOContractAttachmentsToolStripMenuItem.Visible = False
                SJO_CMenu.Show()
                SJO_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FileLabelAs_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FileLabelAs_Cbox.SelectionChangeCommitted
        Try
            If FileLabelAs_Cbox.Text = "Proj/Client`s Name" Then
                ProjectLabel_Tbox.Text = ClientsName
            ElseIf FileLabelAs_Cbox.Text = "Company Name" Then
                ProjectLabel_Tbox.Text = CompanyName_Tbox.Text
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try
    End Sub

    Private Sub AddressTo_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles AddressTo_Cbox.SelectionChangeCommitted
        Try
            If AddressTo_Cbox.SelectedIndex = 0 Then
                AddressTo_Tbox.Text = ClientsName
            ElseIf AddressTo_Cbox.SelectedIndex = 1 Then
                AddressTo_Tbox.Text = CompanyName_Tbox.Text
            ElseIf AddressTo_Cbox.SelectedIndex = 2 Then
                AddressTo_Tbox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try
    End Sub

    Private Sub DelGoodsTo_Cbox_TextChanged(sender As Object, e As EventArgs) Handles DelGoodsTo_Cbox.TextChanged
        Try
            If DelGoodsTo_Cbox.Text.Contains("Project/Site Address") Then
                DelAddress_RTbox.Text = FullAddress
            ElseIf DelGoodsTo_Cbox.Text.Contains("Other Address") Then
                DelAddress_RTbox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try

    End Sub

    Public ProjectLabel,
            CompanyName_txbox,
            JoRefNo_Onload,
            JoRefNo_OnClickUpdate,
            Sub_Jo,
            FileLabelAs,
            JoDesc,
            JoAttach,
            PertDetails,
            Remarks,
            BlankPage,
            VatProfile,
            PaymentTerms,
            PaymentMode,
            DownPayment,
            PaymentDate,
            AddressTo_cmbox,
            AddressTo_txbox,
            EstdDelDate,
            ModeOfDel,
            ModeOfShip,
            OutOfTown,
            DelGoodsTo,
            DelAddress,
            SpInstr,
            BalOfDP,
            ContractType As String

    Private Sub DownPayment_Tbox_TextChanged(sender As Object, e As EventArgs) Handles DownPayment_Tbox.TextChanged
        Try
            Dim DownPayment_inputted As Double
            DownPayment_inputted = Val(DownPayment_Tbox.Text)
            If DownPayment_Tbox.Text = "" Or DownPayment_Tbox.Text = Nothing Then
                DownPayment_inputted = 0
            End If

            If DownPayment_inputted >= 100.0 Then
                DownPayment_Tbox.Text = 100.0
            End If

            BalOfDP_input = DownPayment_input - Val(DownPayment_Tbox.Text)

            BalOfDP_lbl.Text = BalOfDP_input & "%"
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try

    End Sub

    Dim BalOfDP_input, DownPayment_input As Double

    Private Sub PaymentTerms_Cbox_TextChanged(sender As Object, e As EventArgs) Handles PaymentTerms_Cbox.TextChanged
        Try
            If PaymentTerms_Cbox.Text.Contains("C.O.D") Or PaymentTerms_Cbox.Text.Contains("Free-Of-Charge") Or PaymentTerms_Cbox.Text.Contains("Full Payment") Then
                DownPayment_input = 0
            ElseIf PaymentTerms_Cbox.Text.Contains("Standard: 50%,40%,10%") Then
                DownPayment_input = 50
            ElseIf PaymentTerms_Cbox.Text.Contains("90%, 10%") Then
                DownPayment_input = 90
            End If
            DownPayment_Tbox.Text = DownPayment_input
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try

    End Sub

    Private Sub Collections_Textboxes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VatPercent_Tbox.KeyPress, DownPayment_Tbox.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub PD_SalesJobOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Do you want to exit?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = False
            Project_Details.BringToFront()
        Else
            onformLoad()
            e.Cancel = True
        End If
    End Sub

    Public JoDate As Date

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Try
            ProjectLabel = ProjectLabel_Tbox.Text
            CompanyName_txbox = CompanyName_Tbox.Text
            FullAddress = FullAddress_Tbox.Text
            Sub_Jo = JoRefNo_Tbox.Text
            JoRefNo_OnClickUpdate = JoRefNo_Tbox.Text
            JoDate = JoDate_DTP.Value
            FileLabelAs = FileLabelAs_Cbox.Text
            JoDesc = JoDesc_Tbox.Text
            JoAttach = JoAttach_RTbox.Text
            PertDetails = PertDetails_RTbox.Text
            Remarks = Remarks_RTbox.Text
            BlankPage = BlankPage_Tbox.Text
            VatProfile = VatProfile_Cbox.Text
            PaymentTerms = PaymentTerms_Cbox.Text
            PaymentMode = PaymentMode_Cbox.Text
            DownPayment = DownPayment_Tbox.Text
            PaymentDate = PaymentDate_Tbox.Text
            AddressTo_cmbox = AddressTo_Cbox.Text
            AddressTo_txbox = AddressTo_Tbox.Text
            EstdDelDate = EstdDelDate_Tbox.Text
            ModeOfDel = ModeOfDel_Cbox.Text
            ModeOfShip = ModeOfShip_Cbox.Text
            OutOfTown = OutOfTown_Cbox.Text
            DelGoodsTo = DelGoodsTo_Cbox.Text
            DelAddress = DelAddress_RTbox.Text
            SpInstr = SpInstr_RTbox.Text
            BalOfDP = BalOfDP_lbl.Text
            ContractType = ContractType_Cbox.Text
            If Trim(JoRefNo_Tbox.Text).Length <> 11 Then
                If JoRefNo_OnClickUpdate = JoRefNo_Onload Then
                    BGW_Func_turn = "Update"
                    Start_OnLoadBGW()
                ElseIf JoRefNo_OnClickUpdate <> JoRefNo_Onload Then
                    BGW_Func_turn = "SEARCH_FOR_SUB_JO"
                    Start_OnLoadBGW()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message)
            Log_File.Close()
        End Try

    End Sub
End Class