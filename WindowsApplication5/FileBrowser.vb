Public Class FileBrowser
    Private Sub FileBrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Desktop.SetupClosing("File Browser")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
