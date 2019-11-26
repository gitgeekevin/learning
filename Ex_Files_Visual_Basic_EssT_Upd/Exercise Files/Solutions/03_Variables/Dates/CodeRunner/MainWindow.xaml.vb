Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim d1 As Date = New Date(2012, 1, 13)
        Output(d1)

        Dim d2 As Date = #11/28/1974#
        Output(d2)

        Dim d3 As Date = Date.Parse("11/28/13")
        Output(d3)

        Dim dt1 As Date = Date.Parse("November 28, 2013 11:10am")
        Output(dt1)

        Dim strDate1 As String = Format(dt1, "MMM dd, yyyy")
        Output(strDate1)

        Output(Format(Date.Today, "MMM dd"))

        Output("Original Date: " + d1.ToString)
        d1 = d1.AddDays(1)
        d1 = d1.AddMonths(1)
        Output("New Date: " + d1.ToString)

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
