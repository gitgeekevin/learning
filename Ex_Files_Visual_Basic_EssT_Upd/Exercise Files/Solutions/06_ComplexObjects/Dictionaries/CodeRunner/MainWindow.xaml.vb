Class MainWindow

    Dim states As Dictionary(Of String, String) _
        = New Dictionary(Of String, String)

    Sub Output(Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub

    Sub ClearOutput(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        txtOutput.Text = ""
    End Sub

    Sub btnAdd_Click(sender As Object, e As RoutedEventArgs) Handles btnAdd.Click

        states.Clear()

        states.Add("CA", "California")
        states.Add("OR", "Oregon")
        states.Add("WA", "Washington")

        OutputStates()

    End Sub

    Private Sub btnGet_Click(sender As Object, e As RoutedEventArgs) Handles btnGet.Click
        Dim stateID As String = txtInput.Text
        If states.ContainsKey(stateID) Then
            Output("You requested: " + states.Item(stateID))
        Else
            Output("Not found")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As RoutedEventArgs) Handles btnRemove.Click
        Dim stateID As String = txtInput.Text
        If states.ContainsKey(stateID) Then
            states.Remove(stateID)
            txtOutput.Text = ""
            Output(stateID + " removed; here's what's left:")
            OutputStates()
        Else
            Output("Not found")
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As RoutedEventArgs) Handles btnShow.Click
        OutputStates()
    End Sub

    Sub OutputStates()
        For Each state In states
            Output(state.ToString)
        Next
    End Sub

End Class
