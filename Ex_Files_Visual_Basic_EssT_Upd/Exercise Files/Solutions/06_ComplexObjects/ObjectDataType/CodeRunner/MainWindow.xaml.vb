Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim o As Object = New Object()
        If IsNothing(o) Then
            Output("No object exists")
        Else
            Output("before assignment to value: " + o.GetType.ToString)
        End If

        o = 1
        Output("as number: " + o.GetType.ToString)

        o = "David"
        Output("as string: " + o.GetType.ToString)

        Dim src As Integer = 1001
        Dim target As Object = src
        Output("Target value: " + target.ToString)

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
