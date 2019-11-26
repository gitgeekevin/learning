Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)

        '''''''''''''''''''''
        Output("For Loop")
        For forCount As Integer = 1 To 3
            Output("For value is " + forCount.ToString)
        Next
        Output(vbCrLf)

        '''''''''''''''''''''
        Output("While Loop")
        Dim whileCount As Integer = 1
        While whileCount <= 3
            Output("While count is " + whileCount.ToString)
            whileCount = whileCount + 1
        End While
        Output(vbCrLf)

        '''''''''''''''''''''
        Output("Do Loop")
        Dim doCount As Integer = 1
        Do
            Output("Do count is " + doCount.ToString)
            doCount = doCount + 1
        Loop Until doCount > 3
        Output(vbCrLf)

        '''''''''''''''''''''
        Output("Infinite do")
        doCount = 1
        Do
            Output("Do count is " + doCount.ToString)
            doCount = doCount + 1
            If doCount > 3 Then
                Exit Do
            End If
        Loop
        Output(vbCrLf)

        '''''''''''''''''''''
        Output("For Each Loop")
        Dim numbers As Integer() = {1, 3, 5, 7}
        For Each i As Integer In numbers
            Output("For each value is " + i.ToString)
        Next
        Output(vbCrLf)

    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
