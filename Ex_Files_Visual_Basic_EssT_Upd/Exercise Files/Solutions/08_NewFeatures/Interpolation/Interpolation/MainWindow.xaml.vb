Class MainWindow

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim p As Person = New Person()
        p.FirstName = "Alexander"
        p.LastName = "Hamilton"

        'Dim greeting = "My name is " +
        '    p.FirstName + " " + p.LastName + "."

        'Dim greeting =
        '    String.Format("My name is {0} {1}.",
        '                  p.FirstName, p.LastName)

        'Dim greeting =

        Output($"My name is {p.FirstName} {p.LastName}.")

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
