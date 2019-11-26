Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)

        '''''''''''''''''''''
        Output("For Loop")

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("While Loop")
        Dim whileCount As Integer = 1

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("Do Loop")
        Dim doCount As Integer = 1

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("Infinite do")
        doCount = 1

        Output(vbCrLf)

        '''''''''''''''''''''
        Output("For Each Loop")
        Dim numbers As Integer() = {1, 3, 5}

        Output(vbCrLf)
        
    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
