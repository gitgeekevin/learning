Class MainWindow

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim str1 As String = txtInput1.Text
        Dim str2 As String = txtInput2.Text
        Dim dbl1 As Double
        Dim dbl2 As Double

        txtOutput.Text = ""

        If IsNumeric(str1) And IsNumeric(str2) Then
            dbl1 = Double.Parse(str1)
            dbl2 = Double.Parse(str2)
        Else
            Output("Please enter valid numbers!")
            Return
        End If

        Dim operation As String = "None"
        If optAdd.IsChecked Then
            operation = "Add"
        ElseIf optSubtract.IsChecked Then
            operation = "Subtract"
        ElseIf optMultiply.IsChecked Then
            operation = "Multiply"
        ElseIf optDivide.IsChecked Then
            operation = "Divide"
        End If
        Output("Select operation: " + operation)

        Dim result As Double
        Select Case operation
            Case "Add"
                result = dbl1 + dbl2
            Case "Subtract"
                result = dbl1 - dbl2
            Case "Multiply"
                result = dbl1 * dbl2
            Case "Divide"
                result = dbl1 / dbl2
            Case Else
                Output("You didn't select an operation!")
                Return
        End Select
        Output("The result is " + result.ToString)

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
