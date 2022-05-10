<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADD_DRUGS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TOTALamt = New System.Windows.Forms.TextBox()
        Me.totalPROFIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateStart = New System.Windows.Forms.DateTimePicker()
        Me.amountTB = New System.Windows.Forms.TextBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxNAME = New System.Windows.Forms.ComboBox()
        Me.ButtonUPDATE = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_ExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtAvailabeQty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Category = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSaleUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridBUY = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridBUY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridBUY)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 472)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.TOTALamt)
        Me.Panel3.Controls.Add(Me.totalPROFIT)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(0, 423)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1036, 49)
        Me.Panel3.TabIndex = 45
        '
        'TOTALamt
        '
        Me.TOTALamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TOTALamt.Location = New System.Drawing.Point(680, 12)
        Me.TOTALamt.Name = "TOTALamt"
        Me.TOTALamt.Size = New System.Drawing.Size(111, 26)
        Me.TOTALamt.TabIndex = 47
        '
        'totalPROFIT
        '
        Me.totalPROFIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.totalPROFIT.Location = New System.Drawing.Point(351, 12)
        Me.totalPROFIT.Name = "totalPROFIT"
        Me.totalPROFIT.Size = New System.Drawing.Size(111, 26)
        Me.totalPROFIT.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(538, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "TOTAL AMOUNT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(220, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "TOTAL PROFIT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.Snow
        Me.GroupBox2.Controls.Add(Me.TxtCode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DateEnd)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DateStart)
        Me.GroupBox2.Controls.Add(Me.amountTB)
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ComboBoxNAME)
        Me.GroupBox2.Controls.Add(Me.ButtonUPDATE)
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Controls.Add(Me.TxtQuantity)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DTP_ExpiryDate)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtAvailabeQty)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Category)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtSaleUnitPrice)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1036, 127)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(223, 86)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.ReadOnly = True
        Me.TxtCode.Size = New System.Drawing.Size(92, 26)
        Me.TxtCode.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(226, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Drug Code"
        '
        'DateEnd
        '
        Me.DateEnd.CustomFormat = " yyyy/MM/dd"
        Me.DateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateEnd.Location = New System.Drawing.Point(833, 97)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(109, 24)
        Me.DateEnd.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(804, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "TO"
        '
        'DateStart
        '
        Me.DateStart.CustomFormat = "yyyy/MM/dd"
        Me.DateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateStart.Location = New System.Drawing.Point(697, 97)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(105, 24)
        Me.DateStart.TabIndex = 56
        '
        'amountTB
        '
        Me.amountTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.amountTB.Location = New System.Drawing.Point(426, 55)
        Me.amountTB.Name = "amountTB"
        Me.amountTB.ReadOnly = True
        Me.amountTB.Size = New System.Drawing.Size(81, 26)
        Me.amountTB.TabIndex = 50
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Delete.FlatAppearance.BorderSize = 0
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Aachen BT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Delete.Location = New System.Drawing.Point(918, 38)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(103, 51)
        Me.Delete.TabIndex = 51
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(638, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "FROM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(359, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Amount"
        '
        'ComboBoxNAME
        '
        Me.ComboBoxNAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxNAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNAME.DropDownHeight = 140
        Me.ComboBoxNAME.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxNAME.FormattingEnabled = True
        Me.ComboBoxNAME.IntegralHeight = False
        Me.ComboBoxNAME.Location = New System.Drawing.Point(96, 22)
        Me.ComboBoxNAME.Name = "ComboBoxNAME"
        Me.ComboBoxNAME.Size = New System.Drawing.Size(219, 28)
        Me.ComboBoxNAME.TabIndex = 45
        '
        'ButtonUPDATE
        '
        Me.ButtonUPDATE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonUPDATE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonUPDATE.Font = New System.Drawing.Font("Aachen BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUPDATE.Location = New System.Drawing.Point(794, 36)
        Me.ButtonUPDATE.Name = "ButtonUPDATE"
        Me.ButtonUPDATE.Size = New System.Drawing.Size(113, 55)
        Me.ButtonUPDATE.TabIndex = 44
        Me.ButtonUPDATE.Text = "UPDATE"
        Me.ButtonUPDATE.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SaveButton.Font = New System.Drawing.Font("Aachen BT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(673, 35)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(113, 56)
        Me.SaveButton.TabIndex = 42
        Me.SaveButton.Text = "SAVE"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtQuantity.Location = New System.Drawing.Point(96, 54)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(111, 26)
        Me.TxtQuantity.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(24, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Quantity"
        '
        'DTP_ExpiryDate
        '
        Me.DTP_ExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTP_ExpiryDate.CalendarForeColor = System.Drawing.Color.Red
        Me.DTP_ExpiryDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder
        Me.DTP_ExpiryDate.CustomFormat = "yyyy/MM/dd"
        Me.DTP_ExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DTP_ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_ExpiryDate.Location = New System.Drawing.Point(96, 86)
        Me.DTP_ExpiryDate.Name = "DTP_ExpiryDate"
        Me.DTP_ExpiryDate.Size = New System.Drawing.Size(111, 26)
        Me.DTP_ExpiryDate.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(19, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Ex. Date"
        '
        'TxtAvailabeQty
        '
        Me.TxtAvailabeQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtAvailabeQty.Location = New System.Drawing.Point(530, 82)
        Me.TxtAvailabeQty.Name = "TxtAvailabeQty"
        Me.TxtAvailabeQty.ReadOnly = True
        Me.TxtAvailabeQty.Size = New System.Drawing.Size(83, 26)
        Me.TxtAvailabeQty.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(530, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stock Qty"
        '
        'Category
        '
        Me.Category.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Category.Location = New System.Drawing.Point(427, 24)
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Size = New System.Drawing.Size(186, 26)
        Me.Category.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(349, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Category"
        '
        'TxtSaleUnitPrice
        '
        Me.TxtSaleUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtSaleUnitPrice.Location = New System.Drawing.Point(427, 86)
        Me.TxtSaleUnitPrice.Name = "TxtSaleUnitPrice"
        Me.TxtSaleUnitPrice.ReadOnly = True
        Me.TxtSaleUnitPrice.Size = New System.Drawing.Size(81, 26)
        Me.TxtSaleUnitPrice.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(343, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Sale Price"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1036, 49)
        Me.Panel2.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Minicar", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(405, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(593, 46)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "S E L L I N G    F O R M S"
        '
        'DataGridBUY
        '
        Me.DataGridBUY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridBUY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridBUY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBUY.Location = New System.Drawing.Point(0, 182)
        Me.DataGridBUY.MultiSelect = False
        Me.DataGridBUY.Name = "DataGridBUY"
        Me.DataGridBUY.ReadOnly = True
        Me.DataGridBUY.RowHeadersVisible = False
        Me.DataGridBUY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBUY.Size = New System.Drawing.Size(1036, 241)
        Me.DataGridBUY.TabIndex = 44
        '
        'ADD_DRUGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 472)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ADD_DRUGS"
        Me.Text = "ADD_DRUGS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridBUY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSaleUnitPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DTP_ExpiryDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Category As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents ButtonUPDATE As Button
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TOTALamt As TextBox
    Friend WithEvents totalPROFIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridBUY As DataGridView
    Friend WithEvents amountTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxNAME As ComboBox
    Friend WithEvents Delete As Button
    Friend WithEvents TxtAvailabeQty As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateEnd As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DateStart As DateTimePicker
    Friend WithEvents Label10 As Label
End Class
