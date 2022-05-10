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
        Me.VOICE = New System.Windows.Forms.Button()
        Me.EDIT = New System.Windows.Forms.Button()
        Me.BKGD = New System.Windows.Forms.Button()
        Me.ButtonTEXTCOLOR = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonEXIT = New System.Windows.Forms.Button()
        Me.ButtonSAVE = New System.Windows.Forms.Button()
        Me.ButtonIMPORT = New System.Windows.Forms.Button()
        Me.main1 = New System.Windows.Forms.RichTextBox()
        Me.main = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'VOICE
        '
        Me.VOICE.Location = New System.Drawing.Point(221, 209)
        Me.VOICE.Name = "VOICE"
        Me.VOICE.Size = New System.Drawing.Size(59, 23)
        Me.VOICE.TabIndex = 1
        Me.VOICE.Text = "VOICE "
        Me.VOICE.UseVisualStyleBackColor = True
        '
        'EDIT
        '
        Me.EDIT.Location = New System.Drawing.Point(136, 209)
        Me.EDIT.Name = "EDIT"
        Me.EDIT.Size = New System.Drawing.Size(52, 23)
        Me.EDIT.TabIndex = 1
        Me.EDIT.Text = "EDIT"
        Me.EDIT.UseVisualStyleBackColor = True
        '
        'BKGD
        '
        Me.BKGD.Location = New System.Drawing.Point(386, 51)
        Me.BKGD.Name = "BKGD"
        Me.BKGD.Size = New System.Drawing.Size(99, 23)
        Me.BKGD.TabIndex = 1
        Me.BKGD.Text = "BKGRD COLOR"
        Me.BKGD.UseVisualStyleBackColor = True
        '
        'ButtonTEXTCOLOR
        '
        Me.ButtonTEXTCOLOR.Location = New System.Drawing.Point(386, 113)
        Me.ButtonTEXTCOLOR.Name = "ButtonTEXTCOLOR"
        Me.ButtonTEXTCOLOR.Size = New System.Drawing.Size(99, 23)
        Me.ButtonTEXTCOLOR.TabIndex = 2
        Me.ButtonTEXTCOLOR.Text = "TEXT COLOR"
        Me.ButtonTEXTCOLOR.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonEXIT
        '
        Me.ButtonEXIT.Location = New System.Drawing.Point(406, 209)
        Me.ButtonEXIT.Name = "ButtonEXIT"
        Me.ButtonEXIT.Size = New System.Drawing.Size(50, 23)
        Me.ButtonEXIT.TabIndex = 3
        Me.ButtonEXIT.Text = "EXIT"
        Me.ButtonEXIT.UseVisualStyleBackColor = True
        '
        'ButtonSAVE
        '
        Me.ButtonSAVE.Location = New System.Drawing.Point(317, 208)
        Me.ButtonSAVE.Name = "ButtonSAVE"
        Me.ButtonSAVE.Size = New System.Drawing.Size(56, 23)
        Me.ButtonSAVE.TabIndex = 4
        Me.ButtonSAVE.Text = "SAVE"
        Me.ButtonSAVE.UseVisualStyleBackColor = True
        '
        'ButtonIMPORT
        '
        Me.ButtonIMPORT.Location = New System.Drawing.Point(31, 208)
        Me.ButtonIMPORT.Name = "ButtonIMPORT"
        Me.ButtonIMPORT.Size = New System.Drawing.Size(67, 23)
        Me.ButtonIMPORT.TabIndex = 5
        Me.ButtonIMPORT.Text = "IMPORT"
        Me.ButtonIMPORT.UseVisualStyleBackColor = True
        '
        'main1
        '
        Me.main1.Location = New System.Drawing.Point(31, 31)
        Me.main1.Name = "main1"
        Me.main1.ReadOnly = True
        Me.main1.Size = New System.Drawing.Size(332, 132)
        Me.main1.TabIndex = 0
        Me.main1.Text = ""
        '
        'main
        '
        Me.main.Location = New System.Drawing.Point(31, 31)
        Me.main.Multiline = True
        Me.main.Name = "main"
        Me.main.ReadOnly = True
        Me.main.Size = New System.Drawing.Size(342, 132)
        Me.main.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 271)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.ButtonIMPORT)
        Me.Controls.Add(Me.ButtonSAVE)
        Me.Controls.Add(Me.ButtonEXIT)
        Me.Controls.Add(Me.ButtonTEXTCOLOR)
        Me.Controls.Add(Me.BKGD)
        Me.Controls.Add(Me.EDIT)
        Me.Controls.Add(Me.VOICE)
        Me.Controls.Add(Me.main1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VOICE As System.Windows.Forms.Button
    Friend WithEvents EDIT As System.Windows.Forms.Button
    Friend WithEvents BKGD As System.Windows.Forms.Button
    Friend WithEvents ButtonTEXTCOLOR As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonEXIT As System.Windows.Forms.Button
    Friend WithEvents ButtonSAVE As System.Windows.Forms.Button
    Friend WithEvents ButtonIMPORT As System.Windows.Forms.Button
    Friend WithEvents main1 As System.Windows.Forms.RichTextBox
    Friend WithEvents main As System.Windows.Forms.TextBox

End Class
