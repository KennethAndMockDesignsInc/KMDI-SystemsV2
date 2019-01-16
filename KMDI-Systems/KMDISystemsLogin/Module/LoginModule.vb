Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Module LoginModule
    Public AccountType, NickName, FullName, UserNamePrint, ProfilePath, AcctPASSWORD As String

    Public DBName As String
    Public sqlConnection As New SqlConnection
    Public sqlCommand As SqlCommand
    Public Read As SqlDataReader

    Public sqlDataAdapter As New SqlDataAdapter
    Public sqlDataSet As New DataSet
    Public sqlBindingSource As BindingSource

    Public sqlconnString As String

    Public KMDISystems_UserName As String
    Public KMDISystems_Password As String

    Public LoginType As String
    Public DBnameCboxSelectedIndex As Integer
    Public PrevDBnameCboxSelectedIndex As Integer

    Public Sub KMDISystems_Login_SERVER(ByVal DBName As String)
        sqlConnection.Close()
        sqlconnString = "Data Source = 121.58.229.248,49107; Network Library=DBMSSOCN;Initial Catalog='" & DBName & "';User ID=kmdiadmin;Password=kmdiadmin;"
        sqlConnection.ConnectionString = sqlconnString
    End Sub

    Public Sub KMDISystems_Login(ByVal UserName As String,
                                 ByVal Password As String)
        Try
            Using sqlcon As New SqlConnection(sqlconnString)
                sqlcon.Open()
                Using sqlcmd As New SqlCommand("stp_Login", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.CommandTimeout = 10
                    sqlcmd.Parameters.AddWithValue("@UserName", UserName)
                    sqlcmd.Parameters.AddWithValue("@Password", Encrypt(Password))
                    Using read As SqlDataReader = sqlcmd.ExecuteReader
                        read.Read()
                        If read.HasRows Then
                            AccountAutonum = read.Item("AUTONUM").ToString
                            AccountType = read.Item("ACCTTYPE").ToString
                            NickName = read.Item("NICKNAME").ToString
                            FullName = read.Item("FULLNAME").ToString
                            UserNamePrint = read.Item("USERNAME").ToString
                            ProfilePath = read.Item("PROFILEPATH").ToString
                            AcctPASSWORD = Decrypt(read.Item("PASSWORD").ToString)
                        Else
                            KMDISystemsLogin.LoginBGW.WorkerSupportsCancellation = True
                            KMDISystemsLogin.LoginBGW.CancelAsync()
                            AccountAutonum = Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Sub UserAccessCbox_Popolate()
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource

            Using sqlcon As New SqlConnection(sqlconnString)
                sqlcon.Open()
                sqlDataSet.Clear()
                Query = "SELECT DISTINCT [ACCTYPE] 
                     FROM [KMDI_ACCT_ACCTYPE]"
                Using sqlcmd As New SqlCommand(Query, sqlcon)
                    sqlcmd.CommandTimeout = 10
                    sqlDataAdapter.SelectCommand = sqlcmd
                    sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_TB2")
                    sqlBindingSource.DataSource = sqlDataSet
                    sqlBindingSource.DataMember = "KMDI_ACCT_TB2"
                    ManageAccounts.UserAccessCbox.DataSource = sqlBindingSource
                    ManageAccounts.UserAccessCbox.ValueMember = "ACCTYPE"
                    ManageAccounts.UserAccessCbox.SelectedIndex = -1
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Public Function Decrypt(cipherText As String) As String

        Dim EncryptionKey As String = "MAKV2SPBNI99212"

            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)

            Using encryptor As Aes = Aes.Create()

                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})

                encryptor.Key = pdb.GetBytes(32)

                encryptor.IV = pdb.GetBytes(16)

                Using ms As New MemoryStream()

                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)

                        cs.Write(cipherBytes, 0, cipherBytes.Length)

                        cs.Close()

                    End Using

                    cipherText = Encoding.Unicode.GetString(ms.ToArray())

                End Using

            End Using

            Return cipherText

    End Function

End Module
