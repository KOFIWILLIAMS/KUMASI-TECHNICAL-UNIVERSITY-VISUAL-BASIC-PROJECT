<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_PAY = New System.Windows.Forms.Button()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.P_N = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date_Pay = New System.Windows.Forms.DateTimePicker()
        Me.F_N = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BT_PAY)
        Me.Panel1.Controls.Add(Me.amount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.P_N)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Date_Pay)
        Me.Panel1.Controls.Add(Me.F_N)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(229, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 489)
        Me.Panel1.TabIndex = 51
        '
        'BT_PAY
        '
        Me.BT_PAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PAY.ForeColor = System.Drawing.Color.Black
        Me.BT_PAY.Image = CType(resources.GetObject("BT_PAY.Image"), System.Drawing.Image)
        Me.BT_PAY.Location = New System.Drawing.Point(109, 402)
        Me.BT_PAY.Name = "BT_PAY"
        Me.BT_PAY.Size = New System.Drawing.Size(243, 53)
        Me.BT_PAY.TabIndex = 60
        Me.BT_PAY.Text = " Make Payment"
        Me.BT_PAY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BT_PAY.UseVisualStyleBackColor = True
        '
        'amount
        '
        Me.amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(105, 308)
        Me.amount.Multiline = True
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(247, 31)
        Me.amount.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "AMOUNT"
        '
        'P_N
        '
        Me.P_N.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_N.Location = New System.Drawing.Point(105, 204)
        Me.P_N.Multiline = True
        Me.P_N.Name = "P_N"
        Me.P_N.Size = New System.Drawing.Size(247, 31)
        Me.P_N.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "PHONE NUMBER"
        '
        'Date_Pay
        '
        Me.Date_Pay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_Pay.CustomFormat = "yyyy/MM/dd"
        Me.Date_Pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Pay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_Pay.Location = New System.Drawing.Point(105, 259)
        Me.Date_Pay.Name = "Date_Pay"
        Me.Date_Pay.Size = New System.Drawing.Size(247, 27)
        Me.Date_Pay.TabIndex = 55
        Me.Date_Pay.Value = New Date(2020, 1, 16, 0, 0, 0, 0)
        '
        'F_N
        '
        Me.F_N.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.F_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_N.Location = New System.Drawing.Point(105, 151)
        Me.F_N.Multiline = True
        Me.F_N.Name = "F_N"
        Me.F_N.Size = New System.Drawing.Size(247, 31)
        Me.F_N.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(103, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 15)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "DATE OF PAYMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Motion Picture Personal Use ", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 76)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Payment"
        '
        'paymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(977, 597)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BT_PAY As Button
    Friend WithEvents amount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents P_N As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Date_Pay As DateTimePicker
    Friend WithEvents F_N As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
