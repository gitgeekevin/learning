Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim str1 = New String("Hello")
        Dim str2 = New String("Hello")

        If str1 Like "He[!abcl]lo" Then
            Output("match!")
        Else
            Output("no match!")
        End If
        
    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
