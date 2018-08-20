Imports System.Data.SqlClient

Module ContractsModule

    Public Lock_search_string, ShowLock_Status As String

    Public Sub ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(ByVal SearchString As String,
                                                            ByVal LockNotLock As String)
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT TOP 100    [JOB_ORDER_NO]
                                      ,[CLIENTS_NAME]
                                      ,[OWNERS_NAME]
                                      ,[OWNERRES]
                                      ,[OWNERSOFFICE]
                                      ,[OWNERSMOBILE]
                                      ,[PROJECT_CLASSIFICATION]
                                      ,[PROJECT_SOURCE]
                                      ,[CONTRACT_INCLUSIONS]
                                      ,[PROFILE_FINISH]
                                      ,[PRODUCT_TYPE]
                                      ,[CONSTRUCTION_STAGE]
                                      ,[SITEMEETING]
                                      ,[ESTD_DEL_DATE]
                                      ,[ACCT_EXEC_INCHARGE]
                                      ,[PROJECT_ENGR_INCHARGE]
                                      ,[JOB_ORDER_NO_DATE]
                                      ,[QUOTE_REF_NO]
                                      ,[QUOTATION_DATE]
                                      ,[CUST_REF_NO]
                                      ,[FILE_LABEL_AS]
                                      ,[EFFECTIVE_DISCOUNT]
                                      ,[VAT]
                                      ,[CONTRACT_TYPE]
                                      ,[PREV_JOB_ORDER_NO]
                                      ,[PREV_QUOTE_NO]
                                      ,[PREV_QUOTATION_DATE]
                                      ,[PREV_ACCT_EXEC_INCHARGE]
                                      ,[OTHER_PERTINENT_INFO]
                                      ,[LOCK]
                                      ,[REF_JONO]
                                      ,[AUTONUM]
                                      ,[CLASS]
                                      ,[CONTRACT_PRICE]
                                      ,[JOB_ORDER_DESC]
                                      ,[PARENTJONO]
                                      ,[SUB_JO]
                                      ,[JO_ATTACHMENT]
                                      ,[MODE_OF_DEL]
                                      ,[MODE_OF_SHIP]
                                      ,[OUT_OF_TOWN_CHARGES]
                                      ,[DEL_GOODS]
                                      ,[CONTRACT_VAT_PROFILE]
                                      ,[ADDRESS_BILLING]
                                      ,[PROJECT_TYPE]
                                      ,[COMPANY_NAME]
                                      ,[PREV_OWNER]
                                      ,[CONTRACT_POINTS]
                                      ,[FRMPOINTS]
                                      ,[SCRPOINTS]
                                      ,[PROJECT_LABEL]
                                      ,[E_NICKNAME]
                                      ,[ADDRESS_TO]
                                      ,[DELGOODS_TO]
                                      ,[INPUTTED]
                                      ,[UPDATED]
                                      ,[POINTS_DATE]
                                      ,[EMAIL]
                                      ,[LISTPRICE]
                                      ,[DISCOUNTEDPRICE]
                                      ,[REPAIR_COST]
                                      ,[SALES_CREDIT]
                                      ,[ALLOCATED]
                                      ,[AREA]
                                      ,[NETCONTRACTPRICE]
                                      ,[FREEOFCHARGE]
                                      ,[TOTALADDITIONAL]
                                      ,[FULLADD]
                                      ,[TOTALLISTPRICE]
                                      ,[EFF]
                                      ,[STATUS]
                                      ,[ADDON]
                                      ,[FDELSTAT]
                                      ,[GDELSTAT]
                                      ,[COLLECTION]
                     FROM     [ADDENDUM_TO_CONTRACT_TB]

                     WHERE    [LOCK] like @LockNotLock AND
							  ([JOB_ORDER_NO] like @SearchString OR
                              [CLIENTS_NAME] like @SearchString OR
                              [UNITNO] like @SearchString OR
                              [ESTABLISHMENT] like @SearchString OR
                              [NO] like @SearchString OR
                              [STREET] like @SearchString OR
                              [VILLAGE] like @SearchString OR
                              [BRGY_MUNICIPALITY] like @SearchString OR
                              [TOWN_DISTRICT] like @SearchString OR
                              [PROVINCE] like @SearchString OR
                              [OWNERS_NAME] like @SearchString OR
                              [ACCT_EXEC_INCHARGE] like @SearchString OR
                              [PROJECT_ENGR_INCHARGE] like @SearchString OR
                              [QUOTE_REF_NO] like @SearchString OR
                              [CUST_REF_NO] like @SearchString OR
                              [COMPANY_NAME] like @SearchString OR
                              [PROJECT_LABEL] like @SearchString OR
                              [AREA] like @SearchString OR
                              [FULLADD] like @SearchString)"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
            sqlCommand.Parameters.AddWithValue("@LockNotLock", "%" & LockNotLock & "%")
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_ACCESS_TB")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_ACCESS_TB"
            Contracts.ContractsDGV.DataSource = sqlBindingSource

            With Contracts.ContractsDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            If Contracts.LockedContractsToolStripMenuItem.Checked = True Then
                For i = 0 To Contracts.ContractsDGV.Rows.Count - 1
                    Dim LOCK As String = Contracts.ContractsDGV.Rows(i).Cells("LOCK").Value.ToString

                    If LOCK = "1" And Contracts.LockedContractsToolStripMenuItem.Checked = True Then
                        Contracts.ContractsDGV.Rows(i).DefaultCellStyle.BackColor = Color.DarkGray
                    End If
                Next


                For ImageCounter As Integer = 0 To Contracts.ContractsDGV.Rows.Count - 1 Step +1
                    If Not Contracts.ContractsDGV.Rows(ImageCounter).Cells("IMG").Value = "" Then
                        Contracts.ContractsDGV.Rows(ImageCounter).Cells("JOB_ORDER_NO").Style.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
                    End If
                Next

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub



End Module
