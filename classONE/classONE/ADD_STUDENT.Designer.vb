<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_STUDENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_STUDENT))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxAddMember = New System.Windows.Forms.GroupBox()
        Me.BTupdate = New System.Windows.Forms.Button()
        Me.BT_CLEAR = New System.Windows.Forms.Button()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.C_H = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.N_I_N = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.Date_O_B = New System.Windows.Forms.DateTimePicker()
        Me.F_N = New System.Windows.Forms.TextBox()
        Me.P_N = New System.Windows.Forms.TextBox()
        Me.G_P_A = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxAddMember.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBoxAddMember)
        Me.Panel1.Location = New System.Drawing.Point(-4, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 508)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(423, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADD STUDENT"
        '
        'GroupBoxAddMember
        '
        Me.GroupBoxAddMember.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxAddMember.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBoxAddMember.Controls.Add(Me.Label1)
        Me.GroupBoxAddMember.Controls.Add(Me.BTupdate)
        Me.GroupBoxAddMember.Controls.Add(Me.BT_CLEAR)
        Me.GroupBoxAddMember.Controls.Add(Me.BT_SAVE)
        Me.GroupBoxAddMember.Controls.Add(Me.C_H)
        Me.GroupBoxAddMember.Controls.Add(Me.ComboBoxGender)
        Me.GroupBoxAddMember.Controls.Add(Me.N_I_N)
        Me.GroupBoxAddMember.Controls.Add(Me.Label14)
        Me.GroupBoxAddMember.Controls.Add(Me.PicBox)
        Me.GroupBoxAddMember.Controls.Add(Me.Date_O_B)
        Me.GroupBoxAddMember.Controls.Add(Me.F_N)
        Me.GroupBoxAddMember.Controls.Add(Me.P_N)
        Me.GroupBoxAddMember.Controls.Add(Me.G_P_A)
        Me.GroupBoxAddMember.Controls.Add(Me.Label8)
        Me.GroupBoxAddMember.Controls.Add(Me.Label7)
        Me.GroupBoxAddMember.Controls.Add(Me.Label3)
        Me.GroupBoxAddMember.Controls.Add(Me.Label6)
        Me.GroupBoxAddMember.Controls.Add(Me.Label5)
        Me.GroupBoxAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxAddMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxAddMember.Location = New System.Drawing.Point(268, 30)
        Me.GroupBoxAddMember.Name = "GroupBoxAddMember"
        Me.GroupBoxAddMember.Size = New System.Drawing.Size(461, 470)
        Me.GroupBoxAddMember.TabIndex = 0
        Me.GroupBoxAddMember.TabStop = False
        '
        'BTupdate
        '
        Me.BTupdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTupdate.Image = CType(resources.GetObject("BTupdate.Image"), System.Drawing.Image)
        Me.BTupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTupdate.Location = New System.Drawing.Point(32, 80)
        Me.BTupdate.Name = "BTupdate"
        Me.BTupdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTupdate.Size = New System.Drawing.Size(96, 28)
        Me.BTupdate.TabIndex = 26
        Me.BTupdate.Text = "UPDATE"
        Me.BTupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTupdate.UseVisualStyleBackColor = True
        Me.BTupdate.Visible = False
        '
        'BT_CLEAR
        '
        Me.BT_CLEAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BT_CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLEAR.Image = CType(resources.GetObject("BT_CLEAR.Image"), System.Drawing.Image)
        Me.BT_CLEAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CLEAR.Location = New System.Drawing.Point(293, 425)
        Me.BT_CLEAR.Name = "BT_CLEAR"
        Me.BT_CLEAR.Size = New System.Drawing.Size(80, 28)
        Me.BT_CLEAR.TabIndex = 20
        Me.BT_CLEAR.Text = "  CLEAR"
        Me.BT_CLEAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CLEAR.UseVisualStyleBackColor = True
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BT_SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SAVE.Image = CType(resources.GetObject("BT_SAVE.Image"), System.Drawing.Image)
        Me.BT_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_SAVE.Location = New System.Drawing.Point(64, 425)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BT_SAVE.Size = New System.Drawing.Size(80, 28)
        Me.BT_SAVE.TabIndex = 19
        Me.BT_SAVE.Text = " SAVE"
        Me.BT_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'C_H
        '
        Me.C_H.AutoSize = True
        Me.C_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_H.Location = New System.Drawing.Point(189, 91)
        Me.C_H.Name = "C_H"
        Me.C_H.Size = New System.Drawing.Size(87, 17)
        Me.C_H.TabIndex = 25
        Me.C_H.Text = "Click Here "
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.ComboBoxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Location = New System.Drawing.Point(145, 227)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(233, 23)
        Me.ComboBoxGender.TabIndex = 23
        '
        'N_I_N
        '
        Me.N_I_N.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.N_I_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_I_N.Location = New System.Drawing.Point(169, 298)
        Me.N_I_N.Name = "N_I_N"
        Me.N_I_N.Size = New System.Drawing.Size(209, 21)
        Me.N_I_N.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(188, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "PASSPORT PIC"
        '
        'PicBox
        '
        Me.PicBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(165, 17)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(132, 161)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox.TabIndex = 18
        Me.PicBox.TabStop = False
        '
        'Date_O_B
        '
        Me.Date_O_B.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_O_B.CustomFormat = "MMM, dd yyyy"
        Me.Date_O_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_O_B.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_O_B.Location = New System.Drawing.Point(169, 262)
        Me.Date_O_B.Name = "Date_O_B"
        Me.Date_O_B.Size = New System.Drawing.Size(209, 22)
        Me.Date_O_B.TabIndex = 17
        '
        'F_N
        '
        Me.F_N.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.F_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_N.Location = New System.Drawing.Point(145, 195)
        Me.F_N.Name = "F_N"
        Me.F_N.Size = New System.Drawing.Size(233, 21)
        Me.F_N.TabIndex = 16
        '
        'P_N
        '
        Me.P_N.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_N.Location = New System.Drawing.Point(167, 331)
        Me.P_N.Name = "P_N"
        Me.P_N.Size = New System.Drawing.Size(211, 21)
        Me.P_N.TabIndex = 15
        '
        'G_P_A
        '
        Me.G_P_A.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.G_P_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_P_A.Location = New System.Drawing.Point(169, 365)
        Me.G_P_A.Name = "G_P_A"
        Me.G_P_A.Size = New System.Drawing.Size(209, 21)
        Me.G_P_A.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "DATE OF BIRTH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "GUARDIAN TELL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "FULL NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "GP ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "GENDER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "GUARDIAN NAME"
        '
        'ADD_STUDENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 650)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADD_STUDENT"
        Me.Text = "ADD_STUDENT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxAddMember.ResumeLayout(False)
        Me.GroupBoxAddMember.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAddMember As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTupdate As System.Windows.Forms.Button
    Friend WithEvents BT_CLEAR As System.Windows.Forms.Button
    Friend WithEvents BT_SAVE As System.Windows.Forms.Button
    Friend WithEvents C_H As System.Windows.Forms.Label
    Friend WithEvents ComboBoxGender As System.Windows.Forms.ComboBox
    Friend WithEvents N_I_N As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Date_O_B As System.Windows.Forms.DateTimePicker
    Friend WithEvents F_N As System.Windows.Forms.TextBox
    Friend WithEvents P_N As System.Windows.Forms.TextBox
    Friend WithEvents G_P_A As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
