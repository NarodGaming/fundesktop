Public Class FunkyBrowser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(TextBox1.Text)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub FunkyBrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Desktop.SetupClosing("Funky Browser")
    End Sub

    Private Sub FunkyBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        Try
            TextBox1.Text = WebBrowser1.Url.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class