Class MainWindow

    Dim names As ArrayList = New ArrayList()

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        'Dim fruits() As String = {"Apple", "Orange", "Pear"}
        'Output("Number of fruits: " + fruits.Length.ToString)

        'Dim vegetables(2) As String
        'vegetables(0) = "Potato"
        'vegetables(1) = "Lettuce"
        'For veg As Integer = 0 To vegetables.Length - 1
        '    Dim vegName As String = vegetables(veg)
        '    Output(vegName)
        'Next

        Dim name As String = txtInput.Text
        names.Add(name)

        txtOutput.Text = ""
        For Each name In names
            Output(name)
        Next

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
