Imports System.ComponentModel
Imports MetroFramework

Public Class ContractRecordsFRM
    Dim sql As New KMDIContractRecordsClass
    Public SearchString As String = Trim(SearchString)

    Public ActionTaken As String
    Public SearchItemFN As String
    Public UserAcctRestrictions As String
    Public SearchScope As String

    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Public UnitNo As String
    Public Establishment As String
    Public HouseNo As String
    Public Street As String
    Public Village As String
    Public Brgy As String
    Public CityMunicipality As String
    Public Province As String
    Public Area As String

    Public VProjectLabel As Boolean
    Public VClientsName As Boolean
    Public VCompanyName As Boolean
    Public VPrevOwner As Boolean
    Public VAEIC As Boolean
    Public VEIC As Boolean
    Public VFullAdd As Boolean
    Public VParentJONO As Boolean
    Public VUnitNoV As Boolean
    Public VEstablishment As Boolean
    Public VNo As Boolean
    Public VStreet As Boolean
    Public VVillage As Boolean
    Public VBrgy As Boolean
    Public VTown As Boolean
    Public VProvince As Boolean
    Public VArea As Boolean

    Public JobOrderNoID As String
    Public JOWithImage As Boolean
    Public JOWithItem As Boolean
    Public JOUserView As String

    Public ErrorMessage As String

    Public ContractRecordsBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub ContractRecordsGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractRecordsDGV.ColumnHeaderMouseClick
        If e.Button = MouseButtons.Right Then

        ElseIf e.Button = MouseButtons.Left Then
            Grid_Display()
        End If
    End Sub

    Private Sub ContractRecords_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            AddHandler ContractRecordsBGW.DoWork, AddressOf ContractRecordsBGW_DoWork
            AddHandler ContractRecordsBGW.RunWorkerCompleted, AddressOf ContractRecordsBGW_RunWorkerCompleted
            ChangePBVisibility = AddressOf ChangeVisibility

            LoadInitialSetUp()

        Catch ex As Exception
            ErrorMessage = ex.ToString
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Sub LoadInitialSetUp()
        SearchString = ""
        ActionTaken = "Search"
        SearchItemFN = "InitialF2"

        StartWorker()
    End Sub

    Public Sub StartWorker()
        Try
            If ContractRecordsBGW.IsBusy <> True Then
                ContractRecordsDGV.Columns.Clear()
                ContractRecordsDGV.DataSource = Nothing
                ContractRecordsDGV.DataMember = Nothing
                ContractRecordsBGW.WorkerSupportsCancellation = True
                ContractRecordsBGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ContractRecordsBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, True)
            ActionTakenByUser()

            sql.ContractRecordsLoad(QueryFunction,
                                    QueryBody,
                                    QueryCondition,
                                    ActionTaken,
                                    SearchItemFN)
        Catch ex As Exception
            ErrorMessage = ex.ToString
            ContractRecordsBGW.WorkerSupportsCancellation = True
            ContractRecordsBGW.CancelAsync()
        End Try

        If ContractRecordsBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        QueryFunction = "DECLARE @SearchString VARCHAR(MAX) = '%" & SearchString & "%'

                                         SELECT DISTINCT [ClientList_TBL].[PD_ID],
				                                         [ClientList_TBL].[CLIENTS_NAME] AS [Client's Name],
				                                         [ClientList_TBL].[COMPANY_NAME] AS [Company Name],
				                                         IIF([AE_ClientList_TBL].[FULLNAME] IS NULL,'',[AE_ClientList_TBL].[FULLNAME]) AS [AE Incharge],
				                                         IIF([EI_ClientList_TBL].[FULLNAME] IS NULL,'',[EI_ClientList_TBL].[FULLNAME]) AS [Engineer Incharge],
				                                         [ClientList_TBL].[FULLADD] AS [Full Address]"
                        QueryBody = " FROM
	                                         ( 
		                                        SELECT DISTINCT [ACCT].[AUTONUM],
					                                            [ACCT].[FULLNAME],
					                                            [EI].[PD_ID_REF]
	                                            FROM [A_NEW_EI_ASSIGNMENT][EI]
		                                             JOIN [KMDI_ACCT_TB][ACCT]
			                                              ON [EI].EI_ID_REF = [ACCT].AUTONUM
	                                         ) AS EI_ClientList_TBL
	                                         RIGHT JOIN
			                                           ( Select Distinct [Project_Details_TBL].[PD_ID],
								                                         [Contracts_TBL].[JOB_ORDER_NO],
                                                                         [Contracts_TBL].[SUB_JO],
								                                         [Contracts_TBL].[QUOTE_REF_NO],
								                                         [Owners_Details_TBL].[CLIENTS_NAME],
								                                         [Owners_Details_TBL].[OWNERS_NAME],	
								                                         [Owners_Details_TBL].[COMPANY_NAME],
								                                         [Owners_Details_TBL].[CUST_REF_NO],
								                                         [Owners_Details_TBL].[CLIENTS_CONTACT_NO],
								                                         [Owners_Details_TBL].[CLIENTS_CONTACT_OFFICE],
								                                         [Owners_Details_TBL].[CLIENTS_CONTACT_MOBILE],
								                                         [Owners_Details_TBL].[CLIENTS_EMAIL_ADD],
								                                         [Project_Details_TBL].[UNITNO],
								                                         [Project_Details_TBL].[ESTABLISHMENT],
								                                         [Project_Details_TBL].[NO],
								                                         [Project_Details_TBL].[STREET],
								                                         [Project_Details_TBL].[VILLAGE],
								                                         [Project_Details_TBL].[BRGY_MUNICIPALITY],
								                                         [Project_Details_TBL].[TOWN_DISTRICT],
								                                         [Project_Details_TBL].[PROVINCE],
								                                         [Project_Details_TBL].[AREA],
								                                         [Project_Details_TBL].[FULLADD],
																		 [Owners_TBL].[CLIENT_STATUS]
				                                        FROM [A_NEW_CONTRACT_DETAILS] [Contracts_TBL]
					                                         JOIN	[A_NEW_PROJECT_DETAILS] [Project_Details_TBL]
						                                            JOIN	[A_NEW_OWNERS_TBL] [Owners_TBL]
							                                                JOIN	[A_NEW_CLIENT_DETAILS] [Owners_Details_TBL]
							                                                        ON    [Owners_TBL].[CUST_ID_REF] = [Owners_Details_TBL].[CUST_ID]
						                                                    ON	[Project_Details_TBL].[PD_ID] = [Owners_TBL].[PD_ID_REF]
					                                                ON	[Contracts_TBL].[PD_ID_REF] = [Project_Details_TBL].[PD_ID]
			                                          ) AS ClientList_TBL
			                                          LEFT JOIN
					                                           ( SELECT DISTINCT [ACCT].[AUTONUM],
										                                         [ACCT].[FULLNAME],
										                                         [AE].[PD_ID_REF]
						                                         FROM [A_NEW_AE_ASSIGNMENT][AE]
							                                          JOIN [KMDI_ACCT_TB][ACCT]
								                                           ON [AE].[AE_ID_REF] = [ACCT].[AUTONUM]
					                                           ) AS AE_ClientList_TBL
				                                               ON [ClientList_TBL].[PD_ID] = [AE_ClientList_TBL].[PD_ID_REF]
                                               ON [EI_ClientList_TBL].[PD_ID_REF] = [ClientList_TBL].[PD_ID]"
                        QueryCondition = " WHERE (ClientList_TBL.[JOB_ORDER_NO] LIKE @SearchString OR
                                                  ClientList_TBL.[SUB_JO] LIKE @SearchString OR
                                                  ClientList_TBL.[QUOTE_REF_NO] LIKE @SearchString OR
	                                              ClientList_TBL.[CLIENTS_NAME] LIKE @SearchString OR
	                                              ClientList_TBL.[CLIENTS_NAME] LIKE @SearchString OR
	                                              ClientList_TBL.[OWNERS_NAME] LIKE @SearchString OR	
	                                              ClientList_TBL.[COMPANY_NAME] LIKE @SearchString OR
	                                              ClientList_TBL.[CUST_REF_NO] LIKE @SearchString OR
	                                              ClientList_TBL.[CLIENTS_CONTACT_NO] LIKE @SearchString OR
	                                              ClientList_TBL.[CLIENTS_CONTACT_OFFICE] LIKE @SearchString OR
	                                              ClientList_TBL.[CLIENTS_CONTACT_MOBILE] LIKE @SearchString OR
	                                              ClientList_TBL.[CLIENTS_EMAIL_ADD] LIKE @SearchString OR
	                                              ClientList_TBL.[FULLADD] LIKE @SearchString OR
	                                              ClientList_TBL.[UNITNO] LIKE @SearchString OR
	                                              ClientList_TBL.[ESTABLISHMENT] LIKE @SearchString OR
	                                              ClientList_TBL.[NO] LIKE @SearchString OR
	                                              ClientList_TBL.[STREET] LIKE @SearchString OR
                                                  ClientList_TBL.[VILLAGE] LIKE @SearchString OR
	                                              ClientList_TBL.[BRGY_MUNICIPALITY] LIKE @SearchString OR
	                                              ClientList_TBL.[TOWN_DISTRICT] LIKE @SearchString OR
	                                              ClientList_TBL.[PROVINCE] LIKE @SearchString OR
	                                              ClientList_TBL.[AREA] LIKE @SearchString OR
                                                  ClientList_TBL.[FULLADD] LIKE @SearchString OR  
	                                              EI_ClientList_TBL.[FULLNAME] LIKE @SearchString OR
	                                              AE_ClientList_TBL.[FULLNAME] LIKE @SearchString) AND
												  ClientList_TBL.[CLIENT_STATUS] = 'Current Owner'
                                            ORDER BY [CLIENTS_NAME] ASC, [COMPANY_NAME] ASC"
                    Case "SecondF2"
                        QueryFunction = "DECLARE @SearchString VARCHAR(MAX) = '" & SearchString & "'

                                         Select Distinct [ClientList_TBL].[PD_ID],
                                                         [ClientList_TBL].[JOB_ORDER_NO],
				                                         [ClientList_TBL].[SUB_JO] as [JO#],
				                                         [ClientList_TBL].[JOB_ORDER_NO_DATE] as [JO Date],
				                                         [ClientList_TBL].[QUOTE_REF_NO] as [Quote No.],
				                                         [ClientList_TBL].[LOCK],
                                                         [ClientList_TBL].[IMG],
				                                         [ClientList_TBL].[CLIENTS_NAME] as [Client's Name],
				                                         [ClientList_TBL].[COMPANY_NAME] as [Company Name],
				                                         iif([AE_ClientList_TBL].[FULLNAME] is null,'',[AE_ClientList_TBL].[FULLNAME]) as [AE Incharge],
				                                         iif([EI_ClientList_TBL].[FULLNAME] is null,'',[EI_ClientList_TBL].[FULLNAME]) as [Engineer Incharge],
				                                         [ClientList_TBL].[FULLADD] as [Full Address]"
                        QueryBody = " From
	                                        ( Select Distinct [ACCT].[AUTONUM],
					                                          [ACCT].[FULLNAME],
					                                          [EI].[PD_ID_REF]
	                                          From [A_NEW_EI_ASSIGNMENT][EI]
		                                           Join [KMDI_ACCT_TB][ACCT]
			                                          On [EI].EI_ID_REF = [ACCT].AUTONUM
	                                          ) as EI_ClientList_TBL
	                                          RIGHT JOIN
			                                            ( Select Distinct [Project_Details_TBL].[PD_ID],
								                                          [Contracts_TBL].[SUB_JO],
								                                          [Contracts_TBL].[JOB_ORDER_NO],
								                                          [Contracts_TBL].[JOB_ORDER_NO_DATE],
								                                          [Contracts_TBL].[QUOTE_REF_NO],
								                                          [Contracts_TBL].[LOCK],
								                                          [Contracts_TBL].[IMG],
								                                          [Owners_Details_TBL].[CLIENTS_NAME],
								                                          [Owners_Details_TBL].[OWNERS_NAME],	
								                                          [Owners_Details_TBL].[COMPANY_NAME],
								                                          [Owners_Details_TBL].[CUST_REF_NO],
								                                          [Owners_Details_TBL].[CLIENTS_CONTACT_NO],
								                                          [Owners_Details_TBL].[CLIENTS_CONTACT_OFFICE],
								                                          [Owners_Details_TBL].[CLIENTS_CONTACT_MOBILE],
								                                          [Owners_Details_TBL].[CLIENTS_EMAIL_ADD],
								                                          [Project_Details_TBL].[UNITNO],
								                                          [Project_Details_TBL].[ESTABLISHMENT],
								                                          [Project_Details_TBL].[NO],
								                                          [Project_Details_TBL].[STREET],
								                                          [Project_Details_TBL].[VILLAGE],
								                                          [Project_Details_TBL].[BRGY_MUNICIPALITY],
								                                          [Project_Details_TBL].[TOWN_DISTRICT],
								                                          [Project_Details_TBL].[PROVINCE],
								                                          [Project_Details_TBL].[AREA],
								                                          [Project_Details_TBL].[FULLADD],
																		  [Owners_TBL].[CLIENT_STATUS]
				                                          From [A_NEW_CONTRACT_DETAILS] [Contracts_TBL]
					                                           JOIN	[A_NEW_PROJECT_DETAILS] [Project_Details_TBL]
						                                          JOIN	[A_NEW_OWNERS_TBL] [Owners_TBL]
							                                          JOIN	[A_NEW_CLIENT_DETAILS] [Owners_Details_TBL]
							                                          ON    [Owners_TBL].[CUST_ID_REF] = [Owners_Details_TBL].[CUST_ID]
						                                          ON	[Project_Details_TBL].[PD_ID] = [Owners_TBL].[PD_ID_REF]
					                                           ON	[Contracts_TBL].[PD_ID_REF] = [Project_Details_TBL].[PD_ID]
			                                             ) as ClientList_TBL
			                                             LEFT JOIN
						                                          ( Select Distinct [ACCT].[AUTONUM],
										                                            [ACCT].[FULLNAME],
										                                            [AE].[PD_ID_REF]
						                                            From [A_NEW_AE_ASSIGNMENT][AE]
							                                             Join [KMDI_ACCT_TB][ACCT]
								                                            On [AE].[AE_ID_REF] = [ACCT].[AUTONUM]
						                                          ) as AE_ClientList_TBL
				                                         On [ClientList_TBL].[PD_ID] = [AE_ClientList_TBL].[PD_ID_REF]
                                              On [EI_ClientList_TBL].[PD_ID_REF] = [ClientList_TBL].[PD_ID]"
                        Select Case SearchScope
                            Case "Broad"
                                QueryCondition = "  WHERE (ClientList_TBL.[JOB_ORDER_NO] like '%" & SearchString & "%' or
                                                           ClientList_TBL.[SUB_JO] like '%" & SearchString & "%' or
                                                           ClientList_TBL.[QUOTE_REF_NO] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CLIENTS_NAME] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CLIENTS_NAME] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[OWNERS_NAME] like '%" & SearchString & "%' or	
	                                                       ClientList_TBL.[COMPANY_NAME] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CUST_REF_NO] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CLIENTS_CONTACT_NO] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CLIENTS_CONTACT_OFFICE] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CLIENTS_CONTACT_MOBILE] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[CLIENTS_EMAIL_ADD] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[FULLADD] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[UNITNO] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[ESTABLISHMENT] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[NO] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[STREET] like '%" & SearchString & "%' or
                                                           ClientList_TBL.[VILLAGE] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[BRGY_MUNICIPALITY] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[TOWN_DISTRICT] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[PROVINCE] like '%" & SearchString & "%' or
	                                                       ClientList_TBL.[AREA] like '%" & SearchString & "%' or
                                                           ClientList_TBL.[FULLADD] like '%" & SearchString & "%' or
	                                                       EI_ClientList_TBL.[FULLNAME] like '%" & SearchString & "%' or
	                                                       AE_ClientList_TBL.[FULLNAME] like '%" & SearchString & "%') and
													       ClientList_TBL.[CLIENT_STATUS] = 'Current Owner'
                                                    ORDER BY [JOB_ORDER_NO_DATE] DESC, [LOCK] DESC, [CLIENTS_NAME] ASC, [COMPANY_NAME] ASC "
                            Case "Specific"
                                QueryCondition = "  WHERE (ClientList_TBL.[PD_ID] = @SearchString) and
													       ClientList_TBL.[CLIENT_STATUS] = 'Current Owner'
                                                    ORDER BY [JOB_ORDER_NO_DATE] DESC, [LOCK] DESC, [CLIENTS_NAME] ASC, [COMPANY_NAME] ASC "
                        End Select

                    Case "ItemSearchInitialF2"
                        QueryFunction = "DECLARE @SearchString VARCHAR(MAX) = '%" & SearchString & "%'
                                         SELECT DISTINCT [Contract_TBL].[PD_ID],
				                                         [Contract_TBL].[Client's Name],
				                                         [Contract_TBL].[Company Name],
				                                         [Contract_TBL].[AE Incharge],
				                                         [Contract_TBL].[Engineer Incharge],
				                                         [Contract_TBL].[Full Address]"
                        QueryBody = " FROM
	                                        (
		                                        SELECT DISTINCT [ClientList_TBL].[PD_ID],
						                                        [ClientList_TBL].[SUB_JO] AS [JO#],
						                                        [ClientList_TBL].[JOB_ORDER_NO_DATE] AS [JO Date],
						                                        [ClientList_TBL].[JOB_ORDER_NO] AS [JO ID],
						                                        [ClientList_TBL].[QUOTE_REF_NO] AS [Quote No.],
						                                        [ClientList_TBL].[LOCK],
						                                        [ClientList_TBL].[IMG],
						                                        [ClientList_TBL].[CLIENTS_NAME] AS [Client's Name],
						                                        [ClientList_TBL].[COMPANY_NAME] AS [Company Name],
						                                        IIF([AE_ClientList_TBL].[FULLNAME] IS NULL,'',[AE_ClientList_TBL].[FULLNAME]) AS [AE Incharge],
						                                        IIF([EI_ClientList_TBL].[FULLNAME] IS NULL,'',[EI_ClientList_TBL].[FULLNAME]) AS [Engineer Incharge],
						                                        [ClientList_TBL].[FULLADD] AS [Full Address]
		                                        FROM
			                                        ( 
				                                        SELECT DISTINCT [ACCT].[AUTONUM],
								                                        [ACCT].[FULLNAME],
								                                        [EI].[PD_ID_REF]
				                                        FROM [A_NEW_EI_ASSIGNMENT][EI]
					                                         JOIN [KMDI_ACCT_TB][ACCT]
						                                        ON [EI].EI_ID_REF = [ACCT].AUTONUM
			                                        ) AS EI_ClientList_TBL
				                                         RIGHT JOIN
							                                        ( 
								                                        SELECT DISTINCT [Project_Details_TBL].[PD_ID],
												                                        [Contract_Details_TBL].[SUB_JO],
												                                        [Contract_Details_TBL].[JOB_ORDER_NO],
												                                        [Contract_Details_TBL].[JOB_ORDER_NO_DATE],
												                                        [Contract_Details_TBL].[QUOTE_REF_NO],
												                                        [Contract_Details_TBL].[LOCK],
												                                        [Contract_Details_TBL].[IMG],
												                                        [Owners_Details_TBL].[CLIENTS_NAME],
												                                        [Owners_Details_TBL].[OWNERS_NAME],	
												                                        [Owners_Details_TBL].[COMPANY_NAME],
												                                        [Owners_Details_TBL].[CUST_REF_NO],
												                                        [Owners_Details_TBL].[CLIENTS_CONTACT_NO],
												                                        [Owners_Details_TBL].[CLIENTS_CONTACT_OFFICE],
												                                        [Owners_Details_TBL].[CLIENTS_CONTACT_MOBILE],
												                                        [Owners_Details_TBL].[CLIENTS_EMAIL_ADD],
												                                        [Project_Details_TBL].[UNITNO],
												                                        [Project_Details_TBL].[ESTABLISHMENT],
												                                        [Project_Details_TBL].[NO],
												                                        [Project_Details_TBL].[STREET],
												                                        [Project_Details_TBL].[VILLAGE],
												                                        [Project_Details_TBL].[BRGY_MUNICIPALITY],
												                                        [Project_Details_TBL].[TOWN_DISTRICT],
												                                        [Project_Details_TBL].[PROVINCE],
												                                        [Project_Details_TBL].[AREA],
												                                        [Project_Details_TBL].[FULLADD]
								                                        FROM [A_NEW_CONTRACT_DETAILS] [Contract_Details_TBL]
									                                         JOIN	[A_NEW_PROJECT_DETAILS] [Project_Details_TBL]
											                                        JOIN	[A_NEW_OWNERS_TBL] [Owners_TBL]
													                                        JOIN	[A_NEW_CLIENT_DETAILS] [Owners_Details_TBL]
															                                        ON    [Owners_TBL].[CUST_ID_REF] = [Owners_Details_TBL].[CUST_ID]
													                                        ON	[Project_Details_TBL].[PD_ID] = [Owners_TBL].[PD_ID_REF]
											                                        ON	[Contract_Details_TBL].[PD_ID_REF] = [Project_Details_TBL].[PD_ID]
							                                        ) AS ClientList_TBL
								                                         LEFT JOIN
											                                        ( 
												                                        SELECT DISTINCT [ACCT].[AUTONUM],
																                                        [ACCT].[FULLNAME],
																                                        [AE].[PD_ID_REF]
												                                        FROM [A_NEW_AE_ASSIGNMENT][AE]
													                                         JOIN [KMDI_ACCT_TB][ACCT]
														                                          ON [AE].[AE_ID_REF] = [ACCT].[AUTONUM]
											                                        ) AS AE_ClientList_TBL
												                                         ON [ClientList_TBL].[PD_ID] = [AE_ClientList_TBL].[PD_ID_REF]
								                                         ON [EI_ClientList_TBL].[PD_ID_REF] = [ClientList_TBL].[PD_ID]
		                                        ) AS Contract_TBL
		                                        JOIN [KMDI_FABRICATION_TB][Fab_TBL]
			                                         ON [Fab_TBL].[JOB_ORDER_NO] = [Contract_TBL].[JO ID]"
                        QueryCondition = " 	WHERE [Contract_TBL].[LOCK] = '0' AND
			                                      [Fab_TBL].[DESCRIPTION] LIKE @SearchString AND
			                                      ([Fab_TBL].[STATUS] <> 'to adjust' OR
			                                       [Fab_TBL].[STATUS] <> 'to repair' OR
			                                       [Fab_TBL].[STATUS] <> 'see adjustment' OR
			                                       [Fab_TBL].[STATUS] <> 'see repair' OR
			                                       [Fab_TBL].[STATUS] <> 'see revised')
		                                    ORDER BY [Contract_TBL].[Client's Name] ASC, [Contract_TBL].[Company Name] ASC"
                    Case "ItemSearchSecondF2"
                        QueryFunction = "Select Distinct"
                        QueryBody = " [A2C].[JOB_ORDER_NO]
                                ,[A2C].[SUB_JO] as [JO#]
                                ,[A2C].[JOB_ORDER_NO_DATE] as [JO Date]
                                ,[A2C].[PROJECT_LABEL] As [Project Label]
                                ,[A2C].[CLIENTS_NAME] as [Client's Name]
                                ,[A2C].[COMPANY_NAME] as [Company Name]
                                ,[A2C].[PREV_OWNER] as [Previous Owner]
                                ,[A2C].[ACCT_EXEC_INCHARGE] as [AE In-Charge]
                                ,[A2C].[PROJECT_ENGR_INCHARGE] as [Project Engineer In-Charge]
                                ,[A2C].[FULLADD1] as [Full Address]
                                ,[A2C].[IMG]
                                ,[A2C].[LOCK]
                                ,[A2C].[PARENTJONO]
                                ,[A2C].[UNITNO]
                                ,[A2C].[ESTABLISHMENT]
                                ,[A2C].[NO]
                                ,[A2C].[STREET]
                                ,[A2C].[VILLAGE]
                                ,[A2C].[BRGY_MUNICIPALITY]
                                ,[A2C].[TOWN_DISTRICT]
                                ,[A2C].[PROVINCE]
                                ,[A2C].[AREA]
                                From [KMDI_FABRICATION_TB][FFabTB] join 
                                     [ADDENDUM_TO_CONTRACT_TB][A2C]
                                  On [FFabTB].[JOB_ORDER_NO]= [A2C].[JOB_ORDER_NO]"
                        QueryCondition = " Where [FFabTB].[DESCRIPTION] like '%" & SearchString & "%' and
                                                 [FFabTB].[DATE_DELIVERED] <> '' and
                                                 [A2C].[LOCK] = '0'
                                           Order By [JOB_ORDER_NO_DATE] Desc"
                End Select
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Private Sub ContractRecordsBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 key to refresh the system." & vbCrLf & vbCrLf & ErrorMessage, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                End Select
            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 to refresh the system." & vbCrLf & vbCrLf & ErrorMessage, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            If Read.HasRows = True Then
                                Grid_Display()
                            Else
                                SearchFRM.Hide()
                                MetroMessageBox.Show(Me, "No items where found in the database. Please refine search.", "No results found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                SearchFRM.Show()
                                SearchFRM.SearchTbox.Focus()
                            End If
                        Case "Add"
                        Case "Update"
                        Case "Delete"
                    End Select
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Private Sub ContractRecordsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ContractRecordsDGV.RowPostPaint
        Try
            sql.RowPostPaintContractRecords(sender, e)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Grid_Display()
        Try
            Select Case ActionTaken
                Case "Search"
                    Select Case SearchItemFN
                        Case "InitialF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "InitialF2"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("PD_ID").Visible = False
                                .Columns("Company Name").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                        Case "SecondF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "SecondF2"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("PD_ID").Visible = False
                                .Columns("JOB_ORDER_NO").Visible = False
                                .Columns("LOCK").Visible = False
                                .Columns("IMG").Visible = False
                                .Columns("JO#").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                            For ImageCounter As Integer = 0 To ContractRecordsDGV.Rows.Count - 1 Step +1

                                If Not ContractRecordsDGV.Rows(ImageCounter).Cells("IMG").Value = "" Then
                                    ContractRecordsDGV.Rows(ImageCounter).Cells("JO#").Style.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
                                End If

                                If ContractRecordsDGV.Rows(ImageCounter).Cells("LOCK").Value.ToString = "1" Then
                                    ContractRecordsDGV.Rows(ImageCounter).DefaultCellStyle.ForeColor = Color.Black
                                    ContractRecordsDGV.Rows(ImageCounter).DefaultCellStyle.BackColor = Color.Khaki
                                End If

                            Next

                        Case "ItemSearchInitialF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "FFabTB_Join_A2C1"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("PARENTJONO").Visible = False
                                .Columns("UNITNO").Visible = False
                                .Columns("ESTABLISHMENT").Visible = False
                                .Columns("NO").Visible = False
                                .Columns("STREET").Visible = False
                                .Columns("VILLAGE").Visible = False
                                .Columns("BRGY_MUNICIPALITY").Visible = False
                                .Columns("TOWN_DISTRICT").Visible = False
                                .Columns("PROVINCE").Visible = False
                                .Columns("AREA").Visible = False
                                .Columns("Project Label").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                        Case "ItemSearchSecondF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "FFabTB_Join_A2C2"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("JOB_ORDER_NO").Visible = False
                                .Columns("PARENTJONO").Visible = False
                                .Columns("UNITNO").Visible = False
                                .Columns("ESTABLISHMENT").Visible = False
                                .Columns("NO").Visible = False
                                .Columns("STREET").Visible = False
                                .Columns("VILLAGE").Visible = False
                                .Columns("BRGY_MUNICIPALITY").Visible = False
                                .Columns("TOWN_DISTRICT").Visible = False
                                .Columns("PROVINCE").Visible = False
                                .Columns("AREA").Visible = False
                                .Columns("IMG").Visible = False
                                .Columns("LOCK").Visible = False
                                .Columns("Project Label").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                            For ImageCounter As Integer = 0 To ContractRecordsDGV.Rows.Count - 1 Step +1
                                If Not ContractRecordsDGV.Rows(ImageCounter).Cells("IMG").Value = "" Then
                                    ContractRecordsDGV.Rows(ImageCounter).Cells("JO#").Style.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
                                End If
                            Next

                    End Select
                Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub SearchFn(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, ContractRecordsDGV.KeyDown, ContractRecordsLBL.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F2
                    Dim frm As Form = SearchFRM

                    Select Case frm.Visible
                        Case True
                            SearchFRM.BringToFront()
                        Case False
                            SearchFRM.Show()
                            SearchFRM.TopMost = True
                    End Select
                Case Keys.F5
                    Select Case SearchItemFN
                        Case "InitialF2"
                            LoadInitialSetUp()
                        Case "SecondF2"
                            StartWorker()
                        Case "ItemSearchInitialF2"
                            StartWorker()
                        Case "ItemSearchSecondF2"
                            StartWorker()
                    End Select
                Case Keys.Enter
                    Select Case SearchItemFN
                        Case "InitialF2"
                            ActionTaken = "Search"
                            SearchItemFN = "SecondF2"
                            SearchScope = "Specific"
                            StartWorker()
                        Case "SecondF2"
                            OpenScannedContract()
                        Case "ItemSearchInitialF2"
                            StartWorker()
                        Case "ItemSearchSecondF2"
                            StartWorker()
                    End Select
                Case Keys.Back
                    LoadInitialSetUp()
                Case Keys.Escape
                    e.SuppressKeyPress = True
                    Me.Close()
            End Select

            If e.Control And e.KeyCode = Keys.F Then
                SearchFRM.Show()
                SearchFRM.TopMost = True
            ElseIf e.Alt And e.KeyCode = Keys.A Then
                OpenAddress()
            ElseIf e.Alt And e.KeyCode = Keys.C Then
                Select Case SearchItemFN
                    Case "InitialF2"
                        ActionTaken = "Search"
                        SearchItemFN = "SecondF2"
                        SearchScope = "Specific"
                        StartWorker()
                    Case "SecondF2"
                        OpenContractItems()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractRecordsDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ContractRecordsDGV.RowEnter
        Try
            SearchString = ContractRecordsDGV.Item("PD_ID", e.RowIndex).Value.ToString
            Select Case ActionTaken
                Case "Search"
                    ''For add / update of client additional info
                    'ClientBackgroundFRM.JobOrderNoID = ContractRecordsDGV.Item("PARENTJONO", e.RowIndex).Value.ToString

                    ''For update of project address
                    'UpdateProjectAddressFRM.JobOrderNoID = ContractRecordsDGV.Item("PARENTJONO", e.RowIndex).Value.ToString

                    ''For update of owner
                    'UpdateOwnerFRM.JobOrderNoID = ContractRecordsDGV.Item("PARENTJONO", e.RowIndex).Value.ToString

                    Select Case SearchItemFN
                        Case "InitialF2"
                        Case "SecondF2"

                            '// For images of contracts
                            JobOrderNoID = ContractRecordsDGV.Item("JOB_ORDER_NO", e.RowIndex).Value.ToString
                            JOUserView = ContractRecordsDGV.Item("JO#", e.RowIndex).Value.ToString

                            Select Case ContractRecordsDGV.Item("IMG", e.RowIndex).Value.ToString
                                Case "yes"
                                    JOWithImage = True
                                Case Else
                                    JOWithImage = False
                            End Select

                            Select Case ContractRecordsDGV.Item("JO#", e.RowIndex).Value.ToString
                                Case ""
                                    JOWithItem = False
                                Case Nothing
                                    JOWithItem = False
                                Case Else
                                    JOWithItem = True
                            End Select

                            If ContractRecordsDGV.Item("LOCK", e.RowIndex).Value.ToString = "1" Then
                                    'BackloadToolStripMenuItem.Visible = False
                                Else
                                    ''For adding of backloads
                                    'BackloadFrameSash.JobOrderNoID = ContractRecordsDGV.Item("JOB_ORDER_NO", e.RowIndex).Value.ToString
                                    'BackloadToolStripMenuItem.Visible = True
                                    'SearchFRM.Hide()

                                End If
                                Case "ItemSearchInitialF2"
                                Case "ItemSearchSecondF2"
                            End Select
                        Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractRecordsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractRecordsDGV.CellMouseClick
        Try
            If ContractRecordsDGV.RowCount >= 0 And e.RowIndex >= 0 Then
                If e.Button = MouseButtons.Right Then
                    Select Case ActionTaken
                        Case "Search"
                            Select Case SearchItemFN
                                Case "InitialF2"
                                    ListOfView()
                                Case "SecondF2"
                                    ListOfView()
                                Case "ItemSearchInitialF2"
                                    ListOfView()
                                Case "ItemSearchSecondF2"
                                    ListOfView()
                            End Select
                            ListOfViewMenuStrip.Show()
                            ListOfViewMenuStrip.Location = New Point(MousePosition.X, MousePosition.Y)
                        Case "Add"
                        Case "Update"
                        Case "Delete"
                    End Select
                ElseIf e.Button = MouseButtons.Left Then
                    Select Case ClientBackgroundFRM.Visible
                        Case True
                            ClientBackgroundFRM.UnitNoTBOX.Text = ContractRecordsDGV.Item("UNITNO", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.EstablishmentTBOX.Text = ContractRecordsDGV.Item("ESTABLISHMENT", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.HouseNoTBOX.Text = ContractRecordsDGV.Item("NO", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.StreetTBOX.Text = ContractRecordsDGV.Item("STREET", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.VillageTBOX.Text = ContractRecordsDGV.Item("VILLAGE", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.BRGYTBOX.Text = ContractRecordsDGV.Item("BRGY_MUNICIPALITY", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.CityMunicipalityTBOX.Text = ContractRecordsDGV.Item("TOWN_DISTRICT", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.ProvinceTBOX.Text = ContractRecordsDGV.Item("PROVINCE", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.AreaTBOX.Text = ContractRecordsDGV.Item("AREA", e.RowIndex).Value.ToString
                    End Select
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ContractRecordsDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractRecordsDGV.CellMouseDoubleClick
        If e.Button = MouseButtons.Left Then
            Try
                Select Case ActionTaken
                    Case "Search"
                        Select Case SearchItemFN
                            Case "InitialF2"
                                ActionTaken = "Search"
                                SearchItemFN = "SecondF2"
                                SearchScope = "Specific"
                                StartWorker()
                            Case "SecondF2"
                                OpenScannedContract()
                            Case "ItemSearchInitialF2"
                            Case "ItemSearchSecondF2"
                        End Select
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub FrameSashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrameSashToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Frame/Sash"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "F R A M E / S A S H   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub GlassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlassToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Glass"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "G L A S S   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub ScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScreenToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Screen"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "S C R E E N   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub InstallationMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallationMaterialToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Installation Material"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "I N S T A L L A T I O N   M A T E R I A L S   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub ClientsAdditionalInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsAdditionalInfoToolStripMenuItem.Click
        ClientBackgroundFRM.Show()
        ClientBackgroundFRM.BringToFront()
        ClientBackgroundFRM.LoadInitialSetUp()
    End Sub

    Private Sub AddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddressToolStripMenuItem.Click
        OpenAddress()
    End Sub

    Public Sub OpenAddress()
        Try
            UpdateProjectAddressFRM.SearchString = SearchString
            Dim frm As Form = UpdateProjectAddressFRM

            Select Case frm.Visible
                Case True
                    UpdateProjectAddressFRM.BringToFront()
                    UpdateProjectAddressFRM.LoadInitialSetUp()
                Case False
                    UpdateProjectAddressFRM.Show()
                    UpdateProjectAddressFRM.LoadInitialSetUp()
            End Select

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "The system has encountered an error during address retrieval. After page refresh please try again. If problem persist contact the system dev team for assistance.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub OwnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OwnerToolStripMenuItem.Click
        UpdateOwnerFRM.Show()
        UpdateOwnerFRM.BringToFront()
        UpdateOwnerFRM.NODOwnersNameTBOX.Focus()
        UpdateOwnerFRM.LoadInitialSetUp()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Try
            SearchFRM.Show()
            SearchFRM.TopMost = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        LoadInitialSetUp()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        StartWorker()
    End Sub
    Private Sub ContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractsToolStripMenuItem.Click
        Try
            ActionTaken = "Search"
            SearchItemFN = "SecondF2"
            SearchScope = "Specific"

            StartWorker()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ScannedContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScannedContractsToolStripMenuItem.Click
        OpenScannedContract()
    End Sub

    Public Sub OpenScannedContract()
        Try
            Select Case JOWithImage
                Case True
                    ContractImagesFRM.SearchString = JobOrderNoID

                    Dim frm As Form = ContractImagesFRM
                    SearchFRM.Dispose()

                    Select Case frm.Visible
                        Case True
                            ContractImagesFRM.BringToFront()
                            ContractImagesFRM.LoadInitialSetUp()
                        Case Else
                            ContractImagesFRM.Show()
                    End Select

                Case False
                    MetroFramework.MetroMessageBox.Show(Me, "Please coordinate with collections department for a copy of the contract.", "No scanned copy available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub ListOfView()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = True
                        ScannedContractsToolStripMenuItem.Visible = False
                        ContractItemsToolStripMenuItem.Visible = False

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = False

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = True

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True

                    Case "SecondF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = False
                        ScannedContractsToolStripMenuItem.Visible = True
                        ContractItemsToolStripMenuItem.Visible = True

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = True

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = False

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True

                    Case "ItemSearchInitialF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = True
                        ScannedContractsToolStripMenuItem.Visible = False
                        ContractItemsToolStripMenuItem.Visible = False

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = False

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = False

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True

                    Case "ItemSearchSecondF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = False
                        ScannedContractsToolStripMenuItem.Visible = True
                        ContractItemsToolStripMenuItem.Visible = True

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = True

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = False

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True
                End Select
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Private Sub ContractRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            If MetroMessageBox.Show(Me, "Do you wish to proceed?", "Contracts form closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                KMDI_MainFRM.Show()
                KMDI_MainFRM.BringToFront()
                SearchFRM.Dispose()
                ContractItemsFRM.Dispose()
                ContractImagesFRM.Dispose()
                Dispose()
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ContractItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractItemsToolStripMenuItem.Click
        OpenContractItems()
    End Sub

    Public Sub OpenContractItems()
        Try
            Select Case JOWithItem
                Case True
                    ContractItemsFRM.SearchString = JobOrderNoID
                    ContractItemsFRM.ContractRecordsLBL.Text = JOUserView

                    Dim frm As Form = ContractItemsFRM
                    SearchFRM.Dispose()

                    Select Case frm.Visible
                        Case True
                            ContractItemsFRM.BringToFront()
                            ContractItemsFRM.LoadInitialSetUp()
                        Case Else
                            ContractItemsFRM.Show()
                    End Select

                Case False
                    MetroMessageBox.Show(Me, "Please coordinate with collections department for a copy of the contract.", "No item information available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class