<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.StartPanel = New System.Windows.Forms.Panel()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.ShutdownArrow = New System.Windows.Forms.Button()
        Me.FBrowser_btn = New System.Windows.Forms.Button()
        Me.userPhoto = New System.Windows.Forms.PictureBox()
        Me.userName = New System.Windows.Forms.Label()
        Me.myDocuments_btn = New System.Windows.Forms.Button()
        Me.myComputer_btn = New System.Windows.Forms.Button()
        Me.shutdownButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Time = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TaskBarRightclick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TaskBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopBackground = New System.Windows.Forms.PictureBox()
        Me.StartPanel.SuspendLayout()
        CType(Me.userPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TaskBarRightclick.SuspendLayout()
        CType(Me.DesktopBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartPanel
        '
        Me.StartPanel.BackColor = System.Drawing.Color.Silver
        Me.StartPanel.Controls.Add(Me.aboutButton)
        Me.StartPanel.Controls.Add(Me.ShutdownArrow)
        Me.StartPanel.Controls.Add(Me.FBrowser_btn)
        Me.StartPanel.Controls.Add(Me.userPhoto)
        Me.StartPanel.Controls.Add(Me.userName)
        Me.StartPanel.Controls.Add(Me.myDocuments_btn)
        Me.StartPanel.Controls.Add(Me.myComputer_btn)
        Me.StartPanel.Controls.Add(Me.shutdownButton)
        Me.StartPanel.Controls.Add(Me.Button1)
        Me.StartPanel.Location = New System.Drawing.Point(0, 153)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(287, 485)
        Me.StartPanel.TabIndex = 0
        Me.StartPanel.Visible = False
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(3, 455)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(127, 25)
        Me.aboutButton.TabIndex = 7
        Me.aboutButton.Text = "About FunDesktopOS"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'ShutdownArrow
        '
        Me.ShutdownArrow.Location = New System.Drawing.Point(258, 445)
        Me.ShutdownArrow.Name = "ShutdownArrow"
        Me.ShutdownArrow.Size = New System.Drawing.Size(29, 35)
        Me.ShutdownArrow.TabIndex = 6
        Me.ShutdownArrow.Text = ">"
        Me.ShutdownArrow.UseVisualStyleBackColor = True
        '
        'FBrowser_btn
        '
        Me.FBrowser_btn.Location = New System.Drawing.Point(3, 3)
        Me.FBrowser_btn.Name = "FBrowser_btn"
        Me.FBrowser_btn.Size = New System.Drawing.Size(189, 36)
        Me.FBrowser_btn.TabIndex = 2
        Me.FBrowser_btn.Text = "Funky Browser"
        Me.FBrowser_btn.UseVisualStyleBackColor = True
        '
        'userPhoto
        '
        Me.userPhoto.Image = Global.FunDesktopOS.My.Resources.Resources.guestIcon
        Me.userPhoto.Location = New System.Drawing.Point(197, 3)
        Me.userPhoto.Name = "userPhoto"
        Me.userPhoto.Size = New System.Drawing.Size(87, 93)
        Me.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userPhoto.TabIndex = 5
        Me.userPhoto.TabStop = False
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Location = New System.Drawing.Point(227, 99)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(29, 13)
        Me.userName.TabIndex = 4
        Me.userName.Text = "User"
        '
        'myDocuments_btn
        '
        Me.myDocuments_btn.Location = New System.Drawing.Point(197, 128)
        Me.myDocuments_btn.Name = "myDocuments_btn"
        Me.myDocuments_btn.Size = New System.Drawing.Size(85, 40)
        Me.myDocuments_btn.TabIndex = 3
        Me.myDocuments_btn.Text = "Documents"
        Me.myDocuments_btn.UseVisualStyleBackColor = True
        '
        'myComputer_btn
        '
        Me.myComputer_btn.Location = New System.Drawing.Point(197, 185)
        Me.myComputer_btn.Name = "myComputer_btn"
        Me.myComputer_btn.Size = New System.Drawing.Size(87, 48)
        Me.myComputer_btn.TabIndex = 2
        Me.myComputer_btn.Text = "My Computer"
        Me.myComputer_btn.UseVisualStyleBackColor = True
        '
        'shutdownButton
        '
        Me.shutdownButton.Location = New System.Drawing.Point(136, 444)
        Me.shutdownButton.Name = "shutdownButton"
        Me.shutdownButton.Size = New System.Drawing.Size(129, 37)
        Me.shutdownButton.TabIndex = 1
        Me.shutdownButton.Text = "Shutdown"
        Me.shutdownButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Location = New System.Drawing.Point(0, 642)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(104, 39)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.Time)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Location = New System.Drawing.Point(97, 642)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 42)
        Me.Panel1.TabIndex = 3
        '
        'Time
        '
        Me.Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(923, 8)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(244, 24)
        Me.Time.TabIndex = 12
        Me.Time.Text = "DD/MM/YYYY HH:MM:SS"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(803, 0)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(90, 39)
        Me.Button14.TabIndex = 11
        Me.Button14.Text = "Button14"
        Me.Button14.UseVisualStyleBackColor = True
        Me.Button14.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(39, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 39)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(707, 0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(90, 39)
        Me.Button13.TabIndex = 10
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        Me.Button13.Visible = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(133, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 39)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(611, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(90, 39)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        Me.Button12.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(229, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 39)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(419, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(90, 39)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(515, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(90, 39)
        Me.Button11.TabIndex = 8
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(323, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(90, 39)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'TimeTimer
        '
        Me.TimeTimer.Enabled = True
        '
        'TaskBarRightclick
        '
        Me.TaskBarRightclick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaskManagerToolStripMenuItem, Me.ToolStripSeparator1, Me.TaskBarToolStripMenuItem, Me.PropertiesToolStripMenuItem})
        Me.TaskBarRightclick.Name = "TaskBarRightclick"
        Me.TaskBarRightclick.Size = New System.Drawing.Size(163, 76)
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'TaskBarToolStripMenuItem
        '
        Me.TaskBarToolStripMenuItem.Checked = True
        Me.TaskBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TaskBarToolStripMenuItem.Name = "TaskBarToolStripMenuItem"
        Me.TaskBarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TaskBarToolStripMenuItem.Text = "Lock the Taskbar"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'DesktopBackground
        '
        Me.DesktopBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DesktopBackground.Image = CType(resources.GetObject("DesktopBackground.Image"), System.Drawing.Image)
        Me.DesktopBackground.Location = New System.Drawing.Point(0, 1)
        Me.DesktopBackground.Name = "DesktopBackground"
        Me.DesktopBackground.Size = New System.Drawing.Size(1264, 646)
        Me.DesktopBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DesktopBackground.TabIndex = 4
        Me.DesktopBackground.TabStop = False
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.StartPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DesktopBackground)
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.StartPanel.ResumeLayout(False)
        Me.StartPanel.PerformLayout()
        CType(Me.userPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TaskBarRightclick.ResumeLayout(False)
        CType(Me.DesktopBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartPanel As Panel
    Friend WithEvents StartButton As Button
    Friend WithEvents shutdownButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents userPhoto As PictureBox
    Friend WithEvents userName As Label
    Friend WithEvents myDocuments_btn As Button
    Friend WithEvents myComputer_btn As Button
    Friend WithEvents FBrowser_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ShutdownArrow As Button
    Friend WithEvents DesktopBackground As PictureBox
    Friend WithEvents Time As Label
    Friend WithEvents TimeTimer As Timer
    Friend WithEvents TaskBarRightclick As ContextMenuStrip
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TaskBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutButton As Button
End Class
