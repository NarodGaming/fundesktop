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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.StartPanel = New System.Windows.Forms.Panel()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StartPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartPanel
        '
        Me.StartPanel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StartPanel.Controls.Add(Me.Button3)
        Me.StartPanel.Controls.Add(Me.PictureBox1)
        Me.StartPanel.Controls.Add(Me.Label1)
        Me.StartPanel.Controls.Add(Me.Button5)
        Me.StartPanel.Controls.Add(Me.Button4)
        Me.StartPanel.Controls.Add(Me.Button2)
        Me.StartPanel.Controls.Add(Me.Button1)
        Me.StartPanel.Location = New System.Drawing.Point(0, 153)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(287, 485)
        Me.StartPanel.TabIndex = 0
        Me.StartPanel.Visible = False
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(0, 644)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(76, 41)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(199, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Shutdown"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 367)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "FunkyBrowser"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(199, 297)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 48)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "My Computer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(199, 214)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 51)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Documents"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(0, 642)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 42)
        Me.Panel1.TabIndex = 3
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
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.StartPanel.ResumeLayout(False)
        Me.StartPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartPanel As Panel
    Friend WithEvents StartButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
End Class
