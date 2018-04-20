<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQc))
        Me.LblStation = New System.Windows.Forms.Label()
        Me.LblProblem = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.LblFix = New System.Windows.Forms.Label()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.LblBatch = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboQcProblem = New System.Windows.Forms.ComboBox()
        Me.cboQcStatus = New System.Windows.Forms.ComboBox()
        Me.cboQcFix = New System.Windows.Forms.ComboBox()
        Me.cboQcStation = New System.Windows.Forms.ComboBox()
        Me.txtQcBarcode = New System.Windows.Forms.TextBox()
        Me.txtQcBatch = New System.Windows.Forms.TextBox()
        Me.txtQcDate = New System.Windows.Forms.TextBox()
        Me.MetersTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.MetersTableAdapter()
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.MetersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.MetersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetersBindingNavigator.SuspendLayout()
        CType(Me.MetersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblStation
        '
        Me.LblStation.AutoSize = True
        Me.LblStation.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStation.Location = New System.Drawing.Point(16, 75)
        Me.LblStation.Name = "LblStation"
        Me.LblStation.Size = New System.Drawing.Size(68, 25)
        Me.LblStation.TabIndex = 0
        Me.LblStation.Text = "Station"
        '
        'LblProblem
        '
        Me.LblProblem.AutoSize = True
        Me.LblProblem.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblem.Location = New System.Drawing.Point(306, 71)
        Me.LblProblem.Name = "LblProblem"
        Me.LblProblem.Size = New System.Drawing.Size(80, 25)
        Me.LblProblem.TabIndex = 1
        Me.LblProblem.Text = "Problem"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(306, 256)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(61, 25)
        Me.LblStatus.TabIndex = 2
        Me.LblStatus.Text = "Status"
        '
        'LblDateTime
        '
        Me.LblDateTime.AutoSize = True
        Me.LblDateTime.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTime.Location = New System.Drawing.Point(16, 259)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(132, 25)
        Me.LblDateTime.TabIndex = 3
        Me.LblDateTime.Text = "Date and Time"
        '
        'LblFix
        '
        Me.LblFix.AutoSize = True
        Me.LblFix.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFix.Location = New System.Drawing.Point(306, 161)
        Me.LblFix.Name = "LblFix"
        Me.LblFix.Size = New System.Drawing.Size(33, 25)
        Me.LblFix.TabIndex = 4
        Me.LblFix.Text = "Fix"
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(16, 131)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(80, 25)
        Me.LblBarcode.TabIndex = 5
        Me.LblBarcode.Text = "Barcode"
        '
        'LblBatch
        '
        Me.LblBatch.AutoSize = True
        Me.LblBatch.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBatch.Location = New System.Drawing.Point(16, 196)
        Me.LblBatch.Name = "LblBatch"
        Me.LblBatch.Size = New System.Drawing.Size(130, 25)
        Me.LblBatch.TabIndex = 6
        Me.LblBatch.Text = "Batch Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 40)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "QC Analysis"
        '
        'cboQcProblem
        '
        Me.cboQcProblem.FormattingEnabled = True
        Me.cboQcProblem.Location = New System.Drawing.Point(403, 73)
        Me.cboQcProblem.Name = "cboQcProblem"
        Me.cboQcProblem.Size = New System.Drawing.Size(111, 21)
        Me.cboQcProblem.TabIndex = 8
        '
        'cboQcStatus
        '
        Me.cboQcStatus.FormattingEnabled = True
        Me.cboQcStatus.Items.AddRange(New Object() {"Repaired", "Scrapped", "Repair Process"})
        Me.cboQcStatus.Location = New System.Drawing.Point(403, 258)
        Me.cboQcStatus.Name = "cboQcStatus"
        Me.cboQcStatus.Size = New System.Drawing.Size(111, 21)
        Me.cboQcStatus.TabIndex = 9
        '
        'cboQcFix
        '
        Me.cboQcFix.FormattingEnabled = True
        Me.cboQcFix.Location = New System.Drawing.Point(403, 161)
        Me.cboQcFix.Name = "cboQcFix"
        Me.cboQcFix.Size = New System.Drawing.Size(111, 21)
        Me.cboQcFix.TabIndex = 10
        '
        'cboQcStation
        '
        Me.cboQcStation.FormattingEnabled = True
        Me.cboQcStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4"})
        Me.cboQcStation.Location = New System.Drawing.Point(146, 75)
        Me.cboQcStation.Name = "cboQcStation"
        Me.cboQcStation.Size = New System.Drawing.Size(111, 21)
        Me.cboQcStation.TabIndex = 11
        '
        'txtQcBarcode
        '
        Me.txtQcBarcode.Location = New System.Drawing.Point(147, 135)
        Me.txtQcBarcode.Name = "txtQcBarcode"
        Me.txtQcBarcode.Size = New System.Drawing.Size(112, 20)
        Me.txtQcBarcode.TabIndex = 12
        '
        'txtQcBatch
        '
        Me.txtQcBatch.Location = New System.Drawing.Point(147, 196)
        Me.txtQcBatch.Name = "txtQcBatch"
        Me.txtQcBatch.Size = New System.Drawing.Size(112, 20)
        Me.txtQcBatch.TabIndex = 13
        '
        'txtQcDate
        '
        Me.txtQcDate.Location = New System.Drawing.Point(147, 259)
        Me.txtQcDate.Name = "txtQcDate"
        Me.txtQcDate.Size = New System.Drawing.Size(112, 20)
        Me.txtQcDate.TabIndex = 14
        '
        'MetersTableAdapter1
        '
        Me.MetersTableAdapter1.ClearBeforeFill = True
        '
        'AqualocDataSet
        '
        Me.AqualocDataSet.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MetersBindingSource
        '
        Me.MetersBindingSource.DataMember = "Meters"
        Me.MetersBindingSource.DataSource = Me.AqualocDataSet
        '
        'MetersBindingNavigator
        '
        Me.MetersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MetersBindingNavigator.BindingSource = Me.MetersBindingSource
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
        Me.MetersBindingNavigator.Size = New System.Drawing.Size(560, 25)
        Me.MetersBindingNavigator.TabIndex = 15
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
        Me.MetersBindingNavigatorSaveItem.Enabled = False
        Me.MetersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MetersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MetersBindingNavigatorSaveItem.Name = "MetersBindingNavigatorSaveItem"
        Me.MetersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MetersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MetersDataGridView
        '
        Me.MetersDataGridView.AutoGenerateColumns = False
        Me.MetersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MetersDataGridView.DataSource = Me.MetersBindingSource
        Me.MetersDataGridView.Location = New System.Drawing.Point(672, 156)
        Me.MetersDataGridView.Name = "MetersDataGridView"
        Me.MetersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.MetersDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MeterID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MeterID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        'FormQc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(560, 396)
        Me.Controls.Add(Me.MetersBindingNavigator)
        Me.Controls.Add(Me.MetersDataGridView)
        Me.Controls.Add(Me.txtQcDate)
        Me.Controls.Add(Me.txtQcBatch)
        Me.Controls.Add(Me.txtQcBarcode)
        Me.Controls.Add(Me.cboQcStation)
        Me.Controls.Add(Me.cboQcFix)
        Me.Controls.Add(Me.cboQcStatus)
        Me.Controls.Add(Me.cboQcProblem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblBatch)
        Me.Controls.Add(Me.LblBarcode)
        Me.Controls.Add(Me.LblFix)
        Me.Controls.Add(Me.LblDateTime)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblProblem)
        Me.Controls.Add(Me.LblStation)
        Me.Name = "FormQc"
        Me.Text = "FormQC"
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetersBindingNavigator.ResumeLayout(False)
        Me.MetersBindingNavigator.PerformLayout()
        CType(Me.MetersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStation As Label
    Friend WithEvents LblProblem As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents LblFix As Label
    Friend WithEvents LblBarcode As Label
    Friend WithEvents LblBatch As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboQcProblem As ComboBox
    Friend WithEvents cboQcStatus As ComboBox
    Friend WithEvents cboQcFix As ComboBox
    Friend WithEvents cboQcStation As ComboBox
    Friend WithEvents txtQcBarcode As TextBox
    Friend WithEvents txtQcBatch As TextBox
    Friend WithEvents txtQcDate As TextBox
    Friend WithEvents MetersTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.MetersTableAdapter
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents MetersBindingSource As BindingSource
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
    Friend WithEvents MetersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
