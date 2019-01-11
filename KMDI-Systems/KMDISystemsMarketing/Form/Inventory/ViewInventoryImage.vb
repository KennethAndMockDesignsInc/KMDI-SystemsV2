'Imports System.IO
'Imports System.Net

Public Class ViewInventoryImage
    '    Public ImageDisplay As String
    '    Private m_PanStartPoint As New Point

    '    Private Sub Browse_btn_Click(sender As Object, e As EventArgs) Handles Browse_btn.Click
    '        Dim BrowsePic As New OpenFileDialog
    '        BrowsePic.Filter = "Please insert (*.JPG;*.PNG) only.|*.jpg;*.png"

    '        If BrowsePic.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            InventoryImage_Pbox.Image = Image.FromFile(BrowsePic.FileName)
    '        End If
    '    End Sub

    '    Private Sub UpdateInvImage_btn_Click(sender As Object, e As EventArgs) Handles UpdateInvImage_btn.Click
    '        Dim ITEM_IMAGE As New MemoryStream
    '        InventoryImage_Pbox.Image.Save(ITEM_IMAGE, InventoryImage_Pbox.Image.RawFormat)

    '        'Update image
    '        Dim Path As String = "\\kmdisqlserver\KMDIIMAGEFILE2\Marketing Inventory\" & Inventory.ItemCodeTbox.Text & "\"
    '        Dim Dir As String = IO.Path.GetDirectoryName(Path)

    '        If Not Directory.Exists(Dir) Then
    '            Directory.CreateDirectory(Path)
    '        End If

    '        Dim PicPathName As String
    '        PicPathName = System.IO.Path.Combine(Dir, Inventory.CategoryCbox.Text + ".jpeg")

    '        InventoryImage_Pbox.Image.Save(PicPathName)
    '        Updateimage(Inventory.ItemRefNo, Inventory.ItemCode, Inventory.ItemCategory)
    '        If MARKETING_INVENTORY_V2_DBMaintenance_bool = True Then
    '            Inventory.Enabled = True
    '            Inventory.clear()
    '            Me.Hide()
    '        End If
    '    End Sub

    '    Private Sub ViewInventoryImage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '        Inventory.Enabled = True
    '    End Sub

    '    Private Sub InventoryImage_Pbox_MouseWheel(sender As System.Object, e As MouseEventArgs) Handles InventoryImage_Pbox.MouseWheel
    '        If e.Delta <> 0 Then
    '            If e.Delta <= 0 Then
    '                If InventoryImage_Pbox.Width < 500 Then Exit Sub
    '            Else
    '                If InventoryImage_Pbox.Width > 2000 Then Exit Sub
    '            End If

    '            InventoryImage_Pbox.Width += CInt(InventoryImage_Pbox.Width * e.Delta / 1000)
    '            InventoryImage_Pbox.Height += CInt(InventoryImage_Pbox.Height * e.Delta / 1000)
    '        End If

    '    End Sub

    '    Private Sub InventoryImage_Pbox_MouseDown(sender As Object, e As MouseEventArgs) Handles InventoryImage_Pbox.MouseDown
    '        m_PanStartPoint = New Point(e.X, e.Y)
    '    End Sub

    '    Private Sub InventoryImage_Pbox_MouseMove(sender As Object, e As MouseEventArgs) Handles InventoryImage_Pbox.MouseMove
    '        If e.Button = MouseButtons.Left Then
    '            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
    '            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)
    '            Panel1.AutoScrollPosition =
    '                    New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X),
    '                                      (DeltaY - Panel1.AutoScrollPosition.Y))
    '        End If
    '    End Sub

    '    Private Sub Panel1_SizeChanged(sender As Object, e As EventArgs) Handles Panel1.SizeChanged, InventoryImage_Pbox.SizeChanged
    '        If Panel1.Width >= InventoryImage_Pbox.Width Then
    '            InventoryImage_Pbox.Location = New Point(((Panel1.Width - InventoryImage_Pbox.Width) / 2), InventoryImage_Pbox.Location.Y)
    '        ElseIf Panel1.Width < InventoryImage_Pbox.Width Then
    '            InventoryImage_Pbox.Location = New Point(((InventoryImage_Pbox.Width - InventoryImage_Pbox.Width) / 2), InventoryImage_Pbox.Location.Y)
    '        End If

    '    End Sub

    '    'Private Sub InventoryImage_Pbox_SizeChanged(sender As Object, e As EventArgs) Handles InventoryImage_Pbox.SizeChanged
    '    '    'InventoryImage_Pbox.Location = New Point(((InventoryImage_Pbox.Width - InventoryImage_Pbox.Width) / 2), InventoryImage_Pbox.Location.Y)
    '    'End Sub

    '    Private Sub ViewInventoryImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        loadimagetoInventoryImage_Pbox()
    '    End Sub

    '    Public Sub loadimagetoInventoryImage_Pbox()
    '        Try
    '            Dim objwebClient As WebClient
    '            Dim sURL As String = Trim(Inventory.ITEM_IMAGE)
    '            Dim objImage As MemoryStream
    '            Dim srcBmp As Bitmap
    '            If Inventory.ITEM_IMAGE = "" Or Inventory.ITEM_IMAGE = Nothing Then
    '                InventoryImage_Pbox.Image = WindowsApplication7.My.Resources.ImageSelected
    '                ImageDisplay = "0"
    '                PictureBox1.Visible = False
    '                PictureBox2.Visible = False
    '            Else
    '                ImageDisplay = "1"
    '                PictureBox1.Visible = True
    '                PictureBox2.Visible = True
    '                objwebClient = New WebClient()
    '                objImage = New MemoryStream(objwebClient.DownloadData(sURL))
    '                srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)
    '                InventoryImage_Pbox.Image = srcBmp
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString)
    '        End Try
    '    End Sub

    '    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '        Select Case ImageDisplay
    '            Case "0"
    '            Case "1"
    '                Try
    '                    InventoryImage_Pbox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    '                    InventoryImage_Pbox.Refresh()
    '                Catch ex As Exception

    '                End Try
    '        End Select
    '    End Sub

    '    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    '        Select Case ImageDisplay
    '            Case "0"
    '            Case "1"
    '                Try
    '                    InventoryImage_Pbox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
    '                    InventoryImage_Pbox.Refresh()
    '                Catch ex As Exception

    '                End Try
    '        End Select
    '    End Sub
End Class