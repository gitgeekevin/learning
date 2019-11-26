Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim hello As String = "Hello from Visual Basic"
        Output(hello)

        Dim howdy As String = New String("Howdy")
        Output(howdy)

        Dim words As Array = hello.Split()
        For Each word As String In words
            Output(word)
        Next

        Dim letters As Char() = howdy.ToCharArray()
        For Each letter As Char In letters
            Output(letter)
        Next

        Dim numeric As Decimal = 45000
        Dim strNumeric As String = Format(numeric, "0,000")
        Output(strNumeric)

        Dim strCurrency As String = FormatCurrency(numeric)
        Output(strCurrency)

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
