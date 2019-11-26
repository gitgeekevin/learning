Class MainWindow

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        txtOutput.Text = ""
    End Sub

    Sub btnAdd_Click(sender As Object, e As RoutedEventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnGet_Click(sender As Object, e As RoutedEventArgs) Handles btnGet.Click

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As RoutedEventArgs) Handles btnRemove.Click

    End Sub

    Private Sub btnShow_Click(sender As Object, e As RoutedEventArgs) Handles btnShow.Click
        OutputStates()
    End Sub

    Sub OutputStates()

    End Sub

End Class
