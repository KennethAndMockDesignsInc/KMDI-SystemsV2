Public Class SecsToHours
    Dim hrs As Integer
    Dim mins As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''Dim iSpan As TimeSpan = TimeSpan.FromSeconds(secs_tbox.Text)
        ''hrs_tbox.Text = iSpan.Hours.ToString.PadLeft(2, "0"c)
        ''mins_tbox.Text = iSpan.Minutes.ToString.PadLeft(2, "0"c)
        'hrs = secs_tbox.Text / 3600
        'hrs_tbox.Text = hrs
        'mins = (secs_tbox.Text Mod 3600) / 60
        'mins_tbox.Text = mins

        hrs = Decimal.Floor(secs_tbox.Text / 3600)
        mins = Decimal.Floor((secs_tbox.Text - (Decimal.Floor(secs_tbox.Text / 3600) * 3600)) / 60)

        hrs_tbox.Text = secs_tbox.Text / 3600
        mins_tbox.Text = mins
        TextBox1.Text = (Decimal.Floor(secs_tbox.Text / 3600) * 3600)
        TextBox2.Text = Decimal.Floor(secs_tbox.Text / 3600)
    End Sub

End Class