Public Class WinDoorMaker

    Dim WidthOfWindowFrame As New Decimal
    Dim HeightOfWindowFrame As New Decimal
    Dim WidthOfWindowSash As New Decimal
    Dim HeightOfWindowSash As New Decimal
    Dim NoOfSlidingWindowPanel As New Decimal
    Dim NoOfSlidingDoorPanel As New Decimal
    Dim NoOfSFixedPanel As New Decimal
    Dim NoOfOFixedPanel As New Decimal
    Dim NoofCasementWindowPanel As New Decimal
    Dim NoofCasementDoorPanel As New Decimal
    Dim NoofAwningPanel As New Decimal
    Dim FramePerimeter As New Decimal
    Dim SashPerimeter As New Decimal

    Dim AwningWindowFrame As Decimal = 2.0
    Dim AwningWindowSash As Decimal = 2.5
    Dim CasementWindowFrame As Decimal = 2.0
    Dim CasementWindowSash As Decimal = 2.5
    Dim CasementDoorFrame As Decimal = 2.5
    Dim CasementDoorSash As Decimal = 4.5
    Dim SlidingWindowFrame As Decimal = 2.25
    Dim SlidingWindowSash As Decimal = 3.0
    Dim SlidingDoorFrame As Decimal = 3.0
    Dim SlidingDoorSash As Decimal = 4.0
    Dim LouverWindowFrame As Decimal = 2.0
    Dim FixWindowFrame As Decimal = 2.0

    Dim WeightInKgFrame As Decimal
    Dim WeightInKgSash As New Decimal
    Dim Totalframeweightinkg As Decimal
    Dim totalsashweightinkg As Decimal

    Dim GlassWidth As New Decimal
    Dim GlassHeight As New Decimal
    Dim GlassThickness As New Decimal
    Dim TotalGlassWeightinkg As Decimal

    Dim blowingactivity As Decimal = 61.31
    Dim glassalignment As Decimal = 498.24

    Dim frameliftingtime As New Decimal
    Dim frametransfertime As New Decimal
    Dim frameelevationrate As New Decimal
    Dim frameliftingrate As New Decimal
    Dim frameelevation As New Decimal
    Dim sashliftingtime As New Decimal
    Dim sashtransfertime As Decimal
    Dim sashliftingrate As New Decimal
    Dim sashelevationrate As New Decimal
    Dim sashelevation As New Decimal
    Dim glassliftingtime As New Decimal
    Dim glasstransfertime As Decimal
    Dim glasselevationrate As New Decimal
    Dim glassliftingrate As New Decimal
    Dim glasselevation As New Decimal
    Dim removalrateofslidingframe As Decimal = 74.73
    Dim removalrateofslidingsash As Decimal = 52.38
    Dim removalrateoffixsash As Decimal = 51.49
    Dim removalrateofweatherbar As Decimal = 10.28
    Dim Numberofweatherbar As Decimal
    Dim markingrateonconcreteopening As Decimal = 58.36
    Dim alignmentrate As Decimal
    Dim numberofexpansionboltonsideframe As Decimal
    Dim numberofexpansionboltontopframe As Decimal
    Dim numberofexpansionboltonbottomframe As Decimal
    Dim installationrateofexpansionboltonsideframe As Decimal = 40.19
    Dim installationrateofexpansionboltontopframe As Decimal = 60.62
    Dim installationrateofexpansionboltonbottomframe As Decimal = 52
    Dim foamapplicationrate As Decimal
    Dim elementrate As Decimal = 207.0
    Dim removalrateofglazingbead As Decimal = 38.74
    Dim fixingrate As Decimal = 44.45
    Dim nooffixhole As New Decimal
    Dim noofcenterprofile As New Decimal
    Dim installationrateofcenterprofile As Decimal = 25.6
    Dim noofsealingblock As New Decimal
    Dim installationrateofsealingblock As Decimal = 104.1
    Dim noofinterlock As New Decimal
    Dim installationrateofinterlock As Decimal = 38.36
    Dim noofantiliftdevice As New Decimal
    Dim installationrateofantiliftdevice As Decimal = 56.95
    Dim glasssealantapplicationrateonheight As Decimal = 47.88
    Dim glasssealantapplicationrateontopwidth As Decimal = 16.69
    Dim glasssealantapplicationrateonbottomwidth As Decimal = 21.15
    Dim reinstallationrateofglazingbeadontopsash As Decimal = 45.58
    Dim reinstallationrateofglazingbeadonbottomsash As Decimal = 33.88
    Dim glassalignmentrate As New Decimal
    Dim glassperimeter As New Decimal
    Dim trimmingoffoamrate As New Decimal
    Dim sealantapplicationratebetweenwallsandframeinside As New Decimal
    Dim sealantapplicationratebetweenwallsandframeoutside As New Decimal
    Dim plasticcoveringrateinside As Decimal = 15.94
    Dim plasticcoveringrateoutside As Decimal = 9.9
    Dim cleaningorwipingofframeandsashrate As Decimal = 140.0
    Dim noofstriker As New Decimal
    Dim layoutstrikerrate As Decimal = 5.0
    Dim installationrateofstriker As Decimal = 87.58
    Dim cleaningrateofglass As Decimal = 140.0
    Dim totalinstallationtime As New Decimal
    Dim totalinstallationtimeconverted As New Decimal
    Dim installationrateof9c54 As Decimal = 64.8
    Dim noofscrewstoberemove As Decimal
    Dim removalrateofgallery As Decimal = 32.25
    Dim reinstallationrateofgallery As Decimal = 32.63
    Dim noof0373 As Decimal
    Dim reinstallationrateof0373 As Decimal = 153.0
    Dim noof9c54 As Decimal
    Dim reinstallationrateofaccessories As Decimal = 117.5
    Dim noofnonfixblades As Decimal
    Dim installationrateofnonfixblades As Decimal = 25.71
    Dim nooffixblades As Decimal
    Dim installationrateoffixblades As Decimal = 122.0
    Dim noofbatch As Decimal
    Dim nooflouverpanel As Decimal
    Dim op1 As New Decimal
    Dim op2 As New Decimal
    Dim op3 As New Decimal
    Dim op4 As New Decimal
    Dim op5 As New Decimal
    Dim op6 As New Decimal
    Dim op7 As New Decimal
    Dim op8 As New Decimal
    Dim op9 As New Decimal
    Dim op10 As New Decimal
    Dim op11 As New Decimal
    Dim op12 As New Decimal
    Dim op13 As New Decimal
    Dim op14 As New Decimal
    Dim op15 As New Decimal
    Dim op16 As New Decimal
    Dim op17 As New Decimal
    Dim op18 As New Decimal
    Dim op19 As New Decimal
    Dim op20 As New Decimal
    Dim op21 As New Decimal
    Dim op22 As New Decimal
    Dim op23 As New Decimal
    Dim op24 As New Decimal
    Dim op25 As New Decimal
    Dim op26 As New Decimal
    Dim op27 As New Decimal
    Dim op28 As New Decimal
    Dim op29 As New Decimal
    Dim op30 As New Decimal
    Dim op31 As New Decimal
    Dim op32 As New Decimal
    Dim op33 As New Decimal
    Dim op34 As New Decimal
    Dim op35 As New Decimal
    Dim op36 As New Decimal
    Dim op37 As New Decimal
    Dim op38 As New Decimal

    Dim something As Integer

    Private Sub WinDoorMaker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KMDI_MainFRM.Show()
        KMDI_MainFRM.BringToFront()
    End Sub

    Private Sub WinDoorMaker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '--------Frame Perimeter

        FramePerimeter = (2 * (WidthOfWindowFrame + HeightOfWindowFrame))

        '--------Sash Perimeter

        SashPerimeter = (2 * (WidthOfWindowSash + HeightOfWindowSash))

        '--------Foam Application Rate

        If NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel = 1 Then
            foamapplicationrate = 43.95
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel >= 2 Then
            foamapplicationrate = 21.17
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel <= 0 Then
            MsgBox("No panels detected foam application", MsgBoxStyle.OkOnly, "Error")
        End If

        '--------Cleaning or Wiping of Frame and Sash

        If ComboBox1.Text = "Louver Window" Or ComboBox1.Text = "Awning Window" Or ComboBox1.Text = "Casement Door" Or ComboBox1.Text = "Casement Window" Or ComboBox1.Text = "Fix Window" Then
            TextBox38.Text = (FramePerimeter / cleaningorwipingofframeandsashrate)
        Else
            TextBox38.Text = (FramePerimeter / cleaningorwipingofframeandsashrate) +
                             ((SashPerimeter / cleaningorwipingofframeandsashrate) *
                             (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel))
        End If

        '--------Positioning of Frame

        If ComboBox1.Text = "Awning Window" Then
            frameliftingrate = 1.97
            frameelevationrate = 0.04
        ElseIf ComboBox1.Text = "Casement Window" Then
            frameliftingrate = 1.97
            frameelevationrate = 0.04
        ElseIf ComboBox1.Text = "Casement Door" Then
            frameliftingrate = 1.54
            frameelevationrate = 0.0
        ElseIf ComboBox1.Text = "Sliding Window" Then
            frameliftingrate = 1.42
            frameelevationrate = 0.04
        ElseIf ComboBox1.Text = "Sliding Door" Then
            frameliftingrate = 1.24
            frameelevationrate = 0.0
        ElseIf ComboBox1.Text = "Louver Window" Then
            frameliftingrate = 1.97
            frameelevationrate = 0.04
        ElseIf ComboBox1.Text = "Fix Window" Then
            frameliftingrate = 1.97
            frameelevationrate = 0.04
        End If


        If ComboBox1.Text = "Casement Door" Then
            frameliftingtime = ((Totalframeweightinkg + totalsashweightinkg) * frameliftingrate)

        ElseIf ComboBox1.Text = "Sliding Door" Then
            frameliftingtime = (Totalframeweightinkg * frameliftingrate)

        ElseIf ComboBox1.Text = "Awning Window" Or ComboBox1.Text = "Casement Window" Or ComboBox1.Text = "Fix Window" Then
            frameliftingtime = ((((Totalframeweightinkg + totalsashweightinkg) * frameliftingrate) +
                              (frameelevation * frameelevationrate)) / 2)

        ElseIf ComboBox1.Text = "Sliding Window" Or ComboBox1.Text = "Louver Window" Then
            frameliftingtime = (((Totalframeweightinkg * frameliftingrate) +
                              (frameelevation * frameelevationrate)) / 2)
        End If

        TextBox3.Text = (frameliftingtime + frametransfertime)

        '--------Marking lines on concrete opening

        TextBox6.Text = (FramePerimeter / markingrateonconcreteopening)

        '--------Frame Alignment

        If FramePerimeter >= 10000 Then
            alignmentrate = 17.9
        ElseIf FramePerimeter <= 9999 Then
            alignmentrate = 11.93
        End If

        TextBox7.Text = (FramePerimeter / alignmentrate)

        '--------Concrete Drilling and Installation of expansion bolt

        TextBox8.Text = (2 * numberofexpansionboltonsideframe * installationrateofexpansionboltonsideframe) +
                        (numberofexpansionboltonbottomframe * installationrateofexpansionboltonbottomframe) +
                        (numberofexpansionboltontopframe * installationrateofexpansionboltontopframe)

        '--------Blowing Activity

        TextBox12.Text = blowingactivity

        '--------Foam Application on top and side frame

        If ComboBox1.Text = "Sliding Window" Or ComboBox1.Text = "Sliding Door" Then
            TextBox13.Text = ((WidthOfWindowFrame + (2 * HeightOfWindowFrame)) / foamapplicationrate)
        Else
            TextBox13.Text = 0
        End If

        '--------Trimming of foam excess and rebate

        If NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel = 1 Then
            trimmingoffoamrate = 20.98
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel >= 2 Then
            trimmingoffoamrate = 17.59
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel <= 0 Then
            trimmingoffoamrate = 0
        End If

        TextBox33.Text = (FramePerimeter / trimmingoffoamrate)

        '--------Transfer and lifting of glass / Transfer of blades

        If ComboBox1.Text = "Awning Window" Then
            glassliftingrate = 2.54
            glasselevationrate = 0.03
        ElseIf ComboBox1.Text = "Casement Window" Then
            glassliftingrate = 2.54
            glasselevationrate = 0.03
        ElseIf ComboBox1.Text = "Casement Door" Then
            glassliftingrate = 2.15
            glasselevationrate = 0.0
        ElseIf ComboBox1.Text = "Sliding Window" Then
            glassliftingrate = 2.54
            glasselevationrate = 0.03
        ElseIf ComboBox1.Text = "Sliding Door" Then
            glassliftingrate = 2.54
            glasselevationrate = 0.03
        ElseIf ComboBox1.Text = "Louver Window" Then
            glassliftingrate = 0.0
            glasselevationrate = 0.0
        ElseIf ComboBox1.Text = "Fix Window" Then
            glassliftingrate = 2.54
            glasselevationrate = 0.03
        End If

        If ComboBox1.Text = "Casement Door" Or ComboBox1.Text = "Sliding Door" Then
            glassliftingtime = (TotalGlassWeightinkg * glassliftingrate)
        Else
            glassliftingtime = (((TotalGlassWeightinkg * glassliftingrate) +
                              (glasselevation * glasselevationrate)) / 2)
        End If


        TextBox45.Text = glassliftingtime

        If ComboBox1.Text = "Louver Window" Then
            TextBox28.Text = glasstransfertime * noofbatch
        Else
            TextBox28.Text = (glassliftingtime + glasstransfertime) * (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel)
        End If

        '--------Sealant application between walls(inside)

        If NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel = 1 Then
            sealantapplicationratebetweenwallsandframeinside = 10.57
            sealantapplicationratebetweenwallsandframeoutside = 10.88
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel >= 2 Then
            sealantapplicationratebetweenwallsandframeinside = 11.85
            sealantapplicationratebetweenwallsandframeoutside = 5.74
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofCasementDoorPanel + NoofAwningPanel + nooflouverpanel <= 0 Then
            MsgBox("No panels detected sealant application", MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End If

        TextBox34.Text = (FramePerimeter / sealantapplicationratebetweenwallsandframeinside)

        '--------Sealant application between walls(outside)

        TextBox35.Text = (FramePerimeter / sealantapplicationratebetweenwallsandframeoutside)

        '--------Plastic covering (inside)

        If ComboBox1.Text = "Sliding Window" Then
            TextBox36.Text = (SashPerimeter / plasticcoveringrateinside) * (NoOfSlidingWindowPanel + NoOfSFixedPanel)
        ElseIf ComboBox1.Text = "Sliding Door" Then
            TextBox36.Text = (SashPerimeter / plasticcoveringrateinside) * (NoOfSlidingDoorPanel + NoOfSFixedPanel)
        Else
            TextBox36.Text = (FramePerimeter / plasticcoveringrateinside)
        End If

        '--------Plastic covering (outside)

        If ComboBox1.Text = "Sliding Window" Then
            TextBox37.Text = (SashPerimeter / plasticcoveringrateoutside) * (NoOfSlidingWindowPanel + NoOfSFixedPanel)
        ElseIf ComboBox1.Text = "Sliding Door" Then
            TextBox37.Text = (SashPerimeter / plasticcoveringrateoutside) * (NoOfSlidingDoorPanel + NoOfSFixedPanel)
        Else
            TextBox37.Text = (FramePerimeter / plasticcoveringrateoutside)
        End If

        '--------Removal of Pattern and Stretch Film

        RemovalofPatternandStretchFilm.Text = (FramePerimeter / removalrateofslidingframe) +
                        ((SashPerimeter / removalrateofslidingsash) * (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel)) +
                        ((SashPerimeter / removalrateoffixsash) * NoOfSFixedPanel)

        '--------Removal of Weather Bar

        If WithWeatherBar.Text = "Yes" Then
            TextBox4.Text = (WidthOfWindowFrame / removalrateofweatherbar)
        ElseIf WithWeatherBar.Text = "No" Then
            TextBox4.Text = 0
        Else
            TextBox4.Text = 0
        End If


        '--------Trimming of Brush Seal

        TextBox15.Text = (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel) * elementrate

        '--------Removal of Glazing Bead

        TextBox16.Text = (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel +
            NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementDoorPanel +
            NoofCasementWindowPanel + NoofAwningPanel) * removalrateofglazingbead

        '--------Positioning of Sliding Sash

        If ComboBox1.Text = "Sliding Window" Then
            sashliftingrate = 0.95
            sashelevationrate = 0.02
        ElseIf ComboBox1.Text = "Sliding Door" Then
            sashliftingrate = 1.11
            sashelevationrate = 0.00
        End If

        If ComboBox1.Text = "Sliding Window" Then
            sashliftingtime = (((totalsashweightinkg * sashliftingrate) +
                              (sashelevation * sashelevationrate)) / 2)

        ElseIf ComboBox1.Text = "Sliding Door" Then
            sashliftingtime = (totalsashweightinkg * sashliftingrate)
        End If


        If ComboBox1.Text = "Sliding Window" Then
            TextBox17.Text = (sashliftingtime + sashtransfertime) * (NoOfSlidingWindowPanel + NoOfSFixedPanel)

        ElseIf ComboBox1.Text = "Sliding Door" Then
            TextBox17.Text = (sashliftingtime + sashtransfertime) * (NoOfSlidingDoorPanel + NoOfSFixedPanel)
        End If

        '--------Installation of 9C54

        TextBox46.Text = (installationrateof9c54 * noof9c54)

        '--------Fixing of Sash

        TextBox18.Text = (NoOfSFixedPanel * nooffixhole * fixingrate)

        '--------Installation of Center Profile

        TextBox20.Text = (WidthOfWindowFrame / installationrateofcenterprofile)

        '--------Layout of Striker

        TextBox39.Text = (noofstriker * layoutstrikerrate)

        '--------Installation of Striker

        TextBox41.Text = (noofstriker * installationrateofstriker)

        '--------Installation of Sealing Block

        TextBox22.Text = (noofsealingblock * installationrateofsealingblock)

        '--------Installation of Interlock

        TextBox24.Text = (noofinterlock * installationrateofinterlock)

        '--------Installation of Antilift Device

        TextBox26.Text = (noofantiliftdevice * installationrateofantiliftdevice)

        '--------Sealant Application on Glass

        TextBox29.Text = (((HeightOfWindowSash / glasssealantapplicationrateonheight) * 2) +
                         (WidthOfWindowSash / glasssealantapplicationrateontopwidth) +
                         (WidthOfWindowSash / glasssealantapplicationrateonbottomwidth)) * (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementDoorPanel + NoofCasementWindowPanel + NoofAwningPanel)

        '--------Reinstallation of Glazing Bead

        TextBox30.Text = ((WidthOfWindowSash / reinstallationrateofglazingbeadontopsash) +
                          (WidthOfWindowSash / reinstallationrateofglazingbeadonbottomsash)) *
                          (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementDoorPanel + NoofCasementWindowPanel + NoofAwningPanel)

        '--------Glass Alignment

        If NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementDoorPanel + NoofCasementWindowPanel + NoofAwningPanel = 1 Then
            glassalignmentrate = 140.33
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementDoorPanel + NoofCasementWindowPanel + NoofAwningPanel >= 2 Then
            glassalignmentrate = 124.56
        ElseIf NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + NoofCasementDoorPanel + NoofCasementWindowPanel + NoofAwningPanel <= 0 Then
            If ComboBox1.Text = "Louver Window" Then
            Else
                MsgBox("No panels detected glass alignment", MsgBoxStyle.OkOnly, "Error")
            End If
        End If

        If ComboBox1.Text = "Awning Window" Or ComboBox1.Text = "Casement Window" Or ComboBox1.Text = "Casement Door" Or ComboBox1.Text = "Fix Window" Then
            TextBox31.Text = (NoofCasementDoorPanel + NoOfOFixedPanel + NoofCasementWindowPanel + NoofAwningPanel) * (glassalignmentrate)
        ElseIf ComboBox1.Text = "Sliding Window" Or ComboBox1.Text = "Sliding Door" Then
            TextBox31.Text = ((NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel) * glassalignmentrate)
        Else
            TextBox31.Text = 0
        End If

        '--------Foam Application on Bottom Frame
        If ComboBox1.Text = "Sliding Window" Or ComboBox1.Text = "Sliding Door" Then
            TextBox32.Text = (WidthOfWindowFrame / foamapplicationrate)
        Else
            TextBox32.Text = 0
        End If

        '--------Cleaning of Glasses

        TextBox42.Text = ((glassperimeter / cleaningrateofglass) * (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel + NoOfSFixedPanel + NoOfOFixedPanel + +NoofCasementDoorPanel + NoofCasementWindowPanel + NoofAwningPanel))

        '--------Removal of Galleries

        TextBox2.Text = (2 * noofscrewstoberemove * nooflouverpanel * removalrateofgallery)

        '--------Reinstallation of Galleries

        TextBox52.Text = (2 * noofscrewstoberemove * nooflouverpanel * reinstallationrateofgallery)

        '--------Reinstallation of 0373

        TextBox51.Text = (noof0373 * reinstallationrateof0373)

        '--------Reinstallation of Accessories

        TextBox55.Text = (reinstallationrateofaccessories * nooflouverpanel)

        '--------Installation of Non Fix Blades

        TextBox54.Text = (noofnonfixblades * installationrateofnonfixblades)

        '--------Installation of Fix Blades

        TextBox58.Text = (nooffixblades * installationrateoffixblades)

        '--------Foam Application on Louver Window / Awning Window / Casement Window / Casement Door / Fix Window

        TextBox59.Text = (FramePerimeter / foamapplicationrate)

        '--------Variables

        op1 = RemovalofPatternandStretchFilm.Text
        op2 = TextBox3.Text
        op3 = TextBox4.Text
        op4 = TextBox6.Text
        op5 = TextBox7.Text
        op6 = TextBox8.Text
        op7 = TextBox12.Text
        op8 = TextBox13.Text
        op9 = TextBox15.Text
        op10 = TextBox16.Text
        op11 = TextBox17.Text
        op12 = TextBox18.Text
        op13 = TextBox20.Text
        op14 = TextBox22.Text
        op15 = TextBox24.Text
        op16 = TextBox26.Text
        op17 = TextBox28.Text
        op18 = TextBox29.Text
        op19 = TextBox30.Text
        op20 = TextBox31.Text
        op21 = TextBox32.Text
        op22 = TextBox33.Text
        op23 = TextBox34.Text
        op24 = TextBox35.Text
        op25 = TextBox36.Text
        op26 = TextBox37.Text
        op27 = TextBox38.Text
        op28 = TextBox39.Text
        op29 = TextBox41.Text
        op30 = TextBox42.Text
        op31 = TextBox46.Text
        op32 = TextBox2.Text
        op33 = TextBox52.Text
        op34 = TextBox51.Text
        op35 = TextBox55.Text
        op36 = TextBox54.Text
        op37 = TextBox58.Text
        op38 = TextBox59.Text

        '--------Output

        If ComboBox1.Text = "Awning Window" Then
            TextBox43.Text = (op27 + op2 + op4 + op5 + op6 + op7 + op38 + op22 + op10 + op30 +
             op17 + op18 + op19 + op20 + op23 + op24 + op25 + op26)

        ElseIf ComboBox1.Text = "Casement Window" Then
            TextBox43.Text = (op27 + op2 + op4 + op5 + op6 + op7 + op38 + op22 + op10 + op30 +
             op17 + op18 + op19 + op20 + op23 + op24 + op25 + op26)

        ElseIf ComboBox1.Text = "Casement Door" Then
            TextBox43.Text = (op27 + op2 + op4 + op5 + op6 + op7 + op38 + op22 + op10 + op30 +
             op17 + op18 + op19 + op20 + op23 + op24 + op25 + op26)

        ElseIf ComboBox1.Text = "Sliding Window" Then
            TextBox43.Text = (op1 + op2 + op3 + op4 + op5 + op6 + op7 + op8 + op9 +
            op10 + op11 + op12 + op13 + op14 + op15 + op16 + op17 + op18 + op19 +
            op20 + op21 + op22 + op23 + op24 + op25 + op26 + op27 + op28 + op29 +
            op30 + op31)

        ElseIf ComboBox1.Text = "Sliding Door" Then
            TextBox43.Text = (op1 + op2 + op3 + op4 + op5 + op6 + op7 + op8 + op9 +
            op10 + op11 + op12 + op13 + op14 + op15 + op16 + op17 + op18 + op19 +
            op20 + op21 + op22 + op23 + op24 + op25 + op26 + op27 + op28 + op29 +
            op30 + op31)

        ElseIf ComboBox1.Text = "Louver Window" Then
            TextBox43.Text = (op27 + op2 + op4 + op5 + op32 + op6 + op33 + op34 +
                op35 + op17 + op36 + op37 + op7 + op38 + op22 + op23 + op24 + op25 + op26)

        ElseIf ComboBox1.Text = "Fix Window" Then
            TextBox43.Text = (op27 + op2 + op4 + op5 + op6 + op7 + op38 + op22 +
                op10 + op30 + op17 + op18 + op19 + op20 + op23 + op24 + op25 + op26)
        End If

        '------------Convertion
        Dim hr As Decimal = 0
        Dim minuto As Decimal = 0
        Dim segundo As Decimal = 0
        Dim totaltime As Decimal = TextBox43.Text

        Do
            If totaltime < 60 Then
                totaltime -= 10
                segundo += 1
            ElseIf totaltime < 3600 Then
                totaltime -= 60
                minuto += 1
            ElseIf totaltime >= 3600 Then
                totaltime -= 3600
                hr += 1
            End If
        Loop Until totaltime <= 0

        TextBox62.Text = hr.ToString() + "hrs " + minuto.ToString() + "m " + segundo.ToString() + "s"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ComboBox1.Text = "Awning Window" Then
            AwningWindowPanel.Text = 2
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 0
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 6

            FrameWidth.Text = 1200
            FrameHeight.Text = 1200

            SashWidth.Text = 540
            SashHeight.Text = 1140

            GlassWidthTbox.Text = 520
            GlassHeightTbox.Text = 1120

            WhatFloorCbox.Text = 2
            HeightfromFinishFloorLine.Text = 800

            NumberofexpansionboltSF.Text = 3
            NumberofexpansionboltTF.Text = 1
            NumberofexpansionboltBF.Text = 1

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "No"

            Numberof9C54.Text = 0
            NumberofFixHolesPerPanel.Text = 0
            NumberofCenterProfile.Text = 0

            NumberofStriker.Text = 1
            NumberofSealingBlock.Text = 0
            NumberofInterlock.Text = 0
            NumberofAntiliftDevice.Text = 0

            NumberofScrewstobeRemove.Text = 0
            Numberof0373.Text = 0
            NumberofNonFixBlade.Text = 0
            NumberofFixBlade.Text = 0

        ElseIf ComboBox1.Text = "Casement Door" Then
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 2
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 0
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 10

            FrameWidth.Text = 1800
            FrameHeight.Text = 1600

            SashWidth.Text = 600
            SashHeight.Text = 1258

            GlassWidthTbox.Text = 598
            GlassHeightTbox.Text = 1159

            WhatFloorCbox.Text = 3
            HeightfromFinishFloorLine.Text = 0

            NumberofexpansionboltSF.Text = 6
            NumberofexpansionboltTF.Text = 2
            NumberofexpansionboltBF.Text = 2

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "No"

            Numberof9C54.Text = 0
            NumberofFixHolesPerPanel.Text = 0
            NumberofCenterProfile.Text = 0

            NumberofStriker.Text = 2
            NumberofSealingBlock.Text = 0
            NumberofInterlock.Text = 0
            NumberofAntiliftDevice.Text = 0

            NumberofScrewstobeRemove.Text = 0
            Numberof0373.Text = 0
            NumberofNonFixBlade.Text = 0
            NumberofFixBlade.Text = 0

        ElseIf ComboBox1.Text = "Casement Window" Then
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 2
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 0
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 6

            FrameWidth.Text = 1200
            FrameHeight.Text = 1200

            SashWidth.Text = 540
            SashHeight.Text = 1140

            GlassWidthTbox.Text = 520
            GlassHeightTbox.Text = 1120

            WhatFloorCbox.Text = 2
            HeightfromFinishFloorLine.Text = 800

            NumberofexpansionboltSF.Text = 3
            NumberofexpansionboltTF.Text = 1
            NumberofexpansionboltBF.Text = 1

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "No"

            Numberof9C54.Text = 0
            NumberofFixHolesPerPanel.Text = 0
            NumberofCenterProfile.Text = 0

            NumberofStriker.Text = 1
            NumberofSealingBlock.Text = 0
            NumberofInterlock.Text = 0
            NumberofAntiliftDevice.Text = 0

            NumberofScrewstobeRemove.Text = 0
            Numberof0373.Text = 0
            NumberofNonFixBlade.Text = 0
            NumberofFixBlade.Text = 0

        ElseIf ComboBox1.Text = "Sliding Door" Then
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 2
            SFixedWindowPanel.Text = 2
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 10

            FrameWidth.Text = 2682
            FrameHeight.Text = 1690

            SashWidth.Text = 686
            SashHeight.Text = 1620

            GlassWidthTbox.Text = 650
            GlassHeightTbox.Text = 1584

            WhatFloorCbox.Text = 2
            HeightfromFinishFloorLine.Text = 0

            NumberofexpansionboltSF.Text = 5
            NumberofexpansionboltTF.Text = 3
            NumberofexpansionboltBF.Text = 3

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "Yes"

            Numberof9C54.Text = 4
            NumberofFixHolesPerPanel.Text = 5
            NumberofCenterProfile.Text = 1

            NumberofStriker.Text = 4
            NumberofSealingBlock.Text = 4
            NumberofInterlock.Text = 2
            NumberofAntiliftDevice.Text = 4

            NumberofScrewstobeRemove.Text = 0
            Numberof0373.Text = 0
            NumberofNonFixBlade.Text = 0
            NumberofFixBlade.Text = 0

        ElseIf ComboBox1.Text = "Sliding Window" Then
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 2
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 2
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 10

            FrameWidth.Text = 2682
            FrameHeight.Text = 1690

            SashWidth.Text = 686
            SashHeight.Text = 1620

            GlassWidthTbox.Text = 650
            GlassHeightTbox.Text = 1584

            WhatFloorCbox.Text = 2
            HeightfromFinishFloorLine.Text = 1000

            NumberofexpansionboltSF.Text = 5
            NumberofexpansionboltTF.Text = 3
            NumberofexpansionboltBF.Text = 3

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "Yes"

            Numberof9C54.Text = 4
            NumberofFixHolesPerPanel.Text = 5
            NumberofCenterProfile.Text = 1

            NumberofStriker.Text = 4
            NumberofSealingBlock.Text = 4
            NumberofInterlock.Text = 2
            NumberofAntiliftDevice.Text = 4

            NumberofScrewstobeRemove.Text = 0
            Numberof0373.Text = 0
            NumberofNonFixBlade.Text = 0
            NumberofFixBlade.Text = 0

        ElseIf ComboBox1.Text = "Louver Window" Then
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 0
            LouverWindowPanel.Text = 2
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 0

            FrameWidth.Text = 1500
            FrameHeight.Text = 1500

            SashWidth.Text = 0
            SashHeight.Text = 0

            GlassWidthTbox.Text = 552
            GlassHeightTbox.Text = 152

            WhatFloorCbox.Text = 3
            HeightfromFinishFloorLine.Text = 800

            NumberofexpansionboltSF.Text = 6
            NumberofexpansionboltTF.Text = 2
            NumberofexpansionboltBF.Text = 2

            NumberofBladeBatch.Text = 4
            WithWeatherBar.Text = "Yes"

            Numberof9C54.Text = 0
            NumberofFixHolesPerPanel.Text = 0
            NumberofCenterProfile.Text = 0

            NumberofStriker.Text = 0
            NumberofSealingBlock.Text = 0
            NumberofInterlock.Text = 0
            NumberofAntiliftDevice.Text = 0

            NumberofScrewstobeRemove.Text = 8
            Numberof0373.Text = 2
            NumberofNonFixBlade.Text = 12
            NumberofFixBlade.Text = 2

        ElseIf ComboBox1.Text = "Fix Window" Then
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 0
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 1

            GlassthicknesTbox.Text = 10

            FrameWidth.Text = 900
            FrameHeight.Text = 1500

            SashWidth.Text = 0
            SashHeight.Text = 0

            GlassWidthTbox.Text = 812
            GlassHeightTbox.Text = 1302

            WhatFloorCbox.Text = 1
            HeightfromFinishFloorLine.Text = 1000

            NumberofexpansionboltSF.Text = 6
            NumberofexpansionboltTF.Text = 2
            NumberofexpansionboltBF.Text = 2

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "No"

            Numberof9C54.Text = 0
            NumberofFixHolesPerPanel.Text = 0
            NumberofCenterProfile.Text = 0

            NumberofStriker.Text = 1
            NumberofSealingBlock.Text = 0
            NumberofInterlock.Text = 0
            NumberofAntiliftDevice.Text = 0

            NumberofScrewstobeRemove.Text = 8
            Numberof0373.Text = 2
            NumberofNonFixBlade.Text = 12
            NumberofFixBlade.Text = 2
        Else
            AwningWindowPanel.Text = 0
            CasementWindowPanel.Text = 0
            CasementDoorPanel.Text = 0
            SlidingWindowPanel.Text = 0
            SlidingDoorPanel.Text = 0
            SFixedWindowPanel.Text = 0
            LouverWindowPanel.Text = 0
            OFixedWindowPanel.Text = 0

            GlassthicknesTbox.Text = 0

            FrameWidth.Text = 0
            FrameHeight.Text = 0

            SashWidth.Text = 0
            SashHeight.Text = 0

            GlassWidthTbox.Text = 0
            GlassHeightTbox.Text = 0

            WhatFloorCbox.Text = 0
            HeightfromFinishFloorLine.Text = 0

            NumberofexpansionboltSF.Text = 0
            NumberofexpansionboltTF.Text = 0
            NumberofexpansionboltBF.Text = 0

            NumberofBladeBatch.Text = 0
            WithWeatherBar.Text = "Yes"

            Numberof9C54.Text = 0
            NumberofFixHolesPerPanel.Text = 0
            NumberofCenterProfile.Text = 0

            NumberofStriker.Text = 0
            NumberofSealingBlock.Text = 0
            NumberofInterlock.Text = 0
            NumberofAntiliftDevice.Text = 0

            NumberofScrewstobeRemove.Text = 0
            Numberof0373.Text = 0
            NumberofNonFixBlade.Text = 0
            NumberofFixBlade.Text = 0
        End If
    End Sub
    Private Sub FrameWidth_TextChanged(sender As Object, e As EventArgs) Handles FrameWidth.TextChanged

        If FrameWidth.Text = "" Then
            FrameWidth.Text = 0
        End If
        WidthOfWindowFrame = FrameWidth.Text

        If ComboBox1.Text = "Awning Window" Then
            WeightInKgFrame = AwningWindowFrame
        ElseIf ComboBox1.Text = "Casement Window" Then
            WeightInKgFrame = CasementWindowFrame
        ElseIf ComboBox1.Text = "Casement Door" Then
            WeightInKgFrame = CasementDoorFrame
        ElseIf ComboBox1.Text = "Sliding Window" Then
            WeightInKgFrame = SlidingWindowFrame
        ElseIf ComboBox1.Text = "Sliding Door" Then
            WeightInKgFrame = SlidingDoorFrame
        ElseIf ComboBox1.Text = "Louver Window" Then
            WeightInKgFrame = LouverWindowFrame
        ElseIf ComboBox1.Text = "Fix Window" Then
            WeightInKgFrame = FixWindowFrame
        End If

        Totalframeweightinkg = (((WidthOfWindowFrame * 2) + (HeightOfWindowFrame * 2)) / 1000) * WeightInKgFrame
        TotalFrameWeight.Text = Totalframeweightinkg

    End Sub

    Private Sub FrameHeight_TextChanged(sender As Object, e As EventArgs) Handles FrameHeight.TextChanged

        If FrameHeight.Text = "" Then
            FrameHeight.Text = 0
        End If
        HeightOfWindowFrame = FrameHeight.Text

        If ComboBox1.Text = "Awning Window" Then
            WeightInKgFrame = AwningWindowFrame
        ElseIf ComboBox1.Text = "Casement Window" Then
            WeightInKgFrame = CasementWindowFrame
        ElseIf ComboBox1.Text = "Casement Door" Then
            WeightInKgFrame = CasementDoorFrame
        ElseIf ComboBox1.Text = "Sliding Window" Then
            WeightInKgFrame = SlidingWindowFrame
        ElseIf ComboBox1.Text = "Sliding Door" Then
            WeightInKgFrame = SlidingDoorFrame
        ElseIf ComboBox1.Text = "Louver Window" Then
            WeightInKgFrame = LouverWindowFrame
        ElseIf ComboBox1.Text = "Fix Window" Then
            WeightInKgFrame = FixWindowFrame
        End If

        Totalframeweightinkg = (((WidthOfWindowFrame * 2) + (HeightOfWindowFrame * 2)) / 1000) * WeightInKgFrame
        TotalFrameWeight.Text = Totalframeweightinkg
    End Sub

    Private Sub SashWidth_TextChanged(sender As Object, e As EventArgs) Handles SashWidth.TextChanged

        If SashWidth.Text = "" Then
            SashWidth.Text = 0
        End If
        WidthOfWindowSash = SashWidth.Text

        If ComboBox1.Text = "Awning Window" Then
            WeightInKgSash = AwningWindowSash
        ElseIf ComboBox1.Text = "Casement Window" Then
            WeightInKgSash = CasementWindowSash
        ElseIf ComboBox1.Text = "Casement Door" Then
            WeightInKgSash = CasementDoorSash
        ElseIf ComboBox1.Text = "Sliding Window" Then
            WeightInKgSash = SlidingWindowSash
        ElseIf ComboBox1.Text = "Sliding Door" Then
            WeightInKgSash = SlidingDoorSash
        ElseIf ComboBox1.Text = "Louver Window" Then
            SashWidth.Text = 0
            SashHeight.Text = 0
            WeightInKgSash = 0
        End If

        totalsashweightinkg = (((WidthOfWindowSash * 2) + (HeightOfWindowSash * 2)) / 1000) * WeightInKgSash
        TotalSashWeight.Text = totalsashweightinkg


    End Sub

    Private Sub SashHeight_TextChanged(sender As Object, e As EventArgs) Handles SashHeight.TextChanged

        If SashHeight.Text = "" Then
            SashHeight.Text = 0
        End If
        HeightOfWindowSash = SashHeight.Text

        If ComboBox1.Text = "Awning Window" Then
            WeightInKgSash = AwningWindowSash
        ElseIf ComboBox1.Text = "Casement Window" Then
            WeightInKgSash = CasementWindowSash
        ElseIf ComboBox1.Text = "Casement Door" Then
            WeightInKgSash = CasementDoorSash
        ElseIf ComboBox1.Text = "Sliding Window" Then
            WeightInKgSash = SlidingWindowSash
        ElseIf ComboBox1.Text = "Sliding Door" Then
            WeightInKgSash = SlidingDoorSash
        ElseIf ComboBox1.Text = "Louver Window" Then
            SashWidth.Text = 0
            SashHeight.Text = 0
            WeightInKgSash = 0
        End If

        totalsashweightinkg = (((WidthOfWindowSash * 2) + (HeightOfWindowSash * 2)) / 1000) * WeightInKgSash
        TotalSashWeight.Text = totalsashweightinkg

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles SlidingWindowPanel.TextChanged
        If SlidingWindowPanel.Text = "" Then
            SlidingWindowPanel.Text = 0
        End If

        NoOfSlidingWindowPanel = SlidingWindowPanel.Text
        TotalSashWeight.Text = ((((WidthOfWindowSash * 2) + (HeightOfWindowSash * 2)) * NoOfSlidingWindowPanel) / 1000) * WeightInKgSash
    End Sub

    Private Sub SlidingDoorPanel_TextChanged(sender As Object, e As EventArgs) Handles SlidingDoorPanel.TextChanged
        If SlidingDoorPanel.Text = "" Then
            SlidingDoorPanel.Text = 0
        End If

        NoOfSlidingDoorPanel = SlidingDoorPanel.Text
        TotalSashWeight.Text = ((((WidthOfWindowSash * 2) + (HeightOfWindowSash * 2)) * NoOfSlidingDoorPanel) / 1000) * WeightInKgSash
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        WidthOfWindowFrame = FrameWidth.Text
        HeightOfWindowFrame = FrameHeight.Text
        WidthOfWindowSash = SashWidth.Text
        HeightOfWindowSash = SashHeight.Text

        If ComboBox1.Text = "Awning Window" Then
            WeightInKgSash = AwningWindowSash
        ElseIf ComboBox1.Text = "Casement Window" Then
            WeightInKgSash = CasementWindowSash
        ElseIf ComboBox1.Text = "Casement Door" Then
            WeightInKgSash = CasementDoorSash
        ElseIf ComboBox1.Text = "Sliding Window" Then
            WeightInKgSash = SlidingWindowSash
        ElseIf ComboBox1.Text = "Sliding Door" Then
            WeightInKgSash = SlidingDoorSash
        ElseIf ComboBox1.Text = "Louver Window" Then
            SashWidth.Text = 0
            SashHeight.Text = 0
            WeightInKgSash = 0
        End If
        TotalSashWeight.Text = ((((WidthOfWindowSash * 2) + (HeightOfWindowSash * 2)) * (NoOfSlidingWindowPanel + NoOfSlidingDoorPanel)) / 1000) * WeightInKgSash

        If ComboBox1.Text = "Awning Window" Then
            WeightInKgFrame = AwningWindowFrame
        ElseIf ComboBox1.Text = "Casement Window" Then
            WeightInKgFrame = CasementWindowFrame
        ElseIf ComboBox1.Text = "Casement Door" Then
            WeightInKgFrame = CasementDoorFrame
        ElseIf ComboBox1.Text = "Sliding Window" Then
            WeightInKgFrame = SlidingWindowFrame
        ElseIf ComboBox1.Text = "Sliding Door" Then
            WeightInKgFrame = SlidingDoorFrame
        ElseIf ComboBox1.Text = "Louver Window" Then
            WeightInKgFrame = LouverWindowFrame
        End If
        TotalFrameWeight.Text = (((WidthOfWindowFrame * 2) + (HeightOfWindowFrame * 2)) / 1000) * WeightInKgFrame
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles GlassWidthTbox.TextChanged
        If GlassWidthTbox.Text = "" Then
            GlassWidthTbox.Text = 0
        End If
        GlassWidth = GlassWidthTbox.Text
        TotalGlassWeightinkg = ((GlassWidth / 1000) * (GlassHeight / 1000)) * GlassThickness
        GlassWeightTbox.Text = TotalGlassWeightinkg

        glassperimeter = (2 * (GlassWidth + GlassHeight))
    End Sub

    Private Sub GlassHeightTbox_TextChanged(sender As Object, e As EventArgs) Handles GlassHeightTbox.TextChanged
        If GlassHeightTbox.Text = "" Then
            GlassHeightTbox.Text = 0
        End If
        GlassHeight = GlassHeightTbox.Text
        TotalGlassWeightinkg = ((GlassWidth / 1000) * (GlassHeight / 1000)) * GlassThickness
        GlassWeightTbox.Text = TotalGlassWeightinkg

        glassperimeter = (2 * (GlassWidth + GlassHeight))
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles GlassthicknesTbox.TextChanged
        If GlassthicknesTbox.Text = "" Then
            GlassthicknesTbox.Text = 0
        End If
        GlassThickness = GlassthicknesTbox.Text
        TotalGlassWeightinkg = ((GlassWidth / 1000) * (GlassHeight / 1000)) * GlassThickness
        GlassWeightTbox.Text = TotalGlassWeightinkg
    End Sub

    Private Sub SFixedWindowPanelTextChanged(sender As Object, e As EventArgs) Handles SFixedWindowPanel.TextChanged
        If SFixedWindowPanel.Text = "" Then
            SFixedWindowPanel.Text = 0
        End If
        NoOfSFixedPanel = SFixedWindowPanel.Text
    End Sub


    Private Sub OFixedWindowPanel_TextChanged(sender As Object, e As EventArgs) Handles OFixedWindowPanel.TextChanged
        If OFixedWindowPanel.Text = "" Then
            OFixedWindowPanel.Text = 0
        End If
        NoOfOFixedPanel = OFixedWindowPanel.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WithWeatherBar.SelectedIndexChanged
        If WithWeatherBar.Text.Contains("Yes") Then
            Numberofweatherbar = 1
        ElseIf WithWeatherBar.Text.Contains("No") Then
            Numberofweatherbar = 0
        Else
            Numberofweatherbar = 0
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles NumberofexpansionboltSF.TextChanged
        If NumberofexpansionboltSF.Text = "" Then
            NumberofexpansionboltSF.Text = 0
        End If
        numberofexpansionboltonsideframe = NumberofexpansionboltSF.Text
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles NumberofexpansionboltTF.TextChanged
        If NumberofexpansionboltTF.Text = "" Then
            NumberofexpansionboltTF.Text = 0
        End If
        numberofexpansionboltontopframe = NumberofexpansionboltTF.Text
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles NumberofexpansionboltBF.TextChanged
        If NumberofexpansionboltBF.Text = "" Then
            NumberofexpansionboltBF.Text = 0
        End If
        numberofexpansionboltonbottomframe = NumberofexpansionboltBF.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WhatFloorCbox.SelectedIndexChanged
        If WhatFloorCbox.Text = "" Then
            WhatFloorCbox.Text = 0
        End If

        If WhatFloorCbox.Text = 1 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = 60
                sashtransfertime = 60
                glasstransfertime = 60
            Else
                frametransfertime = 60
                sashtransfertime = 60
                glasstransfertime = 90
            End If
        ElseIf WhatFloorCbox.Text = 2 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = 180
                sashtransfertime = 180
                glasstransfertime = 180
            Else
                frametransfertime = 180
                sashtransfertime = 180
                glasstransfertime = 210
            End If
        ElseIf WhatFloorCbox.Text = 3 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = 300
                sashtransfertime = 300
                glasstransfertime = 300
            Else
                frametransfertime = 300
                sashtransfertime = 300
                glasstransfertime = 330
            End If
        ElseIf WhatFloorCbox.Text >= 4 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = WhatFloorCbox.Text * 180
                sashtransfertime = WhatFloorCbox.Text * 180
                glasstransfertime = WhatFloorCbox.Text * 180
            Else
                frametransfertime = WhatFloorCbox.Text * 180
                sashtransfertime = WhatFloorCbox.Text * 180
                glasstransfertime = WhatFloorCbox.Text * 210
            End If
        End If

    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles WhatFloorCbox.TextChanged
        If WhatFloorCbox.Text = "" Then
            WhatFloorCbox.Text = 0
        End If

        If WhatFloorCbox.Text = 1 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = 60
                sashtransfertime = 60
                glasstransfertime = 60
            Else
                frametransfertime = 60
                sashtransfertime = 60
                glasstransfertime = 90
            End If
        ElseIf WhatFloorCbox.Text = 2 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = 180
                sashtransfertime = 180
                glasstransfertime = 180
            Else
                frametransfertime = 180
                sashtransfertime = 180
                glasstransfertime = 210
            End If
        ElseIf WhatFloorCbox.Text = 3 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = 300
                sashtransfertime = 300
                glasstransfertime = 300
            Else
                frametransfertime = 300
                sashtransfertime = 300
                glasstransfertime = 330
            End If
        ElseIf WhatFloorCbox.Text >= 4 Then
            If ComboBox1.Text = "Louver Window" Then
                frametransfertime = WhatFloorCbox.Text * 180
                sashtransfertime = WhatFloorCbox.Text * 180
                glasstransfertime = WhatFloorCbox.Text * 180
            Else
                frametransfertime = WhatFloorCbox.Text * 180
                sashtransfertime = WhatFloorCbox.Text * 180
                glasstransfertime = WhatFloorCbox.Text * 210
            End If
        End If
    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles HeightfromFinishFloorLine.TextChanged
        If HeightfromFinishFloorLine.Text = "" Then
            HeightfromFinishFloorLine.Text = 0
        End If
        frameelevation = HeightfromFinishFloorLine.Text
        sashelevation = HeightfromFinishFloorLine.Text
        glasselevation = HeightfromFinishFloorLine.Text
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles NumberofFixHolesPerPanel.TextChanged
        If NumberofFixHolesPerPanel.Text = "" Then
            NumberofFixHolesPerPanel.Text = 0
        End If

        nooffixhole = NumberofFixHolesPerPanel.Text
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles NumberofCenterProfile.TextChanged
        If NumberofCenterProfile.Text = "" Then
            NumberofCenterProfile.Text = 0
        End If

        noofcenterprofile = NumberofCenterProfile.Text
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles NumberofSealingBlock.TextChanged
        If NumberofSealingBlock.Text = "" Then
            NumberofSealingBlock.Text = 0
        End If

        noofsealingblock = NumberofSealingBlock.Text
    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles NumberofInterlock.TextChanged
        If NumberofInterlock.Text = "" Then
            NumberofInterlock.Text = 0
        End If

        noofinterlock = NumberofInterlock.Text
    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles NumberofAntiliftDevice.TextChanged
        If NumberofAntiliftDevice.Text = "" Then
            NumberofAntiliftDevice.Text = 0
        End If
        noofantiliftdevice = NumberofAntiliftDevice.Text
    End Sub

    Private Sub TextBox40_TextChanged(sender As Object, e As EventArgs) Handles NumberofStriker.TextChanged
        If NumberofStriker.Text = "" Then
            NumberofStriker.Text = 0
        End If
        noofstriker = NumberofStriker.Text
    End Sub

    Private Sub TextBox43_TextChanged(sender As Object, e As EventArgs) Handles TextBox43.TextChanged
        If TextBox43.Text = "" Then
            TextBox43.Text = 0
        End If
        totalinstallationtime = TextBox43.Text
    End Sub

    Private Sub TextBox47_TextChanged(sender As Object, e As EventArgs) Handles Numberof9C54.TextChanged
        If Numberof9C54.Text = "" Then
            Numberof9C54.Text = 0
        End If
        noof9c54 = Numberof9C54.Text
    End Sub

    Private Sub CasementWindowPanel_TextChanged(sender As Object, e As EventArgs) Handles CasementWindowPanel.TextChanged
        If CasementWindowPanel.Text = "" Then
            CasementWindowPanel.Text = 0
        End If
        NoofCasementWindowPanel = CasementWindowPanel.Text
    End Sub

    Private Sub CasementDoorPanel_TextChanged(sender As Object, e As EventArgs) Handles CasementDoorPanel.TextChanged
        If CasementDoorPanel.Text = "" Then
            CasementDoorPanel.Text = 0
        End If
        NoofCasementDoorPanel = CasementDoorPanel.Text
    End Sub

    Private Sub TextBox49_TextChanged(sender As Object, e As EventArgs) Handles AwningWindowPanel.TextChanged
        If AwningWindowPanel.Text = "" Then
            AwningWindowPanel.Text = 0
        End If
        NoofAwningPanel = AwningWindowPanel.Text
    End Sub

    Private Sub TextBox50_TextChanged(sender As Object, e As EventArgs) Handles NumberofScrewstobeRemove.TextChanged
        If NumberofScrewstobeRemove.Text = "" Then
            NumberofScrewstobeRemove.Text = 0
        End If
        noofscrewstoberemove = NumberofScrewstobeRemove.Text
    End Sub

    Private Sub TextBox53_TextChanged(sender As Object, e As EventArgs) Handles Numberof0373.TextChanged
        If Numberof0373.Text = "" Then
            Numberof0373.Text = 0
        End If
        noof0373 = Numberof0373.Text
    End Sub

    Private Sub TextBox56_TextChanged(sender As Object, e As EventArgs) Handles NumberofNonFixBlade.TextChanged
        If NumberofNonFixBlade.Text = "" Then
            NumberofNonFixBlade.Text = 0
        End If
        noofnonfixblades = NumberofNonFixBlade.Text
    End Sub

    Private Sub TextBox57_TextChanged(sender As Object, e As EventArgs) Handles NumberofFixBlade.TextChanged
        If NumberofFixBlade.Text = "" Then
            NumberofFixBlade.Text = 0
        End If
        nooffixblades = NumberofFixBlade.Text
    End Sub

    Private Sub TextBox60_TextChanged(sender As Object, e As EventArgs) Handles NumberofBladeBatch.TextChanged
        If NumberofBladeBatch.Text = "" Then
            NumberofBladeBatch.Text = 0
        End If
        noofbatch = NumberofBladeBatch.Text
    End Sub

    Private Sub TextBox61_TextChanged(sender As Object, e As EventArgs) Handles LouverWindowPanel.TextChanged
        If LouverWindowPanel.Text = "" Then
            LouverWindowPanel.Text = 0
        End If
        nooflouverpanel = LouverWindowPanel.Text
    End Sub
End Class