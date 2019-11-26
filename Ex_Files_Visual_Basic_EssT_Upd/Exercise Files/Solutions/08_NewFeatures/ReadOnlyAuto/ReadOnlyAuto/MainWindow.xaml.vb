Class MainWindow

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim p As Person = New Person("Alexander",
                        "Hamilton", "New York")

        Dim greeting As String =
            $"My name is {p.FullName}!"
        Output(greeting)

        Dim multiLine = $"Contact info:
{p.FullName}
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
