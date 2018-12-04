Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class PD_Addendum
    Public PD_Addendum_BGW As BackgroundWorker = New BackgroundWorker
    Dim ADDENDUM_BGW_TODO As String
    Sub Start_PD_Addendum_BGW()
        If PD_Addendum_BGW.IsBusy <> True Then
            PD_Addendum_Pnl.Visible = False
            LoadingPbox.Visible = True
            PD_Addendum_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub onformLoad()
        Reset()
        ADDENDUM_BGW_TODO = "Onload"
        Start_PD_Addendum_BGW()
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

        For Each DGV In TechPartners_Pnl.Controls
            If TypeOf DGV Is DataGridView Then
                DGV.ROWS.CLEAR()
            End If
        Next
    End Sub

    Private Sub QuoteRefNo_Cbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuoteRefNo_Cbox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub PD_Addendum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PD_Addendum_BGW.WorkerSupportsCancellation = True
        AddHandler PD_Addendum_BGW.DoWork, AddressOf PD_Addendum_BGW_DoWork
        AddHandler PD_Addendum_BGW.RunWorkerCompleted, AddressOf PD_Addendum_BGW_RunWorkerCompleted
        onformLoad()
    End Sub

    Private Sub PD_Addendum_BGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Try
            If ADDENDUM_BGW_TODO = "Onload" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = QuerySearchHeadArrays(5) & QueryMidArrays(4) & QueryConditionArrays(1) & " AND [CTD].JOB_ORDER_NO = [CTD].PARENTJONO"
                Query_Select(PD_ID)
            ElseIf ADDENDUM_BGW_TODO = "AEIC_LBL_LOAD" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = "SELECT AE_TBL.FULLNAME FROM (" & QuerySearchHeadArrays(4) &
                        QueryMidArrays(3) & " ) AS AE_TBL
                    JOIN A_NEW_PROJECT_DETAILS [PD]
                    ON	AE_TBL.PD_ID_REF = PD.PD_ID
                    WHERE PD_ID = @EqualSearch AND AE_TBL.[AE_STATUS] = 1 AND PD.[PD_STATUS] = 1"
                Query_Select(PD_ID)
            ElseIf ADDENDUM_BGW_TODO = "CompanyName" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = QuerySearchHeadArrays(6) & QueryMidArrays(5) & QueryConditionArrays(1) & " AND OWN.[CLIENT_STATUS] = 'Current Owner'"
                Query_Select(PD_ID)
            ElseIf ADDENDUM_BGW_TODO = "TechnicalPartners" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = "SELECT	TP.OFFICENAME,
		                                TP.NAME,
		                                TP.POSITION,
		                                TP.MOBILENO,
		                                TP_NATURE.NATURE 
                              FROM    ( SELECT * " & QueryMidArrays(7) & ") AS [TP] " &
                              QueryMidArrays(6) & " ON TP_NATURE.TP_ID_REF = TP.TP_ID " &
                              QueryConditionArrays(1) & " AND CD.JOB_ORDER_NO = CD.PARENTJONO AND STATUS_AVAILABILITY = 1 AND EMP_STATUS = 1 AND COMP_STATUS = 1 AND PD_STATUS = 1"
                Query_Select(PD_ID)
            ElseIf ADDENDUM_BGW_TODO = "QuoteRefNo" Then
                QueryBUILD = "SELECT QUOTE_NO FROM [A_NEW_WINDOOR_DETAILS]"
                Query_Select("")
            End If
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

    Dim CompanyName_Str, OwnersName, ProjectLabel As String

    Private Sub ProjectLabel_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProjectLabel_Cbox.SelectionChangeCommitted
        Dim ProjectLabel As String
        ProjectLabel = ProjectLabel_Cbox.Text.Replace("&&", "&")
        'MsgBox(ProjectLabel)
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

    Dim FIle_Label_As = Nothing, QuoteRefNo As String = Nothing

    Private Sub PD_Addendum_BGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
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

                        If JORefNo_Lbl.Text <> "" Then
                            Lock_Btn.Text = "Unlock"
                            QuoteRefNo_Cbox.Enabled = False
                        Else
                            Lock_Btn.Text = "Lock"
                            QuoteRefNo_Cbox.Enabled = True
                        End If

                        ADDENDUM_BGW_TODO = "AEIC_LBL_LOAD"
                        Start_PD_Addendum_BGW()
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
                        Start_PD_Addendum_BGW()
                    Case "CompanyName"
                        For Each row2 In sqlBindingSource
                            OwnersName_Tbox.Text = row2("CLIENTS_NAME")
                            OwnersNameHomeCno_Tbox.Text = row2("CLIENTS_CONTACT_NO")
                            OwnersNameOfficeCno_Tbox.Text = row2("CLIENTS_CONTACT_OFFICE")
                            OwnersNameMobile_Tbox.Text = row2("CLIENTS_CONTACT_MOBILE")
                            CompanyName_Str = row2("COMPANY_NAME")
                            OwnersName = row2("OWNERS_NAME")
                        Next row2
                        If OwnersName.Contains("&") Then
                            OwnersName = OwnersName.Replace("&", "&&")
                        End If
                        If CompanyName_Str.Contains("&") Then
                            CompanyName_Str = CompanyName_Str.Replace("&", "&&")
                        End If
                        ProjectLabel_Cbox.Items.Add(OwnersName)
                        ProjectLabel_Cbox.Items.Add(CompanyName_Str)

                        If FIle_Label_As.Contains("Proj/Client`s Name") Then
                            ProjectLabel_Cbox.Text = OwnersName
                        ElseIf FIle_Label_As.Contains("Company Name") Then
                            ProjectLabel_Cbox.Text = CompanyName_Str
                        ElseIf FIle_Label_As = Nothing Or FIle_Label_As = "" Then
                            If OwnersName <> "" And OwnersName <> Nothing Then
                                ProjectLabel_Cbox.Text = OwnersName
                            ElseIf CompanyName_Str <> "" And CompanyName_Str <> Nothing Then
                                ProjectLabel_Cbox.Text = CompanyName_Str
                            End If
                        End If

                        ADDENDUM_BGW_TODO = "TechnicalPartners"
                        Start_PD_Addendum_BGW()
                    Case "TechnicalPartners"
                        For Each row3 In sqlBindingSource
                            Dim nature As String = row3("NATURE")
                            If nature = "Architectural Design" Then
                                ArchDesign_DGV.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"))
                            ElseIf nature = "Interior Design" Then
                                IntrDesign_DGV.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"))
                            ElseIf nature = "General Contractor" Then
                                GenCon_DGV.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"))
                            ElseIf nature = "Construction Management" Then
                                ConsMngmt_DGV.Rows.Add(row3("OFFICENAME"), row3("NAME"), row3("POSITION"), row3("MOBILENO"))
                            End If
                        Next row3

                        'For Each DGV In TechPartners_Pnl.Controls
                        '    If TypeOf DGV Is DataGridView Then
                        '        With DGV
                        '            If .RowCount <> 0 Then
                        '                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        '            Else
                        '                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        '            End If
                        '        End With
                        '    End If
                        'Next


                        ADDENDUM_BGW_TODO = "QuoteRefNo"
                        Start_PD_Addendum_BGW()
                    Case "QuoteRefNo"
                        QuoteRefNo_Cbox.DataBindings.Clear()
                        QuoteRefNo_Cbox.DataSource = sqlBindingSource
                        QuoteRefNo_Cbox.ValueMember = "QUOTE_NO"
                        QuoteRefNo_Cbox.Text = QuoteRefNo

                        'ADDENDUM_BGW_TODO = "Onload"
                        'Start_PD_Addendum_BGW()
                End Select

        End If
            PD_Addendum_Pnl.Visible = True
            LoadingPbox.Visible = False
        Catch ex As Exception
        MessageBox.Show(Me, ex.Message)
        End Try
    End Sub

End Class