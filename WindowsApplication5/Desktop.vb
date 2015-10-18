Public Class Desktop
    Public StartOpen As Boolean = False
    Public ButtonOn As Integer = "6"

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartOpen = False Then
            StartPanel.Visible = True
            StartPanel.Location = New Point(StartButton.Location.X, StartButton.Location.Y - StartPanel.Height)
            StartOpen = True
        Else
            StartPanel.Visible = False
            StartOpen = False
        End If

    End Sub

    Private Sub StartPanel_Paint(sender As Object, e As PaintEventArgs) Handles StartPanel.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles shutdownButton.Click
        Application.Exit()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles FBrowser_btn.Click
        If FunkyBrowser.Visible = False Then
            SetupTaskBar("Funky Browser")
            FunkyBrowser.Show()
            StartPanel.Visible = False
            StartOpen = False
        Else
            FileBrowser.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles myComputer_btn.Click
        If FileBrowser.Visible = False Then
            SetupTaskBar("File Browser")
            FileBrowser.Show()
            StartPanel.Visible = False
            StartOpen = False
        Else
            FileBrowser.Focus()
        End If
    End Sub

    '' Button6 - Button14 works as the buttons the start menu - for example the web browser being open etc.

    Public Function SetupTaskBar(ByVal nameofwindow As String)
        If ButtonOn = "13" Then
            SendNum(13, nameofwindow)
        End If
        If ButtonOn = "12" Then
            SendNum(12, nameofwindow)
        End If
        If ButtonOn = "11" Then
            SendNum(11, nameofwindow)
        End If
        If ButtonOn = "10" Then
            SendNum(10, nameofwindow)
        End If
        If ButtonOn = "9" Then
            SendNum(9, nameofwindow)
        End If
        If ButtonOn = "8" Then
            SendNum(8, nameofwindow)
        End If
        If ButtonOn = "7" Then
            SendNum(7, nameofwindow)
        End If
        If ButtonOn = "6" Then
            SendNum(6, nameofwindow)
        End If
    End Function

    Public Function SetupClosing(ByVal nameofwindow As String)
        If Button6.Text = nameofwindow Then
            RollbackTaskbar(6)
        End If
        If Button7.Text = nameofwindow Then
            RollbackTaskbar(7)
        End If
        If Button8.Text = nameofwindow Then
            RollbackTaskbar(8)
        End If
        If Button9.Text = nameofwindow Then
            RollbackTaskbar(9)
        End If
        If Button10.Text = nameofwindow Then
            RollbackTaskbar(10)
        End If
        If Button11.Text = nameofwindow Then
            RollbackTaskbar(11)
        End If
        If Button12.Text = nameofwindow Then
            RollbackTaskbar(12)
        End If
        If Button13.Text = nameofwindow Then
            RollbackTaskbar(13)
        End If
        If Button14.Text = nameofwindow Then
            RollbackTaskbar(14)
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

    Public Function RollbackTaskbar(ByVal buttonrolledback As Integer)
        If buttonrolledback = 6 Then
            Button6.Visible = False
            ButtonOn = 6
        End If
        If buttonrolledback = 7 Then
            Button7.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 8 Then
            Button8.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 9 Then
            Button9.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 10 Then
            Button10.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 11 Then
            Button11.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 12 Then
            Button12.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 13 Then
            Button13.Visible = False
            ButtonOn = ButtonOn - 1
        End If
        If buttonrolledback = 14 Then
            Button14.Visible = False
            ButtonOn = ButtonOn - 1
        End If
    End Function

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DesktopBackground_Click(sender As Object, e As EventArgs) Handles DesktopBackground.Click
        If StartOpen = True Then
            StartPanel.Visible = False
            StartOpen = False
        End If
    End Sub

    Private Sub TimeTimer_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
        Time.Text = DateAndTime.Now.ToString
    End Sub

    Private Sub Panel1_Click(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.Click
        If e.Button = MouseButtons.Right Then
            TaskBarRightclick.Show(Me, New Point(Cursor.Position.X, Cursor.Position.Y))
        End If
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        If TaskManager.Visible = False Then
            SetupTaskBar("Task Manager")
            TaskManager.Show()
            StartPanel.Visible = False
            StartOpen = False
        Else
            TaskManager.Focus()
        End If
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        If AboutFunDesktopOS.Visible = False Then
            SetupTaskBar("About")
            AboutFunDesktopOS.Show()
            StartPanel.Visible = False
            StartOpen = False
        Else
            AboutFunDesktopOS.Focus()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FocusWindow(Button6.Text, 6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FocusWindow(Button7.Text, 7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        FocusWindow(Button8.Text, 8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FocusWindow(Button9.Text, 9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FocusWindow(Button10.Text, 10)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FocusWindow(Button11.Text, 11)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FocusWindow(Button12.Text, 12)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FocusWindow(Button13.Text, 13)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        FocusWindow(Button14.Text, 14)
    End Sub

    Public Function FocusWindow(ByVal ButtonText As String, ByVal Button As Integer)
        If ButtonText = "File Browser" Then
            If FileBrowser.WindowState = FormWindowState.Minimized Then
                FileBrowser.WindowState = FormWindowState.Normal
            Else
                FileBrowser.Focus()
            End If
        ElseIf ButtonText = "Funky Browser"
            If FunkyBrowser.WindowState = FormWindowState.Minimized Then
                FunkyBrowser.WindowState = FormWindowState.Normal
            Else
                FunkyBrowser.Focus()
            End If
        ElseIf ButtonText = "Task Manager"
            If TaskManager.WindowState = FormWindowState.Minimized Then
                TaskManager.WindowState = FormWindowState.Normal
            Else
                TaskManager.Focus()
            End If
        ElseIf ButtonText = "About"
            If AboutFunDesktopOS.WindowState = FormWindowState.Minimized Then
                AboutFunDesktopOS.WindowState = FormWindowState.Normal
            Else
                AboutFunDesktopOS.Focus()
            End If
        End If
    End Function
End Class
