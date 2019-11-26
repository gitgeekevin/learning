Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim intValue As Integer = 55
        Output(intValue)

        Dim shortValue As Short = 5
        Output(shortValue)

        Dim byteValue As Byte = 255
        Output(byteValue)

        Try
            byteValue += 1
            Output(byteValue)
        Catch ex As Exception
            Output(ex.Message)
        End Try


    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
