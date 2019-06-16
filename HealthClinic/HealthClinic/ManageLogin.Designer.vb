<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Psw = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdateP = New System.Windows.Forms.Button()
        Me.UCP = New System.Windows.Forms.TextBox()
        Me.UNP = New System.Windows.Forms.TextBox()
        Me.UOP = New System.Windows.Forms.TextBox()
        Me.AddSwitch = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CreateAccount = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EditP = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ACP = New System.Windows.Forms.TextBox()
        Me.AUsername = New System.Windows.Forms.TextBox()
        Me.AP = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Psw)
        Me.Panel1.Controls.Add(Me.UserName)
        Me.Panel1.Location = New System.Drawing.Point(153, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 121)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "User Name:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Psw
        '
        Me.Psw.Location = New System.Drawing.Point(21, 68)
        Me.Psw.Name = "Psw"
        Me.Psw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Psw.Size = New System.Drawing.Size(200, 20)
        Me.Psw.TabIndex = 3
        Me.Psw.Text = "         "
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(18, 31)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(203, 20)
        Me.UserName.TabIndex = 2
        Me.UserName.Text = "User Name"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(15, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(756, 376)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.UpdateP)
        Me.Panel3.Controls.Add(Me.UCP)
        Me.Panel3.Controls.Add(Me.UNP)
        Me.Panel3.Controls.Add(Me.UOP)
        Me.Panel3.Controls.Add(Me.AddSwitch)
        Me.Panel3.Location = New System.Drawing.Point(15, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(666, 371)
        Me.Panel3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Confirm New Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Old Password:"
        '
        'UpdateP
        '
        Me.UpdateP.Location = New System.Drawing.Point(348, 183)
        Me.UpdateP.Name = "UpdateP"
        Me.UpdateP.Size = New System.Drawing.Size(75, 23)
        Me.UpdateP.TabIndex = 4
        Me.UpdateP.Text = "Update"
        Me.UpdateP.UseVisualStyleBackColor = True
        '
        'UCP
        '
        Me.UCP.Location = New System.Drawing.Point(66, 184)
        Me.UCP.Name = "UCP"
        Me.UCP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.UCP.Size = New System.Drawing.Size(245, 20)
        Me.UCP.TabIndex = 3
        '
        'UNP
        '
        Me.UNP.Location = New System.Drawing.Point(66, 131)
        Me.UNP.Name = "UNP"
        Me.UNP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.UNP.Size = New System.Drawing.Size(245, 20)
        Me.UNP.TabIndex = 2
        '
        'UOP
        '
        Me.UOP.Location = New System.Drawing.Point(66, 79)
        Me.UOP.Name = "UOP"
        Me.UOP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.UOP.Size = New System.Drawing.Size(245, 20)
        Me.UOP.TabIndex = 1
        '
        'AddSwitch
        '
        Me.AddSwitch.Location = New System.Drawing.Point(588, 344)
        Me.AddSwitch.Name = "AddSwitch"
        Me.AddSwitch.Size = New System.Drawing.Size(75, 23)
        Me.AddSwitch.TabIndex = 0
        Me.AddSwitch.Text = "Add User"
        Me.AddSwitch.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.CreateAccount)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.EditP)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.ACP)
        Me.Panel4.Controls.Add(Me.AUsername)
        Me.Panel4.Controls.Add(Me.AP)
        Me.Panel4.Location = New System.Drawing.Point(15, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(666, 371)
        Me.Panel4.TabIndex = 10
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(178, 223)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.Text = "High Level User"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(63, 223)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Basic User"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Confirm Password:"
        '
        'CreateAccount
        '
        Me.CreateAccount.Location = New System.Drawing.Point(328, 211)
        Me.CreateAccount.Name = "CreateAccount"
        Me.CreateAccount.Size = New System.Drawing.Size(95, 23)
        Me.CreateAccount.TabIndex = 1
        Me.CreateAccount.Text = "Create"
        Me.CreateAccount.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Password:"
        '
        'EditP
        '
        Me.EditP.Location = New System.Drawing.Point(568, 345)
        Me.EditP.Name = "EditP"
        Me.EditP.Size = New System.Drawing.Size(95, 23)
        Me.EditP.TabIndex = 0
        Me.EditP.Text = "Edit Password"
        Me.EditP.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "User Name:"
        '
        'ACP
        '
        Me.ACP.Location = New System.Drawing.Point(63, 183)
        Me.ACP.Name = "ACP"
        Me.ACP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.ACP.Size = New System.Drawing.Size(245, 20)
        Me.ACP.TabIndex = 10
        '
        'AUsername
        '
        Me.AUsername.Location = New System.Drawing.Point(63, 78)
        Me.AUsername.Name = "AUsername"
        Me.AUsername.Size = New System.Drawing.Size(245, 20)
        Me.AUsername.TabIndex = 8
        '
        'AP
        '
        Me.AP.Location = New System.Drawing.Point(63, 130)
        Me.AP.Name = "AP"
        Me.AP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.AP.Size = New System.Drawing.Size(245, 20)
        Me.AP.TabIndex = 9
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(693, 361)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Close"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(559, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "*NOTE: Password can not be changed for a basic user after creation of account*"
        '
        'ManageLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(781, 389)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button7)
        Me.Name = "ManageLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Psw As TextBox
    Friend WithEvents UserName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UpdateP As Button
    Friend WithEvents UCP As TextBox
    Friend WithEvents UNP As TextBox
    Friend WithEvents UOP As TextBox
    Friend WithEvents AddSwitch As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents CreateAccount As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents EditP As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ACP As TextBox
    Friend WithEvents AUsername As TextBox
    Friend WithEvents AP As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label9 As Label
End Class
