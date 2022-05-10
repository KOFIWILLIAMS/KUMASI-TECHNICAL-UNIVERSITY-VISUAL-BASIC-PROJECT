<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.viewBT = New System.Windows.Forms.Button()
        Me.addBT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FirstBT = New System.Windows.Forms.Button()
        Me.ASSESSMENT = New System.Windows.Forms.Button()
        Me.dATE_TIME = New System.Windows.Forms.Label()
        Me.ATT_BT = New System.Windows.Forms.Button()
        Me.payment = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1185, 24)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AddMemberToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.RegistrationToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(483, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(172, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(977, 597)
        Me.Panel3.TabIndex = 43
        '
        'viewBT
        '
        Me.viewBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBT.ForeColor = System.Drawing.Color.Black
        Me.viewBT.Image = CType(resources.GetObject("viewBT.Image"), System.Drawing.Image)
        Me.viewBT.Location = New System.Drawing.Point(26, 238)
        Me.viewBT.Name = "viewBT"
        Me.viewBT.Size = New System.Drawing.Size(122, 53)
        Me.viewBT.TabIndex = 1
        Me.viewBT.Text = " View  Records"
        Me.viewBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.viewBT.UseVisualStyleBackColor = True
        '
        'addBT
        '
        Me.addBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBT.ForeColor = System.Drawing.Color.Black
        Me.addBT.Image = CType(resources.GetObject("addBT.Image"), System.Drawing.Image)
        Me.addBT.Location = New System.Drawing.Point(26, 148)
        Me.addBT.Name = "addBT"
        Me.addBT.Size = New System.Drawing.Size(122, 53)
        Me.addBT.TabIndex = 0
        Me.addBT.Text = " Add  Member"
        Me.addBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addBT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.FirstBT)
        Me.Panel1.Controls.Add(Me.ASSESSMENT)
        Me.Panel1.Controls.Add(Me.dATE_TIME)
        Me.Panel1.Controls.Add(Me.ATT_BT)
        Me.Panel1.Controls.Add(Me.payment)
        Me.Panel1.Controls.Add(Me.viewBT)
        Me.Panel1.Controls.Add(Me.addBT)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 667)
        Me.Panel1.TabIndex = 4
        '
        'FirstBT
        '
        Me.FirstBT.BackgroundImage = CType(resources.GetObject("FirstBT.BackgroundImage"), System.Drawing.Image)
        Me.FirstBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FirstBT.Location = New System.Drawing.Point(0, 297)
        Me.FirstBT.Name = "FirstBT"
        Me.FirstBT.Size = New System.Drawing.Size(1185, 370)
        Me.FirstBT.TabIndex = 44
        Me.FirstBT.UseVisualStyleBackColor = True
        '
        'ASSESSMENT
        '
        Me.ASSESSMENT.Location = New System.Drawing.Point(26, 489)
        Me.ASSESSMENT.Name = "ASSESSMENT"
        Me.ASSESSMENT.Size = New System.Drawing.Size(122, 56)
        Me.ASSESSMENT.TabIndex = 64
        Me.ASSESSMENT.Text = "ASSESSMENT"
        Me.ASSESSMENT.UseVisualStyleBackColor = True
        '
        'dATE_TIME
        '
        Me.dATE_TIME.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dATE_TIME.AutoSize = True
        Me.dATE_TIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dATE_TIME.ForeColor = System.Drawing.Color.Lime
        Me.dATE_TIME.Location = New System.Drawing.Point(491, 634)
        Me.dATE_TIME.Name = "dATE_TIME"
        Me.dATE_TIME.Size = New System.Drawing.Size(64, 22)
        Me.dATE_TIME.TabIndex = 63
        Me.dATE_TIME.Text = "Label1"
        '
        'ATT_BT
        '
        Me.ATT_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATT_BT.ForeColor = System.Drawing.Color.Black
        Me.ATT_BT.Image = CType(resources.GetObject("ATT_BT.Image"), System.Drawing.Image)
        Me.ATT_BT.Location = New System.Drawing.Point(26, 411)
        Me.ATT_BT.Name = "ATT_BT"
        Me.ATT_BT.Size = New System.Drawing.Size(122, 54)
        Me.ATT_BT.TabIndex = 62
        Me.ATT_BT.Text = "REG."
        Me.ATT_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ATT_BT.UseVisualStyleBackColor = True
        '
        'payment
        '
        Me.payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment.ForeColor = System.Drawing.Color.Black
        Me.payment.Image = CType(resources.GetObject("payment.Image"), System.Drawing.Image)
        Me.payment.Location = New System.Drawing.Point(26, 325)
        Me.payment.Name = "payment"
        Me.payment.Size = New System.Drawing.Size(122, 54)
        Me.payment.TabIndex = 61
        Me.payment.Text = " Make Payment"
        Me.payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.payment.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 687)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents viewBT As Button
    Friend WithEvents addBT As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FirstBT As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents payment As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATT_BT As Button
    Friend WithEvents dATE_TIME As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AddMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASSESSMENT As Button
End Class
