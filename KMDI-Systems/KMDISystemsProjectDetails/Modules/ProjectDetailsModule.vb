Imports System.Data.SqlClient
Imports System.IO
Module ProjectDetailsModule
    Public sqlcnstr As String = "Data Source='121.58.229.248,49107';Network Library=DBMSSOCN;Initial Catalog='heretosave';User ID='kmdiadmin';Password='kmdiadmin';"

    Public is_CTD_bool As Boolean = False ' True if searching for Contracts, False if searching for Projects
    Public is_SalesJobOrder_bool As Boolean = False ' True if PD_SalesJobOrder.Show, False if not
    Public SearchStr As String = Nothing

    Public QueryBUILD As String
    Public SelDist As String = "SELECT DISTINCT"
    Public QUERY_INSTANCE As String = Nothing

    Public PD_CountSuccess As Integer = 0
    Public InsertedPD_ID As Integer = Nothing, InsertedCustID As Integer = Nothing, InsertedC_ID As Integer = Nothing
    Public ErrorMsg, ErrorNum As String

    Public PD_ID, CUST_ID, OWN_REP_ID, C_ID As Integer
    Public TPN_ID, TPN_ID_SearchIfDeleted As Integer
    Public PD_Addendum_Update_QuoteRefNo_counter As Integer = 0

    Public ArchDesignBS, IntrDesignBS, ConsMngmtBS, GenConBS As New BindingSource
    'Public QuoteNoBS As New BindingSource

    Public ADDTCols, IDDTCols, CMDTCols, GCDTCols As DataColumn
    Public ArchDesignDT As DataTable = New DataTable("ArchDesignDT")
    Public IntrDesignDT As DataTable = New DataTable("IntrDesignDT")
    Public ConsMngmtDT As DataTable = New DataTable("ConsMngmtDT")
    Public GenConDT As DataTable = New DataTable("GenConDT")
    'Public QuoteNoDT As DataTable = New DataTable("QuoteNoDT")
    Public DTcols_str As String() = {"OFFICENAME", "NAME", "POSITION", "CONTACT NUMBER", "COMP_ID", "EMP_ID", "TP_ID", "TPN_ID"}

    Public arr_WD_ID As New List(Of Integer)
    Public arr_CQN_ID_UponLoad As New List(Of Integer)
    Public arr_Profile_finish As New List(Of String)
    Public arr_Quote_Date As New List(Of Date)
    Public arr_CQN_ID_UponSearch As New List(Of Integer)
    Public arr_AEID As New List(Of Integer)

    Public COMP_ID As String = Nothing,
           COMP_NAME As String = Nothing,
           EMP_ID As String = Nothing,
           EMP_NAME As String = Nothing,
           EMP_MOBILENO As String = Nothing,
           EMP_POSITION As String = Nothing 'used in Technical Partners

    Public sql_Err_no, sql_Err_msg, sql_Transaction_result As String

    Public Log_File As StreamWriter

    Public transaction As SqlTransaction

    Public QuerySearchHeadArrays() As String = {SelDist & " TOP 100 [PD].[PD_ID],
                                                                    [CTD].[SUB_JO] AS [JO#],
                                                                    [PD].[PROJECT_LABEL] AS [PROJECT LABEL],
                                                                    [PD].[FULLADD] AS [ADDRESS]", '0 SELECT ON PROJECT_DETAILS.VB
                                                SelDist & " TOP 100   CTD_PD_OWN_CLD_TBL.[PD_ID],
						                                              CTD_PD_OWN_CLD_TBL.[ContractsID] as [ID],
                                                                      CTD_PD_OWN_CLD_TBL.[SUB_JO] AS [JO#],
						                                              CTD_PD_OWN_CLD_TBL.[CLIENTS_NAME] AS [CLIENT'S NAME],
						                                              CTD_PD_OWN_CLD_TBL.[OWNERS_NAME] AS [OWNER'S NAME],
                                                                      CTD_PD_OWN_CLD_TBL.[CLIENT_STATUS] AS [CLIENT'S STATUS],
						                                              CTD_PD_OWN_CLD_TBL.[FULLADD] AS [ADDRESS]
						                                              --iif(AE_ACCT_TBL.FULLNAME is null,'',AE_ACCT_TBL.FULLNAME) as [AE ASSIGNED],
						                                              --iif(EI_ACCT_TBL.FULLNAME is null,'',EI_ACCT_TBL.FULLNAME) as [EI ASSIGNED],
						                                              ", '1 SELECT ON CONTRACTS IN PROJECT_DETAILS.VB
                                                "SELECT     [ACCT].[AUTONUM],
				                                            [ACCT].[FULLNAME],
				                                            [EI].[PD_ID_REF]", '2
                                                SelDist & " [PD].[PD_ID],
						                                    [CTD].[CD_ID] as [ContractsID],
						                                    [CTD].[SUB_JO],
                                                            [CTD].[STATUS_AVAILABILITY],
						                                    [CLD].[CLIENTS_NAME],
						                                    [CLD].[OWNERS_NAME],
						                                    [OWN].[CLIENT_STATUS],
						                                    [PD].[FULLADD],
															[PD].[PD_STATUS]", '3
                                                 "SELECT	[ACCT].[AUTONUM],
				                                            [ACCT].[FULLNAME],
				                                            [AE].[PD_ID_REF],
                                                            [AE].[AE_STATUS]", '4
                                                 "SELECT    * ",              '5
                                                 SelDist & "    [CD].COMPANY_NAME,
					                                            [CD].CUST_REF_NO,
					                                            [CD].CLIENTS_NAME,
					                                            [CD].OWNERS_NAME,
					                                            [CD].CUST_ID,
																[CD].[CLIENTS_CONTACT_NO],
                                                                [CD].[CLIENTS_CONTACT_OFFICE],
                                                                [CD].[CLIENTS_CONTACT_MOBILE]"  '6
    }

    Public QueryMidArrays() As String = {" FROM [A_NEW_PROJECT_DETAILS]  [PD]
                                                JOIN [A_NEW_CONTRACT_DETAILS] [CTD]
                                                ON [PD].[PD_ID] = [CTD].[PD_ID_REF] ", '0 JOIN PD N' CTD
                                         " FROM	[A_NEW_EI_ASSIGNMENT] [EI]
		                                        JOIN	[KMDI_ACCT_TB] [ACCT]
		                                        ON   [EI].EI_ID_REF = [ACCT].AUTONUM ", '1 JOIN EI N' ACCT_TB
                                         " FROM	[A_NEW_CONTRACT_DETAILS] [CTD]
			                                JOIN	[A_NEW_PROJECT_DETAILS] [PD]
				                                JOIN	[A_NEW_OWNERS_TBL] [OWN]
					                                JOIN	[A_NEW_CLIENT_DETAILS] [CLD]
					                                ON		[OWN].CUST_ID_REF = [CLD].CUST_ID
				                                ON	[PD].PD_ID = [OWN].PD_ID_REF
			                                ON	[CTD].PD_ID_REF = [PD].PD_ID ", '2 JOIN CTD > PD > OWN > CLD
                                         " FROM	[A_NEW_AE_ASSIGNMENT] [AE]
		                                        JOIN	[KMDI_ACCT_TB] [ACCT]
		                                        ON	[AE].AE_ID_REF = [ACCT].AUTONUM ", '3 JOIN AE N' ACCT_TB
                                         " FROM	[A_NEW_WINDOOR_DETAILS] [WD]
												JOIN [A_NEW_CONTRACT_QUOTE_NO] [CQN]
                                                    JOIN	[A_NEW_CONTRACT_DETAILS] [CTD]
			                                            JOIN    [A_NEW_PROJECT_DETAILS] [PD]
                                                        ON      [CTD].PD_ID_REF = [PD].PD_ID 
										            ON  [CQN].CD_ID_REF = [CTD].CD_ID
												ON WD.WD_ID = CQN.WD_ID_REF ", '4 JOIN WD > CQN > CTD > PD
                                         " FROM	[A_NEW_PROJECT_DETAILS] [PD]
			                                    JOIN	[A_NEW_OWNERS_TBL] [OWN]
				                                    JOIN	[A_NEW_CLIENT_DETAILS] [CD]
				                                    ON		[OWN].CUST_ID_REF = [CD].CUST_ID
			                                    ON		[PD].PD_ID = [OWN].PD_ID_REF ",   '5 JOIN PD > OWN > CD 
                                         " JOIN A_NEW_TECHNICAL_PARTNERS_NATURE [TP_NATURE]
		                                     JOIN A_NEW_CONTRACT_DETAILS [CD]
			                                     JOIN A_NEW_PROJECT_DETAILS [PD]
			                                     ON	 CD.PD_ID_REF = PD.PD_ID
		                                     ON	 TP_NATURE.CD_ID_REF = CD.CD_ID ", '6 JOIN (COMP_EMP_REL) > COMP_EMP_CD_LINK > CD > PD
                                         " FROM	A_NEW_COMPANY_DETAILS [COMP]
				                           JOIN	A_NEW_TECHNICAL_PARTNERS [TP]
					                           JOIN	A_NEW_EMPLOYEE_DETAILS [EMP]
					                           ON		[TP].EMP_ID_REF = EMP.EMP_ID
				                           ON	COMP.COMP_ID = [TP].COMP_ID_REF ", ' 7 JOIN COMP > COM_EMP_REL > EMP
                                         " FROM	A_NEW_COMPANY_DETAILS [COMP]
	                                        FULL JOIN	A_NEW_TECHNICAL_PARTNERS [TP]
		                                        FULL JOIN	A_NEW_EMPLOYEE_DETAILS [EMP]
		                                        ON		TP.EMP_ID_REF = EMP.EMP_ID
	                                        ON		COMP.COMP_ID = TP.COMP_ID_REF ",  ' 8 FULL JOIN COMP > TP > EMP
                                         "  FROM	A_NEW_COMPANY_DETAILS [COMP]
	                                        JOIN	A_NEW_TECHNICAL_PARTNERS [TP]
		                                        JOIN	A_NEW_EMPLOYEE_DETAILS [EMP]
		                                        ON		TP.EMP_ID_REF = EMP.EMP_ID
	                                        ON		COMP.COMP_ID = TP.COMP_ID_REF ", '9 JOIN COMP > TP > EMP
                                         " FROM	[dbo].[A_NEW_PROJECT_DETAILS] [PD]
	                                            JOIN	[dbo].[A_NEW_OWNERS_REP] [OWN_REP]
		                                            JOIN	[dbo].[A_NEW_CLIENT_DETAILS] [CLD]
		                                            ON		OWN_REP.CUST_ID_REF = CLD.CUST_ID
	                                            ON		PD.PD_ID = OWN_REP.PD_ID_REF ", '10 JOIN PD > OWN_REP > CLD
                                         " FROM	A_NEW_CONTRACT_DETAILS [CTD]
	                                        JOIN	A_NEW_CONTRACT_QUOTE_NO [CQN]
		                                        JOIN	A_NEW_WINDOOR_DETAILS [WD] 
		                                        ON CQN.WD_ID_REF = WD.WD_ID
	                                        ON	CTD.CD_ID = CD_ID_REF " '11 JOIN CD > CQN > WD
    }

    Public QueryConditionArrays() As String = {"WHERE ([PD].[PD_ID] like @SearchString OR
                                                      [PD].[PROJECT_LABEL] like @SearchString OR
                                                      [PD].[ACTIVITIES] like @SearchString OR
                                                      [PD].[REFFERED_BY] like @SearchString OR
                                                      [PD].[PROJECT_SOURCE] like @SearchString OR
                                                      [PD].[PROJECT_CLASSIFICATION] like @SearchString OR
                                                      [PD].[COMPETITORS] like @SearchString OR
                                                      [PD].[PROFILE_FINISH0] like @SearchString OR
                                                      [PD].[PRODUCT_TYPE] like @SearchString OR
                                                      [PD].[UNITNO] like @SearchString OR
                                                      [PD].[ESTABLISHMENT] like @SearchString OR
                                                      [PD].[NO] like @SearchString OR
                                                      [PD].[STREET] like @SearchString OR
                                                      [PD].[VILLAGE] like @SearchString OR
                                                      [PD].[BRGY_MUNICIPALITY] like @SearchString OR
                                                      [PD].[TOWN_DISTRICT] like @SearchString OR
                                                      [PD].[PROVINCE] like @SearchString OR
                                                      [PD].[AREA] like @SearchString OR
                                                      [PD].[FULLADD] like @SearchString OR
                                                      [PD].[CONSTRUCTION_STAGE] like @SearchString OR
                                                      [PD].[PERTINENT_DETAILS] like @SearchString OR
                                                      [CTD].[JOB_ORDER_NO] like @SearchString) AND [PD_STATUS] = 1 AND [JOB_ORDER_NO] = [PARENTJONO] ", '0 SEARCH ON PD
                                               "WHERE [PD_ID] = @EqualSearch AND [PD_STATUS] = 1 ", '1
                                               "WHERE [CTD].[CD_ID] = @EqualSearch AND [CTD].[STATUS_AVAILABILITY] = 1 "  '2
    }

    Public QueryORDERArrays() As String = {"ORDER BY [PD].[PD_ID] DESC", '0
                                           "ORDER BY CTD_PD_OWN_CLD_TBL.PD_ID DESC" '1
    }
    Public Sub Query_Select(ByVal SearchString As String)

        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        sqlDataSet.Clear()
        sqlBindingSource.Clear()

        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(QueryBUILD, sqlcon)
                Select Case QUERY_INSTANCE
                    Case "Loading_using_SearchString"
                        sqlCommand.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                    Case "Loading_using_EqualSearch"
                        is_SalesJobOrder_bool = True
                        sqlCommand.Parameters.AddWithValue("@EqualSearch", SearchString)
                End Select
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter.Fill(sqlDataSet, "QUERY_DETAILS")
                sqlBindingSource.DataSource = sqlDataSet
                sqlBindingSource.DataMember = "QUERY_DETAILS"
            End Using
        End Using
    End Sub

    Public QUERY_SELECT_WITH_READER_VAL As String
    Public QUERY_SELECT_WITH_READER_bool As Boolean
    Public Sub QUERY_SELECT_WITH_READER(ByVal SearchString As String,
                                        ByVal ReadBy As String)
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(QueryBUILD, sqlcon)
                Select Case QUERY_INSTANCE
                    Case "Read_using_SearchString"
                        sqlCommand.Parameters.AddWithValue("@SearchString", SearchString)
                End Select
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    If read.HasRows Then
                        QUERY_SELECT_WITH_READER_bool = True
                        Select Case ReadBy
                            Case "QuoteRefNo_Sel"
                                arr_WD_ID.Add(read.Item("WD_ID"))
                                arr_Quote_Date.Add(read.Item("QUOTE_DATE"))
                                arr_Profile_finish.Add(read.Item("PROFILE_FINISH"))
                        End Select
                    Else
                        QUERY_SELECT_WITH_READER_bool = False
                    End If
                End Using
            End Using
        End Using
    End Sub
    Public TP_ID As String
    Public Sub SEARCH_TP_ID(ByVal COMP_ID_REF As String,
                            ByVal EMP_ID_REF As String,
                            ByVal POSITION As String)
        Query = "SELECT TP_ID FROM [A_NEW_TECHNICAL_PARTNERS] WHERE [COMP_ID_REF] = @COMP_ID_REF AND 
                                                                    [EMP_ID_REF] = @EMP_ID_REF AND
                                                                    [POSITION] = @POSITION"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@COMP_ID_REF", COMP_ID_REF)
                sqlCommand.Parameters.AddWithValue("@EMP_ID_REF", EMP_ID_REF)
                sqlCommand.Parameters.AddWithValue("@POSITION", POSITION)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    If read.HasRows Then
                        TP_ID = read.Item("TP_ID")
                    Else
                        TP_ID = Nothing
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub A_NEW_PROJECT_DETAILS_Insert(ByVal Formname As Form,
                                            Optional PROJECT_SOURCE As String = "",
                                            Optional PROJECT_CLASSIFICATION As String = "",
                                            Optional COMPETITORS As String = "",
                                            Optional UNITNO As String = "",
                                            Optional ESTABLISHMENT As String = "",
                                            Optional NO As String = "",
                                            Optional STREET As String = "",
                                            Optional VILLAGE As String = "",
                                            Optional BRGY_MUNICIPALITY As String = "",
                                            Optional TOWN_DISTRICT As String = "",
                                            Optional PROVINCE As String = "",
                                            Optional AREA As String = "",
                                            Optional FULLADD As String = "")

        Query = "INSERT INTO [A_NEW_PROJECT_DETAILS]   ([PROJECT_SOURCE],
                                                        [PROJECT_CLASSIFICATION],
                                                        [COMPETITORS],
                                                        [UNITNO],
                                                        [ESTABLISHMENT],
                                                        [NO],
                                                        [STREET],
                                                        [VILLAGE],
                                                        [BRGY_MUNICIPALITY],
                                                        [TOWN_DISTRICT],
                                                        [PROVINCE],
                                                        [AREA],
                                                        [FULLADD])

                                              VALUES   (@PROJECT_SOURCE,
                                                        @PROJECT_CLASSIFICATION,
                                                        @COMPETITORS,
                                                        @UNITNO,
                                                        @ESTABLISHMENT,
                                                        @NO,
                                                        @STREET,
                                                        @VILLAGE,
                                                        @BRGY_MUNICIPALITY,
                                                        @TOWN_DISTRICT,
                                                        @PROVINCE,
                                                        @AREA,
                                                        @FULLADD)
                SELECT @@IDENTITY AS [ID]"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@PROJECT_SOURCE", PROJECT_SOURCE)
                sqlCommand.Parameters.AddWithValue("@PROJECT_CLASSIFICATION", PROJECT_CLASSIFICATION)
                sqlCommand.Parameters.AddWithValue("@COMPETITORS", COMPETITORS)
                sqlCommand.Parameters.AddWithValue("@UNITNO", UNITNO)
                sqlCommand.Parameters.AddWithValue("@ESTABLISHMENT", ESTABLISHMENT)
                sqlCommand.Parameters.AddWithValue("@NO", NO)
                sqlCommand.Parameters.AddWithValue("@STREET", STREET)
                sqlCommand.Parameters.AddWithValue("@VILLAGE", VILLAGE)
                sqlCommand.Parameters.AddWithValue("@BRGY_MUNICIPALITY", BRGY_MUNICIPALITY)
                sqlCommand.Parameters.AddWithValue("@TOWN_DISTRICT", TOWN_DISTRICT)
                sqlCommand.Parameters.AddWithValue("@PROVINCE", PROVINCE)
                sqlCommand.Parameters.AddWithValue("@AREA", AREA)
                sqlCommand.Parameters.AddWithValue("@FULLADD", FULLADD)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    While read.Read
                        InsertedPD_ID = read.Item("ID").ToString
                    End While
                    If InsertedPD_ID <> Nothing Then
                        PD_CountSuccess += 1
                    Else
                        MetroFramework.MetroMessageBox.Show(Formname, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ErrorMsg += " Here @A_NEW_PROJECT_DETAILS_Insert"
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub A_NEW_CLIENT_DETAILS_Insert(ByVal Formname As Form,
                                            Optional CLIENTS_NAME As String = "",
                                            Optional OWNERS_NAME As String = "",
                                            Optional CLIENTS_CONTACT_NO As String = "",
                                            Optional CLIENTS_CONTACT_OFFICE As String = "",
                                            Optional CLIENTS_CONTACT_MOBILE As String = "",
                                            Optional CLIENTS_EMAIL_ADD As String = "",
                                            Optional COMPANY_NAME As String = "")
        Query = "INSERT INTO [A_NEW_CLIENT_DETAILS]    ([CLIENTS_NAME],
                                                        [OWNERS_NAME],
                                                        [CLIENTS_CONTACT_NO],
                                                        [CLIENTS_CONTACT_OFFICE],
                                                        [CLIENTS_CONTACT_MOBILE],
                                                        [CLIENTS_EMAIL_ADD],
                                                        [COMPANY_NAME])

                                              VALUES   (@CLIENTS_NAME,
                                                        @OWNERS_NAME,
                                                        @CLIENTS_CONTACT_NO,
                                                        @CLIENTS_CONTACT_OFFICE,
                                                        @CLIENTS_CONTACT_MOBILE,
                                                        @CLIENTS_EMAIL_ADD,
                                                        @COMPANY_NAME)
                SELECT @@IDENTITY AS [ID]"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_NAME", CLIENTS_NAME)
                sqlCommand.Parameters.AddWithValue("@OWNERS_NAME", OWNERS_NAME)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_NO", CLIENTS_CONTACT_NO)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_OFFICE", CLIENTS_CONTACT_OFFICE)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_MOBILE", CLIENTS_CONTACT_MOBILE)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_EMAIL_ADD", CLIENTS_EMAIL_ADD)
                sqlCommand.Parameters.AddWithValue("@COMPANY_NAME", COMPANY_NAME)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    While read.Read
                        InsertedCustID = read.Item("ID").ToString
                    End While
                    If InsertedCustID <> Nothing Then
                        PD_CountSuccess += 1
                    Else
                        MetroFramework.MetroMessageBox.Show(Formname, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ErrorMsg += " Here @A_NEW_CLIENT_DETAILS_Insert"
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub A_NEW_AE_ASSIGNMENT_Insert(ByVal PD_ID_REF As String,
                                          ByVal AE_ID_REF As String,
                                          ByVal Formname As Form)
        If PD_ID_REF <> Nothing Then
            Query = "INSERT INTO [A_NEW_AE_ASSIGNMENT]  ([PD_ID_REF],
                                                         [AE_ID_REF])
                                                VALUES  (@PD_ID_REF2,
                                                         @AE_ID_REF)"
            Using sqlcon As New SqlConnection(sqlcnstr)
                sqlcon.Open()
                Using sqlCommand As New SqlCommand(Query, sqlcon)
                    sqlCommand.Parameters.AddWithValue("@PD_ID_REF2", PD_ID_REF)
                    sqlCommand.Parameters.AddWithValue("@AE_ID_REF", AE_ID_REF)
                    confirmQuery = sqlCommand.ExecuteNonQuery()
                    If confirmQuery <> 0 Then
                        PD_CountSuccess += 1
                    Else
                        MetroFramework.MetroMessageBox.Show(Formname, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ErrorMsg += " Here @A_NEW_AE_ASSIGNMENT_Insert :" & AE_ID_REF
                    End If
                End Using
            End Using
        End If
    End Sub

    Public Sub A_NEW_CONTRACT_DETAILS_Insert(ByVal PD_ID_REF As String,
                                             ByVal Formname As Form)
        If PD_ID_REF <> Nothing Then
            Query = "INSERT INTO [A_NEW_CONTRACT_DETAILS]  ([PD_ID_REF])
                                                   VALUES  (@PD_ID_REF)
                SELECT @@IDENTITY AS [ID]"
            Using sqlcon As New SqlConnection(sqlcnstr)
                sqlcon.Open()
                Using sqlCommand As New SqlCommand(Query, sqlcon)
                    sqlCommand.Parameters.AddWithValue("@PD_ID_REF", PD_ID_REF)
                    Using read As SqlDataReader = sqlCommand.ExecuteReader
                        While read.Read
                            InsertedC_ID = read.Item("ID").ToString
                        End While
                        If InsertedC_ID <> Nothing Then
                            PD_CountSuccess += 1
                        Else
                            MetroFramework.MetroMessageBox.Show(Formname, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ErrorMsg += " Here @A_NEW_CONTRACT_DETAILS_Insert "
                        End If
                    End Using
                End Using
            End Using
        End If

    End Sub

    Public Sub A_NEW_OWNERS_TBL_Insert(ByVal PD_ID_REF As Integer,
                                       ByVal CUST_ID_REF As Integer,
                                       ByVal STATUS As String,
                                       ByVal FORMNAME As Form)
        Query = "INSERT INTO [A_NEW_OWNERS_TBL] ([PD_ID_REF]
                                                ,[CUST_ID_REF]
                                                ,[CLIENT_STATUS])
                                        VALUES  (@PD_ID_REF,@CUST_ID_REF,@STATUS)"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@PD_ID_REF", PD_ID_REF)
                sqlCommand.Parameters.AddWithValue("@CUST_ID_REF", CUST_ID_REF)
                sqlCommand.Parameters.AddWithValue("@STATUS", STATUS)
                confirmQuery = sqlCommand.ExecuteNonQuery()

                If confirmQuery <> 0 Then
                    PD_CountSuccess += 1
                Else
                    MetroFramework.MetroMessageBox.Show(FORMNAME, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ErrorMsg += " Here @A_NEW_OWNERS_TBL_Insert "
                End If
            End Using
        End Using
    End Sub

    Public Sub A_NEW_CONTRACT_QUOTE_NO_Insert(ByVal C_ID As Integer,
                                              ByVal QUOTE_REF_NO As String,
                                              ByVal QUOTE_DATE As String,
                                              ByVal FORMNAME As Form,
                                              Optional ORIGIN As String = "",
                                              Optional ORIGIN_DATE As String = "")
        Query = "INSERT INTO [A_NEW_CONTRACT_QUOTE_NO] ([CD_ID_REF],
                                                        [QUOTE_REF_NO],
                                                        [QUOTE_DATE],
                                                        [ORIGIN],
                                                        [ORIGIN_DATE])
                                                VALUES  (@C_ID,
                                                         @QUOTE_REF_NO,
                                                         @QUOTE_DATE,
                                                         @ORIGIN,
                                                         @ORIGIN_DATE)"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@C_ID", C_ID)
                sqlCommand.Parameters.AddWithValue("@QUOTE_REF_NO", QUOTE_REF_NO)
                sqlCommand.Parameters.AddWithValue("@QUOTE_DATE", QUOTE_DATE)
                sqlCommand.Parameters.AddWithValue("@ORIGIN", ORIGIN)
                sqlCommand.Parameters.AddWithValue("@ORIGIN_DATE", ORIGIN_DATE)
                confirmQuery = sqlCommand.ExecuteNonQuery()

                If confirmQuery <> 0 Then
                    PD_CountSuccess += 1
                Else
                    MetroFramework.MetroMessageBox.Show(FORMNAME, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ErrorMsg += " Here @A_NEW_CONTRACT_QUOTE_NO_Insert "
                End If
            End Using
        End Using
    End Sub

    Public Sub PD_SalesJobOrder_Update(ByVal SUB_JO As String,
                                       ByVal JOB_ORDER_NO As String,
                                       ByVal JOB_ORDER_NO_DATE As Date,
                                       ByVal FILE_LABEL_AS As String,
                                       ByVal JOB_ORDER_DESC As String,
                                       ByVal JO_ATTACHMENT As String,
                                       ByVal SPECIAL_COMMENTS As String,
                                       ByVal BLANK_PAGE As String,
                                       ByVal CONTRACT_VAT_PROFILE As String,
                                       ByVal PAYMENT_TERMS As String,
                                       ByVal PAYMENT_MODE As String,
                                       ByVal DOWN_PAYMENT As String,
                                       ByVal PAYMENT_DATE As String,
                                       ByVal ADDRESS_BILLING As String,
                                       ByVal ADDRESS_TO As String,
                                       ByVal ESTD_DEL_DATE As String,
                                       ByVal MODE_OF_DEL As String,
                                       ByVal MODE_OF_SHIP As String,
                                       ByVal OUT_OF_TOWN_CHARGES As String,
                                       ByVal DEL_GOODS As String,
                                       ByVal DELGOODS_TO As String,
                                       ByVal OTHER_PERTINENT_INFO As String,
                                       ByVal CONTRACT_TYPE As String,
                                       ByVal BAL_OF_DP As String,
                                       ByVal C_ID As Integer,
                                       ByVal COMPANY_NAME As String,
                                       ByVal CUST_ID As Integer,
                                       ByVal PROJECT_LABEL As String,
                                       ByVal PERTINENT_DETAILS As String,
                                       ByVal PD_ID As Integer)
        Query = "BEGIN TRANSACTION
                 Begin Try
                    
                    UPDATE	A_NEW_CONTRACT_DETAILS
                    SET     JOB_ORDER_NO = @JOB_ORDER_NO,
                            PARENTJONO = @PARENTJONO
                    WHERE	ID = @C_ID AND JOB_ORDER_NO = ''

                    UPDATE	A_NEW_CONTRACT_DETAILS
                    SET		SUB_JO = @SUB_JO,
		                    JOB_ORDER_NO_DATE = @JOB_ORDER_NO_DATE,
		                    FILE_LABEL_AS = @FILE_LABEL_AS,
		                    JOB_ORDER_DESC = @JOB_ORDER_DESC,
		                    JO_ATTACHMENT = @JO_ATTACHMENT,
		                    SPECIAL_COMMENTS = @SPECIAL_COMMENTS,
		                    BLANK_PAGE = @BLANK_PAGE,
		                    CONTRACT_VAT_PROFILE = @CONTRACT_VAT_PROFILE ,
		                    PAYMENT_TERMS = @PAYMENT_TERMS,
		                    PAYMENT_MODE = @PAYMENT_MODE,
		                    DOWN_PAYMENT = @DOWN_PAYMENT,
		                    PAYMENT_DATE = @PAYMENT_DATE,
		                    ADDRESS_BILLING = @ADDRESS_BILLING,
		                    ADDRESS_TO = @ADDRESS_TO,
		                    ESTD_DEL_DATE = @ESTD_DEL_DATE,
		                    MODE_OF_DEL = @MODE_OF_DEL,
		                    MODE_OF_SHIP = @MODE_OF_SHIP,
		                    OUT_OF_TOWN_CHARGES = @OUT_OF_TOWN_CHARGES,
		                    DEL_GOODS = @DEL_GOODS,
		                    DELGOODS_TO = @DELGOODS_TO,
		                    OTHER_PERTINENT_INFO = @OTHER_PERTINENT_INFO,
                            CONTRACT_TYPE = @CONTRACT_TYPE,
                            BAL_OF_DP = @BAL_OF_DP
                    WHERE	ID = @C_ID

                    UPDATE	A_NEW_CLIENT_DETAILS
                    SET		COMPANY_NAME = @COMPANY_NAME 
                    WHERE	CUST_ID = @CUST_ID

                    UPDATE	DBO.A_NEW_PROJECT_DETAILS
                    SET		PROJECT_LABEL = @PROJECT_LABEL,
		                    PERTINENT_DETAILS = @PERTINENT_DETAILS
                    WHERE	PD_ID = @PD_ID

                 SELECT 
										ERROR_NUMBER() AS ErrorNumber  
									   ,ERROR_MESSAGE() AS ErrorMessage
                                        Commit Transaction

                 End try

                Begin Catch
                SELECT   
                ERROR_NUMBER() AS ErrorNumber,
                ERROR_MESSAGE() AS ErrorMessage
                ROLLBACK TRANSACTION
                End Catch"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@JOB_ORDER_NO", JOB_ORDER_NO)
                sqlCommand.Parameters.AddWithValue("@PARENTJONO", JOB_ORDER_NO)
                sqlCommand.Parameters.AddWithValue("@SUB_JO", SUB_JO)
                sqlCommand.Parameters.AddWithValue("@JOB_ORDER_NO_DATE", JOB_ORDER_NO_DATE)
                sqlCommand.Parameters.AddWithValue("@FILE_LABEL_AS", FILE_LABEL_AS)
                sqlCommand.Parameters.AddWithValue("@JOB_ORDER_DESC", JOB_ORDER_DESC)
                sqlCommand.Parameters.AddWithValue("@JO_ATTACHMENT", JO_ATTACHMENT)
                sqlCommand.Parameters.AddWithValue("@SPECIAL_COMMENTS", SPECIAL_COMMENTS)
                sqlCommand.Parameters.AddWithValue("@BLANK_PAGE", BLANK_PAGE)
                sqlCommand.Parameters.AddWithValue("@CONTRACT_VAT_PROFILE", CONTRACT_VAT_PROFILE)
                sqlCommand.Parameters.AddWithValue("@PAYMENT_TERMS", PAYMENT_TERMS)
                sqlCommand.Parameters.AddWithValue("@PAYMENT_MODE", PAYMENT_MODE)
                sqlCommand.Parameters.AddWithValue("@DOWN_PAYMENT", DOWN_PAYMENT)
                sqlCommand.Parameters.AddWithValue("@PAYMENT_DATE", PAYMENT_DATE)
                sqlCommand.Parameters.AddWithValue("@ADDRESS_BILLING", ADDRESS_BILLING)
                sqlCommand.Parameters.AddWithValue("@ADDRESS_TO", ADDRESS_TO)
                sqlCommand.Parameters.AddWithValue("@ESTD_DEL_DATE", ESTD_DEL_DATE)
                sqlCommand.Parameters.AddWithValue("@MODE_OF_DEL", MODE_OF_DEL)
                sqlCommand.Parameters.AddWithValue("@MODE_OF_SHIP", MODE_OF_SHIP)
                sqlCommand.Parameters.AddWithValue("@OUT_OF_TOWN_CHARGES", OUT_OF_TOWN_CHARGES)
                sqlCommand.Parameters.AddWithValue("@DEL_GOODS", DEL_GOODS)
                sqlCommand.Parameters.AddWithValue("@DELGOODS_TO", DELGOODS_TO)
                sqlCommand.Parameters.AddWithValue("@OTHER_PERTINENT_INFO", OTHER_PERTINENT_INFO)
                sqlCommand.Parameters.AddWithValue("@CONTRACT_TYPE", CONTRACT_TYPE)
                sqlCommand.Parameters.AddWithValue("@BAL_OF_DP", BAL_OF_DP)
                sqlCommand.Parameters.AddWithValue("@C_ID", C_ID)
                sqlCommand.Parameters.AddWithValue("@COMPANY_NAME", COMPANY_NAME)
                sqlCommand.Parameters.AddWithValue("@CUST_ID", CUST_ID)
                sqlCommand.Parameters.AddWithValue("@PROJECT_LABEL", PROJECT_LABEL)
                sqlCommand.Parameters.AddWithValue("@PERTINENT_DETAILS", PERTINENT_DETAILS)
                sqlCommand.Parameters.AddWithValue("@PD_ID", PD_ID)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    While read.Read
                        ErrorMsg = read.Item("ErrorMessage").ToString
                        ErrorNum = read.Item("ErrorNumber").ToString
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub PD_UpdateEmp_Operations(ByVal FormName As Form,
                                        ByVal Operation_Type As String,
                                        Optional EMP_ID As String = "",
                                        Optional NAME As String = "",
                                        Optional BIRTHDAY As String = "",
                                        Optional GENDER As String = "",
                                        Optional MOBILENO As String = "",
                                        Optional EMAIL As String = "",
                                        Optional AF As Decimal = 0,
                                        Optional AFTYPE As String = "",
                                        Optional AFRELEASING As String = "")
        If Operation_Type = "Add" Then
            Query = "INSERT INTO [A_NEW_EMPLOYEE_DETAILS] ([NAME]
                                                      ,[BIRTHDAY]
                                                      ,[GENDER]
                                                      ,[MOBILENO]
                                                      ,[EMAIL]
                                                      ,[AF]
                                                      ,[AFTYPE]
                                                      ,[AFRELEASING])
                                               VALUES (@NAME
                                                      ,@BIRTHDAY
                                                      ,@GENDER
                                                      ,@MOBILENO
                                                      ,@EMAIL
                                                      ,@AF
                                                      ,@AFTYPE
                                                      ,@AFRELEASING)"
        ElseIf Operation_Type = "Update" Then
            Query = "UPDATE [A_NEW_EMPLOYEE_DETAILS]
                     SET [NAME] = @NAME,
                         [BIRTHDAY] = @BIRTHDAY,
                         [GENDER] = @GENDER,
                         [MOBILENO] = @MOBILENO,
                         [EMAIL] = @EMAIL,
                         [AF] = @AF,
                         [AFTYPE] = @AFTYPE,
                         [AFRELEASING] = @AFRELEASING
                    WHERE [EMP_ID] = @EMP_ID"
        ElseIf Operation_Type = "Delete" Then
            Query = "UPDATE [A_NEW_EMPLOYEE_DETAILS]
                     SET [EMP_STATUS] = 0
                    WHERE [EMP_ID] = @EMP_ID"
        End If
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@NAME", NAME)
                sqlCommand.Parameters.AddWithValue("@BIRTHDAY", BIRTHDAY)
                sqlCommand.Parameters.AddWithValue("@GENDER", GENDER)
                sqlCommand.Parameters.AddWithValue("@MOBILENO", MOBILENO)
                sqlCommand.Parameters.AddWithValue("@EMAIL", EMAIL)
                sqlCommand.Parameters.AddWithValue("@AF", AF)
                sqlCommand.Parameters.AddWithValue("@AFTYPE", AFTYPE)
                sqlCommand.Parameters.AddWithValue("@AFRELEASING", AFRELEASING)
                If Operation_Type = "Update" Or Operation_Type = "Delete" Then
                    sqlCommand.Parameters.AddWithValue("@EMP_ID", EMP_ID)
                End If

                confirmQuery = sqlCommand.ExecuteNonQuery()
                If confirmQuery <> 0 Then
                    PD_CountSuccess = 1
                Else
                    MetroFramework.MetroMessageBox.Show(FormName, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Public Sub PD_UpdateComp_Operations(ByVal FormName As Form,
                                        ByVal Operation_Type As String,
                                        Optional COMP_ID As String = "",
                                        Optional OFFICENAME As String = "",
                                        Optional OFFICEADDRESS As String = "",
                                        Optional CONTACTNO As String = "",
                                        Optional OFFICEASSISTANT As String = "",
                                        Optional REMARKS As String = "")
        If Operation_Type = "Add" Then
            Query = "INSERT INTO [A_NEW_COMPANY_DETAILS] (  [OFFICENAME]
                                                           ,[OFFICEADDRESS]
                                                           ,[CONTACTNO]
                                                           ,[OFFICEASSISTANT]
                                                           ,[REMARKS])
                                                     VALUES
                                                           (@OFFICENAME
                                                           ,@OFFICEADDRESS
                                                           ,@CONTACTNO
                                                           ,@OFFICEASSISTANT
                                                           ,@REMARKS)"
        ElseIf Operation_Type = "Update" Then
            Query = "UPDATE [A_NEW_COMPANY_DETAILS] SET  [OFFICENAME] = @OFFICENAME
                                                        ,[OFFICEADDRESS] = @OFFICEADDRESS
                                                        ,[CONTACTNO] =  @CONTACTNO
                                                        ,[OFFICEASSISTANT] = @OFFICEASSISTANT
                                                        ,[REMARKS] = @REMARKS
                    WHERE [COMP_ID] = @COMP_ID"
        ElseIf Operation_Type = "Delete" Then
            Query = "UPDATE [A_NEW_COMPANY_DETAILS] SET [COMP_STATUS] = 0
                     WHERE [COMP_ID] = @COMP_ID"
        End If
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@OFFICENAME", OFFICENAME)
                sqlCommand.Parameters.AddWithValue("@OFFICEADDRESS", OFFICEADDRESS)
                sqlCommand.Parameters.AddWithValue("@CONTACTNO", CONTACTNO)
                sqlCommand.Parameters.AddWithValue("@OFFICEASSISTANT", OFFICEASSISTANT)
                sqlCommand.Parameters.AddWithValue("@REMARKS", REMARKS)
                If Operation_Type = "Update" Or Operation_Type = "Delete" Then
                    sqlCommand.Parameters.AddWithValue("@COMP_ID", COMP_ID)
                End If

                confirmQuery = sqlCommand.ExecuteNonQuery()
                If confirmQuery <> 0 Then
                    PD_CountSuccess = 1
                Else
                    MetroFramework.MetroMessageBox.Show(FormName, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Public Sub PD_Addendum_Update(ByVal REP_AddorUpdate As String,
                                  ByVal PROJECT_LABEL As String,
                                  ByVal CONSTRUCTION_STAGE As String,
                                  ByVal ACTIVITIES_SITEMEETING As String,
                                  ByVal OTHER_PERTINENT_INFO As String,
                                  ByVal PD_ID As String,
                                  ByVal OWNERS_NAME As String,
                                  ByVal CLIENTS_CONTACT_NO As String,
                                  ByVal CLIENTS_CONTACT_OFFICE As String,
                                  ByVal CLIENTS_CONTACT_MOBILE As String,
                                  ByVal CUST_ID As String,
                                  ByVal OWNERS_NAME_REP As String,
                                  ByVal CLIENTS_CONTACT_NO_REP As String,
                                  ByVal CLIENTS_CONTACT_OFFICE_REP As String,
                                  ByVal CLIENTS_CONTACT_MOBILE_REP As String,
                                  ByVal CUST_ID_REP As String)

        Dim QUERY_PART1 As String = ""
        Select Case REP_AddorUpdate
            Case "ADD"
                QUERY_PART1 = " INSERT  INTO [A_NEW_CLIENT_DETAILS]
                                        ([CLIENTS_NAME],
                                         [CLIENTS_CONTACT_NO],
                                         [CLIENTS_CONTACT_OFFICE],
                                         [CLIENTS_CONTACT_MOBILE])
                                VALUES  (@OWNERS_NAME_REP,
                                         @CLIENTS_CONTACT_NO_REP,
                                         @CLIENTS_CONTACT_OFFICE_REP,
                                         @CLIENTS_CONTACT_MOBILE_REP)

	                            SELECT @CUST_ID_REP_IDENTITY = @@IDENTITY
	                            INSERT	INTO	[A_NEW_OWNERS_REP]
					                            ([PD_ID_REF]
					                            ,[CUST_ID_REF])
			                            VALUES	(@PD_ID,@CUST_ID_REP_IDENTITY) "
            Case "UPDATE"
                QUERY_PART1 = " UPDATE  [A_NEW_CLIENT_DETAILS]
                              SET     [CLIENTS_NAME] = @OWNERS_NAME_REP,
                                      [CLIENTS_CONTACT_NO] = @CLIENTS_CONTACT_NO_REP,
                                      [CLIENTS_CONTACT_OFFICE] = @CLIENTS_CONTACT_OFFICE_REP,
                                      [CLIENTS_CONTACT_MOBILE] = @CLIENTS_CONTACT_MOBILE_REP
                              WHERE   [CUST_ID] = @CUST_ID_REP "
        End Select
        Query = "
Begin Transaction
DECLARE @CUST_ID_REP_IDENTITY AS INTEGER

	Begin Try
	UPDATE	[A_NEW_PROJECT_DETAILS]
	SET		[PROJECT_LABEL] = @PROJECT_LABEL,
			[CONSTRUCTION_STAGE] = @CONSTRUCTION_STAGE,
			[ACTIVITIES] = @ACTIVITIES_SITEMEETING
	WHERE	[PD_ID] = @PD_ID

    UPDATE  [A_NEW_CONTRACT_DETAILS]
    SET     [OTHER_PERTINENT_INFO] = @OTHER_PERTINENT_INFO
    WHERE   [PD_ID_REF] = @PD_ID

    UPDATE  [A_NEW_CLIENT_DETAILS]
    SET     [OWNERS_NAME] = @OWNERS_NAME,
            [CLIENTS_CONTACT_NO] = @CLIENTS_CONTACT_NO,
            [CLIENTS_CONTACT_OFFICE] = @CLIENTS_CONTACT_OFFICE,
            [CLIENTS_CONTACT_MOBILE] = @CLIENTS_CONTACT_MOBILE
    WHERE   [CUST_ID] = @CUST_ID

" & QUERY_PART1 & " 

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage,
            'Commited' AS [Transaction]
            Commit Transaction
	End Try

	Begin Catch
	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage,
            'Rollback' AS [Transaction]
			ROLLBACK TRANSACTION
	End Catch"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@PROJECT_LABEL", PROJECT_LABEL)
                sqlCommand.Parameters.AddWithValue("@CONSTRUCTION_STAGE", CONSTRUCTION_STAGE)
                sqlCommand.Parameters.AddWithValue("@ACTIVITIES_SITEMEETING", ACTIVITIES_SITEMEETING)
                sqlCommand.Parameters.AddWithValue("@OTHER_PERTINENT_INFO", OTHER_PERTINENT_INFO)
                sqlCommand.Parameters.AddWithValue("@PD_ID", PD_ID)
                sqlCommand.Parameters.AddWithValue("@OWNERS_NAME", OWNERS_NAME)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_NO", CLIENTS_CONTACT_NO)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_OFFICE", CLIENTS_CONTACT_OFFICE)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_MOBILE", CLIENTS_CONTACT_MOBILE)
                sqlCommand.Parameters.AddWithValue("@CUST_ID", CUST_ID)
                sqlCommand.Parameters.AddWithValue("@OWNERS_NAME_REP", OWNERS_NAME_REP)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_NO_REP", CLIENTS_CONTACT_NO_REP)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_OFFICE_REP", CLIENTS_CONTACT_OFFICE_REP)
                sqlCommand.Parameters.AddWithValue("@CLIENTS_CONTACT_MOBILE_REP", CLIENTS_CONTACT_MOBILE_REP)
                sqlCommand.Parameters.AddWithValue("@CUST_ID_REP", CUST_ID_REP)

                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    sql_Err_no = read.Item("ErrorNumber").ToString
                    sql_Err_msg = read.Item("ErrorMessage").ToString
                    sql_Transaction_result = read.Item("Transaction").ToString
                End Using
            End Using
        End Using
    End Sub
    Public Sub PD_Addendum_Update_TechPartners(ByVal Formname As Form,
                                               ByVal CD_ID_REF As Integer,
                                               ByVal NATURE As String,
                                               Optional COMP_ID_REF As Integer = Nothing,
                                               Optional EMP_ID_REF As Integer = Nothing,
                                               Optional POSITION As String = "",
                                               Optional TP_ID_REF As String = "")
        Dim QUERY_PART1 As String = ""

        Select Case TP_ID_REF
            Case ""
                QUERY_PART1 = " INSERT INTO [A_NEW_TECHNICAL_PARTNERS] ([COMP_ID_REF],
                                                                        [EMP_ID_REF],
                                                                        [POSITION]) 
                                                                VALUES (@COMP_ID_REF,
                                                                        @EMP_ID_REF,
                                                                        @POSITION)
                                SELECT @TP_ID = @@IDENTITY 
                                INSERT INTO [A_NEW_TECHNICAL_PARTNERS_NATURE] ([TP_ID_REF],
                                                                               [CD_ID_REF],
                                                                               [NATURE])
                                                                VALUES (@TP_ID,
                                                                        @CD_ID_REF,
                                                                        @NATURE) "
            Case <> ""
                QUERY_PART1 = " INSERT INTO [A_NEW_TECHNICAL_PARTNERS_NATURE] ([TP_ID_REF],
                                                                               [CD_ID_REF],
                                                                               [NATURE])
                                                                VALUES (@TP_ID_REF,
                                                                        @CD_ID_REF,
                                                                        @NATURE) "
        End Select
        Query = "
