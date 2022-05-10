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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New WindowsApplication1.DatabaseDataSet()
        Me.Data_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_tableTableAdapter = New WindowsApplication1.DatabaseDataSetTableAdapters.data_tableTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager()
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
        Me.Name_2TextBox = New System.Windows.Forms.TextBox()
        Me.Address_1TextBox = New System.Windows.Forms.TextBox()
        Me.Address_2TextBox = New System.Windows.Forms.TextBox()
        Me.Address_3TextBox = New System.Windows.Forms.TextBox()
        Me.Post_codeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.F3 = New System.Windows.Forms.Button()
        Me.F1 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_Update = New System.Windows.Forms.Button()
        Me.BT_CLEAR = New System.Windows.Forms.Button()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_tableBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Data_tableBindingNavigator
        '
        Me.Data_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Data_tableBindingNavigator.BindingSource = Me.Data_tableBindingSource
        Me.Data_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Data_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Data_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Data_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Data_tableBindingNavigatorSaveItem})
        Me.Data_tableBindingNavigator.Location = New System.Drawing.Point(0, 483)
        Me.Data_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Data_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Data_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Data_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Data_tableBindingNavigator.Name = "Data_tableBindingNavigator"
        Me.Data_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Data_tableBindingNavigator.Size = New System.Drawing.Size(654, 25)
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(370, 3)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(122, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'Name_1TextBox
        '
        Me.Name_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "name_1", True))
        Me.Name_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_1TextBox.Location = New System.Drawing.Point(108, 22)
        Me.Name_1TextBox.Name = "Name_1TextBox"
        Me.Name_1TextBox.Size = New System.Drawing.Size(106, 26)
        Me.Name_1TextBox.TabIndex = 4
        '
        'Name_2TextBox
        '
        Me.Name_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "Name_2", True))
        Me.Name_2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_2TextBox.Location = New System.Drawing.Point(231, 22)
        Me.Name_2TextBox.Name = "Name_2TextBox"
        Me.Name_2TextBox.Size = New System.Drawing.Size(99, 26)
        Me.Name_2TextBox.TabIndex = 6
        '
        'Address_1TextBox
        '
        Me.Address_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "address_1", True))
        Me.Address_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_1TextBox.Location = New System.Drawing.Point(108, 59)
        Me.Address_1TextBox.Name = "Address_1TextBox"
        Me.Address_1TextBox.Size = New System.Drawing.Size(222, 26)
        Me.Address_1TextBox.TabIndex = 8
        '
        'Address_2TextBox
        '
        Me.Address_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "address_2", True))
        Me.Address_2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_2TextBox.Location = New System.Drawing.Point(108, 94)
        Me.Address_2TextBox.Name = "Address_2TextBox"
        Me.Address_2TextBox.Size = New System.Drawing.Size(222, 26)
        Me.Address_2TextBox.TabIndex = 10
        '
        'Address_3TextBox
        '
        Me.Address_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "address_3", True))
        Me.Address_3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_3TextBox.Location = New System.Drawing.Point(108, 128)
        Me.Address_3TextBox.Name = "Address_3TextBox"
        Me.Address_3TextBox.Size = New System.Drawing.Size(222, 26)
        Me.Address_3TextBox.TabIndex = 12
        '
        'Post_codeTextBox
        '
        Me.Post_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "post_code", True))
        Me.Post_codeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Post_codeTextBox.Location = New System.Drawing.Point(108, 165)
        Me.Post_codeTextBox.Name = "Post_codeTextBox"
        Me.Post_codeTextBox.Size = New System.Drawing.Size(222, 26)
        Me.Post_codeTextBox.TabIndex = 14
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(108, 201)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(222, 26)
        Me.PhoneTextBox.TabIndex = 16
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(108, 235)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(222, 26)
        Me.EmailTextBox.TabIndex = 18
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Data_tableBindingSource, "note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox.Location = New System.Drawing.Point(375, 64)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(222, 197)
        Me.NoteTextBox.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Name_1TextBox)
        Me.GroupBox1.Controls.Add(Me.Name_2TextBox)
        Me.GroupBox1.Controls.Add(Me.Address_1TextBox)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.Address_2TextBox)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.Address_3TextBox)
        Me.GroupBox1.Controls.Add(Me.Post_codeTextBox)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.NoteTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 299)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(379, 25)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(218, 21)
        Me.TextBox7.TabIndex = 66
        Me.TextBox7.Text = "NOTE"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(25, 28)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 20)
        Label1.TabIndex = 3
        Label1.Text = "name :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(25, 238)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 20)
        Label2.TabIndex = 17
        Label2.Text = "email:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(25, 205)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(58, 20)
        Label3.TabIndex = 15
        Label3.Text = "phone:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(25, 60)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(70, 20)
        Label4.TabIndex = 7
        Label4.Text = "address:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(25, 168)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(83, 20)
        Label5.TabIndex = 13
        Label5.Text = "post code:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(143, 24)
        Me.MenuStrip1.TabIndex = 70
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(257, 7)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(107, 20)
        IDLabel.TabIndex = 71
        IDLabel.Text = "Search By ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.F3)
        Me.GroupBox3.Controls.Add(Me.F1)
        Me.GroupBox3.Controls.Add(Me.B1)
        Me.GroupBox3.Controls.Add(Me.B3)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 79)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'F3
        '
        Me.F3.Location = New System.Drawing.Point(206, 34)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(46, 23)
        Me.F3.TabIndex = 3
        Me.F3.Text = ">>>"
        Me.F3.UseVisualStyleBackColor = True
        '
        'F1
        '
        Me.F1.Location = New System.Drawing.Point(141, 34)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(46, 23)
        Me.F1.TabIndex = 2
        Me.F1.Text = ">"
        Me.F1.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(73, 33)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(46, 23)
        Me.B1.TabIndex = 1
        Me.B1.Text = "<"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(6, 33)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(46, 23)
        Me.B3.TabIndex = 0
        Me.B3.Text = "<<<"
        Me.B3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BTN_Update)
        Me.GroupBox2.Controls.Add(Me.BT_CLEAR)
        Me.GroupBox2.Controls.Add(Me.BT_SAVE)
        Me.GroupBox2.Location = New System.Drawing.Point(370, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 131)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(67, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(119, 28)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "  CANCEL"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(18, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(92, 28)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "ADD NEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_Update
        '
        Me.BTN_Update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Update.Image = CType(resources.GetObject("BTN_Update.Image"), System.Drawing.Image)
        Me.BTN_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Update.Location = New System.Drawing.Point(18, 57)
        Me.BTN_Update.Name = "BTN_Update"
        Me.BTN_Update.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_Update.Size = New System.Drawing.Size(92, 28)
        Me.BTN_Update.TabIndex = 61
        Me.BTN_Update.Text = "UPDATE"
        Me.BTN_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Update.UseVisualStyleBackColor = True
        '
        'BT_CLEAR
        '
        Me.BT_CLEAR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLEAR.Image = CType(resources.GetObject("BT_CLEAR.Image"), System.Drawing.Image)
        Me.BT_CLEAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CLEAR.Location = New System.Drawing.Point(158, 21)
        Me.BT_CLEAR.Name = "BT_CLEAR"
        Me.BT_CLEAR.Size = New System.Drawing.Size(80, 28)
        Me.BT_CLEAR.TabIndex = 60
        Me.BT_CLEAR.Text = "COMMIT"
        Me.BT_CLEAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CLEAR.UseVisualStyleBackColor = True
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SAVE.Image = CType(resources.GetObject("BT_SAVE.Image"), System.Drawing.Image)
        Me.BT_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_SAVE.Location = New System.Drawing.Point(158, 58)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BT_SAVE.Size = New System.Drawing.Size(80, 28)
        Me.BT_SAVE.TabIndex = 59
        Me.BT_SAVE.Text = "DELETE"
        Me.BT_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(498, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(113, 28)
        Me.ComboBox1.TabIndex = 74
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 508)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Data_tableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_tableBindingNavigator.ResumeLayout(False)
        Me.Data_tableBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents Name_2TextBox As TextBox
    Friend WithEvents Address_1TextBox As TextBox
    Friend WithEvents Address_2TextBox As TextBox
    Friend WithEvents Address_3TextBox As TextBox
    Friend WithEvents Post_codeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents F3 As Button
    Friend WithEvents F1 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_Update As Button
    Friend WithEvents BT_CLEAR As Button
    Friend WithEvents BT_SAVE As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
