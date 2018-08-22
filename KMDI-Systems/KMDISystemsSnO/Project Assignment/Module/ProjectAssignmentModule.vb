Imports System.Data.SqlClient

Module ProjectAssignmentModule
    Public Sub SearchORLoadProjAssignDGV()

        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        sqlConnection.Close()
        sqlConnection.Open()

        sqlDataSet.Clear()
        sqlBindingSource.Clear()
        Query = "SELECT DISTINCT   PD.[PA_AUTONUMBER]
                                  ,PD.[JOB_ORDER_NO_PARENT]
                                  ,PD.[QUOTE_NO]
                                  ,PD.[QUOTE_DATE]
                                  ,PD.[CUST_REF_NO]
                                  ,PD.[PROJECT_LABEL]
                                  ,PD.[PROJECT_TYPE]
                                  ,PD.[SOURCE]
                                  ,PD.[REFFERED_BY]
                                  ,PD.[CLIENTS_NAME]
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
                                  ,PD.[CLIENTS_ADDRESS]
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
                                  ,PD.[COMPANY_NAME]
                                  ,PD.[PROFILE_FINISH]
                                  ,PD.[PROJECT_CLASSIFICATION]
                                  ,PD.[CONSTRUCTION_STAGE]
                                  ,PD.[SITE_MEETING_SCHEDULE]
                                  ,PD.[WIP]
                            from PERTINENT_DETAILS PD
                            JOIN PROJECT_ASSIGNMENT PA on PD.PA_AUTONUMBER = PA.PERTINENT_DETAILS_REF_NO"

        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlDataAdapter.Fill(sqlDataSet, "MARKETING_INVENTORY_V2")
        sqlBindingSource.DataSource = sqlDataSet
        sqlBindingSource.DataMember = "MARKETING_INVENTORY_V2"

    End Sub

End Module