BEGIN TRANSACTION

DECLARE @TP_ID AS INTEGER
DECLARE @TPN_ID AS INTEGER
BEGIN TRY
" & QUERY_PART1 & "
    SELECT @TPN_ID = @@IDENTITY
    SELECT @TPN_ID AS [TPN_ID]
	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage
            Commit Transaction
END TRY

BEGIN CATCH
	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage
			ROLLBACK TRANSACTION
END CATCH
"
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@NATURE", NATURE)
                Select Case TP_ID_REF
                    Case ""
                        sqlCommand.Parameters.AddWithValue("@COMP_ID_REF", COMP_ID_REF)
                        sqlCommand.Parameters.AddWithValue("@EMP_ID_REF", EMP_ID_REF)
                        sqlCommand.Parameters.AddWithValue("@POSITION", POSITION)
                    Case <> ""
                        sqlCommand.Parameters.AddWithValue("@TP_ID_REF", TP_ID_REF)
                End Select
                sqlCommand.Parameters.AddWithValue("@CD_ID_REF", CD_ID_REF)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    If read.HasRows Then
                        PD_CountSuccess = 1
                        TPN_ID = read.Item("TPN_ID")
                    Else
                        PD_CountSuccess = 0
                        TPN_ID = Nothing
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub PD_Addendum_TPN_Delete(ByVal Formname As Form,
                                      ByVal TPN_ID As Integer)
        Query = " UPDATE [A_NEW_TECHNICAL_PARTNERS_NATURE] SET [TPN_STATUS] = 0 WHERE [TPN_ID] = @TPN_ID"

        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@TPN_ID", TPN_ID)
                confirmQuery = sqlCommand.ExecuteNonQuery()
                If confirmQuery <> 0 Then
                    'PD_CountSuccess += 1
                    'MetroFramework.MetroMessageBox.Show(Formname, "SUCCESS", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Formname, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
    Public Sub PD_Addendum_TechPartners_SearchIfDeleted(ByVal TP_ID_REF As String,
                                                        ByVal CD_ID_REF As Integer,
                                                        ByVal NATURE As String)
        Query = "SELECT [TPN_ID]
                 FROM [A_NEW_TECHNICAL_PARTNERS_NATURE]
                 WHERE [TP_ID_REF] = @TP_ID_REF AND
                       [CD_ID_REF] = @CD_ID_REF AND
                       [NATURE] = @NATURE AND
                       [TPN_STATUS] = 0 "
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@NATURE", NATURE)
                sqlCommand.Parameters.AddWithValue("@TP_ID_REF", TP_ID_REF)
                sqlCommand.Parameters.AddWithValue("@CD_ID_REF", CD_ID_REF)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    If read.HasRows Then
                        TPN_ID_SearchIfDeleted = read.Item("TPN_ID")
                    Else
                        TPN_ID_SearchIfDeleted = Nothing
                    End If
                End Using
            End Using
        End Using
    End Sub
    Public Sub PD_Addendum_TechPartners_ReturnDeletedRow(ByVal FORMNAME As Form,
                                                         ByVal TPN_ID As Integer)
        Query = "UPDATE [A_NEW_TECHNICAL_PARTNERS_NATURE]
                 SET [TPN_STATUS] = 1
                 WHERE [TPN_ID] = @TPN_ID "
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@TPN_ID", TPN_ID)
                confirmQuery = sqlCommand.ExecuteNonQuery()
                If confirmQuery <> 0 Then
                    PD_CountSuccess = 1
                Else
                    PD_CountSuccess = 0
                End If
            End Using
        End Using
    End Sub
    Public Sub PD_Addendum_Update_QuoteRefNo(ByVal CD_ID As String,
                                             ByVal WD_ID As String)
        Dim QUERY_PART1 As String = "", QUERY_PART2 As String = ""
        Select Case PD_Addendum_Update_QuoteRefNo_counter
            Case = 0
                QUERY_PART1 = " UPDATE  [A_NEW_CONTRACT_QUOTE_NO] 
                                SET     [CQN_STATUS] = 0 
                                WHERE   [CD_ID_REF] = @CD_ID "
            Case <> 0
                QUERY_PART1 = " SET @CQN_ID = (SELECT [CQN_ID] FROM [A_NEW_CONTRACT_QUOTE_NO]
			                                   WHERE [CD_ID_REF] = @CD_ID AND [WD_ID_REF] = @WD_ID AND [CQN_STATUS] = 1 ) 
                                IF (@CQN_ID IS NOT NULL)
			                        UPDATE  [A_NEW_CONTRACT_QUOTE_NO]
					                SET     [CQN_STATUS] = 0
					                WHERE	[CQN_ID] = @CQN_ID "
        End Select

        Select Case PD_Addendum_Update_QuoteRefNo_counter
            Case >= 0
                QUERY_PART2 = " SET @CQN_ID = (SELECT   [CQN_ID] FROM [A_NEW_CONTRACT_QUOTE_NO]
			                                   WHERE    [CD_ID_REF] = @CD_ID AND [WD_ID_REF] = @WD_ID )
                IF (@CQN_ID IS NOT NULL)
			                BEGIN
			                  SET @CQN_STATUS = ( SELECT CQN_STATUS FROM [A_NEW_CONTRACT_QUOTE_NO] WHERE CQN_ID = @CQN_ID)
			                  IF (@CQN_ID = 1 )
					                UPDATE      [A_NEW_CONTRACT_QUOTE_NO]
					                SET     [CQN_STATUS] = 0
					                WHERE	[CQN_ID] = @CQN_ID
			                  ELSE
					                UPDATE      [A_NEW_CONTRACT_QUOTE_NO]
					                SET     [CQN_STATUS] = 1
					                WHERE	[CQN_ID] = @CQN_ID
			                END

                ELSE			   
			                   INSERT INTO [A_NEW_CONTRACT_QUOTE_NO] ([CD_ID_REF],[WD_ID_REF])
											                  VALUES (@CD_ID,@WD_ID) "
            Case = 0
                QUERY_PART2 = "  "
        End Select
        Query = "
