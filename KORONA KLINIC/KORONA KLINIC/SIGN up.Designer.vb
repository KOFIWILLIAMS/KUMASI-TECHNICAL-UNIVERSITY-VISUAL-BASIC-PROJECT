<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGN_up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIGN_up))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTN_Update = New System.Windows.Forms.Button()
        Me.BT_CLEAR = New System.Windows.Forms.Button()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Phone_Num = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Date_O_Birth = New System.Windows.Forms.DateTimePicker()
        Me.First_Name = New System.Windows.Forms.TextBox()
        Me.PassWord = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Sure_Name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.BTN_Update)
        Me.Panel4.Controls.Add(Me.BT_CLEAR)
        Me.Panel4.Controls.Add(Me.BT_SAVE)
        Me.Panel4.Controls.Add(Me.Email)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Phone_Num)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Date_O_Birth)
        Me.Panel4.Controls.Add(Me.First_Name)
        Me.Panel4.Controls.Add(Me.PassWord)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Sure_Name)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(537, 419)
        Me.Panel4.TabIndex = 7
        '
        'BTN_Update
        '
        Me.BTN_Update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Update.Image = CType(resources.GetObject("BTN_Update.Image"), System.Drawing.Image)
        Me.BTN_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Update.Location = New System.Drawing.Point(181, 367)
        Me.BTN_Update.Name = "BTN_Update"
        Me.BTN_Update.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_Update.Size = New System.Drawing.Size(93, 28)
        Me.BTN_Update.TabIndex = 46
        Me.BTN_Update.Text = "UPDATE"
        Me.BTN_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Update.UseVisualStyleBackColor = True
        '
        'BT_CLEAR
        '
        Me.BT_CLEAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLEAR.Image = CType(resources.GetObject("BT_CLEAR.Image"), System.Drawing.Image)
        Me.BT_CLEAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CLEAR.Location = New System.Drawing.Point(330, 367)
        Me.BT_CLEAR.Name = "BT_CLEAR"
        Me.BT_CLEAR.Size = New System.Drawing.Size(83, 28)
        Me.BT_CLEAR.TabIndex = 45
        Me.BT_CLEAR.Text = "  CLEAR"
        Me.BT_CLEAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CLEAR.UseVisualStyleBackColor = True
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SAVE.Image = CType(resources.GetObject("BT_SAVE.Image"), System.Drawing.Image)
        Me.BT_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_SAVE.Location = New System.Drawing.Point(111, 367)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BT_SAVE.Size = New System.Drawing.Size(80, 28)
        Me.BT_SAVE.TabIndex = 44
        Me.BT_SAVE.Text = " SAVE"
        Me.BT_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'Email
        '
        Me.Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(158, 166)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(202, 21)
        Me.Email.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MyriadBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(164, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Add New Worker"
        '
        'Phone_Num
        '
        Me.Phone_Num.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Phone_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_Num.Location = New System.Drawing.Point(158, 206)
        Me.Phone_Num.Name = "Phone_Num"
        Me.Phone_Num.Size = New System.Drawing.Size(202, 21)
        Me.Phone_Num.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "CREATE  PASSWORD"
        '
        'Date_O_Birth
        '
        Me.Date_O_Birth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Date_O_Birth.CustomFormat = "yyyy/MM/dd"
        Me.Date_O_Birth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_O_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_O_Birth.Location = New System.Drawing.Point(158, 248)
        Me.Date_O_Birth.Name = "Date_O_Birth"
        Me.Date_O_Birth.Size = New System.Drawing.Size(202, 22)
        Me.Date_O_Birth.TabIndex = 38
        Me.Date_O_Birth.Value = New Date(2020, 2, 12, 0, 0, 0, 0)
        '
        'First_Name
        '
        Me.First_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.First_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_Name.Location = New System.Drawing.Point(158, 86)
        Me.First_Name.Name = "First_Name"
        Me.First_Name.Size = New System.Drawing.Size(202, 21)
        Me.First_Name.TabIndex = 37
        '
        'PassWord
        '
        Me.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PassWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassWord.Location = New System.Drawing.Point(158, 293)
        Me.PassWord.Name = "PassWord"
        Me.PassWord.Size = New System.Drawing.Size(202, 21)
        Me.PassWord.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "DATE OF BIRTH"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "PHONE NO."
        '
        'Sure_Name
        '
        Me.Sure_Name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sure_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sure_Name.Location = New System.Drawing.Point(158, 124)
        Me.Sure_Name.Name = "Sure_Name"
        Me.Sure_Name.Size = New System.Drawing.Size(202, 21)
        Me.Sure_Name.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "SURE NAME"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "FIRST NAME"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "EMAIL"
        '
        'SIGN_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 419)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SIGN_up"
        Me.Text = "SIGN_up"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Date_O_Birth As DateTimePicker
    Friend WithEvents First_Name As TextBox
    Friend WithEvents PassWord As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Sure_Name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents BT_CLEAR As Button
    Friend WithEvents BT_SAVE As Button
    Friend WithEvents Phone_Num As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Update As Button
End Class
