Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Module LoginModule
    Public AccountType, nickname, fullname, usernamePrint, PROFILEPATH, AcctPASSWORD As String

    Public KMDISystemsLogin_AccessPoint As String
    'Dim AccessPoint As String = KMDISystemsLogin.KMDISystemsLogin_AccessPoint
    Public DBName As String
    Dim DBUserName As String = "kmdiadmin"
    Dim DBPassword As String = "kmdiadmin"
    Public sqlConnection As New SqlConnection
    Public sqlCommand As SqlCommand
    Public Read As SqlDataReader

    Public sqlDataAdapter As New SqlDataAdapter
    Public sqlDataSet As DataSet
    Public sqlBindingSource As BindingSource

    Public sqlconnString As String

    Public KMDISystems_UserName As String
    Public KMDISystems_Password As String

    Public LoginType As String
    Public DBnameCboxSelectedIndex As Integer
    Public PrevDBnameCboxSelectedIndex As Integer

    Public Sub KMDISystems_Login_SERVER(ByVal DBName As String)
        sqlConnection.Close()
        sqlconnString = "Data Source='" & KMDISystemsLogin_AccessPoint & "';Network Library=DBMSSOCN;Initial Catalog='" & DBName & "';User ID='" & DBUserName & "';Password='" & DBPassword & "';"
        sqlConnection.ConnectionString = sqlconnString
    End Sub

    Public Sub KMDISystems_Login(ByVal UserName As String,
                                 ByVal Password As String)
        sqlConnection.Close()
        sqlConnection.Open()
        Query = "Select    [AUTONUM]
                                  ,[FULLNAME]
                                  ,[NICKNAME]
                                  ,[ACCTTYPE]
                                  ,[USERNAME]
                                  ,[PASSWORD]
                                  ,[PROFILEPATH]
                     From KMDI_ACCT_TB
                     Where [username] = @UserName AND [password] COLLATE Latin1_General_CS_AS = @Password"
        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@UserName", UserName)
        sqlCommand.Parameters.AddWithValue("@Password", Encrypt(Password))
        Read = sqlCommand.ExecuteReader
        Read.Read()
        If Read.HasRows Then
            AccountAutonum = Read.Item("AUTONUM").ToString
            AccountType = Read.Item("ACCTTYPE").ToString
            nickname = Read.Item("NICKNAME").ToString
            fullname = Read.Item("FULLNAME").ToString
            usernamePrint = Read.Item("USERNAME").ToString
            PROFILEPATH = Read.Item("PROFILEPATH").ToString
            AcctPASSWORD = Decrypt(Read.Item("PASSWORD").ToString)
        Else
            KMDISystemsLogin.LoginBGW.WorkerSupportsCancellation = True
            KMDISystemsLogin.LoginBGW.CancelAsync()
            AccountAutonum = Nothing
        End If
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

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "Select Distinct [ACCTYPE] 
                     FROM [KMDI_ACCT_ACCTYPE]"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_TB2")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_TB2"
            ManageAccounts.UserAccessCbox.DataSource = sqlBindingSource
            ManageAccounts.UserAccessCbox.ValueMember = "ACCTYPE"
            ManageAccounts.UserAccessCbox.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
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
