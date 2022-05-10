<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATTENDANCE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ATTENDANCE))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Filter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateStart = New System.Windows.Forms.DateTimePicker()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewATTENDANCE = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ABS_BT = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.PRE_BT = New System.Windows.Forms.Button()
        Me.search2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewATTENDANCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Filter)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateStart)
        Me.Panel1.Controls.Add(Me.DatePicker)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateEnd)
        Me.Panel1.Controls.Add(Me.DataGridViewATTENDANCE)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ABS_BT)
        Me.Panel1.Controls.Add(Me.DataGrid)
        Me.Panel1.Controls.Add(Me.PRE_BT)
        Me.Panel1.Controls.Add(Me.search2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 533)
        Me.Panel1.TabIndex = 0
        '
        'Filter
        '
        Me.Filter.Location = New System.Drawing.Point(866, 70)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(75, 23)
        Me.Filter.TabIndex = 13
        Me.Filter.Text = "FILTER"
        Me.Filter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(674, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TO"
        '
        'DateStart
        '
        Me.DateStart.CustomFormat = "yyyy/MM/dd"
        Me.DateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateStart.Location = New System.Drawing.Point(553, 70)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(105, 24)
        Me.DateStart.TabIndex = 11
        '
        'DatePicker
        '
        Me.DatePicker.CustomFormat = "yyyy/MM/dd"
        Me.DatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.Location = New System.Drawing.Point(303, 292)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(135, 24)
        Me.DatePicker.TabIndex = 10
        Me.DatePicker.Value = New Date(2020, 3, 7, 13, 54, 37, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(488, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "FROM"
        '
        'DateEnd
        '
        Me.DateEnd.CustomFormat = " yyyy/MM/dd"
        Me.DateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateEnd.Location = New System.Drawing.Point(721, 70)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(109, 24)
        Me.DateEnd.TabIndex = 8
        '
        'DataGridViewATTENDANCE
        '
        Me.DataGridViewATTENDANCE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewATTENDANCE.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridViewATTENDANCE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewATTENDANCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewATTENDANCE.Location = New System.Drawing.Point(459, 100)
        Me.DataGridViewATTENDANCE.Name = "DataGridViewATTENDANCE"
        Me.DataGridViewATTENDANCE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewATTENDANCE.Size = New System.Drawing.Size(511, 490)
        Me.DataGridViewATTENDANCE.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(698, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search By Name"
        '
        'ABS_BT
        '
        Me.ABS_BT.BackColor = System.Drawing.Color.Red
        Me.ABS_BT.BackgroundImage = CType(resources.GetObject("ABS_BT.BackgroundImage"), System.Drawing.Image)
        Me.ABS_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABS_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABS_BT.ForeColor = System.Drawing.Color.AliceBlue
        Me.ABS_BT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABS_BT.Location = New System.Drawing.Point(303, 331)
        Me.ABS_BT.Name = "ABS_BT"
        Me.ABS_BT.Size = New System.Drawing.Size(135, 40)
        Me.ABS_BT.TabIndex = 5
        Me.ABS_BT.Text = "     ABSENT"
        Me.ABS_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABS_BT.UseVisualStyleBackColor = False
        '
        'DataGrid
        '
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(2, 100)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(281, 490)
        Me.DataGrid.TabIndex = 4
        '
        'PRE_BT
        '
        Me.PRE_BT.BackColor = System.Drawing.Color.Green
        Me.PRE_BT.BackgroundImage = CType(resources.GetObject("PRE_BT.BackgroundImage"), System.Drawing.Image)
        Me.PRE_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PRE_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRE_BT.ForeColor = System.Drawing.Color.AliceBlue
        Me.PRE_BT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PRE_BT.Location = New System.Drawing.Point(303, 231)
        Me.PRE_BT.Name = "PRE_BT"
        Me.PRE_BT.Size = New System.Drawing.Size(135, 40)
        Me.PRE_BT.TabIndex = 3
        Me.PRE_BT.Text = "     PRESENT"
        Me.PRE_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PRE_BT.UseVisualStyleBackColor = False
        '
        'search2
        '
        Me.search2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search2.Location = New System.Drawing.Point(803, 23)
        Me.search2.Name = "search2"
        Me.search2.Size = New System.Drawing.Size(159, 21)
        Me.search2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Motion Picture Personal Use ", 28.0!)
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(286, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Members Attendance Sheet"
        '
        'ATTENDANCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 597)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ATTENDANCE"
        Me.Text = "ATTENDANCE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewATTENDANCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents PRE_BT As Button
    Friend WithEvents search2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewATTENDANCE As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents ABS_BT As Button
    Friend WithEvents DateEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateStart As DateTimePicker
    Friend WithEvents Filter As Button
End Class
