Imports System.Data.SqlClient

Module ManageAccountsModule

    Dim confirmQuery As Integer
    Public FailedCount As Integer = 0
    Public AUTONUMforuserNpass As String

    Public Sub KMDI_ACCT_ACCESS_TB_DELETE(ByVal TileAccess As String,
                                          ByVal UserAcctAutonum As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "DELETE FROM [KMDI_ACCT_ACCESS_TB] WHERE
                                                       [TileAccess] = @TileAccess AND
                                                       [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@TileAccess", TileAccess)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                'MetroFramework.MetroMessageBox.Show(ChangeWritePermision, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(ChangeTilePermision, "Failed DELETE at TileAccess #" & TileAccess, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FailedCount += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_INSERT(ByVal ACCTYPE As String,
                                          ByVal TileAccess As String,
                                          ByVal Write As String,
                                          ByVal UserAcctAutonum As String,
                                          ByVal InputtedUpdated As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "INSERT INTO [KMDI_ACCT_ACCESS_TB] ([ACCTYPE]
                                                       ,[TileAccess]
                                                       ,[Write]
                                                       ,[UserAcctAutonum]
                                                       ,[InputtedUpdated])
                                                VALUES (@ACCTYPE,
                                                        @TileAccess,
                                                        @Write,
                                                        @UserAcctAutonum,
                                                        @InputtedUpdated)"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@ACCTYPE", ACCTYPE)
            sqlCommand.Parameters.AddWithValue("@TileAccess", TileAccess)
            sqlCommand.Parameters.AddWithValue("@Write", Write)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)
            sqlCommand.Parameters.AddWithValue("@InputtedUpdated", InputtedUpdated)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                'MetroFramework.MetroMessageBox.Show(ChangeWritePermision, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(ChangeTilePermision, "Failed INSERT at TileAccess #" & TileAccess, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FailedCount += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeTilePermision(ByVal UserAcctAutonum As String)
        Try
            Dim tileAccessHere As String
            sqlConnection.Close()
            sqlConnection.Open()

            Query = "SELECT [TileAccess] as [Tile]
                       FROM [KMDI_ACCT_ACCESS_TB]
                     WHERE [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)

            Read = sqlCommand.ExecuteReader

            While Read.Read
                If Read.HasRows Then
                    tileAccessHere = Read.Item("Tile").ToString

                    If tileAccessHere <> "" Then
                        ChangeTilePermision.tileAccess += "|" + tileAccessHere
                    Else
                        ChangeTilePermision.tileAccess = ""
                        Exit While
                    End If

                End If
            End While
            Read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeWritePermision(ByVal UserAcctAutonum As String)
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [Autonumber]
                           ,[ACCTYPE] as [Account Type]
                           ,[TileAccess] as [Tile]
                           ,[Write] as [Write]
                           ,[UserAcctAutonum] as [User ID]
                           ,[InputtedUpdated] as [Inputted/Updated By]
                     FROM [KMDI_ACCT_ACCESS_TB]
                     WHERE [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)

            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_ACCESS_TB")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_ACCESS_TB"
            ChangeWritePermision.UserAccessDGV.DataSource = sqlBindingSource

            With ChangeWritePermision.UserAccessDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            ChangeWritePermision.UserAccessDGV.Columns("Autonumber").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_TB_INSERT_ManageAccounts(ByVal fullname As String,
                                                  ByVal nickname As String,
                                                  ByVal acctype As String,
                                                  ByVal username As String,
                                                  ByVal password As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()

            Dim str1 As String = "SELECT * FROM KMDI_ACCT_TB WHERE [nickname] COLLATE Latin1_General_CS_AS = '" & nickname.ToString & "'"

            sqlCommand = New SqlCommand(str1, sqlConnection)
            Read = sqlCommand.ExecuteReader
            If Read.HasRows = True Then
                MetroFramework.MetroMessageBox.Show(ManageAccounts, " Invalid Nickname : " & nickname & " Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
                Read.Close()
            Else
                sqlConnection.Close()
                Read.Close()

                sqlConnection.Open()
                Dim strsInsert As String = "INSERT INTO KMDI_ACCT_TB (FULLNAME,
                                                                      NICKNAME,
                                                                      ACCTTYPE,
                                                                      USERNAME,
                                                                      PASSWORD)
                                                              VALUES (@FULLNAME,
                                                                      @NICKNAME,
                                                                      @ACCTTYPE,
                                                                      @USERNAME,
                                                                      @PASSWORD)"
                sqlCommand = New SqlCommand(strsInsert, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@FULLNAME", fullname)
                sqlCommand.Parameters.AddWithValue("@NICKNAME", nickname)
                sqlCommand.Parameters.AddWithValue("@ACCTTYPE", acctype)
                sqlCommand.Parameters.AddWithValue("@USERNAME", username)
                sqlCommand.Parameters.AddWithValue("@PASSWORD", password)
                confirmQuery = sqlCommand.ExecuteNonQuery()
                If confirmQuery <> 0 Then
                    MetroFramework.MetroMessageBox.Show(ManageAccounts, "Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KMDI_ACCT_TB_READ(AccountAutonum)
                End If
                sqlConnection.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_TB_READ(ByVal AccountAutonum As String)
        Dim sqlDataAdapter As New SqlDataAdapter
        Dim sqlDataSet As New DataSet
        Dim sqlBindingSource As New BindingSource


        Try
            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [AUTONUM],
                            [FULLNAME],
                            [NICKNAME],
                            [ACCTTYPE],
                            [PASSWORD]
                     FROM [KMDI_ACCT_TB]
                     where NOT ACCTTYPE = 'Admin' or AUTONUM = @AccountAutonum "
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@AccountAutonum", AccountAutonum)
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_TB")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_TB"
            ManageAccounts.UserAcctDGV.DataSource = sqlBindingSource

            With ManageAccounts.UserAcctDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            'ManageAccounts.UserAcctDGV.Columns("PASSWORD").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_TB_READ_MAXAutonum()
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "SELECT MAX(AUTONUM)+1 as AUTONUMinc FROM [KMDI_ACCT_TB]"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            Read = sqlCommand.ExecuteReader
            Read.Read()

            If Read.HasRows Then
                AUTONUMforuserNpass = Read.Item("AUTONUMinc").ToString
            End If
            Read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " dito sa KMDI_ACCT_TB_READ_MAXAutonum")
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_TB_UPDATE_ManageAccounts(ByVal fullname As String,
                                                  ByVal nickname As String,
                                                  ByVal acctype As String,
                                                  ByVal Autonumhere As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Dim str1 As String = "SELECT * FROM KMDI_ACCT_TB WHERE [nickname] COLLATE Latin1_General_CS_AS = '" & nickname.ToString & "'"

            sqlCommand = New SqlCommand(str1, sqlConnection)
            Read = sqlCommand.ExecuteReader
            If Read.HasRows = True Then
                MetroFramework.MetroMessageBox.Show(ManageAccounts, " Invalid Nickname : " & nickname & " Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
                Read.Close()
            Else
                sqlConnection.Close()
                Read.Close()

                sqlConnection.Open()

                Query = " UPDATE KMDI_ACCT_TB SET fullname = @fullname, nickname = @nickname,
                                                  ACCTTYPE = @acctype 
                                            WHERE AUTONUM = @Autonumhere "
                sqlCommand = New SqlCommand(Query, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@fullname", fullname)
                sqlCommand.Parameters.AddWithValue("@nickname", nickname)
                sqlCommand.Parameters.AddWithValue("@acctype", acctype)
                sqlCommand.Parameters.AddWithValue("@Autonumhere", Autonumhere)
                confirmQuery = sqlCommand.ExecuteNonQuery
                If confirmQuery <> 0 Then
                    MetroFramework.MetroMessageBox.Show(ManageAccounts, "Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KMDI_ACCT_TB_READ(AccountAutonum)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try

    End Sub

    Public Sub KMDI_ACCT_ACCTYPE_READ()
        Dim sqlDataAdapter As New SqlDataAdapter
        Dim sqlDataSet As New DataSet
        Dim sqlBindingSource As New BindingSource


        Try
            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT *
                     FROM [KMDI_ACCT_ACCTYPE]"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_ACCTYPE")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_ACCTYPE"
            UpdateAcctType.AcctTypeDGV.DataSource = sqlBindingSource

            With UpdateAcctType.AcctTypeDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            UpdateAcctType.AcctTypeDGV.Columns("Autonumber").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCTYPE_TB_INSERT(ByVal ACCTYPE As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "INSERT INTO [KMDI_ACCT_ACCTYPE] ([ACCTYPE])
                                              VALUES (@ACCTYPE)"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@ACCTYPE", ACCTYPE)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(UpdateAcctType, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAcctType.AcctTypeNameTbox.Clear()
                KMDI_ACCT_ACCTYPE_READ()
            Else
                MetroFramework.MetroMessageBox.Show(UpdateAcctType, "Failed INSERT at KMDI_ACCT_ACCTYPE_TB", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FailedCount += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub
    Public Sub KMDI_ACCT_ACCTYPE_TB_UPDATE(ByVal ACCTYPE As String,
                                           ByVal AutonumOFAccType As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "UPDATE [KMDI_ACCT_ACCTYPE] SET [ACCTYPE] = @ACCTYPE WHERE [Autonumber] = @AutonumOFAccType"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@ACCTYPE", ACCTYPE)
            sqlCommand.Parameters.AddWithValue("@AutonumOFAccType", AutonumOFAccType)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(UpdateAcctType, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAcctType.AcctTypeNameTbox.Clear()
                KMDI_ACCT_ACCTYPE_READ()
            Else
                MetroFramework.MetroMessageBox.Show(UpdateAcctType, "Failed UPDATE at KMDI_ACCT_ACCTYPE_TB", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FailedCount += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCTYPE_TB_DELETE(ByVal AutonumOFAccType As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "DELETE FROM [KMDI_ACCT_ACCTYPE] WHERE [Autonumber] = @AutonumOFAccType"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@AutonumOFAccType", AutonumOFAccType)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(UpdateAcctType, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateAcctType.AcctTypeNameTbox.Clear()
                KMDI_ACCT_ACCTYPE_READ()
            Else
                MetroFramework.MetroMessageBox.Show(UpdateAcctType, "Failed DELETE at KMDI_ACCT_ACCTYPE_TB ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FailedCount += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_UPDATE(ByVal Write As String,
                                          ByVal Autonumber As String,
                                          ByVal InputtedUpdated As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Query = "UPDATE [KMDI_ACCT_ACCESS_TB] SET [Write] = @Write, [InputtedUpdated] = @InputtedUpdated WHERE [Autonumber] = @Autonumber"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@Write", Write)
            sqlCommand.Parameters.AddWithValue("@Autonumber", Autonumber)
            sqlCommand.Parameters.AddWithValue("@InputtedUpdated", InputtedUpdated)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(ChangeWritePermision, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeWritePermision(ManageAccounts.UsersAutonum)
            Else
                MetroFramework.MetroMessageBox.Show(ChangeWritePermision, "Failed UPDATE at KMDI_ACCT_ACCESS_TB", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Public Sub KMDI_ACCT_TB_UPDATE_ManageAccounts_FOR_AccountUpdate_Username(ByVal username As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
            Dim str1 As String = "SELECT * FROM KMDI_ACCT_TB WHERE [USERNAME] COLLATE Latin1_General_CS_AS = '" & username & "'"

            sqlCommand = New SqlCommand(str1, sqlConnection)
            Read = sqlCommand.ExecuteReader
            If Read.HasRows = True Then
                MetroFramework.MetroMessageBox.Show(ManageAccounts, " Invalid Nickname : " & username & " Already Exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
                Read.Close()
            Else
                sqlConnection.Close()
                Read.Close()

                sqlConnection.Open()

                Query = " UPDATE KMDI_ACCT_TB SET [USERNAME] = @USERNAME
                                            WHERE AUTONUM = @AccountAutonum "
                sqlCommand = New SqlCommand(Query, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@USERNAME", username)
                sqlCommand.Parameters.AddWithValue("@AccountAutonum", AccountAutonum)
                confirmQuery = sqlCommand.ExecuteNonQuery
                If confirmQuery <> 0 Then
                    MetroFramework.MetroMessageBox.Show(AccountUpdate, "Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    AccountUpdate.UsernameLbl.Text = username
                    usernamePrint = username
                Else
                    MetroFramework.MetroMessageBox.Show(AccountUpdate, "Failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                AccountUpdate.NewUserTbox.Clear()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try

    End Sub

    Public Sub KMDI_ACCT_TB_UPDATE_ManageAccounts_FOR_AccountUpdate_Password(ByVal oldpass As String,
                                                                             ByVal newpass As String,
                                                                             ByVal retypepass As String)
        Try

            If oldpass = AcctPASSWORD Then

                If newpass = retypepass Then

                    sqlConnection.Close()
                    Read.Close()

                    sqlConnection.Open()


                    Query = " UPDATE KMDI_ACCT_TB SET [PASSWORD] = @PASSWORD
                                            WHERE AUTONUM = @AccountAutonum "
                    sqlCommand = New SqlCommand(Query, sqlConnection)
                    sqlCommand.Parameters.AddWithValue("@PASSWORD", Encrypt(newpass))
                    sqlCommand.Parameters.AddWithValue("@AccountAutonum", AccountAutonum)
                    confirmQuery = sqlCommand.ExecuteNonQuery
                    If confirmQuery <> 0 Then
                        MetroFramework.MetroMessageBox.Show(AccountUpdate, "Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        AcctPASSWORD = newpass
                    Else
                        MetroFramework.MetroMessageBox.Show(AccountUpdate, "Failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MetroFramework.MetroMessageBox.Show(AccountUpdate, "Passwords does not match", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MetroFramework.MetroMessageBox.Show(AccountUpdate, "Wrong Old password", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            AccountUpdate.OldPasswordTbox.Clear()
            AccountUpdate.NewPassTbox.Clear()
            AccountUpdate.RetypePassTbox.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try

    End Sub

    Public Sub KMDI_ACCT_TB_UPDATE_ManageAccounts_FOR_AccountUpdate_PicImage(ByVal PROFILEPATH22 As String)
        Try

            sqlConnection.Close()
            Read.Close()

            sqlConnection.Open()


            Query = " UPDATE KMDI_ACCT_TB SET [PROFILEPATH] = @PROFILEPATH
                                           WHERE AUTONUM = @AccountAutonum "
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@PROFILEPATH", PROFILEPATH22)
            sqlCommand.Parameters.AddWithValue("@AccountAutonum", AccountAutonum)
            confirmQuery = sqlCommand.ExecuteNonQuery
            If confirmQuery <> 0 Then
                PROFILEPATH = AccountUpdate.ProfilePicDirectory
                MetroFramework.MetroMessageBox.Show(AccountUpdate, "Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MetroFramework.MetroMessageBox.Show(AccountUpdate, "Failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
        End Try

    End Sub
End Module
