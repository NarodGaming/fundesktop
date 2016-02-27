Public Class LoginScreen
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        txt_Username.Text = My.Settings.Username


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Password Then
            Desktop.Show()
        Else
            MsgBox("incorrect password!")


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonShutdown.Click
        Application.Exit()


    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = e.KeyCode.Enter Then
            e.SuppressKeyPress = True
            If TextBox1.Text = My.Settings.Password Then
                Desktop.Show()
            Else
                MsgBox("incorrect password!")


            End If
        End If
    End Sub
End Class