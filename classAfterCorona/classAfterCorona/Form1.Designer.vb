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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Name_1Label As System.Windows.Forms.Label
        Dim Address_1Label As System.Windows.Forms.Label
        Dim Post_codeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DatabaseDataSet = New classAfterCorona.DatabaseDataSet()
        Me.Data_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_tableTableAdapter = New classAfterCorona.DatabaseDataSetTableAdapters.data_tableTableAdapter()
        Me.TableAdapterManager = New classAfterCorona.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Data_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Data_tableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Name_1TextBox = New System.Windows.Forms.TextBox()
        Me.Address_2TextBox = New System.Windows.Forms.TextBox()
        Me.Address_1TextBox = New System.Windows.Forms.TextBox()
        Me.Address_3TextBox = New System.Windows.Forms.TextBox()
        Me.Post_codeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        IDLabel = New System.Windows.Forms.Label()
        Name_1Label = New System.Windows.Forms.Label()
        Address_1Label = New System.Windows.Forms.Label()
        Post_codeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_tableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data_tableBindingSource
        '
        Me.Data_tableBindingSource.DataMember = "data_table"
        Me.Data_tableBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Data_tableTableAdapter
        '
        Me.Data_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.data_tableTableAdapter = Me.Data_tableTableAdapter
        Me.TableAdapterManager.UpdateOrder = classAfterCorona.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Data_tableBindingNavigator
        '
        Me.Data_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Data_tableBindingNavigator.BindingSource = Me.Data_tableBindingSource
        Me.Data_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Data_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Data_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Data_tableBindingNavigatorSaveItem})
        Me.Data_tableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Data_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Data_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Data_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Data_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Data_tableBindingNavigator.Name = "Data_tableBindingNavigator"
        Me.Data_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Data_tableBindingNavigator.Size = New System.Drawing.Size(772, 25)
        Me.Data_tableBindingNavigator.TabIndex = 0
        Me.Data_tableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Data_tableBindingNavigatorSaveItem
        '
        Me.Data_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Data_tableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Data_tableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Data_tableBindingNavigatorSaveItem.Name = "Data_tableBindingNavigatorSaveItem"
        Me.Data_tableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Data_tableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(75, 182)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(37, 25)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(177, 177)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'Name_1Label
        '
        Name_1Label.AutoSize = True
        Name_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_1Label.Location = New System.Drawing.Point(75, 220)
        Name_1Label.Name = "Name_1Label"
        Name_1Label.Size = New System.Drawing.Size(83, 25)
        Name_1Label.TabIndex = 3
        Name_1Label.Text = "name 1:"
        '
        'Name_1TextBox
        '
        Me.Name_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "name_1", True))
        Me.Name_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_1TextBox.Location = New System.Drawing.Point(177, 215)
        Me.Name_1TextBox.Name = "Name_1TextBox"
        Me.Name_1TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Name_1TextBox.TabIndex = 4
        '
        'Address_2TextBox
        '
        Me.Address_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "address_2", True))
        Me.Address_2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_2TextBox.Location = New System.Drawing.Point(177, 294)
        Me.Address_2TextBox.Name = "Address_2TextBox"
        Me.Address_2TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Address_2TextBox.TabIndex = 6
        '
        'Address_1Label
        '
        Address_1Label.AutoSize = True
        Address_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_1Label.Location = New System.Drawing.Point(75, 261)
        Address_1Label.Name = "Address_1Label"
        Address_1Label.Size = New System.Drawing.Size(104, 25)
        Address_1Label.TabIndex = 7
        Address_1Label.Text = "address 1:"
        '
        'Address_1TextBox
        '
        Me.Address_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "address_1", True))
        Me.Address_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_1TextBox.Location = New System.Drawing.Point(177, 258)
        Me.Address_1TextBox.Name = "Address_1TextBox"
        Me.Address_1TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Address_1TextBox.TabIndex = 8
        '
        'Address_3TextBox
        '
        Me.Address_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "address_3", True))
        Me.Address_3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_3TextBox.Location = New System.Drawing.Point(177, 330)
        Me.Address_3TextBox.Name = "Address_3TextBox"
        Me.Address_3TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Address_3TextBox.TabIndex = 10
        '
        'Post_codeLabel
        '
        Post_codeLabel.AutoSize = True
        Post_codeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Post_codeLabel.Location = New System.Drawing.Point(359, 188)
        Post_codeLabel.Name = "Post_codeLabel"
        Post_codeLabel.Size = New System.Drawing.Size(103, 25)
        Post_codeLabel.TabIndex = 11
        Post_codeLabel.Text = "post code:"
        '
        'Post_codeTextBox
        '
        Me.Post_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "post_code", True))
        Me.Post_codeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Post_codeTextBox.Location = New System.Drawing.Point(467, 187)
        Me.Post_codeTextBox.Name = "Post_codeTextBox"
        Me.Post_codeTextBox.Size = New System.Drawing.Size(179, 26)
        Me.Post_codeTextBox.TabIndex = 12
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(359, 230)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(73, 25)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(467, 229)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(179, 26)
        Me.PhoneTextBox.TabIndex = 14
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(359, 309)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(64, 25)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(467, 309)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(179, 26)
        Me.EmailTextBox.TabIndex = 16
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(359, 269)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(56, 25)
        NoteLabel.TabIndex = 17
        NoteLabel.Text = "note:"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox.Location = New System.Drawing.Point(467, 269)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(179, 26)
        Me.NoteTextBox.TabIndex = 18
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(250, 69)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(244, 25)
        Label1.TabIndex = 19
        Label1.Text = "GAME DESIGN FINALIST"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 486)
        Me.Controls.Add(Label1)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Post_codeLabel)
        Me.Controls.Add(Me.Post_codeTextBox)
        Me.Controls.Add(Me.Address_3TextBox)
        Me.Controls.Add(Address_1Label)
        Me.Controls.Add(Me.Address_1TextBox)
        Me.Controls.Add(Me.Address_2TextBox)
        Me.Controls.Add(Name_1Label)
        Me.Controls.Add(Me.Name_1TextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Data_tableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_tableBindingNavigator.ResumeLayout(False)
        Me.Data_tableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents Data_tableBindingSource As BindingSource
    Friend WithEvents Data_tableTableAdapter As DatabaseDataSetTableAdapters.data_tableTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Data_tableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Data_tableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Name_1TextBox As TextBox
    Friend WithEvents Address_2TextBox As TextBox
    Friend WithEvents Address_1TextBox As TextBox
    Friend WithEvents Address_3TextBox As TextBox
    Friend WithEvents Post_codeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
