<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ViewSubmissionsBtn = New System.Windows.Forms.Button()
        Me.CreateNewSubmissionBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ViewSubmissionsBtn
        '
        Me.ViewSubmissionsBtn.BackColor = System.Drawing.Color.Gold
        Me.ViewSubmissionsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSubmissionsBtn.Location = New System.Drawing.Point(106, 43)
        Me.ViewSubmissionsBtn.Name = "ViewSubmissionsBtn"
        Me.ViewSubmissionsBtn.Size = New System.Drawing.Size(265, 34)
        Me.ViewSubmissionsBtn.TabIndex = 0
        Me.ViewSubmissionsBtn.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.ViewSubmissionsBtn.UseVisualStyleBackColor = False
        '
        'CreateNewSubmissionBtn
        '
        Me.CreateNewSubmissionBtn.BackColor = System.Drawing.Color.LightBlue
        Me.CreateNewSubmissionBtn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateNewSubmissionBtn.Location = New System.Drawing.Point(78, 83)
        Me.CreateNewSubmissionBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CreateNewSubmissionBtn.Name = "CreateNewSubmissionBtn"
        Me.CreateNewSubmissionBtn.Size = New System.Drawing.Size(315, 32)
        Me.CreateNewSubmissionBtn.TabIndex = 1
        Me.CreateNewSubmissionBtn.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.CreateNewSubmissionBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rohan Shah, Slidely Task 2 - Slidely Form App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 137)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CreateNewSubmissionBtn)
        Me.Controls.Add(Me.ViewSubmissionsBtn)
        Me.MaximumSize = New System.Drawing.Size(488, 176)
        Me.MinimumSize = New System.Drawing.Size(488, 176)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ViewSubmissionsBtn As Button
    Friend WithEvents CreateNewSubmissionBtn As Button
    Friend WithEvents Label1 As Label
End Class
