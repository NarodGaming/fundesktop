Public Class Desktop
    Public StartOpen As Boolean = False
    Public ButtonOn As Integer = "6"

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetupTaskBar("File Browser")
    End Sub

    '' Button6 - Button14 works as the buttons the start menu - for example the web browser being open etc.

    Public Function SetupTaskBar(ByVal nameofwindow As String)
        If nameofwindow = "File Browser" Then
            If ButtonOn = "6" Then
                SendNum(6, nameofwindow)
            End If
            If ButtonOn = "7" Then
                SendNum(7, nameofwindow)
            End If
            If ButtonOn = "8" Then
                SendNum(8, nameofwindow)
            End If
            If ButtonOn = "9" Then
                SendNum(9, nameofwindow)
            End If
            If ButtonOn = "10" Then
                SendNum(10, nameofwindow)
            End If
            If ButtonOn = "11" Then
                SendNum(11, nameofwindow)
            End If
            If ButtonOn = "12" Then
                SendNum(12, nameofwindow)
            End If
            If ButtonOn = "13" Then
                SendNum(13, nameofwindow)
            End If
        End If
    End Function

    Public Function SetupClosing(ByVal nameofwindow As String)
        If nameofwindow = "File Browser" Then
            If nameofwindow = "File Browser" Then
                If ButtonOn = "7" Then
                    Button6.Visible = False
                End If
                If ButtonOn = "8" Then
                    Button7.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
                If ButtonOn = "9" Then
                    Button8.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
                If ButtonOn = "10" Then
                    Button9.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
                If ButtonOn = "11" Then
                    Button10.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
                If ButtonOn = "12" Then
                    Button11.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
                If ButtonOn = "13" Then
                    Button12.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
                If ButtonOn = "14" Then
                    Button13.Visible = False
                    ButtonOn = ButtonOn - 1
                End If
            End If
        End If
    End Function

    Public Function SendNum(ByVal numsend As Integer, ByVal nameofwindow As String)
        If numsend = "6" Then
            Button6.Text = nameofwindow
            Button6.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "7" Then
            Button7.Text = nameofwindow
            Button7.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "8" Then
            Button8.Text = nameofwindow
            Button8.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "9" Then
            Button9.Text = nameofwindow
            Button9.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "10" Then
            Button10.Text = nameofwindow
            Button10.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "11" Then
            Button11.Text = nameofwindow
            Button11.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "12" Then
            Button12.Text = nameofwindow
            Button12.Visible = True
            ButtonOn = ButtonOn + 1
        End If
        If numsend = "13" Then
            Button13.Text = nameofwindow
            Button13.Visible = True
            ButtonOn = ButtonOn + 1
        End If
    End Function
End Class
