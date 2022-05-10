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
        Me.even = New System.Windows.Forms.Button()
        Me.data = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'even
        '
        Me.even.Location = New System.Drawing.Point(88, 119)
        Me.even.Name = "even"
        Me.even.Size = New System.Drawing.Size(75, 23)
        Me.even.TabIndex = 0
        Me.even.Text = "list Even No"
        Me.even.UseVisualStyleBackColor = True
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(77, 93)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(100, 20)
        Me.data.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.even)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents even As System.Windows.Forms.Button
    Friend WithEvents data As System.Windows.Forms.TextBox

End Class
