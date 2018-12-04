Imports System.IO
Imports System.Net
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class BackloadImageFRM
    Dim sql As New KMDISystemsBackloadClass

    Public ActionTaken As String
    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Public BtnAction As String
    Public Image_Count As Integer
    Public Image_Default_Folder As String
    Public Image_Folder_Name As String
    Public Image_File_Name As String
    Public Image_Link As String
    Public JO As String

    Public BackloadImageBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub BackloadImageFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        AddHandler BackloadImageBGW.DoWork, AddressOf BackloadImageBGW_DoWork
        AddHandler BackloadImageBGW.RunWorkerCompleted, AddressOf BackloadImageBGW_RunWorkerCompleted
        'LoadImagetoBackloadImage_Pbox()
        ChangePBVisibility = AddressOf ChangeVisibility

        LoadInitialSetUp()
    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub LoadInitialSetUp()
        ActionTaken = "Search"
        StartWorker()
    End Sub

    Public Sub StartWorker()
        If BackloadImageBGW.IsBusy <> True Then
            Select Case ActionTaken
                Case "Search"
                Case "Add"
                    Image_Folder_Name = Replace(Trim(JO), " ", "%20")
                Case "Update"
                Case "Delete"
            End Select

            BackloadImageBGW.WorkerSupportsCancellation = True
            BackloadImageBGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BackloadImageBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            sql.Backloads(QueryFunction,
                          QueryBody,
                          QueryCondition,
                          ActionTaken)
        Catch ex As Exception
            MsgBox(ex.ToString)
            BackloadImageBGW.WorkerSupportsCancellation = True
            BackloadImageBGW.CancelAsync()
        End Try

        If BackloadImageBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                QueryFunction = "Select Count([JO Number]) as [Image Count], [Image Folder], [Image Name]"
                QueryBody = " From BACKLOAD_IMAGES"
                QueryCondition = " Where [JO Number] = '" & JO & "' and
                                         [Image Status] = 'Active'
                                   Group by [Image Folder], [Image Name]"
            Case "Add"
                QueryFunction = "Insert into BACKLOAD_IMAGES"
                QueryBody = " Values('" & JO & "','" & Image_Default_Folder & "/" & Image_Folder_Name & "','" & Image_File_Name & "','Active')"
                QueryCondition = ""
            Case "Update"
                QueryFunction = ""
                QueryBody = ""
                QueryCondition = ""
            Case "Delete"
                QueryFunction = "Update BACKLOAD_IMAGES"
                QueryBody = " Set [Image Status] = 'Deleted'"
                QueryCondition = " Where [JO Number] = '" & JO & "' and
                                         [Image Status] = 'Active' and
                                         [Image Name] = '" & Image_File_Name & "'"
        End Select
    End Sub

    Private Sub BackloadImageBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to retrieve the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to add the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Update"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to update the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Delete"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to delete the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select

            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to retrieve the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to add the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Update"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to update the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Delete"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to delete the image. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            Read = sqlCommand.ExecuteReader
                            If Read.HasRows = True Then
                                DisplayImage()
                            Else
                                BackloadImage_Pbox.Image = My.Resources.ImageSelected
                                AddUpdateImage_BTN.Text = "Add"
                                ActionTaken = "Add"
                            End If
                        Case "Add"
                            LoadInitialSetUp()
                            MetroFramework.MetroMessageBox.Show(Me, "Image has been successfully added to the system.", "Image has been added.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case "Update"
                            LoadInitialSetUp()
                            MetroFramework.MetroMessageBox.Show(Me, "Image has been successfully updated to the system.", "Image has been updated.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case "Delete"
                            LoadInitialSetUp()
                            MetroFramework.MetroMessageBox.Show(Me, "Image has been successfully deleted from the system.", "Image has been deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Select
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub DisplayImage()
        Try

            Select Case ActionTaken
                Case "Search"
                    With Read
                        .Read()
                        Image_Count = .Item("Image Count")
                        Image_Link = .Item("Image Folder").ToString
                        Image_File_Name = .Item("Image Name")
                        .Close()
                    End With

                    Dim objwebClient As WebClient
                    Dim sURL As String = Trim(Image_Link & "/" & Image_File_Name)
                    Dim objImage As MemoryStream
                    Dim srcBmp As Bitmap

                    Select Case Image_Count
                        Case 0
                            BackloadImage_Pbox.Image = My.Resources.ImageSelected
                            AddUpdateImage_BTN.Text = "Add"
                            ActionTaken = "Add"
                            'Case Nothing
                            '    BackloadImage_Pbox.Image = WindowsApplication7.My.Resources.ImageSelected
                            '    AddUpdateImage_BTN.Text = "Add"
                            '    ActionTaken = "Add"
                        Case Else
                            MessageBox.Show(sURL)
                            AddUpdateImage_BTN.Text = "Update"
                            ActionTaken = "Update"
                            objwebClient = New WebClient()
                            objImage = New MemoryStream(objwebClient.DownloadData(sURL))
                            srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)
                            BackloadImage_Pbox.Image = srcBmp
                    End Select

                Case "Add"
                Case "Update"
                Case "Delete"
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private m_PanStartPoint As New Point

    Private Sub Browse_BTN_Click(sender As Object, e As EventArgs) Handles Browse_BTN.Click
    End Sub

    Private Sub AddUpdateImage_BTN_Click(sender As Object, e As EventArgs) Handles AddUpdateImage_BTN.Click
        'Dim ITEM_IMAGE As New MemoryStream
        'Image_Default_Folder = "http://121.58.229.248:8083/Backload%20Images"

        'Select Case ActionTaken
        '    Case "Search"
        '    Case "Add"
        '        Try
        '            Dim BrowsePic As New OpenFileDialog
        '            BrowsePic.Filter = "Please insert (*.JPG;*.PNG) only.|*.jpg;*.png"

        '            If BrowsePic.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                BackloadImage_Pbox.Image = Image.FromFile(BrowsePic.FileName)
        '            End If

        '            BackloadImage_Pbox.Image.Save(ITEM_IMAGE, BackloadImage_Pbox.Image.RawFormat)
        '            Dim Path As String = "\\kmdisqlserver\KMDIIMAGEFILE2\Backload Images\" & JO & "\"
        '            Dim Dir As String = IO.Path.GetDirectoryName(Path)

        '            If Not Directory.Exists(Dir) Then
        '                Directory.CreateDirectory(Path)
        '            End If

        '            Image_File_Name = (Image_Count + 1).ToString & ".jpeg"

        '            Dim PicPathName As String
        '            PicPathName = System.IO.Path.Combine(Dir, Image_File_Name)

        '            BackloadImage_Pbox.Image.Save(PicPathName)

        '            StartWorker()

        '        Catch ex As Exception
        '            MessageBox.Show(ex.ToString)
        '        End Try


        '    Case "Update"

        '        BackloadImage_Pbox.Image.Save(ITEM_IMAGE, BackloadImage_Pbox.Image.RawFormat)

        '        'Update image
        '        Dim Path As String = "\\kmdisqlserver\KMDIIMAGEFILE2\Backload Images\" & JO & "\"
        '        Dim Dir As String = IO.Path.GetDirectoryName(Path)

        '        If Not Directory.Exists(Dir) Then
        '            Directory.CreateDirectory(Path)
        '        End If

        '        Dim PicPathName As String
        '        PicPathName = System.IO.Path.Combine(Dir, Image_Count + 1 + ".jpeg")

        '        BackloadImage_Pbox.Image.Save(PicPathName)

        '        'Updateimage(Inventory.ItemRefNo, Inventory.ItemCode, Inventory.ItemCategory)
        '    Case "Delete"

        'End Select
    End Sub

    Private Sub ViewInventoryImage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Inventory.Enabled = True
    End Sub

    Private Sub InventoryImage_Pbox_MouseWheel(sender As System.Object, e As MouseEventArgs) Handles BackloadImage_Pbox.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                If BackloadImage_Pbox.Width < 500 Then Exit Sub
            Else
                If BackloadImage_Pbox.Width > 2000 Then Exit Sub
            End If

            BackloadImage_Pbox.Width += CInt(BackloadImage_Pbox.Width * e.Delta / 1000)
            BackloadImage_Pbox.Height += CInt(BackloadImage_Pbox.Height * e.Delta / 1000)
        End If

    End Sub

    Private Sub BackloadImage_Pbox_Pbox_MouseDown(sender As Object, e As MouseEventArgs) Handles BackloadImage_Pbox.MouseDown
        m_PanStartPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub BackloadImage_Pbox_Pbox_MouseMove(sender As Object, e As MouseEventArgs) Handles BackloadImage_Pbox.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)
            Panel1.AutoScrollPosition =
                        New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X),
                                          (DeltaY - Panel1.AutoScrollPosition.Y))
        End If
    End Sub

    Private Sub Panel1_SizeChanged(sender As Object, e As EventArgs) Handles Panel1.SizeChanged, BackloadImage_Pbox.SizeChanged
        Try
            Dim PB_Container_Width As Integer = Panel1.Width
            Dim PB_Width As Integer = BackloadImage_Pbox.Width
            Dim PB_X As Integer
            Dim PB_Y As Integer = BackloadImage_Pbox.Location.Y

            If PB_Container_Width >= PB_Width Then
                PB_X = Panel1.Width - BackloadImage_Pbox.Width
            ElseIf PB_Container_Width < PB_Width Then
                PB_X = 0
            End If

            BackloadImage_Pbox.Location = New Point(((PB_X) / 2), PB_Y)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Private Sub BackloadImage_Pbox_Pbox_SizeChanged(sender As Object, e As EventArgs) Handles BackloadImage_Pbox.SizeChanged
    '    BackloadImage_Pbox.Location = New Point(((BackloadImage_Pbox.Width - BackloadImage_Pbox.Width) / 2), BackloadImage_Pbox.Location.Y)
    'End Sub

    Private Sub BackloadImage_Pbox_MouseClick(sender As Object, e As MouseEventArgs) Handles BackloadImage_Pbox.MouseClick
        Select Case e.Button
            Case MouseButtons.Right
                Select Case Image_Count
                    Case 0
                        UpdateToolStripMenuItem.Visible = False
                        DeleteToolStripMenuItem.Visible = False
                    Case Nothing
                        UpdateToolStripMenuItem.Visible = False
                        DeleteToolStripMenuItem.Visible = False
                    Case Else
                        UpdateToolStripMenuItem.Visible = True
                        DeleteToolStripMenuItem.Visible = true
                End Select
                BackloadImage_CMS.Show()
                BackloadImage_CMS.Location = New Point(MousePosition.X, MousePosition.Y)
            Case MouseButtons.Left

        End Select
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim ITEM_IMAGE As New MemoryStream
        Image_Default_Folder = "http://121.58.229.248:8083/Backload%20Images"

        Try
            Dim BrowsePic As New OpenFileDialog
            BrowsePic.Filter = "Please insert (*.JPG;*.PNG) only.|*.jpg;*.png"

            If BrowsePic.ShowDialog = DialogResult.OK Then
                BackloadImage_Pbox.Image = Image.FromFile(BrowsePic.FileName)
            End If

            BackloadImage_Pbox.Image.Save(ITEM_IMAGE, BackloadImage_Pbox.Image.RawFormat)
            Dim Path As String = "\\kmdisqlserver\KMDIIMAGEFILE2\Backload Images\" & JO & "\"
            Dim Dir As String = IO.Path.GetDirectoryName(Path)

            If Not Directory.Exists(Dir) Then
                Directory.CreateDirectory(Path)
            End If

            Image_File_Name = (Image_Count + 1).ToString & ".jpeg"

            Dim PicPathName As String
            PicPathName = System.IO.Path.Combine(Dir, Image_File_Name)

            BackloadImage_Pbox.Image.Save(PicPathName)

            ActionTaken = "Add"
            StartWorker()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            ActionTaken = "Delete"
            StartWorker()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class