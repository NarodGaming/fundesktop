Public Class LoginScreen
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "fundesktop" Then
            Desktop.Show()
        Else
            MsgBox("incorrect password!")


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonShutdown.Click
        Application.Exit()


    End Sub
End Class