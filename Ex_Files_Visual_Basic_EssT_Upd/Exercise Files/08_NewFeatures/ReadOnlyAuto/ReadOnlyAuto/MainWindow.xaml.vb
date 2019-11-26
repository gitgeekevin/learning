Class MainWindow

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim p As Person = New Person()
        p.FirstName = "Alexander"
        p.LastName = "Hamilton"
        p.City = "New York"

        Dim greeting As String =
            $"My name is {p.FirstName} {p.LastName}!"
        Output(greeting)

        Dim multiLine = $"Contact info:
{p.FirstName} {p.LastName}
{p.City}"

        Output(multiLine)

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
