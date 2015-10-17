Public Class TaskManager
    Private Sub TaskManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Desktop.SetupClosing("Task Manager")
    End Sub
End Class