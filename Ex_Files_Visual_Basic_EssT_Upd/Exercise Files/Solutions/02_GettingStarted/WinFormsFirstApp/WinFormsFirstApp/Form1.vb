Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredValue As String = TextBox1.Text
        enteredValue = "You typed: " + enteredValue
        Label1.Text = enteredValue
    End Sub
End Class
