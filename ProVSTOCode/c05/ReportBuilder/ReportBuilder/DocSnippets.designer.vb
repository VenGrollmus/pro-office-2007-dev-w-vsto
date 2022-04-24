<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class DocSnippets
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocSnippets))
    Me.Label1 = New System.Windows.Forms.Label
    Me.PreviewBox = New System.Windows.Forms.RichTextBox
    Me.cboContentControlList = New System.Windows.Forms.ComboBox
    Me.btnInsert = New System.Windows.Forms.Button
    Me.DocSnippetsDataSet1 = New ReportBuilder.DocSnippetsDataSet
    Me.SnippetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.SnippetsTableAdapter1 = New ReportBuilder.DocSnippetsDataSetTableAdapters.SnippetsTableAdapter
    Me.TableAdapterManager1 = New ReportBuilder.DocSnippetsDataSetTableAdapters.TableAdapterManager
    Me.SnippetsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
    Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
    Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
    Me.SnippetsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
    Me.InsertSelection = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.CreateBlock = New System.Windows.Forms.ToolStripButton
    Me.SnippetsDataGridView = New System.Windows.Forms.DataGridView
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.DocSnippetsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SnippetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SnippetsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SnippetsBindingNavigator.SuspendLayout()
    CType(Me.SnippetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 288)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Snippet Preview:"
    '
    'PreviewBox
    '
    Me.PreviewBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.PreviewBox.Location = New System.Drawing.Point(4, 304)
    Me.PreviewBox.Name = "PreviewBox"
    Me.PreviewBox.Size = New System.Drawing.Size(328, 251)
    Me.PreviewBox.TabIndex = 4
    Me.PreviewBox.Text = ""
    '
    'cboContentControlList
    '
    Me.cboContentControlList.FormattingEnabled = True
    Me.cboContentControlList.Location = New System.Drawing.Point(137, 561)
    Me.cboContentControlList.Name = "cboContentControlList"
    Me.cboContentControlList.Size = New System.Drawing.Size(194, 21)
    Me.cboContentControlList.TabIndex = 5
    '
    'btnInsert
    '
    Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnInsert.Location = New System.Drawing.Point(4, 561)
    Me.btnInsert.Name = "btnInsert"
    Me.btnInsert.Size = New System.Drawing.Size(127, 23)
    Me.btnInsert.TabIndex = 6
    Me.btnInsert.Text = "Insert Snippet Into:"
    Me.btnInsert.UseVisualStyleBackColor = True
    '
    'DocSnippetsDataSet1
    '
    Me.DocSnippetsDataSet1.DataSetName = "DocSnippetsDataSet"
    Me.DocSnippetsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'SnippetsBindingSource
    '
    Me.SnippetsBindingSource.DataMember = "Snippets"
    Me.SnippetsBindingSource.DataSource = Me.DocSnippetsDataSet1
    '
    'SnippetsTableAdapter1
    '
    Me.SnippetsTableAdapter1.ClearBeforeFill = True
    '
    'TableAdapterManager1
    '
    Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager1.SnippetsTableAdapter = Me.SnippetsTableAdapter1
    Me.TableAdapterManager1.UpdateOrder = ReportBuilder.DocSnippetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '
    'SnippetsBindingNavigator
    '
    Me.SnippetsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.SnippetsBindingNavigator.BindingSource = Me.SnippetsBindingSource
    Me.SnippetsBindingNavigator.CountItem = Nothing
    Me.SnippetsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.SnippetsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SnippetsBindingNavigatorSaveItem, Me.InsertSelection, Me.ToolStripSeparator1, Me.CreateBlock})
    Me.SnippetsBindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.SnippetsBindingNavigator.MoveFirstItem = Nothing
    Me.SnippetsBindingNavigator.MoveLastItem = Nothing
    Me.SnippetsBindingNavigator.MoveNextItem = Nothing
    Me.SnippetsBindingNavigator.MovePreviousItem = Nothing
    Me.SnippetsBindingNavigator.Name = "SnippetsBindingNavigator"
    Me.SnippetsBindingNavigator.PositionItem = Nothing
    Me.SnippetsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.SnippetsBindingNavigator.Size = New System.Drawing.Size(337, 25)
    Me.SnippetsBindingNavigator.TabIndex = 7
    Me.SnippetsBindingNavigator.Text = "BindingNavigator1"
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
    'SnippetsBindingNavigatorSaveItem
    '
    Me.SnippetsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.SnippetsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SnippetsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.SnippetsBindingNavigatorSaveItem.Name = "SnippetsBindingNavigatorSaveItem"
    Me.SnippetsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
    Me.SnippetsBindingNavigatorSaveItem.Text = "Save Data"
    '
    'InsertSelection
    '
    Me.InsertSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.InsertSelection.Image = CType(resources.GetObject("InsertSelection.Image"), System.Drawing.Image)
    Me.InsertSelection.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.InsertSelection.Name = "InsertSelection"
    Me.InsertSelection.Size = New System.Drawing.Size(156, 22)
    Me.InsertSelection.Text = "Create Snippet From Selection"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'CreateBlock
    '
    Me.CreateBlock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.CreateBlock.Image = CType(resources.GetObject("CreateBlock.Image"), System.Drawing.Image)
    Me.CreateBlock.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.CreateBlock.Name = "CreateBlock"
    Me.CreateBlock.Size = New System.Drawing.Size(23, 22)
    Me.CreateBlock.Text = "Create Building Block"
    '
    'SnippetsDataGridView
    '
    Me.SnippetsDataGridView.AutoGenerateColumns = False
    Me.SnippetsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.SnippetsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
    Me.SnippetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.SnippetsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
    Me.SnippetsDataGridView.DataSource = Me.SnippetsBindingSource
    Me.SnippetsDataGridView.Location = New System.Drawing.Point(8, 34)
    Me.SnippetsDataGridView.Name = "SnippetsDataGridView"
    Me.SnippetsDataGridView.Size = New System.Drawing.Size(324, 251)
    Me.SnippetsDataGridView.TabIndex = 7
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
    Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.Visible = False
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "Category"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Category"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.Width = 74
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "Content"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Content"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DocSnippets
    '
    Me.Controls.Add(Me.SnippetsDataGridView)
    Me.Controls.Add(Me.SnippetsBindingNavigator)
    Me.Controls.Add(Me.btnInsert)
    Me.Controls.Add(Me.cboContentControlList)
    Me.Controls.Add(Me.PreviewBox)
    Me.Controls.Add(Me.Label1)
    Me.Name = "DocSnippets"
    Me.Size = New System.Drawing.Size(337, 587)
    CType(Me.DocSnippetsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SnippetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.SnippetsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SnippetsBindingNavigator.ResumeLayout(False)
    Me.SnippetsBindingNavigator.PerformLayout()
    CType(Me.SnippetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents PreviewBox As System.Windows.Forms.RichTextBox
  Friend WithEvents cboContentControlList As System.Windows.Forms.ComboBox
  Friend WithEvents btnInsert As System.Windows.Forms.Button
  Friend WithEvents DocSnippetsDataSet1 As ReportBuilder.DocSnippetsDataSet
  Friend WithEvents SnippetsBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents SnippetsTableAdapter1 As ReportBuilder.DocSnippetsDataSetTableAdapters.SnippetsTableAdapter
  Friend WithEvents TableAdapterManager1 As ReportBuilder.DocSnippetsDataSetTableAdapters.TableAdapterManager
  Friend WithEvents SnippetsBindingNavigator As System.Windows.Forms.BindingNavigator
  Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents SnippetsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents SnippetsDataGridView As System.Windows.Forms.DataGridView
  Friend WithEvents InsertSelection As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CreateBlock As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
