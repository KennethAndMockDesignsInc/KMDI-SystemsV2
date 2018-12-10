Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class PD_Addendum
    Public PD_Addendum_BGW As BackgroundWorker = New BackgroundWorker
    Dim ADDENDUM_BGW_TODO As String
    Dim WD_ID, QUOTE_NO As String


    Sub Start_PD_Addendum_BGW(ByVal Panel_bool As Boolean,
                              ByVal Loading_bool As Boolean)
        If PD_Addendum_BGW.IsBusy <> True Then
            PD_Addendum_Pnl.Visible = Panel_bool
            LoadingPbox.Visible = Loading_bool
            PD_Addendum_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub onformLoad()
        Reset()
        ADDENDUM_BGW_TODO = "Onload"
        Start_PD_Addendum_BGW(False, True)
    End Sub

    Sub Reset()
        AEIC_Lbl.Text = ""
        Competitors_Lbl.Text = ""
        JORefNo_Lbl.Text = ""
        ProfileFin_Lbl.Text = ""
        ProjClass_Lbl.Text = ""
        ProjSource_Lbl.Text = ""
        QuoteDate_Lbl.Text = ""
        ProjectLabel_Cbox.Items.Clear()
    End Sub

    Private Sub PD_Addendum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PD_Addendum_BGW.WorkerSupportsCancellation = True
        PD_Addendum_BGW.WorkerReportsProgress = True
        AddHandler PD_Addendum_BGW.DoWork, AddressOf PD_Addendum_BGW_DoWork
        AddHandler PD_Addendum_BGW.RunWorkerCompleted, AddressOf PD_Addendum_BGW_RunWorkerCompleted
        'AddHandler PD_Addendum_BGW.ProgressChanged, AddressOf PD_Addendum_BGW_ProgressChanged
        onformLoad()
    End Sub

    Dim Qnos() As String
    Private Sub PD_Addendum_BGW_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try
            Select Case ADDENDUM_BGW_TODO
                Case "Onload"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = QuerySearchHeadArrays(5) & QueryMidArrays(4) & QueryConditionArrays(1) & " AND [CTD].JOB_ORDER_NO = [CTD].PARENTJONO"
                    Query_Select(PD_ID)
                Case "AEIC_LBL_LOAD"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = "SELECT AE_TBL.FULLNAME FROM (" & QuerySearchHeadArrays(4) &
                            QueryMidArrays(3) & " ) AS AE_TBL
                    JOIN A_NEW_PROJECT_DETAILS [PD]
                    ON	AE_TBL.PD_ID_REF = PD.PD_ID
                    WHERE PD_ID = @EqualSearch AND AE_TBL.[AE_STATUS] = 1 AND PD.[PD_STATUS] = 1"
                    Query_Select(PD_ID)
                Case "CompanyName"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = QuerySearchHeadArrays(6) & QueryMidArrays(5) & QueryConditionArrays(1) & " AND OWN.[CLIENT_STATUS] = 'Current Owner'"
                    Query_Select(PD_ID)
                Case "TechnicalPartners"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    QueryBUILD = "SELECT	*
                              FROM    ( SELECT * " & QueryMidArrays(7) & ") AS [TP] " &
                                          QueryMidArrays(6) & " ON TP_NATURE.TP_ID_REF = TP.TP_ID " &
                                          QueryConditionArrays(1) & " AND CD.JOB_ORDER_NO = CD.PARENTJONO AND STATUS_AVAILABILITY = 1 AND EMP_STATUS = 1 AND COMP_STATUS = 1 AND PD_STATUS = 1"
                    Query_Select(PD_ID)
                Case "QuoteRefNo_Sel"
                    QUERY_INSTANCE = "Read_using_SearchString"
                    QueryBUILD = "SELECT * FROM [A_NEW_WINDOOR_DETAILS] WHERE QUOTE_NO = @SearchString AND [WD_STATUS] = 1"

                    Qnos = QUOTE_NO.Split("&")
                    If arr_Profile_finish.Count <> 0 Or arr_Quote_Date.Count <> 0 Then
                        arr_Profile_finish.Clear()
                        arr_Quote_Date.Clear()
                    End If
                    For Each Qno As String In Qnos
                        QUERY_SELECT_WITH_READER(Qno, ADDENDUM_BGW_TODO)
                    Next
                Case "INSERT_TECHNICAL_PARTNERS"
                    For Each ROW In ArchDesignBS
                        PD_Addendum_Update_TechPartners(Me, C_ID, "Architectural Design", ROW("COMP_ID"), ROW("EMP_ID"), ROW("POSITION"), ROW("TP_ID"))
                    Next
                Case "Search_for_TP_ID"
                    SEARCH_TP_ID(COMP_ID, EMP_ID, EMP_POSITION)
            End Select

        Catch ex As SqlException
        'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
        If ex.Number = -2 Then
            MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ex.Number = 1232 Then
            MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PD_Addendum_BGW.CancelAsync()
        ElseIf ex.Number = 19 Then
            MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PD_Addendum_BGW.CancelAsync()
        ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
            MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            PD_Addendum_BGW.CancelAsync()
        End If
        Catch ex2 As Exception
        MessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub ProjectLabel_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProjectLabel_Cbox.SelectionChangeCommitted
        'Dim ProjectLabel As String
        ProjectLabel = ProjectLabel_Cbox.Text.Replace("&&", "&")
        If ProjectLabel = OwnersName Then
            FIle_Label_As = "Proj/Client`s Name"
        ElseIf ProjectLabel = CompanyName_Str Then
            FIle_Label_As = "Company Name"
        End If
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
        PD_UpdateHeader.disFormOpenedBy = "Addendum"
        PD_UpdateHeader.Show()
    End Sub

    Private Sub Header_Pnl_MouseClick(sender As Object, e As MouseEventArgs) Handles Header_Pnl.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = True
                EditTechnicalPartnersToolStripMenuItem.Visible = False
                Addendum_CMenu.Show()
                Addendum_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TechPartners_Pnl_MouseClick(sender As Object, e As MouseEventArgs) Handles TechPartners_Pnl.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                EditHeaderPartToolStripMenuItem.Visible = False
                EditTechnicalPartnersToolStripMenuItem.Visible = True
                Addendum_CMenu.Show()
                Addendum_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditTechnicalPartnersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTechnicalPartnersToolStripMenuItem.Click
        PD_TechPartners.Show()
    End Sub

    Private Sub ArchDesign_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ArchDesign_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub IntrDesign_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles IntrDesign_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub ConsMngmt_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ConsMngmt_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub GenCon_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles GenCon_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub PD_Addendum_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Project_Details.BringToFront()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim OwnersRep, OwnersRepHomeCno, OwnersRepOfficeCno, OwnersRepMobileCno, OwnersNameHomeCno,
        OwnersNameOfficeCno, OwnersNameMobile, ConStage, SiteMeeting, SpInstr, CUST_ID, CUST_ID_REP As String

    Dim CompanyName_Str, OwnersName, ProjectLabel As String

    Dim FIle_Label_As As String = Nothing, QuoteRefNo As String = Nothing

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Try
            ProjectLabel = ProjectLabel_Cbox.Text
            QuoteRefNo = QuoteRefNo_Tbox.Text
            OwnersName = OwnersName_Tbox.Text
            OwnersNameHomeCno = OwnersNameHomeCno_Tbox.Text
            OwnersNameOfficeCno = OwnersNameOfficeCno_Tbox.Text
            OwnersNameMobile = OwnersNameMobile_Tbox.Text
            OwnersRep = OwnersRep_Tbox.Text
            OwnersRepHomeCno = OwnersRepHomeCno_Tbox.Text
            OwnersRepOfficeCno = OwnersRepOfficeCno_Tbox.Text
            OwnersRepMobileCno = OwnersRepMobileCno_Tbox.Text
            ConStage = ConStage_Tbox.Text
            SiteMeeting = SiteMeeting_Tbox.Text
            SpInstr = SpInstr_RTbox.Text

            If ProjectLabel = Nothing Or ProjectLabel = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select Project Name.")
            Else
                ADDENDUM_BGW_TODO = "Search_for_TP_ID"
                Start_PD_Addendum_BGW(False, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QuoteRefNo_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuoteRefNo_Tbox.KeyDown
        QUOTE_NO = Replace(QuoteRefNo_Tbox.Text, " ", "")
        If e.KeyCode = Keys.Enter Then
            If QUOTE_NO <> Nothing And QUOTE_NO <> "" Then
                QuoteDate_Lbl.Text = ""
                ProfileFin_Lbl.Text = ""
                ADDENDUM_BGW_TODO = "QuoteRefNo_Sel"
                Start_PD_Addendum_BGW(False, True)

            Else
                MetroFramework.MetroMessageBox.Show(Me, "Please input a valid Quote reference number.")
            End If
        End If
    End Sub


    Private Sub PD_Addendum_BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Width = 800
            Me.Height = 600
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '' otherwise it completed normally
                FullAddress_Tbox.Text = Project_Details.FULLADDRESS
                Dim rownum As Integer = sqlBindingSource.Count
                Select Case ADDENDUM_BGW_TODO
                    Case "Onload"
                        For Each row In sqlBindingSource
                            C_ID = row("CD_ID")
                            FIle_Label_As = row("FILE_LABEL_AS")
                            ProjectLabel = row("PROJECT_LABEL")
                            JORefNo_Lbl.Text = row("SUB_JO")
                            QuoteRefNo = row("QUOTE_NO")
                            QuoteDate_Lbl.Text = row("QUOTE_DATE")
                            ConStage_Tbox.Text = row("CONSTRUCTION_STAGE")
                            SiteMeeting_Tbox.Text = row("ACTIVITIES")

                            ProjClass_Lbl.Text = row("PROJECT_CLASSIFICATION")
                            ProjSource_Lbl.Text = row("PROJECT_SOURCE")
                            Competitors_Lbl.Text = row("COMPETITORS")
                            ProfileFin_Lbl.Text = row("PROFILE_FINISH")
                            SpInstr_RTbox.Text = row("OTHER_PERTINENT_INFO")

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

                    'Lock_Btn.Text = "Unlock"
                    'QuoteRefNo_Cbox.Enabled = False
                    ArchDesignDT.Clear()
                    ConsMngmtDT.Clear()
                    GenConDT.Clear()
                    IntrDesignDT.Clear()

                    If ArchDesignDT.Columns.Count = 0 And ConsMngmtDT.Columns.Count = 0 And
                            GenConDT.Columns.Count = 0 And IntrDesignDT.Columns.Count = 0 Then
                            For i = 0 To UBound(DTcols_str)
                                ADDTCols = New DataColumn(DTcols_str(i), GetType(String))
                                IDDTCols = New DataColumn(DTcols_str(i), GetType(String))
                                GCDTCols = New DataColumn(DTcols_str(i), GetType(String))
                                CMDTCols = New DataColumn(DTcols_str(i), GetType(String))

                                ArchDesignDT.Columns.Add(ADDTCols)
                                ConsMngmtDT.Columns.Add(CMDTCols)
                                GenConDT.Columns.Add(GCDTCols)
                                IntrDesignDT.Columns.Add(IDDTCols)
                            Next
                        End If

                        If (QuoteRefNo <> Nothing Or QuoteRefNo <> "") And
                           (JORefNo_Lbl.Text <> Nothing Or JORefNo_Lbl.Text <> "") Then
                            QuoteRefNo_Tbox.Enabled = False
                        Else
                            QuoteRefNo_Tbox.Enabled = True
                        End If

                        ADDENDUM_BGW_TODO = "AEIC_LBL_LOAD"
                        Start_PD_Addendum_BGW(False, True)
                    Case "AEIC_LBL_LOAD"
                        Dim lbl_output_seq As Integer
                        For Each rowAEIC In sqlBindingSource
                            lbl_output_seq += 1
                            If AEIC_Lbl.Width > 547 Then
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
                        ADDENDUM_BGW_TODO = "CompanyName"
                        Start_PD_Addendum_BGW(False, True)
                    Case "CompanyName"
                        For Each row2 In sqlBindingSource
                            CUST_ID = row2("CUST_ID")
                            OwnersName_Tbox.Text = row2("CLIENTS_NAME")
                            OwnersNameHomeCno_Tbox.Text = row2("CLIENTS_CONTACT_NO")
                            OwnersNameOfficeCno_Tbox.Text = row2("CLIENTS_CONTACT_OFFICE")
                            OwnersNameMobile_Tbox.Text = row2("CLIENTS_CONTACT_MOBILE")
                            CompanyName_Str = row2("COMPANY_NAME")
                            OwnersName = row2("OWNERS_NAME")
                        Next row2
                        If OwnersName <> Nothing AndAlso OwnersName.Contains("&") Then
                            OwnersName = OwnersName.Replace("&", "&&")
                        End If
                        If CompanyName_Str <> Nothing AndAlso CompanyName_Str.Contains("&") Then
                            CompanyName_Str = CompanyName_Str.Replace("&", "&&")
                        End If
                        ProjectLabel_Cbox.Items.Add(OwnersName)
                        ProjectLabel_Cbox.Items.Add(CompanyName_Str)


                        If FIle_Label_As = Nothing Or FIle_Label_As = "" Then
                            If OwnersName <> "" And OwnersName <> Nothing Then
                                ProjectLabel_Cbox.Text = OwnersName
                                FIle_Label_As = "Proj/Client`s Name"
                            ElseIf CompanyName_Str <> "" And CompanyName_Str <> Nothing Then
                                ProjectLabel_Cbox.Text = CompanyName_Str
                                FIle_Label_As = "Company Name"
                            End If
                        ElseIf FIle_Label_As.Contains("Proj/Client`s Name") Then
                            ProjectLabel_Cbox.Text = OwnersName
                        ElseIf FIle_Label_As.Contains("Company Name") Then
                            ProjectLabel_Cbox.Text = CompanyName_Str
                        End If

                        ADDENDUM_BGW_TODO = "TechnicalPartners"
                        Start_PD_Addendum_BGW(False, True)
                    Case "TechnicalPartners"
                        For Each row3 In sqlBindingSource
                            Dim nature As String = row3("NATURE")
                            If nature = "Architectural Design" Then
                                ArchDesignDT.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"), row3("COMP_ID"), row3("EMP_ID"), row3("TP_ID"))
                            ElseIf nature = "Interior Design" Then
                                IntrDesignDT.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"), row3("COMP_ID"), row3("EMP_ID"), row3("TP_ID"))
                            ElseIf nature = "General Contractor" Then
                                GenConDT.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"), row3("COMP_ID"), row3("EMP_ID"), row3("TP_ID"))
                            ElseIf nature = "Construction Management" Then
                                ConsMngmtDT.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"), row3("COMP_ID"), row3("EMP_ID"), row3("TP_ID"))
                            End If
                        Next row3

                        ArchDesign_DGV.DataSource = Nothing
                        ArchDesignBS.DataSource = ArchDesignDT
                        ArchDesign_DGV.DataSource = ArchDesignBS
                        ArchDesign_DGV.Columns("COMP_ID").Visible = False
                        ArchDesign_DGV.Columns("EMP_ID").Visible = False
                        ArchDesign_DGV.Columns("TP_ID").Visible = False

                        IntrDesign_DGV.DataSource = Nothing
                        IntrDesignBS.DataSource = IntrDesignDT
                        IntrDesign_DGV.DataSource = IntrDesignBS
                        IntrDesign_DGV.Columns("COMP_ID").Visible = False
                        IntrDesign_DGV.Columns("EMP_ID").Visible = False
                        IntrDesign_DGV.Columns("TP_ID").Visible = False

                        ConsMngmt_DGV.DataSource = Nothing
                        ConsMngmtBS.DataSource = ConsMngmtDT
                        ConsMngmt_DGV.DataSource = ConsMngmtBS
                        ConsMngmt_DGV.Columns("COMP_ID").Visible = False
                        ConsMngmt_DGV.Columns("EMP_ID").Visible = False
                        ConsMngmt_DGV.Columns("TP_ID").Visible = False

                        GenCon_DGV.DataSource = Nothing
                        GenConBS.DataSource = GenConDT
                        GenCon_DGV.DataSource = GenConBS
                        GenCon_DGV.Columns("COMP_ID").Visible = False
                        GenCon_DGV.Columns("EMP_ID").Visible = False
                        GenCon_DGV.Columns("TP_ID").Visible = False

                    Case "QuoteRefNo_Sel"

                        For i = 0 To arr_Quote_Date.Count - 1
                            If arr_Quote_Date.Count = 1 Then
                                QuoteDate_Lbl.Text = arr_Quote_Date(0).ToString("MMM-dd-yyyy")
                            ElseIf arr_Quote_Date.Count > 1 And i <> arr_Quote_Date.Count - 1 Then
                                QuoteDate_Lbl.Text += arr_Quote_Date(i).ToString("MMM-dd-yyyy") & ", "
                            ElseIf arr_Quote_Date.Count > 1 And i = arr_Quote_Date.Count - 1 Then
                                QuoteDate_Lbl.Text += arr_Quote_Date(i).ToString("MMM-dd-yyyy")
                            End If
                        Next
                        For i = 0 To arr_Profile_finish.Count - 1
                            If arr_Profile_finish.Count = 1 Then
                                ProfileFin_Lbl.Text = arr_Profile_finish(0)
                            ElseIf arr_Profile_finish.Count > 1 And i <> arr_Profile_finish.Count - 1 Then
                                ProfileFin_Lbl.Text += arr_Profile_finish(i) & ", "
                            ElseIf arr_Profile_finish.Count > 1 And i = arr_Profile_finish.Count - 1 Then
                                ProfileFin_Lbl.Text += arr_Profile_finish(i)
                            End If
                        Next
                        'OwnersName_Tbox.Focus()
                    Case "INSERT_TECHNICAL_PARTNERS"
                        If PD_CountSuccess = ArchDesignBS.Count Then
                            MetroFramework.MetroMessageBox.Show(Me, "Success", " ", MessageBoxButtons.OK, MessageBoxIcon.None)
                        End If
                    Case "Search_for_TP_ID"
                End Select

            End If
            PD_Addendum_Pnl.Visible = True
            LoadingPbox.Visible = False
        Catch ex As Exception
        MessageBox.Show(Me, ex.Message)
        End Try
    End Sub

End Class