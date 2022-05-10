<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PURCHASE_INVOICE
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_INVOICE = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalSalePrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSearch_box = New System.Windows.Forms.TextBox()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.BTN_add = New System.Windows.Forms.Button()
        Me.TxtSalePrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTP_ExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CBX_Category = New System.Windows.Forms.ComboBox()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridViewINVOICE = New System.Windows.Forms.DataGridView()
        Me.Panel_INVOICE.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewINVOICE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_INVOICE
        '
        Me.Panel_INVOICE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_INVOICE.BackColor = System.Drawing.Color.Snow
        Me.Panel_INVOICE.Controls.Add(Me.Panel2)
        Me.Panel_INVOICE.Controls.Add(Me.Panel1)
        Me.Panel_INVOICE.Controls.Add(Me.DataGridViewINVOICE)
        Me.Panel_INVOICE.Location = New System.Drawing.Point(0, 0)
        Me.Panel_INVOICE.Name = "Panel_INVOICE"
        Me.Panel_INVOICE.Size = New System.Drawing.Size(1036, 472)
        Me.Panel_INVOICE.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.TotalSalePrice)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtSearch_box)
        Me.Panel2.Controls.Add(Me.Btn_Delete)
        Me.Panel2.Controls.Add(Me.Btn_Edit)
        Me.Panel2.Controls.Add(Me.BTN_add)
        Me.Panel2.Controls.Add(Me.TxtSalePrice)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtUnitPrice)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtTotalAmount)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.DTP_ExpiryDate)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.CBX_Category)
        Me.Panel2.Controls.Add(Me.TxtQuantity)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtCode)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TxtName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1036, 172)
        Me.Panel2.TabIndex = 45
        '
        'TotalSalePrice
        '
        Me.TotalSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TotalSalePrice.Location = New System.Drawing.Point(841, 59)
        Me.TotalSalePrice.Name = "TotalSalePrice"
        Me.TotalSalePrice.ReadOnly = True
        Me.TotalSalePrice.Size = New System.Drawing.Size(111, 26)
        Me.TotalSalePrice.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(736, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Total S. Amt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(783, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "SEARCH"
        '
        'TxtSearch_box
        '
        Me.TxtSearch_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtSearch_box.Location = New System.Drawing.Point(857, 137)
        Me.TxtSearch_box.Multiline = True
        Me.TxtSearch_box.Name = "TxtSearch_box"
        Me.TxtSearch_box.Size = New System.Drawing.Size(144, 25)
        Me.TxtSearch_box.TabIndex = 32
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.Location = New System.Drawing.Point(629, 121)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(135, 39)
        Me.Btn_Delete.TabIndex = 30
        Me.Btn_Delete.Text = "DELETE"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.Location = New System.Drawing.Point(488, 121)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(135, 39)
        Me.Btn_Edit.TabIndex = 31
        Me.Btn_Edit.Text = "UPDATE"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'BTN_add
        '
        Me.BTN_add.BackColor = System.Drawing.SystemColors.Control
        Me.BTN_add.Font = New System.Drawing.Font("Aachen BT", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_add.ForeColor = System.Drawing.Color.Black
        Me.BTN_add.Location = New System.Drawing.Point(329, 114)
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.Size = New System.Drawing.Size(153, 55)
        Me.BTN_add.TabIndex = 29
        Me.BTN_add.Text = "A  D  D "
        Me.BTN_add.UseVisualStyleBackColor = False
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtSalePrice.Location = New System.Drawing.Point(841, 20)
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(115, 26)
        Me.TxtSalePrice.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(752, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 18)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Sale Price"
        '
        'TxtUnitPrice
        '
        Me.TxtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtUnitPrice.Location = New System.Drawing.Point(608, 22)
        Me.TxtUnitPrice.Name = "TxtUnitPrice"
        Me.TxtUnitPrice.Size = New System.Drawing.Size(111, 26)
        Me.TxtUnitPrice.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(525, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Unit Price"
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtTotalAmount.Location = New System.Drawing.Point(608, 55)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.ReadOnly = True
        Me.TxtTotalAmount.Size = New System.Drawing.Size(111, 26)
        Me.TxtTotalAmount.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(503, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total P. Amt "
        '
        'DTP_ExpiryDate
        '
        Me.DTP_ExpiryDate.CustomFormat = "yyyy-MM-dd"
        Me.DTP_ExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DTP_ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_ExpiryDate.Location = New System.Drawing.Point(380, 56)
        Me.DTP_ExpiryDate.Name = "DTP_ExpiryDate"
        Me.DTP_ExpiryDate.Size = New System.Drawing.Size(104, 26)
        Me.DTP_ExpiryDate.TabIndex = 22
        Me.DTP_ExpiryDate.Value = New Date(2020, 5, 18, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(282, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 18)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Expiry Date"
        '
        'CBX_Category
        '
        Me.CBX_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBX_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBX_Category.FormattingEnabled = True
        Me.CBX_Category.Items.AddRange(New Object() {"BOTTLE", "BOX", "CAPSULES ", "PACK", "STRIP", "SUSPENSION", "TABLET", "VIAL"})
        Me.CBX_Category.Location = New System.Drawing.Point(138, 85)
        Me.CBX_Category.MaxDropDownItems = 5
        Me.CBX_Category.Name = "CBX_Category"
        Me.CBX_Category.Size = New System.Drawing.Size(115, 28)
        Me.CBX_Category.Sorted = True
        Me.CBX_Category.TabIndex = 21
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtQuantity.Location = New System.Drawing.Point(378, 24)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(104, 26)
        Me.TxtQuantity.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(306, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Category"
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(148, 23)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(105, 26)
        Me.TxtCode.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(55, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Drug Code"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtName.Location = New System.Drawing.Point(148, 53)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(105, 26)
        Me.TxtName.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(51, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Drug Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 55)
        Me.Panel1.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Minicar", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(242, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(533, 46)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "D R U G S    F O R M S"
        '
        'DataGridViewINVOICE
        '
        Me.DataGridViewINVOICE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewINVOICE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewINVOICE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewINVOICE.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGridViewINVOICE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewINVOICE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewINVOICE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewINVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewINVOICE.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridViewINVOICE.Location = New System.Drawing.Point(0, 227)
        Me.DataGridViewINVOICE.MultiSelect = False
        Me.DataGridViewINVOICE.Name = "DataGridViewINVOICE"
        Me.DataGridViewINVOICE.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewINVOICE.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewINVOICE.RowHeadersVisible = False
        Me.DataGridViewINVOICE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridViewINVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewINVOICE.Size = New System.Drawing.Size(1036, 245)
        Me.DataGridViewINVOICE.TabIndex = 6
        '
        'PURCHASE_INVOICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 472)
        Me.Controls.Add(Me.Panel_INVOICE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PURCHASE_INVOICE"
        Me.Text = "PURCHASE_INVOICE"
        Me.Panel_INVOICE.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewINVOICE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_INVOICE As Panel
    Friend WithEvents DataGridViewINVOICE As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSearch_box As TextBox
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents BTN_add As Button
    Friend WithEvents TxtSalePrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtUnitPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtTotalAmount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DTP_ExpiryDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents CBX_Category As ComboBox
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalSalePrice As TextBox
    Friend WithEvents Label5 As Label
End Class
