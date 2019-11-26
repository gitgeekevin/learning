Class MainWindow 

    Private Sub MyButton_Click(sender As Object, e As RoutedEventArgs) Handles MyButton.Click
        Dim enteredValue As String = MyTextBox.Text
        enteredValue = "You typed: " + enteredValue
        MyLabel.Content = enteredValue
    End Sub
End Class
