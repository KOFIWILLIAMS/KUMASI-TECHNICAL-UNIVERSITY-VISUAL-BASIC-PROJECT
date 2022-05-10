<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASSESSMENT
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.exams = New System.Windows.Forms.RadioButton()
        Me.ex = New System.Windows.Forms.RadioButton()
        Me.text = New System.Windows.Forms.RadioButton()
        Me.SearchByName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SelectTASK = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridAsses = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridAsses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridAsses)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 585)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.SearchByName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DateOfBirth)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.SelectTASK)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(62, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(851, 142)
        Me.Panel2.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(663, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 45)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.exams)
        Me.GroupBox1.Controls.Add(Me.ex)
        Me.GroupBox1.Controls.Add(Me.text)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 45)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select One"
        '
        'exams
        '
        Me.exams.AutoSize = True
        Me.exams.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exams.Location = New System.Drawing.Point(231, 23)
        Me.exams.Name = "exams"
        Me.exams.Size = New System.Drawing.Size(72, 21)
        Me.exams.TabIndex = 2
        Me.exams.TabStop = True
        Me.exams.Text = "Exams"
        Me.exams.UseVisualStyleBackColor = True
        '
        'ex
        '
        Me.ex.AutoSize = True
        Me.ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ex.Location = New System.Drawing.Point(6, 23)
        Me.ex.Name = "ex"
        Me.ex.Size = New System.Drawing.Size(87, 21)
        Me.ex.TabIndex = 1
        Me.ex.TabStop = True
        Me.ex.Text = "Class Ex"
        Me.ex.UseVisualStyleBackColor = True
        '
        'text
        '
        Me.text.AutoSize = True
        Me.text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text.Location = New System.Drawing.Point(109, 23)
        Me.text.Name = "text"
        Me.text.Size = New System.Drawing.Size(101, 21)
        Me.text.TabIndex = 0
        Me.text.TabStop = True
        Me.text.Text = "Class Text"
        Me.text.UseVisualStyleBackColor = True
        '
        'SearchByName
        '
        Me.SearchByName.AllowDrop = True
        Me.SearchByName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SearchByName.FormattingEnabled = True
        Me.SearchByName.Location = New System.Drawing.Point(33, 51)
        Me.SearchByName.Name = "SearchByName"
        Me.SearchByName.Size = New System.Drawing.Size(178, 21)
        Me.SearchByName.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Index NO."
        '
        'DateOfBirth
        '
        Me.DateOfBirth.Location = New System.Drawing.Point(33, 94)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(178, 20)
        Me.DateOfBirth.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Marks"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(419, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 4
        '
        'SelectTASK
        '
        Me.SelectTASK.FormattingEnabled = True
        Me.SelectTASK.Location = New System.Drawing.Point(237, 48)
        Me.SelectTASK.Name = "SelectTASK"
        Me.SelectTASK.Size = New System.Drawing.Size(145, 21)
        Me.SelectTASK.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(663, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridAsses
        '
        Me.DataGridAsses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAsses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridAsses.GridColor = System.Drawing.Color.AliceBlue
        Me.DataGridAsses.Location = New System.Drawing.Point(29, 212)
        Me.DataGridAsses.Name = "DataGridAsses"
        Me.DataGridAsses.ReadOnly = True
        Me.DataGridAsses.Size = New System.Drawing.Size(913, 374)
        Me.DataGridAsses.TabIndex = 0
        '
        'ASSESSMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 597)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ASSESSMENT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridAsses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DateOfBirth As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SelectTASK As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridAsses As DataGridView
    Friend WithEvents SearchByName As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents exams As RadioButton
    Friend WithEvents ex As RadioButton
    Friend WithEvents text As RadioButton
End Class
