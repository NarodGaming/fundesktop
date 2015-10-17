Public Class Desktop
    Public StartOpen As Boolean = False

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartOpen = False Then
            StartPanel.Visible = True
            StartPanel.Location = New Point(StartButton.Location.X, StartButton.Location.Y - StartPanel.Height + 5)
            StartOpen = True
        Else
            StartPanel.Visible = False
            StartOpen = False
        End If

    End Sub

    Private Sub StartPanel_Paint(sender As Object, e As PaintEventArgs) Handles StartPanel.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()



    End Sub
End Class
