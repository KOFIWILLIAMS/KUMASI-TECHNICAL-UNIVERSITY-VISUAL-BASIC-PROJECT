<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sign_up_form
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
        Me.First_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Last_Name = New System.Windows.Forms.TextBox()
        Me.Answer = New System.Windows.Forms.TextBox()
        Me.Create_Password = New System.Windows.Forms.TextBox()
        Me.Question = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.signUP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GENDER = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.D_O_Birth = New System.Windows.Forms.Label()
        Me.Phone_N0 = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.D_O_B = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Confirm_Password = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rd_Male = New System.Windows.Forms.RadioButton()
        Me.rd_Female = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'First_Name
        '
        Me.First_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_Name.Location = New System.Drawing.Point(132, 61)
        Me.First_Name.Name = "First_Name"
        Me.First_Name.Size = New System.Drawing.Size(306, 21)
        Me.First_Name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 438)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Create Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Question"
        '
        'Last_Name
        '
        Me.Last_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_Name.Location = New System.Drawing.Point(132, 107)
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.Size = New System.Drawing.Size(306, 21)
        Me.Last_Name.TabIndex = 6
        '
        'Answer
        '
        Me.Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer.Location = New System.Drawing.Point(132, 456)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(306, 21)
        Me.Answer.TabIndex = 8
        '
        'Create_Password
        '
        Me.Create_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create_Password.Location = New System.Drawing.Point(133, 313)
        Me.Create_Password.Name = "Create_Password"
        Me.Create_Password.Size = New System.Drawing.Size(305, 21)
        Me.Create_Password.TabIndex = 7
        '
        'Question
        '
        Me.Question.AutoCompleteCustomSource.AddRange(New String() {"Whats is your name", "How old are you", "Where do you come from", "What is your mothers name"})
        Me.Question.FormattingEnabled = True
        Me.Question.Location = New System.Drawing.Point(133, 409)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(305, 21)
        Me.Question.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tivoli", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sign Up Forms"
        '
        'signUP
        '
        Me.signUP.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.signUP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.signUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUP.ForeColor = System.Drawing.Color.White
        Me.signUP.Location = New System.Drawing.Point(133, 498)
        Me.signUP.Name = "signUP"
        Me.signUP.Size = New System.Drawing.Size(146, 26)
        Me.signUP.TabIndex = 12
        Me.signUP.Text = "Sign Up"
        Me.signUP.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Phone Number"
        '
        'GENDER
        '
        Me.GENDER.AutoSize = True
        Me.GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GENDER.Location = New System.Drawing.Point(130, 236)
        Me.GENDER.Name = "GENDER"
        Me.GENDER.Size = New System.Drawing.Size(54, 15)
        Me.GENDER.TabIndex = 14
        Me.GENDER.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(130, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Email"
        '
        'D_O_Birth
        '
        Me.D_O_Birth.AutoSize = True
        Me.D_O_Birth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_O_Birth.Location = New System.Drawing.Point(129, 266)
        Me.D_O_Birth.Name = "D_O_Birth"
        Me.D_O_Birth.Size = New System.Drawing.Size(89, 15)
        Me.D_O_Birth.TabIndex = 16
        Me.D_O_Birth.Text = "Date Of Birth"
        '
        'Phone_N0
        '
        Me.Phone_N0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_N0.Location = New System.Drawing.Point(132, 155)
        Me.Phone_N0.Name = "Phone_N0"
        Me.Phone_N0.Size = New System.Drawing.Size(306, 21)
        Me.Phone_N0.TabIndex = 17
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(132, 202)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(306, 21)
        Me.Email.TabIndex = 18
        '
        'D_O_B
        '
        Me.D_O_B.CustomFormat = "yyyy/mm/dd"
        Me.D_O_B.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_O_B.Location = New System.Drawing.Point(224, 263)
        Me.D_O_B.Name = "D_O_B"
        Me.D_O_B.Size = New System.Drawing.Size(214, 20)
        Me.D_O_B.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(130, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Confirm Password"
        '
        'Confirm_Password
        '
        Me.Confirm_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirm_Password.Location = New System.Drawing.Point(132, 362)
        Me.Confirm_Password.Name = "Confirm_Password"
        Me.Confirm_Password.Size = New System.Drawing.Size(305, 21)
        Me.Confirm_Password.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(363, 498)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rd_Male
        '
        Me.rd_Male.AutoSize = True
        Me.rd_Male.Location = New System.Drawing.Point(231, 234)
        Me.rd_Male.Name = "rd_Male"
        Me.rd_Male.Size = New System.Drawing.Size(48, 17)
        Me.rd_Male.TabIndex = 25
        Me.rd_Male.TabStop = True
        Me.rd_Male.Text = "Male"
        Me.rd_Male.UseVisualStyleBackColor = True
        '
        'rd_Female
        '
        Me.rd_Female.AutoSize = True
        Me.rd_Female.Location = New System.Drawing.Point(325, 234)
        Me.rd_Female.Name = "rd_Female"
        Me.rd_Female.Size = New System.Drawing.Size(59, 17)
        Me.rd_Female.TabIndex = 26
        Me.rd_Female.TabStop = True
        Me.rd_Female.Text = "Female"
        Me.rd_Female.UseVisualStyleBackColor = True
        '
        'sign_up_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 565)
        Me.Controls.Add(Me.rd_Female)
        Me.Controls.Add(Me.rd_Male)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Confirm_Password)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.D_O_B)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Phone_N0)
        Me.Controls.Add(Me.D_O_Birth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GENDER)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.signUP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.Answer)
        Me.Controls.Add(Me.Create_Password)
        Me.Controls.Add(Me.Last_Name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.First_Name)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sign_up_form"
        Me.Text = "sign_up_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents First_Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Last_Name As TextBox
    Friend WithEvents Answer As TextBox
    Friend WithEvents Create_Password As TextBox
    Friend WithEvents Question As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents signUP As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GENDER As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents D_O_Birth As Label
    Friend WithEvents Phone_N0 As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents D_O_B As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Confirm_Password As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents rd_Male As RadioButton
    Friend WithEvents rd_Female As RadioButton
End Class
