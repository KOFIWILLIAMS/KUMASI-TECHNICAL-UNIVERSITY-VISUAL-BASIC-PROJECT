<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.timer = New System.Windows.Forms.Label()
        Me.CLOSEr = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.GAMEover = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Label1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.PictureBox()
        Me.RESERT = New System.Windows.Forms.Button()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 90
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'timer
        '
        Me.timer.AutoSize = True
        Me.timer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer.Location = New System.Drawing.Point(349, 574)
        Me.timer.Name = "timer"
        Me.timer.Size = New System.Drawing.Size(110, 24)
        Me.timer.TabIndex = 3
        Me.timer.Text = "SCORE : 0"
        Me.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.timer.UseWaitCursor = True
        '
        'CLOSEr
        '
        Me.CLOSEr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CLOSEr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLOSEr.Location = New System.Drawing.Point(471, 255)
        Me.CLOSEr.Name = "CLOSEr"
        Me.CLOSEr.Size = New System.Drawing.Size(116, 36)
        Me.CLOSEr.TabIndex = 4
        Me.CLOSEr.Text = "CLOSE "
        Me.CLOSEr.UseVisualStyleBackColor = True
        Me.CLOSEr.Visible = False
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(339, 197)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 17)
        Me.result.TabIndex = 5
        Me.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.result.Visible = False
        '
        'GAMEover
        '
        Me.GAMEover.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GAMEover.AutoSize = True
        Me.GAMEover.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAMEover.ForeColor = System.Drawing.Color.Red
        Me.GAMEover.Location = New System.Drawing.Point(271, 123)
        Me.GAMEover.Name = "GAMEover"
        Me.GAMEover.Size = New System.Drawing.Size(284, 46)
        Me.GAMEover.TabIndex = 6
        Me.GAMEover.Text = "GAME OVER!"
        Me.GAMEover.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(167, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 136)
        Me.Label1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Label1.TabIndex = 7
        Me.Label1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(317, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 171)
        Me.Label2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Label2.TabIndex = 8
        Me.Label2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(507, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 162)
        Me.Label3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Label3.TabIndex = 9
        Me.Label3.TabStop = False
        '
        'RESERT
        '
        Me.RESERT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RESERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESERT.Location = New System.Drawing.Point(205, 255)
        Me.RESERT.Name = "RESERT"
        Me.RESERT.Size = New System.Drawing.Size(118, 36)
        Me.RESERT.TabIndex = 10
        Me.RESERT.Text = "RETRY"
        Me.RESERT.UseVisualStyleBackColor = True
        Me.RESERT.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 616)
        Me.Controls.Add(Me.RESERT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GAMEover)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.CLOSEr)
        Me.Controls.Add(Me.timer)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents timer As System.Windows.Forms.Label
    Friend WithEvents CLOSEr As System.Windows.Forms.Button
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents GAMEover As System.Windows.Forms.Label
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents Label1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.PictureBox
    Friend WithEvents RESERT As System.Windows.Forms.Button

End Class
