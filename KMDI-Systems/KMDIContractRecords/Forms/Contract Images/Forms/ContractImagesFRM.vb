Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports MetroFramework
Imports System.Data.SqlClient

Public Class ContractImagesFRM
    Dim sql As New ContractImagesClass
    Public SearchString As String = Trim(SearchString)

    Public ActionTaken As String
    Public GenerateImage As Boolean

    Public err As String

    Dim stp_Name As String

    Public picbox As PictureBox
    Public ImageAddresses As New ArrayList
    Private m_PanStartPoint As New Point

    Dim locationx As Integer
    Dim locationy As Integer

    Dim AdditionalHeight As Integer
    Dim AdditionalWidth As Integer

    Dim PrintNumber As Integer
    Dim PageNumber As Integer

    Public ContractImagesBGW As BackgroundWorker = New BackgroundWorker

    Private Sub ContractImagesFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            AddHandler ContractImagesBGW.DoWork, AddressOf ContractImagesBGW_DoWork
            AddHandler ContractImagesBGW.RunWorkerCompleted, AddressOf ContractImagesBGW_RunWorkerCompleted
            AddHandler ContractImagesBGW.ProgressChanged, AddressOf ContractImagesBGW_ProgressChanged

            LoadInitialSetUp()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub LoadInitialSetUp()
        PageNo_LBL.Visible = False
        GenerateImage = False
        ActionTaken = "Search"
        Load_LBL.Text = "Gathering information"
        StartWorker()
    End Sub

    Public Sub StartWorker()
        Try
            If ContractImagesBGW.IsBusy <> True Then
                ImageAddresses.Clear()
                Load_LBL.Visible = True
                Load_PB.Visible = True
                ContractImagesBGW.WorkerReportsProgress = True
                ContractImagesBGW.WorkerSupportsCancellation = True
                ContractImagesBGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "The system has encountered an error during recovery of the scanned contract" & vbCrLf & vbCrLf & ex.ToString, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub ContractImagesBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Try
            Select Case GenerateImage
                Case True
                    For Each row In sql.bs
                        ImageAddresses.Add(row("IMG"))
                    Next

                    If ImageAddresses.Count <= 0 Then
                        MetroMessageBox.Show(Me, "No scanned copy of the contract where found in the database.", "No scanned copy available", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        For i As Integer = 0 To ImageAddresses.Count - 1
                            Threading.Thread.Sleep(100)
                            ContractImagesBGW.ReportProgress(i)
                        Next i
                    End If

                Case False
                    Try
                        ActionTakenByUser()

                        For i As Integer = 0 To 1 - 1
                            sql.ContractImagesLoad(ActionTaken,
                                                   stp_Name,
                                                   SearchString)
                            Threading.Thread.Sleep(100)
                            ContractImagesBGW.ReportProgress(i)
                        Next i
                    Catch ex As SqlException
                        err = ex.Number.ToString
                    End Try

            End Select
        Catch ex As Exception
            err = ex.ToString
            ContractImagesBGW.WorkerSupportsCancellation = True
            ContractImagesBGW.CancelAsync()
        End Try

        If ContractImagesBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ContractImagesBGW_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        Try
            Select Case GenerateImage
                Case True
                    '// Clear all picture box inside the panel.
                    Select Case e.ProgressPercentage
                        Case 0
                            ContractImages_PNL.Controls.Clear()
                    End Select

                    '// Start loading bar.
                    With Load_PB
                        .ProgressBarStyle = ProgressBarStyle.Blocks
                        .Value = (100 * e.ProgressPercentage / ImageAddresses.Count)
                    End With

                    '// Generate new picture box
                    picbox = New PictureBox()
                    picbox.Height = 1000
                    picbox.Width = 800
                    locationx = ((ContractImages_PNL.Width - picbox.Width) / 2)
                    locationy = (1025 * e.ProgressPercentage)
                    picbox.Location = New Point(locationx, locationy)
                    picbox.SizeMode = PictureBoxSizeMode.Zoom
                    picbox.BorderStyle = 0


                    '// Get image location
                    Dim ImageLink As String = TryCast(ImageAddresses.Item(e.ProgressPercentage), String)

                    '// Access file from storage
                    Dim objwebClient As WebClient
                    Dim sURL As String = Trim(ImageLink)
                    Dim objImage As MemoryStream
                    Dim srcBmp As Bitmap

                    objwebClient = New WebClient()
                    objImage = New MemoryStream(objwebClient.DownloadData(sURL))
                    srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)

                    picbox.Image = srcBmp
                    picbox.Text = ImageLink
                    ContractImages_PNL.Controls.Add(picbox)

                    AddHandler picbox.KeyDown, AddressOf KeyDowns
                    AddHandler picbox.MouseClick, AddressOf picbox_MouseClick
                   'AddHandler picbox.MouseWheel, AddressOf picbox_MouseWheel
                   'AddHandler picbox.MouseDown, AddressOf picbox_MouseDown
                   'AddHandler picbox.MouseMove, AddressOf picbox_MouseMove
                Case False

                    '// Start loading bar.
                    With Load_PB
                        .ProgressBarStyle = ProgressBarStyle.Blocks
                        .Value = (100 * e.ProgressPercentage / 1)
                    End With

            End Select

        Catch ex As Exception
            err = ex.ToString
            ContractImagesBGW.CancelAsync()
        End Try

    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                stp_Name = "stp_SearchContractImages"
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Private Sub ContractImagesBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)

        Select Case GenerateImage
            Case True

                Try
                    Load_LBL.Text = "Retrieving scanned contracts. Please wait"
                    Load_LBL.Visible = False
                    Load_PB.Visible = False
                    Load_PB.Value = 0
                    PageNo_LBL.Visible = True
                    PageNo_LBL.Text = "1 of " & ImageAddresses.Count

                    Select Case err
                        Case ""
                        Case Nothing
                        Case Else
                            GeneralSystemError(sender, e)
                    End Select

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case False
                Try
                    Select Case err
                        Case ""
                            Output()
                        Case Nothing
                            Output()
                        Case Else
                            GeneralSystemError(sender, e)
                    End Select
                Catch ex As Exception
                End Try
        End Select
    End Sub

    Public Sub Scanned_Contracts_Display()
        Try
            Select Case ActionTaken
                Case "Search"
                    GenerateImage = True
                    Load_LBL.Text = "Retrieving scanned contracts. Please wait"
                    StartWorker()
                Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractImages_PNL_Resize(sender As Object, e As EventArgs) Handles ContractImages_PNL.Resize
        Try
            For Each picbox In ContractImages_PNL.Controls
                picbox.Location = New Point(((ContractImages_PNL.Width - picbox.Width) / 2), picbox.Location.Y)
            Next
        Catch ex As Exception

        End Try
    End Sub

    'Public Sub picbox_MouseWheel(ByVal sender As System.Object, e As MouseEventArgs)
    '    Try
    '        For Each picbox In ContractImages_PNL.Controls

    '            If e.Delta <> 0 And (Control.ModifierKeys = Keys.Control) Then
    '                If e.Delta <= 0 Then
    '                    If picbox.Height < 1000 Then Exit Sub
    '                Else
    '                    If picbox.Width > 2000 Then Exit Sub
    '                End If

    '                AdditionalHeight = CInt(picbox.Height * e.Delta / 1000)
    '                AdditionalWidth = CInt(picbox.Width * e.Delta / 1000)
    '                picbox.Width = picbox.Width + AdditionalWidth
    '                picbox.Height = picbox.Height + AdditionalHeight

    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Public Sub picbox_MouseDown(ByVal sender As System.Object, e As MouseEventArgs)
    '    Try
    '        For Each picbox In ContractImages_PNL.Controls
    '            m_PanStartPoint = New Point(e.X, e.Y)
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Public Sub picbox_MouseMove(ByVal sender As System.Object, e As MouseEventArgs)
    '    Try
    '        For Each picbox In ContractImages_PNL.Controls
    '            If e.Button = MouseButtons.Left Then
    '                Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
    '                Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)
    '                ContractImages_PNL.AutoScrollPosition = New Drawing.Point((DeltaX - ContractImages_PNL.AutoScrollPosition.X), (DeltaY - ContractImages_PNL.AutoScrollPosition.Y))
    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Public Sub picbox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
    '    Try
    '        Select Case e.KeyCode
    '            Case Keys.F5
    '                LoadInitialSetUp()
    '        End Select
    '    Catch ex As Exception
    '         MetroMessageBox.Show(Me, "A system error has occured. If problem persist please contact the system dev team for assistance. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Me.Close()
    '    End Try
    'End Sub

    Public Sub picbox_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        ShowScannedOptions(sender, e)
    End Sub

    Private Sub KeyDowns(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown, ContractImages_LBL.KeyDown,
                                                                                  ContractImages_PNL.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F5
                    LoadInitialSetUp()
                Case Keys.Escape
                    Me.Close()
            End Select

            If e.Control And e.KeyCode = Keys.P Then
                PrintDoc()
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, "A system error has occured. If problem persist please contact the system dev team for assistance. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try
    End Sub

    Private Sub ContractImagesFRM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dispose()
            ContractRecordsFRM.BringToFront()
            ContractRecordsFRM.ContractRecordsDGV.Select()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintCtrlPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintCtrlPToolStripMenuItem.Click
        Try
            PrintDoc()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractImages_PNL_MouseClick(sender As Object, e As MouseEventArgs) Handles ContractImages_PNL.MouseClick
        Try
            ShowScannedOptions(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc_PDC.PrintPage
        Try
            '// Traverse the images.
            If PrintNumber < PrintDoc_PDC.PrinterSettings.ToPage - 1 Then
                '// print currentpage
                PrintPages(sender, e)
                PrintNumber = PrintNumber + 1
                e.HasMorePages = True
            ElseIf PrintNumber = PrintDoc_PDC.PrinterSettings.ToPage - 1 Then
                '// print currentpage
                PrintPages(sender, e)
                PrintNumber = PrintNumber + 1
                e.HasMorePages = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ContractImages_PNL_Scroll(sender As Object, e As ScrollEventArgs) Handles ContractImages_PNL.Scroll
        Try
            VerticalScrolling()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractImages_PNL_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ContractImages_PNL.MouseWheel
        VerticalScrolling()
    End Sub

    Public Sub VerticalScrolling()
        Try
            PageNumber = (ContractImages_PNL.VerticalScroll.Value / 1025) + 1
            PageNo_LBL.Text = PageNumber & " of " & ImageAddresses.Count
        Catch ex As Exception
            MetroMessageBox.Show(Me, "A system error has occured. If problem persist please contact the system dev team for assistance. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
        End Try
    End Sub

    Public Sub PrintPages(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Try
            '// Get the image
            Dim ImageLink As String = TryCast(ImageAddresses.Item(PrintNumber), String)

            '// Access file from storage
            Dim objwebClient As WebClient
            Dim sURL As String = Trim(ImageLink)
            Dim objImage As MemoryStream
            Dim srcBmp As Bitmap

            objwebClient = New WebClient()
            objImage = New MemoryStream(objwebClient.DownloadData(sURL))
            srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)

            '// Apply print setup
            With PrintDoc_PDC
                .DefaultPageSettings = PrintSetup_PSD.PageSettings
                .PrinterSettings = PrintSetup_PSD.PrinterSettings
                .OriginAtMargins = True
            End With

            '// Draw the image
            e.Graphics.DrawImage(srcBmp, 0, 0)
        Catch ex As Exception
            MetroMessageBox.Show(Me, "A system error has occured. If problem persist please contact the system dev team for assistance. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try
    End Sub

    Public Sub ShowScannedOptions(ByVal sender As Object, ByVal e As MouseEventArgs)
        Try
            Select Case e.Button
                Case MouseButtons.Right
                    With ScannedMenuStrip
                        .Show()
                        .Location = New Point(MousePosition.X, MousePosition.Y)
                    End With
            End Select
        Catch ex As Exception
            MetroMessageBox.Show(Me, "The system has encountered an error during recovery of the scanned contract" & vbCrLf & vbCrLf & ex.ToString, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
        End Try
    End Sub

    Public Sub PrintDoc()
        Try
            With PrintDoc_PDC
                .DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)
            End With

            With PrintPage_PDG
                .AllowCurrentPage = False
                .AllowSomePages = True
                .AllowSelection = False
                .AllowPrintToFile = False
                .ShowHelp = True
                .Document = PrintDoc_PDC
            End With

            Dim form As New Form
            form.StartPosition = FormStartPosition.CenterScreen
            form.Visible = False

            With PrintSetup_PSD
                .AllowMargins = False
                .AllowOrientation = False
                .Document = PrintDoc_PDC
            End With

            If PrintSetup_PSD.ShowDialog = DialogResult.OK Then
                If PrintPage_PDG.ShowDialog(form) = DialogResult.OK Then
                    Select Case PrintDoc_PDC.PrinterSettings.FromPage
                        Case 0
                            PrintNumber = 0
                            PrintDoc_PDC.PrinterSettings.ToPage = ImageAddresses.Count
                            PrintDoc_PDC.Print()
                        Case Nothing
                            PrintNumber = 0
                            PrintDoc_PDC.PrinterSettings.ToPage = ImageAddresses.Count
                            PrintDoc_PDC.Print()
                        Case Else
                            PrintNumber = PrintDoc_PDC.PrinterSettings.FromPage - 1
                            PrintDoc_PDC.Print()
                    End Select

                End If
            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, "A system error has occured. If problem persist please contact the system dev team for assistance. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
        End Try
    End Sub

    Public Sub GeneralSystemError(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            If e.Cancelled = True Then
                If err = "-2" Then
                    MetroMessageBox.Show(Me, "Request time out", "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf err = "1232" Then
                    MetroMessageBox.Show(Me, "Connection error", "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf err = "19" Then
                    MetroMessageBox.Show(Me, "Server maintenance", "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf err <> "-2" And err <> "1232" And err <> "19" Then
                    MetroMessageBox.Show(Me, "The system has encountered an error during recovery of the scanned contract" & vbCrLf & vbCrLf & err, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            ElseIf e.Error IsNot Nothing Then
                If err = "-2" Then
                    MetroMessageBox.Show(Me, "Request time out", "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf err = "1232" Then
                    MetroMessageBox.Show(Me, "Connection error", "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf err = "19" Then
                    MetroMessageBox.Show(Me, "Server maintenance", "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf err <> "-2" And err <> "1232" And err <> "19" Then
                    MetroMessageBox.Show(Me, "The system has encountered an error during recovery of the scanned contract" & vbCrLf & vbCrLf & err, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If
            Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Output()
        Try
            Select Case ActionTaken
                Case "Search"
                    If Read.HasRows = True Then

                        Scanned_Contracts_Display()
                    Else
                        MetroMessageBox.Show(Me, "Please coordinate with collections department for a copy of the contract.", "No scanned contracts detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception
            MetroMessageBox.Show(Me, "The system has encountered an error during recovery of the scanned contract" & vbCrLf & vbCrLf & ex.ToString, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class