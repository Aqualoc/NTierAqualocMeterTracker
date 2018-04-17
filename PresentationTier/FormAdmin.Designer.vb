<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnCreateStation = New System.Windows.Forms.Button()
        Me.btnCreateStickers = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetersTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.MetersTableAdapter()
        Me.StationsTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter()
        Me.TableAdapterManager = New DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableAdapter = New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter()
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.MetersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MetersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetersBindingNavigator.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Location = New System.Drawing.Point(180, 108)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(113, 50)
        Me.btnCreateUser.TabIndex = 0
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(61, 255)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(113, 50)
        Me.btnDeleteUser.TabIndex = 1
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnCreateStation
        '
        Me.btnCreateStation.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateStation.Location = New System.Drawing.Point(61, 108)
        Me.btnCreateStation.Name = "btnCreateStation"
        Me.btnCreateStation.Size = New System.Drawing.Size(113, 50)
        Me.btnCreateStation.TabIndex = 2
        Me.btnCreateStation.Text = "Create Station"
        Me.btnCreateStation.UseVisualStyleBackColor = True
        '
        'btnCreateStickers
        '
        Me.btnCreateStickers.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateStickers.Location = New System.Drawing.Point(299, 108)
        Me.btnCreateStickers.Name = "btnCreateStickers"
        Me.btnCreateStickers.Size = New System.Drawing.Size(113, 50)
        Me.btnCreateStickers.TabIndex = 8
        Me.btnCreateStickers.Text = "Create Stickers"
        Me.btnCreateStickers.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DisplayMember = "PersonID"
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(40, 215)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(189, 29)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.ValueMember = "PersonID"
        '
        'ComboBox4
        '
        Me.ComboBox4.DisplayMember = "StationID"
        Me.ComboBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(252, 215)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(195, 29)
        Me.ComboBox4.TabIndex = 12
        Me.ComboBox4.ValueMember = "StationID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Please click on the procedure you wish to perfrom."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Select an item to delete"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(135, 331)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(184, 52)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Next"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MetersTableAdapter
        '
        Me.MetersTableAdapter.ClearBeforeFill = True
        '
        'StationsTableAdapter
        '
        Me.StationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MetersTableAdapter = Me.MetersTableAdapter
        Me.TableAdapterManager.StationsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'AqualocDataSet
        '
        Me.AqualocDataSet.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetersBindingNavigator
        '
        Me.MetersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MetersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MetersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MetersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MetersBindingNavigatorSaveItem})
        Me.MetersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MetersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MetersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MetersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MetersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MetersBindingNavigator.Name = "MetersBindingNavigator"
        Me.MetersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MetersBindingNavigator.Size = New System.Drawing.Size(959, 25)
        Me.MetersBindingNavigator.TabIndex = 17
        Me.MetersBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MetersBindingNavigatorSaveItem
        '
        Me.MetersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MetersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MetersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MetersBindingNavigatorSaveItem.Name = "MetersBindingNavigatorSaveItem"
        Me.MetersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MetersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AqualocDataSet
        '
        'StationsBindingSource
        '
        Me.StationsBindingSource.DataMember = "Stations"
        Me.StationsBindingSource.DataSource = Me.AqualocDataSet
        '
        'MetersBindingSource
        '
        Me.MetersBindingSource.DataMember = "Meters"
        Me.MetersBindingSource.DataSource = Me.AqualocDataSet
        '
        'MetersDataGridView
        '
        Me.MetersDataGridView.AutoGenerateColumns = False
        Me.MetersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.MetersDataGridView.DataSource = Me.MetersBindingSource
        Me.MetersDataGridView.Location = New System.Drawing.Point(509, 124)
        Me.MetersDataGridView.Name = "MetersDataGridView"
        Me.MetersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.MetersDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MeterID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MeterID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MeterNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MeterNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MeterManufacturedDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MeterManufacturedDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MeterDispatchDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MeterDispatchDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QrCode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "QrCode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Revision"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Revision"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(959, 473)
        Me.Controls.Add(Me.MetersDataGridView)
        Me.Controls.Add(Me.MetersBindingNavigator)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.btnCreateStickers)
        Me.Controls.Add(Me.btnCreateStation)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormAdmin"
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetersBindingNavigator.ResumeLayout(False)
        Me.MetersBindingNavigator.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnCreateStation As Button
    Friend WithEvents btnCreateStickers As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents MetersTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.MetersTableAdapter
    Friend WithEvents StationsTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
    Friend WithEvents TableAdapterManager As DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersTableAdapter As DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents MetersBindingNavigator As BindingNavigator
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
    Friend WithEvents MetersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents StationsBindingSource As BindingSource
    Friend WithEvents MetersBindingSource As BindingSource
    Friend WithEvents MetersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
