<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DRUG_LIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DRUG_LIST))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Print = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.addBT = New System.Windows.Forms.Button()
        Me.TxtSearch_box = New System.Windows.Forms.TextBox()
        Me.MainDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PanelDL = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.MainDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTN_Print)
        Me.Panel1.Controls.Add(Me.Btn_Delete)
        Me.Panel1.Controls.Add(Me.Btn_Edit)
        Me.Panel1.Controls.Add(Me.addBT)
        Me.Panel1.Controls.Add(Me.TxtSearch_box)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 59)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(741, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SEARCH"
        '
        'BTN_Print
        '
        Me.BTN_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_Print.Location = New System.Drawing.Point(500, 10)
        Me.BTN_Print.Name = "BTN_Print"
        Me.BTN_Print.Size = New System.Drawing.Size(135, 39)
        Me.BTN_Print.TabIndex = 4
        Me.BTN_Print.Text = "PRINT"
        Me.BTN_Print.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.Location = New System.Drawing.Point(306, 9)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(135, 39)
        Me.Btn_Delete.TabIndex = 4
        Me.Btn_Delete.Text = "DELETE"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.Location = New System.Drawing.Point(165, 9)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(135, 39)
        Me.Btn_Edit.TabIndex = 4
        Me.Btn_Edit.Text = "UPDATE"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'addBT
        '
        Me.addBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.addBT.Location = New System.Drawing.Point(25, 9)
        Me.addBT.Name = "addBT"
        Me.addBT.Size = New System.Drawing.Size(135, 39)
        Me.addBT.TabIndex = 4
        Me.addBT.Text = "ADD NEW"
        Me.addBT.UseVisualStyleBackColor = True
        '
        'TxtSearch_box
        '
        Me.TxtSearch_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtSearch_box.Location = New System.Drawing.Point(818, 14)
        Me.TxtSearch_box.Multiline = True
        Me.TxtSearch_box.Name = "TxtSearch_box"
        Me.TxtSearch_box.Size = New System.Drawing.Size(206, 25)
        Me.TxtSearch_box.TabIndex = 3
        '
        'MainDataGridView1
        '
        Me.MainDataGridView1.AllowUserToAddRows = False
        Me.MainDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MainDataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.MainDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MainDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainDataGridView1.Location = New System.Drawing.Point(0, 67)
        Me.MainDataGridView1.MultiSelect = False
        Me.MainDataGridView1.Name = "MainDataGridView1"
        Me.MainDataGridView1.ReadOnly = True
        Me.MainDataGridView1.RowHeadersVisible = False
        Me.MainDataGridView1.RowTemplate.Height = 25
        Me.MainDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MainDataGridView1.Size = New System.Drawing.Size(1037, 400)
        Me.MainDataGridView1.TabIndex = 7
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PanelDL
        '
        Me.PanelDL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDL.Controls.Add(Me.Panel1)
        Me.PanelDL.Controls.Add(Me.MainDataGridView1)
        Me.PanelDL.Location = New System.Drawing.Point(-1, 2)
        Me.PanelDL.Name = "PanelDL"
        Me.PanelDL.Size = New System.Drawing.Size(1036, 472)
        Me.PanelDL.TabIndex = 10
        '
        'DRUG_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 472)
        Me.Controls.Add(Me.PanelDL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DRUG_LIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "DRUG_LIST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MainDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_Print As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents addBT As Button
    Friend WithEvents TxtSearch_box As TextBox
    Friend WithEvents MainDataGridView1 As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PanelDL As Panel
    Friend WithEvents Label1 As Label
End Class
