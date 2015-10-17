Public Class FileBrowser
    Private Sub FileBrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Desktop.SetupClosing("File Browser")
    End Sub
End Class