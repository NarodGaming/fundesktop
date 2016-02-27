<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.txt_Username = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBox_userpass = New System.Windows.Forms.TextBox()
        Me.txtBox_newuser = New System.Windows.Forms.TextBox()
        Me.txtBox_oldpass = New System.Windows.Forms.TextBox()
        Me.txtBox_newpass1 = New System.Windows.Forms.TextBox()
        Me.txtBox_newpass2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Username
        '
        Me.txt_Username.AutoSize = True
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(12, 9)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(244, 25)
        Me.txt_Username.TabIndex = 0
        Me.txt_Username.Text = "Current Username: User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Old Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(419, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password Change"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "New Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Re-type new password:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FunDesktopOS.My.Resources.Resources.windows_xp_bliss_wide
        Me.PictureBox1.Location = New System.Drawing.Point(12, 390)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Current Wallpaper:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FunDesktopOS.My.Resources.Resources.alienware_ui___for_windows_7_by_mvgraphics
        Me.PictureBox2.Location = New System.Drawing.Point(520, 390)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 137)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(492, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Current Login Screen Wallpaper:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Change Username"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(494, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Change Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBox_userpass
        '
        Me.txtBox_userpass.Location = New System.Drawing.Point(103, 54)
        Me.txtBox_userpass.Name = "txtBox_userpass"
        Me.txtBox_userpass.Size = New System.Drawing.Size(162, 20)
        Me.txtBox_userpass.TabIndex = 13
        Me.txtBox_userpass.UseSystemPasswordChar = True
        '
        'txtBox_newuser
        '
        Me.txtBox_newuser.Location = New System.Drawing.Point(102, 79)
        Me.txtBox_newuser.Name = "txtBox_newuser"
        Me.txtBox_newuser.Size = New System.Drawing.Size(163, 20)
        Me.txtBox_newuser.TabIndex = 14
        '
        'txtBox_oldpass
        '
        Me.txtBox_oldpass.Location = New System.Drawing.Point(503, 57)
        Me.txtBox_oldpass.Name = "txtBox_oldpass"
        Me.txtBox_oldpass.Size = New System.Drawing.Size(150, 20)
        Me.txtBox_oldpass.TabIndex = 15
        Me.txtBox_oldpass.UseSystemPasswordChar = True
        '
        'txtBox_newpass1
        '
        Me.txtBox_newpass1.Location = New System.Drawing.Point(503, 79)
        Me.txtBox_newpass1.Name = "txtBox_newpass1"
        Me.txtBox_newpass1.Size = New System.Drawing.Size(150, 20)
        Me.txtBox_newpass1.TabIndex = 16
        Me.txtBox_newpass1.UseSystemPasswordChar = True
        '
        'txtBox_newpass2
        '
        Me.txtBox_newpass2.Location = New System.Drawing.Point(503, 102)
        Me.txtBox_newpass2.Name = "txtBox_newpass2"
        Me.txtBox_newpass2.Size = New System.Drawing.Size(150, 20)
        Me.txtBox_newpass2.TabIndex = 17
        Me.txtBox_newpass2.UseSystemPasswordChar = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 50)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Change"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Image Files|*.*"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(119, 366)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 539)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtBox_newpass2)
        Me.Controls.Add(Me.txtBox_newpass1)
        Me.Controls.Add(Me.txtBox_oldpass)
        Me.Controls.Add(Me.txtBox_newuser)
        Me.Controls.Add(Me.txtBox_userpass)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.Text = "Settings"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Username As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtBox_userpass As TextBox
    Friend WithEvents txtBox_newuser As TextBox
    Friend WithEvents txtBox_oldpass As TextBox
    Friend WithEvents txtBox_newpass1 As TextBox
    Friend WithEvents txtBox_newpass2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button5 As Button
End Class