Begin Transaction
DECLARE @CQN_ID AS INTEGER
DECLARE @CQN_STATUS AS BIT
	Begin Try

" & QUERY_PART1 & QUERY_PART2 & "

	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage,
            'Commited' AS [Transaction]
            Commit Transaction
	End Try

	Begin Catch
	SELECT	ERROR_NUMBER() AS ErrorNumber,
			ERROR_MESSAGE() AS ErrorMessage,
            'Rollback' AS [Transaction]
			ROLLBACK TRANSACTION
	End Catch"

        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlCommand As New SqlCommand(Query, sqlcon)
                sqlCommand.Parameters.AddWithValue("@CD_ID", CD_ID)
                sqlCommand.Parameters.AddWithValue("@WD_ID", WD_ID)
                'sqlCommand.Parameters.AddWithValue("@CQN_ID", CQN_ID)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    sql_Err_no = read.Item("ErrorNumber").ToString
                    sql_Err_msg = read.Item("ErrorMessage").ToString
                    sql_Transaction_result = read.Item("Transaction").ToString
                End Using
            End Using
        End Using
        PD_Addendum_Update_QuoteRefNo_counter += 1
    End Sub

    Public Sub PD_Inserts_NewProj(Optional PROJECT_SOURCE As String = "",
                                  Optional PROJECT_CLASSIFICATION As String = "",
                                  Optional COMPETITORS As String = "",
                                  Optional UNITNO As String = "",
                                  Optional ESTABLISHMENT As String = "",
                                  Optional NO As String = "",
                                  Optional STREET As String = "",
                                  Optional VILLAGE As String = "",
                                  Optional BRGY_MUNICIPALITY As String = "",
                                  Optional TOWN_DISTRICT As String = "",
                                  Optional PROVINCE As String = "",
                                  Optional AREA As String = "",
                                  Optional FULLADD As String = "",
                                  Optional CLIENTS_NAME As String = "",
                                  Optional OWNERS_NAME As String = "",
                                  Optional CLIENTS_CONTACT_NO As String = "",
                                  Optional CLIENTS_CONTACT_OFFICE As String = "",
                                  Optional CLIENTS_CONTACT_MOBILE As String = "",
                                  Optional CLIENTS_EMAIL_ADD As String = "",
                                  Optional COMPANY_NAME As String = "")
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction("SampleTransaction")
                sqlcmd.Connection = sqlcon
                sqlcmd.Transaction = transaction
                sqlcmd.CommandText = "PD_stp_NewProject"
                sqlcmd.CommandType = CommandType.StoredProcedure

                sqlcmd.Parameters.AddWithValue("@PROJECT_SOURCE", PROJECT_SOURCE)
                sqlcmd.Parameters.AddWithValue("@PROJECT_CLASSIFICATION", PROJECT_CLASSIFICATION)
                sqlcmd.Parameters.AddWithValue("@COMPETITORS", COMPETITORS)
                sqlcmd.Parameters.AddWithValue("@UNITNO", UNITNO)
                sqlcmd.Parameters.AddWithValue("@ESTABLISHMENT", ESTABLISHMENT)
                sqlcmd.Parameters.AddWithValue("@NO", NO)
                sqlcmd.Parameters.AddWithValue("@STREET", STREET)
                sqlcmd.Parameters.AddWithValue("@VILLAGE", VILLAGE)
                sqlcmd.Parameters.AddWithValue("@BRGY_MUNICIPALITY", BRGY_MUNICIPALITY)
                sqlcmd.Parameters.AddWithValue("@TOWN_DISTRICT", TOWN_DISTRICT)
                sqlcmd.Parameters.AddWithValue("@PROVINCE", PROVINCE)
                sqlcmd.Parameters.AddWithValue("@AREA", AREA)
                sqlcmd.Parameters.AddWithValue("@FULLADD", FULLADD)

                sqlcmd.Parameters.AddWithValue("@CLIENTS_NAME", CLIENTS_NAME)
                sqlcmd.Parameters.AddWithValue("@OWNERS_NAME", OWNERS_NAME)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_CONTACT_NO", CLIENTS_CONTACT_NO)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_CONTACT_OFFICE", CLIENTS_CONTACT_OFFICE)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_CONTACT_MOBILE", CLIENTS_CONTACT_MOBILE)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_EMAIL_ADD", CLIENTS_EMAIL_ADD)
                sqlcmd.Parameters.AddWithValue("@COMPANY_NAME", COMPANY_NAME)
                Using read As SqlDataReader = sqlcmd.ExecuteReader
                    read.Read()
                    InsertedPD_ID = read.Item("PD_ID").ToString
                End Using
                'sqlcmd.ExecuteNonQuery()

                'sqlcmd.CommandType = CommandType.StoredProcedure

                For Each arr_AEID_int As Integer In arr_AEID
                    sqlcmd.CommandText = "INSERT INTO [A_NEW_AE_ASSIGNMENT]  ([PD_ID_REF],[AE_ID_REF])
                                                                 VALUES  (@PD_ID_REF2" & arr_AEID_int & ",
                                                                          @AE_ID_REF" & arr_AEID_int & ")"
                    sqlcmd.Parameters.AddWithValue("@PD_ID_REF2" & arr_AEID_int, InsertedPD_ID)
                    sqlcmd.Parameters.AddWithValue("@AE_ID_REF" & arr_AEID_int, arr_AEID_int)
                Next
                sqlcmd.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using

    End Sub

    Public Sub ExecuteSqlTransaction(Optional Params As String = "")
        Using sqlcon As New SqlConnection(sqlcnstr)
            sqlcon.Open()
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand()

                'Dim command As SqlCommand = sqlcon.CreateCommand()

                ' Start a local transaction
                transaction = sqlcon.BeginTransaction("SampleTransaction")

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                sqlcmd.Connection = sqlcon
                sqlcmd.Transaction = transaction

                'Try
                sqlcmd.CommandText = "PD_stp_NewProject"
                sqlcmd.CommandType = CommandType.StoredProcedure

                sqlcmd.Parameters.AddWithValue("@PROJECT_SOURCE", Params)
                sqlcmd.Parameters.AddWithValue("@PROJECT_CLASSIFICATION", Params)
                sqlcmd.Parameters.AddWithValue("@COMPETITORS", Params)
                sqlcmd.Parameters.AddWithValue("@UNITNO", Params)
                sqlcmd.Parameters.AddWithValue("@ESTABLISHMENT", Params)
                sqlcmd.Parameters.AddWithValue("@NO", Params)
                sqlcmd.Parameters.AddWithValue("@STREET", Params)
                sqlcmd.Parameters.AddWithValue("@VILLAGE", Params)
                sqlcmd.Parameters.AddWithValue("@BRGY_MUNICIPALITY", Params)
                sqlcmd.Parameters.AddWithValue("@TOWN_DISTRICT", Params)
                sqlcmd.Parameters.AddWithValue("@PROVINCE", Params)
                sqlcmd.Parameters.AddWithValue("@AREA", Params)
                sqlcmd.Parameters.AddWithValue("@FULLADD", Params)

                sqlcmd.Parameters.AddWithValue("@CLIENTS_NAME", Params)
                sqlcmd.Parameters.AddWithValue("@OWNERS_NAME", Params)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_CONTACT_NO", Params)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_CONTACT_OFFICE", Params)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_CONTACT_MOBILE", Params)
                sqlcmd.Parameters.AddWithValue("@CLIENTS_EMAIL_ADD", Params)
                sqlcmd.Parameters.AddWithValue("@COMPANY_NAME", Params)

                sqlcmd.ExecuteNonQuery()

                ' Attempt to commit the transaction.
                transaction.Commit()
                sql_Transaction_result = "Committed"
                MsgBox("Both records are written to database.")

                'Catch ex As Exception
                '    Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                '    Console.WriteLine("  Message: {0}", ex.Message)

                '    ' Attempt to roll back the transaction.
                '    Try
                '        transaction.Rollback()

                '    Catch ex2 As Exception
                '        ' This catch block will handle any errors that may have occurred
                '        ' on the server that would cause the rollback to fail, such as
                '        ' a closed connection.
                '        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                '        Console.WriteLine("  Message: {0}", ex2.Message)
                '    End Try
                'End Try
            End Using
        End Using
    End Sub


End Module