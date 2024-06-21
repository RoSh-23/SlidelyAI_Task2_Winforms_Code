<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTxtBox = New System.Windows.Forms.TextBox()
        Me.emailTxtBox = New System.Windows.Forms.TextBox()
        Me.phoneNumTxtBox = New System.Windows.Forms.TextBox()
        Me.gHubLinkTxtBox = New System.Windows.Forms.TextBox()
        Me.ToggleSWBtn = New System.Windows.Forms.Button()
        Me.StopwatchLabel = New System.Windows.Forms.Label()
        Me.StopwatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rohan Shah, Slidely Task 2 - Create Submission"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 40)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Github Link " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Phone Num"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'nameTxtBox
        '
        Me.nameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameTxtBox.Location = New System.Drawing.Point(217, 69)
        Me.nameTxtBox.Name = "nameTxtBox"
        Me.nameTxtBox.Size = New System.Drawing.Size(236, 20)
        Me.nameTxtBox.TabIndex = 12
        '
        'emailTxtBox
        '
        Me.emailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailTxtBox.Location = New System.Drawing.Point(217, 100)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(236, 20)
        Me.emailTxtBox.TabIndex = 13
        '
        'phoneNumTxtBox
        '
        Me.phoneNumTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneNumTxtBox.Location = New System.Drawing.Point(217, 132)
        Me.phoneNumTxtBox.Name = "phoneNumTxtBox"
        Me.phoneNumTxtBox.Size = New System.Drawing.Size(236, 20)
        Me.phoneNumTxtBox.TabIndex = 14
        '
        'gHubLinkTxtBox
        '
        Me.gHubLinkTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gHubLinkTxtBox.Location = New System.Drawing.Point(217, 173)
        Me.gHubLinkTxtBox.Name = "gHubLinkTxtBox"
        Me.gHubLinkTxtBox.Size = New System.Drawing.Size(236, 20)
        Me.gHubLinkTxtBox.TabIndex = 15
        '
        'ToggleSWBtn
        '
        Me.ToggleSWBtn.BackColor = System.Drawing.Color.Gold
        Me.ToggleSWBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleSWBtn.Location = New System.Drawing.Point(29, 222)
        Me.ToggleSWBtn.Name = "ToggleSWBtn"
        Me.ToggleSWBtn.Size = New System.Drawing.Size(275, 29)
        Me.ToggleSWBtn.TabIndex = 16
        Me.ToggleSWBtn.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.ToggleSWBtn.UseVisualStyleBackColor = False
        '
        'StopwatchLabel
        '
        Me.StopwatchLabel.AutoSize = True
        Me.StopwatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopwatchLabel.Location = New System.Drawing.Point(351, 226)
        Me.StopwatchLabel.Name = "StopwatchLabel"
        Me.StopwatchLabel.Size = New System.Drawing.Size(71, 20)
        Me.StopwatchLabel.TabIndex = 18
        Me.StopwatchLabel.Text = "00:00:00"
        '
        'StopwatchTimer
        '
        Me.StopwatchTimer.Interval = 1000
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackColor = System.Drawing.Color.LightBlue
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.Location = New System.Drawing.Point(160, 267)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(174, 32)
        Me.SubmitBtn.TabIndex = 19
        Me.SubmitBtn.Text = "SUBMIT (CTRL + S)"
        Me.SubmitBtn.UseVisualStyleBackColor = False
        '
        'CreateSubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 324)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.StopwatchLabel)
        Me.Controls.Add(Me.ToggleSWBtn)
        Me.Controls.Add(Me.gHubLinkTxtBox)
        Me.Controls.Add(Me.phoneNumTxtBox)
        Me.Controls.Add(Me.emailTxtBox)
        Me.Controls.Add(Me.nameTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(507, 363)
        Me.MinimumSize = New System.Drawing.Size(507, 39)
        Me.Name = "CreateSubForm"
        Me.Text = "CreateSubForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameTxtBox As TextBox
    Friend WithEvents emailTxtBox As TextBox
    Friend WithEvents phoneNumTxtBox As TextBox
    Friend WithEvents gHubLinkTxtBox As TextBox
    Friend WithEvents ToggleSWBtn As Button
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents StopwatchTimer As Timer
    Friend WithEvents SubmitBtn As Button
End Class
