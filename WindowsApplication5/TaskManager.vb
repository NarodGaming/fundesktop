Public Class TaskManager
    Private Sub TaskManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Desktop.SetupClosing("Task Manager")
    End Sub

    Private Sub TaskManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AboutFunDesktopOS.IsHandleCreated = True Then
            ListBox1.Items.Add("aboutfundesktop.prg")
        End If
        If FileBrowser.IsHandleCreated = True Then
            ListBox1.Items.Add("explorer_window.prg")
        End If
        If FunkyBrowser.IsHandleCreated = True Then
            ListBox1.Items.Add("funky_browser.prg")
        End If
        If Settings.IsHandleCreated = True Then
            ListBox1.Items.Add("explorer_settings.prg")
        End If
        ListBox1.Items.Add("explorer_desktop.prg")
    End Sub

    Private Sub updateList_Tick(sender As Object, e As EventArgs) Handles updateList.Tick
        ListBox1.Items.Clear()
        If AboutFunDesktopOS.IsHandleCreated = True Then
            ListBox1.Items.Add("aboutfundesktop.prg")
        End If
        If FileBrowser.IsHandleCreated = True Then
            ListBox1.Items.Add("explorer_window.prg")
        End If
        If FunkyBrowser.IsHandleCreated = True Then
            ListBox1.Items.Add("funky_browser.prg")
        End If
        If Settings.IsHandleCreated = True Then
            ListBox1.Items.Add("explorer_settings.prg")
        End If
        ListBox1.Items.Add("explorer_desktop.prg")
    End Sub

    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        If ListBox1.SelectedItem = "aboutfundesktop.prg" Then
            AboutFunDesktopOS.Close()
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        ElseIf ListBox1.SelectedItem = "explorer_window.prg"
            FileBrowser.Close()
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        ElseIf ListBox1.SelectedItem = "funky_browser.prg"
            FunkyBrowser.Close()
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        ElseIf ListBox1.SelectedItem = "explorer_settings.prg"
            Settings.Close()
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class