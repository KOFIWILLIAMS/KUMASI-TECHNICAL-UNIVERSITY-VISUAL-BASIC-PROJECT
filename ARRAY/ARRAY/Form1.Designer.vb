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
        Me.AddAray = New System.Windows.Forms.Button()
        Me.ListArray = New System.Windows.Forms.ListBox()
        Me.sortttt = New System.Windows.Forms.Button()
        Me.Revse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddAray
        '
        Me.AddAray.Location = New System.Drawing.Point(284, 12)
        Me.AddAray.Name = "AddAray"
        Me.AddAray.Size = New System.Drawing.Size(110, 23)
        Me.AddAray.TabIndex = 0
        Me.AddAray.Text = "AddArray"
        Me.AddAray.UseVisualStyleBackColor = True
        '
        'ListArray
        '
        Me.ListArray.FormattingEnabled = True
        Me.ListArray.Location = New System.Drawing.Point(12, 12)
        Me.ListArray.Name = "ListArray"
        Me.ListArray.Size = New System.Drawing.Size(266, 251)
        Me.ListArray.TabIndex = 1
        '
        'sortttt
        '
        Me.sortttt.Location = New System.Drawing.Point(284, 52)
        Me.sortttt.Name = "sortttt"
        Me.sortttt.Size = New System.Drawing.Size(110, 23)
        Me.sortttt.TabIndex = 2
        Me.sortttt.Text = "sort array"
        Me.sortttt.UseVisualStyleBackColor = True
        '
        'Revse
        '
        Me.Revse.Location = New System.Drawing.Point(284, 100)
        Me.Revse.Name = "Revse"
        Me.Revse.Size = New System.Drawing.Size(110, 23)
        Me.Revse.TabIndex = 3
        Me.Revse.Text = "Reverse Array"
        Me.Revse.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 326)
        Me.Controls.Add(Me.Revse)
        Me.Controls.Add(Me.sortttt)
        Me.Controls.Add(Me.ListArray)
        Me.Controls.Add(Me.AddAray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddAray As System.Windows.Forms.Button
    Friend WithEvents ListArray As System.Windows.Forms.ListBox
    Friend WithEvents sortttt As System.Windows.Forms.Button
    Friend WithEvents Revse As System.Windows.Forms.Button

End Class
