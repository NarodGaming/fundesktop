Public Class Settings
    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Desktop.SetupClosing("Settings")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBox_userpass.Text = My.Settings.Password Then
            My.Settings.Username = txtBox_newuser.Text
            MsgBox("Changed the username!")
        Else
            MsgBox("Incorrect password.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtBox_oldpass.Text = My.Settings.Password Then
            If txtBox_newpass1.Text = txtBox_newpass2.Text Then
                My.Settings.Password = txtBox_newpass1.Text
            Else
                MsgBox("New passwords do not match!")
            End If
        Else
            MsgBox("Old password not correct!")
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Username.Text = ("Current Username: " & My.Settings.Username)
    End Sub
End Class