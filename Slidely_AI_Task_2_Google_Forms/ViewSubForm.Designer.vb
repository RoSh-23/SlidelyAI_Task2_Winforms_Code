<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrevBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.SWatchLabel = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.nameTxtBox = New System.Windows.Forms.TextBox()
        Me.emailTxtBox = New System.Windows.Forms.TextBox()
        Me.phoneNumTxtBox = New System.Windows.Forms.TextBox()
        Me.gHubLinkTxtBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rohan Shah, Slidely Task 2- View Submissions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Num"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 40)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Github Link " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 40)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Stopwatch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     time"
        '
        'PrevBtn
        '
        Me.PrevBtn.BackColor = System.Drawing.Color.Gold
        Me.PrevBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevBtn.Location = New System.Drawing.Point(69, 246)
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(191, 33)
        Me.PrevBtn.TabIndex = 9
        Me.PrevBtn.Text = "PREVIOUS (CTRL + P)"
        Me.PrevBtn.UseVisualStyleBackColor = False
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.Color.LightBlue
        Me.NextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.Location = New System.Drawing.Point(295, 246)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(149, 33)
        Me.NextBtn.TabIndex = 10
        Me.NextBtn.Text = "NEXT (CTRL + N)"
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'SWatchLabel
        '
        Me.SWatchLabel.AutoSize = True
        Me.SWatchLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SWatchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SWatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SWatchLabel.Location = New System.Drawing.Point(177, 198)
        Me.SWatchLabel.MinimumSize = New System.Drawing.Size(239, 2)
        Me.SWatchLabel.Name = "SWatchLabel"
        Me.SWatchLabel.Size = New System.Drawing.Size(239, 18)
        Me.SWatchLabel.TabIndex = 15
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Red
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Snow
        Me.DeleteBtn.Location = New System.Drawing.Point(69, 294)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(191, 36)
        Me.DeleteBtn.TabIndex = 16
        Me.DeleteBtn.Text = "DELETE (CTRL+ D)"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.LightGreen
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Location = New System.Drawing.Point(295, 294)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(149, 36)
        Me.EditBtn.TabIndex = 17
        Me.EditBtn.Text = "EDIT (CTRL + E)"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'nameTxtBox
        '
        Me.nameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameTxtBox.Location = New System.Drawing.Point(177, 58)
        Me.nameTxtBox.Name = "nameTxtBox"
        Me.nameTxtBox.Size = New System.Drawing.Size(239, 20)
        Me.nameTxtBox.TabIndex = 18
        '
        'emailTxtBox
        '
        Me.emailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailTxtBox.Location = New System.Drawing.Point(177, 89)
        Me.emailTxtBox.Name = "emailTxtBox"
        Me.emailTxtBox.Size = New System.Drawing.Size(239, 20)
        Me.emailTxtBox.TabIndex = 19
        '
        'phoneNumTxtBox
        '
        Me.phoneNumTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneNumTxtBox.Location = New System.Drawing.Point(177, 120)
        Me.phoneNumTxtBox.Name = "phoneNumTxtBox"
        Me.phoneNumTxtBox.Size = New System.Drawing.Size(239, 20)
        Me.phoneNumTxtBox.TabIndex = 20
        '
        'gHubLinkTxtBox
        '
        Me.gHubLinkTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gHubLinkTxtBox.Location = New System.Drawing.Point(178, 157)
        Me.gHubLinkTxtBox.Name = "gHubLinkTxtBox"
        Me.gHubLinkTxtBox.Size = New System.Drawing.Size(239, 20)
        Me.gHubLinkTxtBox.TabIndex = 21
        '
        'ViewSubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 342)
        Me.Controls.Add(Me.gHubLinkTxtBox)
        Me.Controls.Add(Me.phoneNumTxtBox)
        Me.Controls.Add(Me.emailTxtBox)
        Me.Controls.Add(Me.nameTxtBox)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SWatchLabel)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.PrevBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewSubForm"
        Me.Text = "Rohan Shah, Slidely Task 2- View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PrevBtn As Button
    Friend WithEvents NextBtn As Button
    Friend WithEvents SWatchLabel As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents nameTxtBox As TextBox
    Friend WithEvents emailTxtBox As TextBox
    Friend WithEvents phoneNumTxtBox As TextBox
    Friend WithEvents gHubLinkTxtBox As TextBox
End Class
