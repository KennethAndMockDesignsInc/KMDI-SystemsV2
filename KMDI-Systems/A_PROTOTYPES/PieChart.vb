Imports System.Windows.Forms.DataVisualization.Charting

Public Class PieChart
    Dim series1 As Series
    Dim areas1 As ChartArea
    Private Sub PieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Chart1
            .Legends.Clear()
            .Series.Clear()
            .ChartAreas.Clear()
        End With

        areas1 = Chart1.ChartAreas.Add("Areas1")
        With areas1
            .AxisX.Title = "Item no."
            .AxisY.Title = "Time in hours"
        End With
        'series1 = Chart1.Series.Add("Screen")

        Dim legends1 As Legend = Chart1.Legends.Add("Legends1")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'For Each series In Chart1.Series
            '    Console.WriteLine(series.Name)
            '    If series.Name <> TextBox3.Text Then
            With Chart1.Series(TextBox3.Text)
                .LabelFormat = "{#.##}"
                .IsValueShownAsLabel = True
                .ChartArea = areas1.Name
                .ChartType = SeriesChartType.Column
                .YValueType = ChartValueType.Double
                .AxisLabel = ""
                '.XValueType = ChartValueType.Double
                .Points.AddXY(TextBox1.Text, TextBox2.Text)
            End With
            '    End If
            'Next
            'If series1.Name.Contains(TextBox3.Text) = False Then
            '    series1 = Chart1.Series.Add(TextBox3.Text)
            '    With Chart1.Series(TextBox3.Text)
            '        .LabelFormat = "{#.##}"
            '        .IsValueShownAsLabel = True
            '        .ChartArea = areas1.Name
            '        .ChartType = SeriesChartType.Column
            '        .YValueType = ChartValueType.Double
            '        .AxisLabel = ""
            '        '.XValueType = ChartValueType.Double
            '        .Points.AddXY(TextBox1.Text, TextBox2.Text)
            '    End With
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'With series1
        '    .LabelFormat = "{#.##}"
        '    .IsValueShownAsLabel = True
        '    .ChartArea = areas1.Name
        '    .ChartType = SeriesChartType.Column
        '    .YValueType = ChartValueType.Double
        '    '.XValueType = ChartValueType.Double
        '    .Points.AddXY(TextBox1.Text, TextBox2.Text)
        'End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Chart1
            .Legends.Clear()
            .Series.Clear()
            .ChartAreas.Clear()
        End With

        areas1 = Chart1.ChartAreas.Add("Areas1")

        With areas1

        End With

        series1 = Chart1.Series.Add("Items")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Chart1.Series.IsUniqueName(TextBox3.Text) Then
                series1 = Chart1.Series.Add(TextBox3.Text)
            End If
            'For Each s In Chart1.Series
            '    Console.WriteLine(s.Name)
            '    If s.Name <> TextBox3.Text Then
            '        series1 = Chart1.Series.Add(TextBox3.Text)
            '    End If
            'Next
            'If Chart1.Series.Contains(TextBox3.Text) = False Then
            '    Console.WriteLine("Exists")
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            For Each s In Chart1.Series
                Console.WriteLine(s.Name)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class