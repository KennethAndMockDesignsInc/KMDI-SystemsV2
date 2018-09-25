Imports System.Data.SqlClient

Module ProjectAssignmentModule
    Public Sub SearchORLoadProjAssignDGV(ByVal SearchString As String)

        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        'sqlConnection = New SqlConnection
        sqlConnection.Close()
        sqlConnection.Open()


        sqlDataSet.Clear()
        sqlBindingSource.Clear()
        Query = "SELECT DISTINCT TOP 50  PD.[PA_AUTONUMBER]
                                  ,PD.[JOB_ORDER_NO_PARENT]
                                  ,PD.[QUOTE_NO]
                                  ,PD.[QUOTE_DATE]
                                  ,PD.[CUST_REF_NO]
                                  ,PD.[PROJECT_LABEL]
                                  ,PD.[PROJECT_TYPE]
                                  ,PD.[SOURCE]
                                  ,PD.[REFFERED_BY]
                                  ,PD.[CLIENTS_CONTACT_NO]
                                  ,PD.[CLIENTS_CONTACT_NO_OFFICE]
                                  ,PD.[CLIENTS_CONTACT_NO_MOBILE]
                                  ,PD.[CLIENTS_EMAIL_ADD]
                                  ,PD.[UNIT_NO]
                                  ,PD.[ESTABLISHMENT]
                                  ,PD.[HOUSE_NO]
                                  ,PD.[STREET]
                                  ,PD.[VILLAGE]
                                  ,PD.[BARANGAY]
                                  ,PD.[TOWN]
                                  ,PD.[PROVINCE]
                                  ,PD.[AREA]
                                  ,PD.[PROJECT_STATUS]
                                  ,PD.[PRESENTATION]
                                  ,PD.[SITE_MEETINGS]
                                  ,PD.[ARCHITECTURAL_DISCUSSIONS]
                                  ,PD.[SUBMITTAL_REVISION_OF_QUOTES]
                                  ,PD.[TRIAL_CLOSING]
                                  ,PD.[CLOSING_NEGOTIATION]
                                  ,PD.[CLOSED]
                                  ,PD.[CLOSED_OPTION]
                                  ,PD.[CLOSED_FULL_PARTIAL]
                                  ,PD.[AE_ASSIGNED_CODE]
                                  ,PD.[COMPETITORS]
                                  ,PD.[PROFILE_FINISH]
                                  ,PD.[PROJECT_CLASSIFICATION]
                                  ,PD.[CONSTRUCTION_STAGE]
                                  ,PD.[SITE_MEETING_SCHEDULE]
                                  ,PD.[WIP]
                                  ,PD.[CLIENTS_NAME] as [CLIENTS NAME]
                                  ,PD.[CLIENTS_ADDRESS] as [CLIENTS ADDRESS]
                                  ,PD.[COMPANY_NAME] as [COMPANY NAME]
                            from PERTINENT_DETAILS PD
                            JOIN PROJECT_ASSIGNMENT PA on PD.PA_AUTONUMBER = PA.PERTINENT_DETAILS_REF_NO
                            WHERE [CLIENTS_NAME] like @SearchString or
                                  [CLIENTS_ADDRESS] like @SearchString or
                                  [COMPANY_NAME] like @SearchString or
                                  [PROJECT_LABEL] like @SearchString"

        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlDataAdapter.Fill(sqlDataSet, "PROJ_ASSIGN")
        sqlBindingSource.DataSource = sqlDataSet
        sqlBindingSource.DataMember = "PROJ_ASSIGN"

    End Sub

    Public archSqlds As DataSet
    Public archsqlDataAdapter As SqlDataAdapter
    Public archsqlBindingSource As BindingSource
    Public archsqlConnection As SqlConnection
    Public Sub SearchORLoadArchDesignDGV(ByVal SearchStringArch As String)

        archsqlConnection = New SqlConnection(sqlconnString)
        archsqlDataAdapter = New SqlDataAdapter
        archsqlBindingSource = New BindingSource
        archSqlds = New DataSet

        archsqlConnection.Close()
        archsqlConnection.Open()

        archSqlds.Clear()
        archsqlBindingSource.Clear()
        Query = "SELECT TOP 50     [AUTONUM]
                                  ,[OFFICENAME]
                                  ,[NAME]
                                  ,[POSITION]
                              FROM [ARCHITECTURAL_EMP]
                             WHERE [OFFICENAME] like @SearchStringArch or
                                   [NAME] like @SearchStringArch or
                                   [POSITION] like @SearchStringArch"

        sqlCommand = New SqlCommand(Query, archsqlConnection)
        sqlCommand.Parameters.AddWithValue("@SearchStringArch", "%" & SearchStringArch & "%")
        archsqlDataAdapter.SelectCommand = sqlCommand
        archsqlDataAdapter.Fill(archSqlds, "ARCH_DESIGN")
        archsqlBindingSource.DataSource = archSqlds
        archsqlBindingSource.DataMember = "ARCH_DESIGN"

    End Sub

    Public Sub SearchAE_AssignedCode(ByVal PA_AUTONUMBER As String)

        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        'sqlConnection = New SqlConnection
        sqlConnection.Close()
        sqlConnection.Open()


        sqlDataSet.Clear()
        sqlBindingSource.Clear()
        Query = "SELECT     PA.AE_ASSIGNED_CODE as [AE_ASSIGNED_CODE]
                            from PERTINENT_DETAILS PD
                            JOIN PROJECT_ASSIGNMENT PA on PD.PA_AUTONUMBER = PA.PERTINENT_DETAILS_REF_NO
                            WHERE [PA_AUTONUMBER] = @PA_AUTONUMBER"

        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@PA_AUTONUMBER", PA_AUTONUMBER)
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlDataAdapter.Fill(sqlDataSet, "AE_ASSIGNED")
        sqlBindingSource.DataSource = sqlDataSet
        sqlBindingSource.DataMember = "AE_ASSIGNED"

    End Sub

    Public Sub Populate_AEAssignedCBox()

        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        'sqlConnection = New SqlConnection
        sqlConnection.Close()
        sqlConnection.Open()


        sqlDataSet.Clear()
        sqlBindingSource.Clear()
        Query = "SELECT [AUTONUM]
                       ,[FULLNAME]
                 FROM [KMDI_Systems].[dbo].[KMDI_ACCT_TB] where ACCTTYPE = 'AEIC' and IS_ACTIVE = 1"

        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlDataAdapter.Fill(sqlDataSet, "AE_ASSIGNED")
        sqlBindingSource.DataSource = sqlDataSet
        sqlBindingSource.DataMember = "AE_ASSIGNED"

        ProjectAssignment.AEAssignedCBox.DataSource = sqlBindingSource
        ProjectAssignment.AEAssignedCBox.ValueMember = "AUTONUM"
        ProjectAssignment.AEAssignedCBox.DisplayMember = "FULLNAME"
        ProjectAssignment.AEAssignedCBox.SelectedIndex = -1
    End Sub

    Public AE_ASSIGNED_FULLNAME As String
    Public Sub SearchAE_AssignedFULLNAME(ByVal AUTONUM As String)

        'sqlConnection = New SqlConnection
        sqlConnection.Close()
        sqlConnection.Open()

        Query = "SELECT     [FULLNAME]
                            FROM [KMDI_ACCT_TB]
                            WHERE [AUTONUM] = @AUTONUM"
        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@AUTONUM", AUTONUM)
        sqlDataAdapter.SelectCommand = sqlCommand
        Read = sqlCommand.ExecuteReader
        Read.Read()
        If Read.HasRows Then
            AE_ASSIGNED_FULLNAME = Read.Item("FULLNAME").ToString
        End If
    End Sub
End Module
