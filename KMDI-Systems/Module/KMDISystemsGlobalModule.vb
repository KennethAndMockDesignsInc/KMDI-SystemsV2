Imports System.Data.SqlClient
Module KMDISystemsGlobalModule
    Public TileAccessOfLoggedAccount As String
    Public AccountAutonum As String
    Public confirmQuery As Integer

    Public ContractCollumns As Boolean

    Public Query As String

    Public dt As New DataTable

    Public EngrSDreq = "|01", DelReciepts = "|02", DR = "|03", DrReports = "|04", EngrsItinerary = "|05", EngrSDsubm = "|06", 'Engineering
     addendum = "|07", SalesItinerary = "|08", SalesMoni = "|09", SUS = "|10", CallerInfo = "|11", Collection = "|12", ExtDMGs = "|13", CheckBalance = "|14", 'Sales and OP
     ProdSDreq = "|15", CuttList = "|16", StatsMoni = "|17", GlassSpecs = "|18", ProdSDSubm = "|19", ' Production
     ArchiFirm = "|20", Inventory = "|21", Request = "|22", 'Marketing
     WinDoor As String = "|25" ' Costing


    Public Sub rowpostpaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Public UnitNo As String
    Public Establishment As String
    Public HouseNo As String
    Public Street As String
    Public Village As String
    Public Brgy As String
    Public CityMunicipality As String
    Public Province As String
    Public Area As String
    Public FullAddress As String

    Public Sub AddressFormat(ByVal unitnoAF As String,
                             ByVal establishmentAF As String,
                             ByVal housenoAF As String,
                             ByVal streetAF As String,
                             ByVal villageAF As String,
                             ByVal brgyAF As String,
                             ByVal cityAF As String,
                             ByVal provinceAF As String)

        FullAddress = Nothing

        Select Case UnitNo
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = UnitNo
        End Select

        Select Case Establishment
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & Establishment
        End Select

        Select Case HouseNo
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & HouseNo
        End Select

        Select Case Street
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & Street
        End Select

        Select Case Village
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                FullAddress = FullAddress & " " & Village
                            Case Else
                                FullAddress = FullAddress & ", " & Village
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                FullAddress = FullAddress & " " & Village
                            Case Else
                                FullAddress = FullAddress & ", " & Village
                        End Select
                End Select
        End Select

        Select Case Brgy
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & " " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & ", " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & " " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & ", " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                        End Select
                End Select
        End Select

        Select Case CityMunicipality
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & " " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & " " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        Select Case Province
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & " " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & " " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        FullAddress = Trim(FullAddress)
        MsgBox(unitnoAF &
                             establishmentAF &
                             housenoAF &
                             streetAF &
                             villageAF &
                             brgyAF &
                             cityAF &
                             provinceAF)
        MsgBox("FullAddress: " & FullAddress)
    End Sub


    Public Sub KMDI_ACCT_ACCESS_TB_READ_FOR_KMDI_MainFRM(ByVal UserAcctAutonum As String)
        Try
            sqlDataSet = New DataSet
            Dim tileAccessHere As String

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [TileAccess] as [Tile]
                       FROM [KMDI_ACCT_ACCESS_TB]
                     WHERE [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)
            Read = sqlCommand.ExecuteReader

            If Read.HasRows = True Then
                While Read.Read
                    tileAccessHere = Read.Item("Tile").ToString

                    If tileAccessHere <> "" Then
                        TileAccessOfLoggedAccount += "|" + tileAccessHere

                    End If

                End While

            ElseIf Read.HasRows = False Then
                TileAccessOfLoggedAccount = Nothing
            End If

            Read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

End Module
