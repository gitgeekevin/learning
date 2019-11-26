Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim byte1 As Byte = 255
        Dim int1 As Integer = 55
        Dim dbl1 As Double = 55.5
        Dim str1 As String = txtInput.Text

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
