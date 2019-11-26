Class MainWindow 

    Sub RunCode(sender As Object, e As RoutedEventArgs)
        'Add code here

        Dim str1 As String = txtInput1.Text
        Dim str2 As String = txtInput2.Text
        Dim evalNumbers As Boolean = chkNumeric.IsChecked

        If str1 = str2 Then
            Output("Strings match!")
        ElseIf str1 > str2 Then
            Output("String 1 is greater than string 2")
        Else
            Output("String 2  is greater than string 1")
        End If

        If evalNumbers Then
            If IsNumeric(str1) And IsNumeric(str2) Then
                Dim dbl1 As Double = Double.Parse(str1)
                Dim dbl2 As Double = Double.Parse(str2)

                If dbl1 = dbl2 Then
                    Output("Numbers match!")
                ElseIf dbl1 > dbl2 Then
                    Output("Value 1 is greater than value 2")
                Else
                    Output("Value 2 is greater than value 1")
                End If

            Else
                Output("Strings can't be converted to numbers")
            End If
        End If
        
    End Sub

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs)
        txtOutput.Text = ""
    End Sub

End Class
