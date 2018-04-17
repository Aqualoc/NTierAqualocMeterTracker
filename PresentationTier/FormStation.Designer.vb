<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStation))
        Me.ButtonScanningPass = New System.Windows.Forms.Button()
        Me.ButtonScanningFail = New System.Windows.Forms.Button()
        Me.TxtScanningConfig = New System.Windows.Forms.TextBox()
        Me.ButtonScanningNext = New System.Windows.Forms.Button()
        Me.TxtScanningHeading = New System.Windows.Forms.TextBox()
        Me.LblScanningOperator = New System.Windows.Forms.Label()
        Me.TxtScanningOperator = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonScanningPass
        '
        Me.ButtonScanningPass.BackColor = System.Drawing.Color.Ivory
        Me.ButtonScanningPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningPass.Location = New System.Drawing.Point(207, 220)
        Me.ButtonScanningPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonScanningPass.Name = "ButtonScanningPass"
        Me.ButtonScanningPass.Size = New System.Drawing.Size(189, 110)
        Me.ButtonScanningPass.TabIndex = 0
        Me.ButtonScanningPass.Text = "Pass"
        Me.ButtonScanningPass.UseVisualStyleBackColor = False
        '
        'ButtonScanningFail
        '
        Me.ButtonScanningFail.BackColor = System.Drawing.Color.Red
        Me.ButtonScanningFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningFail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningFail.Location = New System.Drawing.Point(13, 220)
        Me.ButtonScanningFail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonScanningFail.Name = "ButtonScanningFail"
        Me.ButtonScanningFail.Size = New System.Drawing.Size(185, 110)
        Me.ButtonScanningFail.TabIndex = 1
        Me.ButtonScanningFail.Text = "Fail"
        Me.ButtonScanningFail.UseVisualStyleBackColor = False
        '
        'TxtScanningConfig
        '
        Me.TxtScanningConfig.Enabled = False
        Me.TxtScanningConfig.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningConfig.Location = New System.Drawing.Point(199, 100)
        Me.TxtScanningConfig.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtScanningConfig.Name = "TxtScanningConfig"
        Me.TxtScanningConfig.Size = New System.Drawing.Size(132, 22)
        Me.TxtScanningConfig.TabIndex = 2
        '
        'ButtonScanningNext
        '
        Me.ButtonScanningNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonScanningNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningNext.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonScanningNext.Location = New System.Drawing.Point(13, 409)
        Me.ButtonScanningNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonScanningNext.Name = "ButtonScanningNext"
        Me.ButtonScanningNext.Size = New System.Drawing.Size(383, 110)
        Me.ButtonScanningNext.TabIndex = 4
        Me.ButtonScanningNext.Text = "Finish"
        Me.ButtonScanningNext.UseVisualStyleBackColor = False
        '
        'TxtScanningHeading
        '
        Me.TxtScanningHeading.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningHeading.Location = New System.Drawing.Point(68, 164)
        Me.TxtScanningHeading.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtScanningHeading.Name = "TxtScanningHeading"
        Me.TxtScanningHeading.Size = New System.Drawing.Size(303, 22)
        Me.TxtScanningHeading.TabIndex = 6
        '
        'LblScanningOperator
        '
        Me.LblScanningOperator.AutoSize = True
        Me.LblScanningOperator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanningOperator.Location = New System.Drawing.Point(64, 64)
        Me.LblScanningOperator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScanningOperator.Name = "LblScanningOperator"
        Me.LblScanningOperator.Size = New System.Drawing.Size(72, 20)
        Me.LblScanningOperator.TabIndex = 7
        Me.LblScanningOperator.Text = "Operator:"
        '
        'TxtScanningOperator
        '
        Me.TxtScanningOperator.Enabled = False
        Me.TxtScanningOperator.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanningOperator.Location = New System.Drawing.Point(199, 64)
        Me.TxtScanningOperator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtScanningOperator.Name = "TxtScanningOperator"
        Me.TxtScanningOperator.Size = New System.Drawing.Size(132, 22)
        Me.TxtScanningOperator.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(64, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Configuration:"
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.Location = New System.Drawing.Point(47, 345)
        Me.LblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(0, 20)
        Me.LblPass.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 360)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fail Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 360)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Pass Count:"
        '
        'AqualocDataSet
        '
        Me.AqualocDataSet.DataSetName = "AqualocDataSet"
        Me.AqualocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AqualocDataSet
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
        Me.MetersDataGridView.Location = New System.Drawing.Point(540, 145)
        Me.MetersDataGridView.Name = "MetersDataGridView"
        Me.MetersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.MetersDataGridView.TabIndex = 15
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
        'FormStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(860, 539)
        Me.Controls.Add(Me.MetersDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtScanningOperator)
        Me.Controls.Add(Me.LblScanningOperator)
        Me.Controls.Add(Me.TxtScanningHeading)
        Me.Controls.Add(Me.ButtonScanningNext)
        Me.Controls.Add(Me.TxtScanningConfig)
        Me.Controls.Add(Me.ButtonScanningFail)
        Me.Controls.Add(Me.ButtonScanningPass)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormStation"
        Me.Text = "Scanning Process"
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonScanningPass As Button
    Friend WithEvents ButtonScanningFail As Button
    Friend WithEvents TxtScanningConfig As TextBox
    Friend WithEvents ButtonScanningNext As Button
    Friend WithEvents TxtScanningHeading As TextBox
    Friend WithEvents LblScanningOperator As Label
    Friend WithEvents TxtScanningOperator As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents MetersBindingSource As BindingSource
    Friend WithEvents MetersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
