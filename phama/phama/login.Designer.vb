<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userTB = New System.Windows.Forms.TextBox()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.StoreBT = New System.Windows.Forms.Button()
        Me.loginBT = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FORGETpw = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveBT
        '
        Me.SaveBT.Location = New System.Drawing.Point(197, 117)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(75, 29)
        Me.SaveBT.TabIndex = 0
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Aachen BT", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 68)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Aachen BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UserName / PhoneNo."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Aachen BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'userTB
        '
        Me.userTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTB.Location = New System.Drawing.Point(26, 166)
        Me.userTB.Multiline = True
        Me.userTB.Name = "userTB"
        Me.userTB.Size = New System.Drawing.Size(233, 29)
        Me.userTB.TabIndex = 2
        '
        'passwordTB
        '
        Me.passwordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTB.Location = New System.Drawing.Point(26, 241)
        Me.passwordTB.Multiline = True
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(233, 29)
        Me.passwordTB.TabIndex = 2
        '
        'StoreBT
        '
        Me.StoreBT.Location = New System.Drawing.Point(197, 53)
        Me.StoreBT.Name = "StoreBT"
        Me.StoreBT.Size = New System.Drawing.Size(75, 23)
        Me.StoreBT.TabIndex = 3
        Me.StoreBT.Text = "Store"
        Me.StoreBT.UseVisualStyleBackColor = True
        '
        'loginBT
        '
        Me.loginBT.Location = New System.Drawing.Point(38, 297)
        Me.loginBT.Name = "loginBT"
        Me.loginBT.Size = New System.Drawing.Size(75, 29)
        Me.loginBT.TabIndex = 4
        Me.loginBT.Text = "Login"
        Me.loginBT.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(61, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 26)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Create New Account"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FORGETpw
        '
        Me.FORGETpw.AutoSize = True
        Me.FORGETpw.Location = New System.Drawing.Point(26, 342)
        Me.FORGETpw.Name = "FORGETpw"
        Me.FORGETpw.Size = New System.Drawing.Size(86, 13)
        Me.FORGETpw.TabIndex = 7
        Me.FORGETpw.TabStop = True
        Me.FORGETpw.Text = "Forget Password"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 432)
        Me.Controls.Add(Me.FORGETpw)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.loginBT)
        Me.Controls.Add(Me.StoreBT)
        Me.Controls.Add(Me.passwordTB)
        Me.Controls.Add(Me.userTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SaveBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents userTB As TextBox
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents StoreBT As Button
    Friend WithEvents loginBT As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FORGETpw As LinkLabel
End Class
