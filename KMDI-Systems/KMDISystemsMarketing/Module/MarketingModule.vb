Imports ThoughtWorks.QRCode.Codec
Imports System.IO
Imports System.Data.SqlClient

Module MarketingModule

    'Dim sql As New sql3
    Dim Sqlcmd As New SqlCommand
    Dim read As SqlDataReader
    'Public query As String
    Public confirmQuery As Integer


    Public sqlds As New DataSet
    Public sqlda As New SqlDataAdapter
    Public sqlbs As New BindingSource

    Public maxCounter As Integer

    Public ItemCode_bool, Category_bool, ItemDescription_bool, Brand_bool,
            Color_bool, Size_bool, Gender_bool, PurchasedPrice_bool,
           DiscountedPrice_bool, Discount_bool, Quantity_bool, PurchasedDate_bool,
           ItemPurpose_bool, ItemClass_bool, InputtedBy_bool, UpdatedBy_bool As Boolean

    Public M_Ids As New Marketing_Inventory
    Public IfDeletedInventoryisOpen_bool As Boolean

    Public AE_ID As Integer

    Public AEorOthers As Boolean

    Public Sub MARKETING_INVENTORY_V2_READ_SEARCH(ByVal SearchString As String,
                                                  ByVal ItemStatus As Boolean)
        Try
            sqlds = New DataSet
            sqlda = New SqlDataAdapter
            sqlbs = New BindingSource

            sqlcon.Close()
            sqlcon.Open()

            sqlds.Clear()
            sqlbs.Clear()
            Query = "Select [MI_AUTONUMBER]
                                           ,[Item Code]
                                           ,[Category]
                                           ,[Brand]
                                           ,[Item Description]
                                           ,[Color]
                                           ,[Size]
                                           ,[Gender Preference]
                                           ,[Purchased Price]
                                           ,[Discounted Price]
                                           ,[Discount]
                                           ,[Quantity]
                                           ,[Purchased Date]
                                           ,[Item Purpose]
                                           ,[Item Classification]
                                           ,[Inputted By]
                                           ,[Updated By]
                                           ,[ITEM_IMAGE]
                                           ,[Remarks]
                                    from MARKETING_INVENTORY_V2
                                    WHERE [Item View Status] = @ItemStatus AND
                                         ([Item Code] LIKE @SearchString OR
                                          [Category] LIKE @SearchString OR
                                          [Brand] LIKE @SearchString OR
                                          [Item Description] LIKE @SearchString OR
                                          [Color] LIKE @SearchString OR
                                          [Size] LIKE @SearchString OR
                                          [Gender Preference] LIKE @SearchString OR
                                          [Item Purpose] LIKE @SearchString OR
                                          [Item Classification] LIKE @SearchString OR
                                          [Inputted By] LIKE @SearchString OR
                                          [Updated By] LIKE @SearchString)
                                    ORDER BY [Item Code] asc"
            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
            Sqlcmd.Parameters.AddWithValue("@ItemStatus", ItemStatus)
            sqlda.SelectCommand = Sqlcmd
            sqlda.Fill(sqlds, "MARKETING_INVENTORY_V2")
            sqlbs.DataSource = sqlds
            sqlbs.DataMember = "MARKETING_INVENTORY_V2"
            If IfDeletedInventoryisOpen_bool = False Then
                Inventory.InventoryDGV.DataSource = sqlbs

                With Inventory.InventoryDGV
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                End With

            ElseIf IfDeletedInventoryisOpen_bool = True Then
                DeletedInventory.DeletedInventoryDGV.DataSource = sqlbs

                With DeletedInventory.DeletedInventoryDGV
                    .DefaultCellStyle.BackColor = Color.Black
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub
    Public Sub MarketingCategory()
        Try
            sqlds = New DataSet
            sqlda = New SqlDataAdapter
            sqlbs = New BindingSource

            sqlcon.Close()
            sqlcon.Open()

            sqlds.Clear()
            sqlbs.Clear()
            Dim str As String = "Select DISTINCT(Category)
                                 From CATEGORYUPDATE"
            sqlda.SelectCommand = New SqlCommand(str, sqlcon)
            sqlda.Fill(sqlds, "CATEGORYUPDATE_CBOX_POPULATE")
            sqlbs.DataSource = sqlds
            sqlbs.DataMember = "CATEGORYUPDATE_CBOX_POPULATE"
            Inventory.CategoryCbox.DataSource = sqlbs
            Inventory.CategoryCbox.ValueMember = "Category"
            Inventory.CategoryCbox.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public MARKETING_INVENTORY_V2_HasDuplicateEntry_bool As Boolean

    Public Sub MARKETING_INVENTORY_V2_SearchForDuplicateEntry(ByVal ItemCode As String)
        Try
            sqlcon.Close()
            sqlcon.Open()
            Dim Query As String = "Select [Item Code]
                                         ,[Item Description]
                                     from [MARKETING_INVENTORY_V2] 
                                     where [Item Code] = @ItemCode"
            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("@ItemCode", ItemCode)
            read = Sqlcmd.ExecuteReader
            read.Read()
            If read.HasRows Then
                MetroFramework.MetroMessageBox.Show(Inventory, "Error -->> Multiple item code detected in conflict with " & read(0).ToString & " with item " & read(1).ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MARKETING_INVENTORY_V2_HasDuplicateEntry_bool = True
            Else
                MARKETING_INVENTORY_V2_HasDuplicateEntry_bool = False
            End If
            read.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public MARKETING_INVENTORY_V2_DBMaintenance_bool As Boolean
    Public MARKETING_INVENTORY_V2_CountSucess As Integer = Nothing

    Public Sub MARKETING_INVENTORY_V2_SaveInventoryItem(ByVal ITEM_CODE As String,
                                                        ByVal CATEGORY As String,
                                                        ByVal BRAND As String,
                                                        ByVal ITEM_DESCRIPTION As String,
                                                        ByVal Color As String,
                                                        ByVal Size As String,
                                                        ByVal GENDER_PREFERENCE As String,
                                                        ByVal PURCHASEDPRICE As Decimal,
                                                        ByVal DISCOUNTEDPRICE As Decimal,
                                                        ByVal DISCOUNT As Decimal,
                                                        ByVal QUANTITY As Integer,
                                                        ByVal PURCHASEDDATE As String,
                                                        ByVal ITEMPURPOSE As String,
                                                        ByVal ITEMCLASSIFICATION As String,
                                                        ByVal QUANTITY_OF_DELIVERY As String,
                                                        ByVal REMARKS As String,
                                                        ByVal INPUTTED_BY As String,
                                                        ByVal CATEGORY_CODE As String,
                                                        ByVal IF_GENERATED_QR_STATUS As Boolean)
        Try
            sqlcon.Close()
            sqlcon.Open()

            Query = "insert into MARKETING_INVENTORY_V2 ([Item Code]
                                                         ,[Category]
                                                         ,[Brand]
                                                         ,[Item Description]
                                                         ,[Color]
                                                         ,[Size]
                                                         ,[Gender Preference]
                                                         ,[Purchased Price]
                                                         ,[Discounted Price]
                                                         ,[Discount]
                                                         ,[Quantity]
                                                         ,[Purchased Date]
                                                         ,[Item Purpose]
                                                         ,[Item Classification]
                                                         ,[Remarks]
                                                         ,[Inputted By]
                                                         ,[Category Code]
                                                         ,[Item View Status]
                                                         ,[If Generated QR Status])
                                       VALUES(@ITEM_CODE, 
                                             @CATEGORY,
                                             @BRAND,
                                             @ITEM_DESCRIPTION,
                                             @COLOR,
                                             @SIZE,
                                             @GENDER_PREFERENCE,
                                             @PURCHASEDPRICE,
                                             @DISCOUNTEDPRICE,
                                             @DISCOUNT,
                                             @QUANTITY,
                                             @PURCHASEDDATE,
                                             @ITEMPURPOSE,
                                             @ITEMCLASSIFICATION,
                                             @REMARKS,
                                             @INPUTTED_BY,
                                             @CATEGORY_CODE,
                                             @Item_View_Status,
                                             @IF_GENERATED_QR_STATUS)"

            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("@ITEM_CODE", ITEM_CODE)
            Sqlcmd.Parameters.AddWithValue("@CATEGORY", CATEGORY)
            Sqlcmd.Parameters.AddWithValue("@BRAND", BRAND)
            Sqlcmd.Parameters.AddWithValue("@ITEM_DESCRIPTION", ITEM_DESCRIPTION)
            Sqlcmd.Parameters.AddWithValue("@COLOR", Color)
            Sqlcmd.Parameters.AddWithValue("@SIZE", Size)
            Sqlcmd.Parameters.AddWithValue("@GENDER_PREFERENCE", GENDER_PREFERENCE)
            Sqlcmd.Parameters.AddWithValue("@PURCHASEDPRICE", PURCHASEDPRICE)
            Sqlcmd.Parameters.AddWithValue("@DISCOUNTEDPRICE", DISCOUNTEDPRICE)
            Sqlcmd.Parameters.AddWithValue("@DISCOUNT", DISCOUNT)
            Sqlcmd.Parameters.AddWithValue("@QUANTITY", QUANTITY)
            Sqlcmd.Parameters.AddWithValue("@PURCHASEDDATE", PURCHASEDDATE)
            Sqlcmd.Parameters.AddWithValue("@ITEMPURPOSE", ITEMPURPOSE)
            Sqlcmd.Parameters.AddWithValue("@ITEMCLASSIFICATION", ITEMCLASSIFICATION)
            Sqlcmd.Parameters.AddWithValue("@QUANTITY_OF_DELIVERY", QUANTITY_OF_DELIVERY)
            Sqlcmd.Parameters.AddWithValue("@REMARKS", REMARKS)
            Sqlcmd.Parameters.AddWithValue("@INPUTTED_BY", INPUTTED_BY)
            Sqlcmd.Parameters.AddWithValue("@CATEGORY_CODE", CATEGORY_CODE)
            Sqlcmd.Parameters.AddWithValue("@Item_View_Status", True)
            Sqlcmd.Parameters.AddWithValue("@IF_GENERATED_QR_STATUS", IF_GENERATED_QR_STATUS)
            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then

                ' MetroFramework.MetroMessageBox.Show(Inventory, "Record added successfully.", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_CountSucess += 1
            Else
                MetroFramework.MetroMessageBox.Show(Inventory, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub MARKETING_INVENTORY_V2_EditInventoryItem(ByVal ItemRefNo As String,
                                                        ByVal Category As String,
                                                        ByVal BRAND As String,
                                                        ByVal ITEM_DESCRIPTION As String,
                                                        ByVal Color As String,
                                                        ByVal Size As String,
                                                        ByVal GENDER_PREFERENCE As String,
                                                        ByVal PURCHASEDPRICE As Decimal,
                                                        ByVal DISCOUNTEDPRICE As Decimal,
                                                        ByVal DISCOUNT As Decimal,
                                                        ByVal QUANTITY As Integer,
                                                        ByVal PURCHASEDDATE As String,
                                                        ByVal ITEMPURPOSE As String,
                                                        ByVal ITEMCLASSIFICATION As String,
                                                        ByVal QUANTITY_OF_DELIVERY As String,
                                                        ByVal REMARKS As String,
                                                        ByVal UPDATED_BY As String,
                                                        ByVal IF_GENERATED_QR_STATUS As Boolean)

        Try
            sqlcon.Close()
            sqlcon.Open()

            Query = "UPDATE MARKETING_INVENTORY_V2 SET [Brand] = @Brand,
                                                       [Category] = @Category,
                                                       [Item Description] = @ITEM_DESCRIPTION,
                                                       [Color] = @COLOR,
                                                       [Size] = @SIZE,
                                                       [Gender Preference] = @GENDER_PREFERENCE,
                                                       [Quantity] = @QUANTITY,
                                                       [Purchased Price] = @PURCHASED_PRICE,
                                                       [Discounted Price] = @DISCOUNTED_PRICE,
                                                       [Discount] = @DISCOUNT,
                                                       [Purchased Date] = @PURCHASED_DATE,
                                                       [Item Purpose] = @ITEM_PURPOSE,
                                                       [Item Classification] = @ITEM_CLASSIFICATION,
                                                       [Updated By] = @UPDATED_BY,
                                                       [If Generated QR Status] = @IF_GENERATED_QR_STATUS,
                                                       [Remarks] = @Remarks
                                               WHERE [MI_AUTONUMBER] = @ItemRefNo"
            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("@ItemRefNo", ItemRefNo)
            Sqlcmd.Parameters.AddWithValue("@Brand", BRAND)
            Sqlcmd.Parameters.AddWithValue("@Category", Category)
            Sqlcmd.Parameters.AddWithValue("@ITEM_DESCRIPTION", ITEM_DESCRIPTION)
            Sqlcmd.Parameters.AddWithValue("@COLOR", Color)
            Sqlcmd.Parameters.AddWithValue("@SIZE", Size)
            Sqlcmd.Parameters.AddWithValue("@GENDER_PREFERENCE", GENDER_PREFERENCE)
            Sqlcmd.Parameters.AddWithValue("@QUANTITY", QUANTITY)
            Sqlcmd.Parameters.AddWithValue("@PURCHASED_PRICE", PURCHASEDPRICE)
            Sqlcmd.Parameters.AddWithValue("@DISCOUNTED_PRICE", DISCOUNTEDPRICE)
            Sqlcmd.Parameters.AddWithValue("@DISCOUNT", DISCOUNT)
            Sqlcmd.Parameters.AddWithValue("@PURCHASED_DATE", PURCHASEDDATE)
            Sqlcmd.Parameters.AddWithValue("@ITEM_PURPOSE", ITEMPURPOSE)
            Sqlcmd.Parameters.AddWithValue("@ITEM_CLASSIFICATION", ITEMCLASSIFICATION)
            Sqlcmd.Parameters.AddWithValue("@UPDATED_BY", UPDATED_BY)
            Sqlcmd.Parameters.AddWithValue("@IF_GENERATED_QR_STATUS", IF_GENERATED_QR_STATUS)
            Sqlcmd.Parameters.AddWithValue("@Remarks", REMARKS)

            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then
                'MetroFramework.MetroMessageBox.Show(Inventory, "Record Updated successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_CountSucess += 1
            Else
                MetroFramework.MetroMessageBox.Show(Inventory, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub MARKETING_INVENTORY_V2_DeleteInventoryItem(ByVal ItemRefNo As String,
                                                          ByVal ItemMethod As String,
                                                          ByVal Item_View_Status As Boolean)
        Try
            sqlcon.Close()
            sqlcon.Open()

            Query = "UPDATE MARKETING_INVENTORY_V2 SET [Item View Status] = @Item_View_Status
                     WHERE [MI_AUTONUMBER] = @ItemRefNo"

            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("ItemRefNo", ItemRefNo)
            Sqlcmd.Parameters.AddWithValue("Item_View_Status", Item_View_Status)
            confirmQuery = Sqlcmd.ExecuteNonQuery

            If confirmQuery <> 0 Then

                MetroFramework.MetroMessageBox.Show(Inventory, "Record " & ItemMethod & " successfully.", ItemMethod & " Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = True
            Else
                MetroFramework.MetroMessageBox.Show(Inventory, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub Updateimage(ByVal ItemRefNo As String,
                           ByVal ItemCode As String,
                           ByVal Category As String)
        Try
            sqlcon.Close()
            sqlcon.Open()
            Dim x As String = "http://121.58.229.248:8083/Marketing%20Inventory"

            Query = "UPDATE MARKETING_INVENTORY_V2 set
                                 ITEM_IMAGE = @ITEM_IMAGE
                                 WHERE [MI_AUTONUMBER] = @ItemRefNo"

            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("@ITEM_IMAGE", x & "/" & ItemCode & "/" & Category & ".jpeg")
            Sqlcmd.Parameters.AddWithValue("@ItemRefNo", ItemRefNo)
            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then

                MetroFramework.MetroMessageBox.Show(ViewInventoryImage, "Record Updated successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = True
            Else
                MetroFramework.MetroMessageBox.Show(ViewInventoryImage, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub CATEGORYUPDATE_READ()
        Try
            sqlds = New DataSet
            sqlda = New SqlDataAdapter
            sqlbs = New BindingSource

            sqlcon.Close()
            sqlcon.Open()

            sqlds.Clear()
            sqlbs.Clear()
            Sqlcmd = New SqlCommand("Select [CategoryKey],
                                            [Category Code],
                                            [Category] as [Category Name]
                                     from CATEGORYUPDATE", sqlcon)
            sqlda.SelectCommand = Sqlcmd
            sqlda.Fill(sqlds, "CATEGORYUPDATE_READ")
            sqlbs.DataSource = sqlds
            sqlbs.DataMember = "CATEGORYUPDATE_READ"
            Category_Update.CategoryDGV.DataSource = sqlbs

            With Category_Update.CategoryDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Category_Update.CategoryDGV.Columns("CategoryKey").Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub CATEGORYUPDATE_AddCategory(ByVal addcategoryname As String,
                                          ByVal addcategorycode As String)

        Try
            sqlcon.Close()
            sqlcon.Open()
            Query = "Insert into CATEGORYUPDATE (Category,[Category Code])                                                   
                                         VALUES (@addcategoryname,@addcategorycode)"

            Sqlcmd = New SqlCommand(Query, sqlcon)

            Sqlcmd.Parameters.AddWithValue("@addcategoryname", addcategoryname)
            Sqlcmd.Parameters.AddWithValue("@addcategorycode", addcategorycode)
            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(Category_Update, "Record Added successfully.", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = True
            Else
                MetroFramework.MetroMessageBox.Show(Category_Update, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub CATEGORYUPDATE_UpdateCategory(ByVal updcategoryname As String,
                                             ByVal updcategorycode As String,
                                             ByVal UpdCategoryKey As String)

        Try
            sqlcon.Close()
            sqlcon.Open()
            Query = "UPDATE CATEGORYUPDATE SET Category=@updcategoryname,[Category Code]=@updcategorycode                                                   
                                           WHERE [CategoryKey] = @CategoryKey"

            Sqlcmd = New SqlCommand(Query, sqlcon)

            Sqlcmd.Parameters.AddWithValue("@updcategoryname", updcategoryname)
            Sqlcmd.Parameters.AddWithValue("@updcategorycode", updcategorycode)
            Sqlcmd.Parameters.AddWithValue("@CategoryKey", UpdCategoryKey)
            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(Category_Update, "Record Updated successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = True
            Else
                MetroFramework.MetroMessageBox.Show(Category_Update, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub CATEGORYUPDATE_DeleteCategory(ByVal delCategoryKey As String)

        Try
            sqlcon.Close()
            sqlcon.Open()
            Query = "DELETE FROM CATEGORYUPDATE WHERE [CategoryKey] = @delCategoryKey"

            Sqlcmd = New SqlCommand(Query, sqlcon)

            Sqlcmd.Parameters.AddWithValue("@delCategoryKey", delCategoryKey)
            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(Category_Update, "Record Deleted successfully.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = True
            Else
                MetroFramework.MetroMessageBox.Show(Category_Update, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MARKETING_INVENTORY_V2_DBMaintenance_bool = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public maxMI_AUTONUMBER As String
    Public acctAutonum As String

    Public Sub MARKETING_INVENTORY_V2_QRCodeGeneration()
        Try
            sqlcon.Close()
            sqlcon.Open()
            Dim Query As String = "SELECT max([MI_AUTONUMBER]) FROM MARKETING_INVENTORY_V2"
            Sqlcmd = New SqlCommand(Query, sqlcon)
            read = Sqlcmd.ExecuteReader
            read.Read()
            If read.HasRows Then
                maxMI_AUTONUMBER = read.Item(0).ToString
            End If
            read.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub MARKETING_INVENTORY_V2_QRCODES_PRINT()
        Dim sqlds As New Marketing_Inventory
        sqlda = New SqlDataAdapter
        sqlbs = New BindingSource
        Dim QRImage As Image
        Dim byteToStr As String

        Try
            sqlcon.Close()
            sqlcon.Open()
            Query = " select  [Item Description] as Item_Description,
                              [Brand],
                              [Item Code] as QRCodes
                      FROM [MARKETING_INVENTORY_V2]
                      WHERE [If Generated QR Status] = 1"

            Sqlcmd = New SqlCommand(Query, sqlcon)
            sqlda.SelectCommand = Sqlcmd
            sqlda.Fill(sqlds.QRCODES)
            Print_QRCodes.QRCODESBindingSource.DataSource = sqlds.QRCODES.DefaultView


            Dim QRCodeEncoder As New QRCodeEncoder

            QRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            QRCodeEncoder.QRCodeScale = 5
            QRCodeEncoder.QRCodeVersion = 1
            QRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L


            If sqlds.QRCODES.Rows.Count >= 0 Then
                For i As Integer = 0 To sqlds.QRCODES.Rows.Count - 1
                    Dim QRs As String
                    QRs = sqlds.QRCODES.Rows(i).Item("QRCodes").ToString
                    QRImage = QRCodeEncoder.Encode(QRs)

                    Dim mstream As New MemoryStream()
                    QRImage.Save(mstream, Imaging.ImageFormat.Jpeg)
                    Dim arrimage() As Byte = mstream.ToArray()
                    byteToStr = Convert.ToBase64String(arrimage)

                    sqlds.QRCODES.Rows(i).Item("QRImage") = byteToStr
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public Sub MARKETING_INVENTORY_V2_SaveLogs(ByVal Activity As String)
        Try
            sqlcon.Close()
            sqlcon.Open()

            Query = "insert into LOGS_TB ([Activity])
                                       VALUES(@Activity)"

            Sqlcmd = New SqlCommand(Query, sqlcon)
            Sqlcmd.Parameters.AddWithValue("@Activity", Activity)
            confirmQuery = Sqlcmd.ExecuteNonQuery()

            If confirmQuery <> 0 Then
                ' MetroFramework.MetroMessageBox.Show(Inventory, "Record added successfully.", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MARKETING_INVENTORY_V2_CountSucess += 1
            Else
                MetroFramework.MetroMessageBox.Show(Inventory, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            sqlcon.Close()
        End Try
    End Sub

    Public OverallCP As Decimal

    Public Sub Marketing_AnalysisReport_OverallCP(ByVal DateLookBack As String)
        'sqlcon.Close()
        'sqlcon.Open()
        Dim Query As String = "
SELECT	SUM(SXTH_TBL.[INITIAL_CP]) as [Overall Credit Points]
FROM	(
		SELECT	DISTINCT	FFTH_TBL.COUNT_COMPANY,
							FFTH_TBL.OFFICENAME,
							FFTH_TBL.JO,
							FFTH_TBL.DISCOUNTEDPRICE,
							((FFTH_TBL.DISCOUNTEDPRICE)/FFTH_TBL.COUNT_COMPANY)*0.01 as [INITIAL_CP]
		FROM	(
				SELECT	TRD_TBL.COUNT_COMPANY,
						TRD_TBL.JO,
						TRD_TBL.OFFICENAME,
						FRTH_TBL.DISCOUNTEDPRICE
				FROM	(
						SELECT	ARCHILINK.OFFICENAME,
								SEC_TBL.JO,
								SEC_TBL.COUNT_COMPANY
						FROM	(
								SELECT	COUNT(BASE_TBL.OFFICENAME) as [COUNT_COMPANY],
										BASE_TBL.JO
								FROM	(
										SELECT	DISTINCT	OFFICENAME,
															JO
										FROM ARCHITECTTOJO_TB
								) as BASE_TBL
								GROUP BY BASE_TBL.JO
						) as SEC_TBL
						join ARCHITECTTOJO_TB [ARCHILINK]
						on SEC_TBL.JO = ARCHILINK.JO
						WHERE	[ARCHILINK].OFFICENAME <> ''AND
								[ARCHILINK].OFFICENAME <> 'N/A' AND
								[ARCHILINK].OFFICENAME <> 'NO' AND
								[ARCHILINK].OFFICENAME <> 'TBA' AND
								[ARCHILINK].OFFICENAME <> 'T/F'
				) as TRD_TBL
				join	(
						SELECT	JOB_ORDER_NO as [JO],
								DISCOUNTEDPRICE
						FROM	ADDENDUM_TO_CONTRACT_TB
						WHERE	JOB_ORDER_NO = PARENTJONO AND
								DISCOUNTEDPRICE is not null AND
								DISCOUNTEDPRICE <> 0 AND
								--[JOB_ORDER_NO_DATE] >= '1997-07-01' AND 
								[JOB_ORDER_NO_DATE] >= @DateLookBack AND 
								[JOB_ORDER_NO_DATE] <= Concat(YEAR(getdate()), '-06-30') AND
								[JOB_ORDER_NO] not like '%CO%' AND
								[JOB_ORDER_NO] not like '%CC%'
				) as FRTH_TBL
				on TRD_TBL.JO = FRTH_TBL.JO
		) as FFTH_TBL
) as SXTH_TBL"
        'Sqlcmd = New SqlCommand(Query, sqlcon)
        'Sqlcmd.Parameters.AddWithValue("@DateLookBack", DateLookBack & "-07-1")
        'read = Sqlcmd.ExecuteReader
        'read.Read()
        'If read.HasRows Then
        '    OverallCP = read.Item("Overall Credit Points").ToString
        'End If
        'read.Close()

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(Query, sqlcon)
                Sqlcmd.Parameters.AddWithValue("@DateLookBack", DateLookBack & "-07-1")
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        OverallCP = read.Item("Overall Credit Points").ToString
                    End While
                End Using
            End Using
        End Using

    End Sub

    Public OverallInvPrice As Decimal
    Public TotalQty As Integer

    Public OverallInvPrice_FOR_REQUESTOR As Decimal

    Public Sub Marketing_AnalysisReport_OverallInventory()

        Dim Query As String = " Select sum(Quantity) as [Total Quantity],
                                           sum([Purchased Price]*[Quantity]) as [Overall Total Inventory Price] 
                                    FROM  MARKETING_INVENTORY_V2 
                                    where [Item View Status] = 1"
        'Sqlcmd = New SqlCommand(Query, sqlcon)
        'read = Sqlcmd.ExecuteReader
        'read.Read()
        'If read.HasRows Then
        '    TotalQty = read.Item("Total Quantity").ToString
        '    OverallInvPrice = read.Item("Overall Total Inventory Price").ToString
        '    OverallInvPrice_FOR_REQUESTOR = read.Item("Overall Total Inventory Price").ToString
        'End If
        'read.Close()

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(Query, sqlcon)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        TotalQty = read.Item("Total Quantity").ToString
                        OverallInvPrice = read.Item("Overall Total Inventory Price").ToString
                        OverallInvPrice_FOR_REQUESTOR = read.Item("Overall Total Inventory Price").ToString
                    End While
                End Using
            End Using
        End Using
    End Sub
    Public OverallCPConsumed As Decimal
    Public OverallConsumedQty As Integer

    Public OverallCPConsumed_OF_Requestor As Decimal

    Public Sub Marketing_AnalysisReport_OverallConsumedCP()

        Dim Query As String = " Declare @TGComp money
  Declare @TGEmp money
  Declare @TGSpecial money

  Declare @TQtyComp int
  Declare @TQtyEmp int
  Declare @TQtySpecial int

  select @TGComp = iif(sum([Total Price of Gift]) is null,0,sum([Total Price of Gift])) from GIFT_REQUEST_COMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'
  select @TQtyComp = iif(sum(quantity) is null,0,sum(quantity)) from GIFT_REQUEST_COMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'

  
  select @TGEmp = iif(sum([Total Price of Gift]) is null,0,sum([Total Price of Gift])) from GIFT_REQUEST_EMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'
  select @TQtyEmp = iif(sum(quantity) is null,0,sum(quantity)) from GIFT_REQUEST_EMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'

  select @TGSpecial = iif(sum([SP_Price]) is null,0,sum([SP_Price])) from GIFT_REQUEST_SPECIAL where [Request Status] = 'Pending' or [Request Status] = 'Approved'
  select @TQtySpecial = iif(sum(quantity) is null,0,sum(quantity)) from GIFT_REQUEST_SPECIAL where [Request Status] = 'Pending' or [Request Status] = 'Approved'

  Declare @OverallConsumedCp money
  Select @OverallConsumedCp = @TGComp + @TGEmp + @TGSpecial

  Declare @OverallConsumedQty int
  Select @OverallConsumedQty = @TQtyComp + @TQtyEmp + @TQtySpecial

  Select @OverallConsumedCp as OverallConsumedCp,@OverallConsumedQty as OverallConsumedQty"
        'Sqlcmd = New SqlCommand(Query, sqlcon)
        'read = Sqlcmd.ExecuteReader
        'read.Read()
        'If read.HasRows Then
        '    OverallCPConsumed = read.Item("OverallConsumedCp").ToString
        '    OverallConsumedQty = read.Item("OverallConsumedQty").ToString
        'End If
        'read.Close()

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(Query, sqlcon)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        OverallCPConsumed = read.Item("OverallConsumedCp").ToString
                        OverallConsumedQty = read.Item("OverallConsumedQty").ToString
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub SalesGiftRequest_TotalExpenseOFRequestor()

        Dim Query As String = " Declare @TGComp money
  Declare @TGEmp money
  Declare @TGSpecial money

  select @TGComp = iif(sum([Total Price of Gift]) is null,0,sum([Total Price of Gift])) from GIFT_REQUEST_COMP where ([Request Status] = 'Pending' or [Request Status] = 'Approved')
					AND Requestor_ID = @Requestor_ID
  
  select @TGEmp = iif(sum([Total Price of Gift]) is null,0,sum([Total Price of Gift])) from GIFT_REQUEST_EMP where ([Request Status] = 'Pending' or [Request Status] = 'Approved')
					AND Requestor_ID = @Requestor_ID

  select @TGSpecial = iif(sum([SP_Price]) is null,0,sum([SP_Price])) from GIFT_REQUEST_SPECIAL where ([Request Status] = 'Pending' or [Request Status] = 'Approved')
					AND Requestor_ID = @Requestor_ID
					
  Declare @OverallConsumedCp money
  Select @OverallConsumedCp = @TGComp + @TGEmp + @TGSpecial

  Select @OverallConsumedCp as OverallConsumedCp"
        'Sqlcmd = New SqlCommand(Query, sqlcon)
        'Sqlcmd.Parameters.AddWithValue("@Requestor_ID", KMDISystemsGlobalModule.AccountAutonum)
        'read = Sqlcmd.ExecuteReader
        'read.Read()
        'If read.HasRows Then
        '    OverallCPConsumed_OF_Requestor = read.Item("OverallConsumedCp").ToString
        'End If
        'read.Close()

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(Query, sqlcon)
                Sqlcmd.Parameters.AddWithValue("@Requestor_ID", AccountAutonum)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        OverallCPConsumed_OF_Requestor = read.Item("OverallConsumedCp").ToString
                    End While
                End Using
            End Using
        End Using
    End Sub


    Public AEIC, ACCTYPE As String
    Public TotalQTYperSales, TotalQTYOthers As Integer
    Public TotalPRICEperSales, TotalPRICEOthers As Decimal
    Public GCG_BPercent, JMC_BPercent, RLB_BPercent, WBB_BPercent, AOS_BPercent, CCA_BPercent, JLS_BPercent, DLN_BPercent, MLM_BPercent, LLA_BPercent,
           RRE_BPercent, JMV_BPercent, Others_BPercent As String
    Public GCG_Blue, JMC_Blue, RLB_Blue, WBB_Blue, AOS_Blue, CCA_Blue, JLS_Blue, DLN_Blue, MLM_Blue, LLA_Blue,
           RRE_Blue, JMV_Blue, Others_Blue As Decimal

    Public GCG_GPercent, JMC_GPercent, RLB_GPercent, WBB_GPercent, AOS_GPercent, CCA_GPercent, JLS_GPercent, DLN_GPercent, MLM_GPercent, LLA_GPercent,
           RRE_GPercent, JMV_GPercent, Others_GPercent As String
    Public GCG_Green, JMC_Green, RLB_Green, WBB_Green, AOS_Green, CCA_Green, JLS_Green, DLN_Green, MLM_Green, LLA_Green,
           RRE_Green, JMV_Green, Others_Green As Integer

    Public GCG_LPercent, JMC_LPercent, RLB_LPercent, WBB_LPercent, AOS_LPercent, CCA_LPercent, JLS_LPercent, DLN_LPercent, MLM_LPercent, LLA_LPercent,
           RRE_LPercent, JMV_LPercent, Others_LPercent As String
    Public GCG_Lime, JMC_Lime, RLB_Lime, WBB_Lime, AOS_Lime, CCA_Lime, JLS_Lime, DLN_Lime, MLM_Lime, LLA_Lime,
           RRE_Lime, JMV_Lime, Others_Lime As Decimal

    Public GCG_Str = "Gena Garcia",
            JMC_Str = "Mr. Jayson M. Comia",
            RLB_Str = "Mr. Rafael John L. Bigornia",
            WBB_Str = "Mr. Whally B. Barro",
            AOS_Str = "Mr. Alexander Raymond O. Salas",
            CCA_Str = "Ms. Cate C. Almeda",
            JLS_Str = "Mr. John Leo Santos",
            DLN_Str = "Ms. Dorothy L. Nechaldas",
            MLM_Str = "Ms. Maui L. Miranda",
            LLA_Str = "Ms. Liezl L. Aquino",
            RRE_Str = "Mr. Ralph R. Englatera",
            JMV_Str As String = "Mr. Jayson M. Villanueva"

    Public Sub AEIC_Monitoring()
        Dim query As String = "SELECT  Request_Tbl.[Inputted By],
		acct.ACCTTYPE,
		Sum([Total Price of Gift]) as [TotalPRICEperSales],
		sum([Quantity]) as [TotalQTYperSales],
		Request_Tbl.[Requestor_ID]
FROM
(
	Select [Inputted By],
			[Requestor_ID],
			sum([Total Price of Gift]) as [Total Price of Gift], 
			sum(Quantity) as [Quantity]
	From GIFT_REQUEST_COMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'
	group by [Inputted By],
			[Requestor_ID]
	UNION ALL
	Select [Inputted By],
			[Requestor_ID],
			sum([Total Price of Gift]) as [Total Price of Gift], 
			sum(Quantity) as [Quantity]
	From GIFT_REQUEST_EMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'
	group by [Inputted By],
			[Requestor_ID]
	UNION ALL
	Select [Inputted By],
			[Requestor_ID],
			sum([SP_Price]) as [Total Price of Gift], 
			sum(Quantity) as [Quantity]
	From GIFT_REQUEST_SPECIAL where [Request Status] = 'Pending' or [Request Status] = 'Approved'
	group by [Inputted By],
			[Requestor_ID]
) Request_Tbl
	join KMDI_ACCT_TB [acct]
	on Request_Tbl.[Requestor_ID] = acct.AUTONUM
group by Request_Tbl.[Inputted By],
		Request_Tbl.[Requestor_ID],
		 acct.ACCTTYPE"

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(query, sqlcon)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        AEIC = read.GetString(0)
                        ACCTYPE = read.GetString(1)
                        TotalPRICEperSales = read.GetDecimal(2)
                        TotalQTYperSales = read.GetInt32(3)

                        If AEIC = GCG_Str Then
                            GCG_Blue = TotalPRICEperSales
                            GCG_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            GCG_Green = TotalQTYperSales
                            GCG_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            GCG_Lime = TotalPRICEperSales
                            GCG_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = JMC_Str Then
                            JMC_Blue = TotalPRICEperSales
                            JMC_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            JMC_Green = TotalQTYperSales
                            JMC_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            JMC_Lime = TotalPRICEperSales
                            JMC_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = RLB_Str Then
                            RLB_Blue = TotalPRICEperSales
                            RLB_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            RLB_Green = TotalQTYperSales
                            RLB_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            RLB_Lime = TotalPRICEperSales
                            RLB_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = WBB_Str Then
                            WBB_Blue = TotalPRICEperSales
                            WBB_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            WBB_Green = TotalQTYperSales
                            WBB_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            WBB_Lime = TotalPRICEperSales
                            WBB_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = AOS_Str Then
                            AOS_Blue = TotalPRICEperSales
                            AOS_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            AOS_Green = TotalQTYperSales
                            AOS_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            AOS_Lime = TotalPRICEperSales
                            AOS_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = CCA_Str Then
                            CCA_Blue = TotalPRICEperSales
                            CCA_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            CCA_Green = TotalQTYperSales
                            CCA_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            CCA_Lime = TotalPRICEperSales
                            CCA_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = JLS_Str Then
                            JLS_Blue = TotalPRICEperSales
                            JLS_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            JLS_Green = TotalQTYperSales
                            JLS_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            JLS_Lime = TotalPRICEperSales
                            JLS_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = DLN_Str Then
                            DLN_Blue = TotalPRICEperSales
                            DLN_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            DLN_Green = TotalQTYperSales
                            DLN_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            DLN_Lime = TotalPRICEperSales
                            DLN_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = MLM_Str Then
                            MLM_Blue = TotalPRICEperSales
                            MLM_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            MLM_Green = TotalQTYperSales
                            MLM_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            MLM_Lime = TotalPRICEperSales
                            MLM_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = LLA_Str Then
                            LLA_Blue = TotalPRICEperSales
                            LLA_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            LLA_Green = TotalQTYperSales
                            LLA_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            LLA_Lime = TotalPRICEperSales
                            LLA_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = RRE_Str Then
                            RRE_Blue = TotalPRICEperSales
                            RRE_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            RRE_Green = TotalQTYperSales
                            RRE_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            RRE_Lime = TotalPRICEperSales
                            RRE_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        ElseIf AEIC = JMV_Str Then
                            JMV_Blue = TotalPRICEperSales
                            JMV_BPercent = Math.Round((TotalPRICEperSales / OverallCP) * 100, 2) & "%"

                            JMV_Green = TotalQTYperSales
                            JMV_GPercent = Math.Round((TotalQTYperSales / TotalQty) * 100, 2) & "%"

                            JMV_Lime = TotalPRICEperSales
                            JMV_LPercent = Math.Round((TotalPRICEperSales / OverallInvPrice) * 100, 2) & "%"
                        End If

                    End While
                End Using
            End Using
        End Using
    End Sub
    Public Sub OTHERS_Monitoring()
        Dim query As String = "SELECT  --Request_Tbl.[Inputted By],
		iif(Sum([Total Price of Gift]) is null,0,Sum([Total Price of Gift])) as [TotalPRICEperSales],
		iif(sum([Quantity]) is null,0,sum([Quantity])) as [TotalQTYperSales]
		--acct.ACCTTYPE
FROM
(
	Select [Inputted By],[Requestor_ID],iif(Sum([Total Price of Gift]) is null,0,Sum([Total Price of Gift])) as [Total Price of Gift],
			iif(sum(Quantity) is null,0,sum(Quantity)) as [Quantity]
	From GIFT_REQUEST_COMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'
	group by [Inputted By],
			[Requestor_ID]
	UNION ALL
	Select [Inputted By],[Requestor_ID],iif(Sum([Total Price of Gift]) is null,0,Sum([Total Price of Gift])) as [Total Price of Gift],
			iif(sum(Quantity) is null,0,sum(Quantity)) as [Quantity]
	From GIFT_REQUEST_EMP where [Request Status] = 'Pending' or [Request Status] = 'Approved'
	group by [Inputted By],
			[Requestor_ID]
	UNION ALL
	Select [Inputted By],[Requestor_ID],iif(sum([SP_Price]) is null,0,sum([SP_Price])) as [Total Price of Gift], 
			iif(sum(Quantity) is null,0,sum(Quantity)) as [Quantity]
	From GIFT_REQUEST_SPECIAL where [Request Status] = 'Pending' or [Request Status] = 'Approved'
	group by [Inputted By],
			[Requestor_ID]
) Request_Tbl
	join KMDI_ACCT_TB [acct]
	on Request_Tbl.[Requestor_ID] = acct.AUTONUM
WHERE   [Inputted By] <> 'Mr. Alexander Raymond O. Salas' AND 
		[Inputted By] <> 'Mr. Jayson M. Comia' AND 
		[Inputted By] <> 'Gena Garcia' AND 
		[Inputted By] <> 'Mr. Rafael John L. Bigornia' AND 
		[Inputted By] <> 'Mr. Whally B. Barro' AND 
		[Inputted By] <> 'Ms. Cate C. Almeda' AND 
		[Inputted By] <> 'Mr. John Leo Santos' AND 
		[Inputted By] <> 'Ms. Dorothy L. Nechaldas' AND 
		[Inputted By] <> 'Ms. Maui L. Miranda' AND 
		[Inputted By] <> 'Ms. Liezl L. Aquino' AND 
		[Inputted By] <> 'Mr. Ralph R. Englatera' AND 
		[Inputted By] <> 'Mr. Jayson M. Villanueva' 
--group by Request_Tbl.[Inputted By],
--		 acct.ACCTTYPE"

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(query, sqlcon)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        TotalPRICEOthers = read.GetDecimal(0)
                        TotalQTYOthers = read.GetInt32(1)

                        Others_Blue = TotalPRICEOthers
                        Others_BPercent = Math.Round((TotalPRICEOthers / OverallCP) * 100, 2) & "%"

                        Others_Green = TotalQTYOthers
                        Others_GPercent = Math.Round((TotalQTYOthers / TotalQty) * 100, 2) & "%"

                        Others_Lime = TotalPRICEOthers
                        Others_LPercent = Math.Round((TotalPRICEOthers / OverallInvPrice) * 100, 2) & "%"
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public query_INDI As String
    Public Sub Individual_Analysis(ByVal ModeSelected As String,
                                   ByVal AEIC_ID As String,
                                   ByVal Year As String,
                                   ByVal AEorOthers As Boolean)
        Dim AEcondition As String = Nothing

        If AEorOthers = True Then
            AEcondition = "requestor_id = @AEIC_ID"
        ElseIf AEorOthers = False Then
            AEcondition = "requestor_id <> 31 AND 
								requestor_id <> 82 AND
								requestor_id <> 64 AND
								requestor_id <> 80 AND
								requestor_id <> 54 AND
								requestor_id <> 81 AND
								requestor_id <> 85 AND
								requestor_id <> 50 AND
								requestor_id <> 84 AND
								requestor_id <> 86 AND
								requestor_id <> 68 AND
								requestor_id <> 83"
        End If

        If ModeSelected = "Regular" Then 'GIFT_REQUEST_EMP
            query_INDI = "SELECT    [Inputted By] as [Sales name]
                              ,[Company Name]
                              ,[Employee Name]
                              ,[Position]
                              ,[Gender]
                              ,[Event]
                              ,[Gift]
                              ,[Quantity]
                              ,[Total Price of Gift] as [Total Price]
                              ,[Request Status]
                          FROM GIFT_REQUEST_EMP where ([Request Status] = 'Pending' or [Request Status] = 'Approved') and
                               YEAR = @Year AND " & AEcondition
        ElseIf ModeSelected = "Special" Then 'GIFT_REQUEST_SPECIAL
            query_INDI = "SELECT    [Inputted By] as [Sales name]
                              ,[SP_Name] as Name
                              ,[Gender]
                              ,[Event]
                              ,[Gift]
                              ,[Quantity]
                              ,[SP_Price] as [Total Price]
                              ,[Request Status]
                          FROM GIFT_REQUEST_SPECIAL where ([Request Status] = 'Pending' or [Request Status] = 'Approved') and 
                               YEAR = @Year AND " & AEcondition
        ElseIf ModeSelected = "Raffle" Then 'GIFT_REQUEST_COMP
            query_INDI = "SELECT    [Inputted By] as [Sales name]
                              ,[Company Name]
                              ,[Event]
                              ,[Gift]
                              ,[Quantity]
                              ,[Total Price of Gift] as [Total Price]
                              ,[Request Status]
                          FROM GIFT_REQUEST_COMP where ([Request Status] = 'Pending' or [Request Status] = 'Approved') and 
                               YEAR = @Year AND " & AEcondition
        End If
        sqlds = New DataSet
        sqlda = New SqlDataAdapter
        sqlbs = New BindingSource

        sqlds.Clear()
        sqlbs.Clear()
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(query_INDI, sqlcon)
                If AEorOthers = True Then 'AEIC siya 
                    Sqlcmd.Parameters.AddWithValue("@AEIC_ID", AEIC_ID)
                End If
                Sqlcmd.Parameters.AddWithValue("@Year", Year)
                sqlda.SelectCommand = Sqlcmd
                sqlda.Fill(sqlds, "GIFT_REQUEST_INDISALES")
                sqlbs.DataSource = sqlds
                sqlbs.DataMember = "GIFT_REQUEST_INDISALES"
            End Using
        End Using
    End Sub

    Public query_TotalCPConsumed_Lbl As String
    Public TotalCPConsumed_Lbld As Decimal

    Public query_TotalCPConsumedhere_Lbl As String
    Public TotalCPConsumedhere_Lbld As Decimal
    Public Sub TotalCPConsumedhere_Lbl_Updates(ByVal ModeSelected As String,
                                               ByVal AEIC_ID As String,
                                               ByVal Year As String,
                                               ByVal AEorOthers As String)
        Dim AEcondition As String = Nothing

        If AEorOthers = True Then
            AEcondition = "requestor_id = @AEIC_ID"
        ElseIf AEorOthers = False Then
            AEcondition = "requestor_id <> 31 AND 
								requestor_id <> 82 AND
								requestor_id <> 64 AND
								requestor_id <> 80 AND
								requestor_id <> 54 AND
								requestor_id <> 81 AND
								requestor_id <> 85 AND
								requestor_id <> 50 AND
								requestor_id <> 86 AND
								requestor_id <> 68 AND
								requestor_id <> 83"
        End If

        If ModeSelected = "Regular" Then 'GIFT_REQUEST_EMP
            query_TotalCPConsumedhere_Lbl = "SELECT IIF(sum([Total Price of Gift]) is null,0,sum([Total Price of Gift]))
                          FROM GIFT_REQUEST_EMP where ([Request Status] = 'Pending' or [Request Status] = 'Approved') and
                               YEAR = @Year AND " & AEcondition
        ElseIf ModeSelected = "Special" Then 'GIFT_REQUEST_SPECIAL
            query_TotalCPConsumedhere_Lbl = "SELECT IIF(sum([Total Price of Gift]) is null,0,sum([Total Price of Gift]))
                          FROM GIFT_REQUEST_COMP where ([Request Status] = 'Pending' or [Request Status] = 'Approved') and 
                               YEAR = @Year AND " & AEcondition
        ElseIf ModeSelected = "Raffle" Then 'GIFT_REQUEST_COMP
            query_TotalCPConsumedhere_Lbl = "SELECT IIF(sum([SP_Price]) is null,0,sum([SP_Price]))
                          FROM GIFT_REQUEST_SPECIAL where ([Request Status] = 'Pending' or [Request Status] = 'Approved') and 
                               YEAR = @Year AND " & AEcondition
        End If
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(query_TotalCPConsumedhere_Lbl, sqlcon)
                If AEorOthers = True Then 'AEIC siya 
                    Sqlcmd.Parameters.AddWithValue("@AEIC_ID", AEIC_ID)
                End If
                Sqlcmd.Parameters.AddWithValue("@Year", Year)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        TotalCPConsumedhere_Lbld = read.GetDecimal(0)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub GIFT_DATELOOKBACK_UPDATE(ByVal DATELOOKBACK As String)
        Try
            Query = "UPDATE GIFT_DATELOOKBACK SET [DateLookBack] = @DATELOOKBACK where id = 1"
            Using sqlcon As New SqlConnection(sqlconnString)
                sqlcon.Open()
                Sqlcmd = New SqlCommand(Query, sqlcon)
                Sqlcmd.Parameters.AddWithValue("@DATELOOKBACK", DATELOOKBACK)
                confirmQuery = Sqlcmd.ExecuteNonQuery()
                If confirmQuery <> 0 Then
                    MetroFramework.MetroMessageBox.Show(Marketing_AnalysisReport, "Record Updated successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Marketing_AnalysisReport, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                'sqlcon.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public SettedDate As String

    Public Sub SettedDate_Lbl_Updates()
        Dim query As String = "SELECT [DateLookBack] FROM GIFT_DATELOOKBACK where id = 1"

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using Sqlcmd As New SqlCommand(query, sqlcon)
                Using read As SqlDataReader = Sqlcmd.ExecuteReader
                    While read.Read
                        SettedDate = read.GetDateTime(0).Year
                    End While
                End Using
            End Using
        End Using
    End Sub

End Module
