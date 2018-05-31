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
        Me.ButtonScanningNext = New System.Windows.Forms.Button()
        Me.TxtScanBox = New System.Windows.Forms.TextBox()
        Me.LblScanningOperator = New System.Windows.Forms.Label()
        Me.TxtScanningOperator = New System.Windows.Forms.TextBox()
        Me.AqualocDataSet = New DataEntityTier.AqualocDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MeterQcPointTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.meterQcPointTableAdapter()
        Me.MetersTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.MetersTableAdapter()
        Me.StationsTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter()
        Me.UsersTableAdapter1 = New DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager1 = New DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager()
        Me.MeterQcPointBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelFailCount = New System.Windows.Forms.Label()
        Me.LabelPassCount = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeterQcPointBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonScanningNext
        '
        Me.ButtonScanningNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonScanningNext.Enabled = False
        Me.ButtonScanningNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanningNext.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanningNext.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonScanningNext.Location = New System.Drawing.Point(13, 207)
        Me.ButtonScanningNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonScanningNext.Name = "ButtonScanningNext"
        Me.ButtonScanningNext.Size = New System.Drawing.Size(383, 110)
        Me.ButtonScanningNext.TabIndex = 4
        Me.ButtonScanningNext.Text = "Finish"
        Me.ButtonScanningNext.UseVisualStyleBackColor = False
        '
        'TxtScanBox
        '
        Me.TxtScanBox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScanBox.Location = New System.Drawing.Point(13, 164)
        Me.TxtScanBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtScanBox.Name = "TxtScanBox"
        Me.TxtScanBox.Size = New System.Drawing.Size(383, 33)
        Me.TxtScanBox.TabIndex = 6
        '
        'LblScanningOperator
        '
        Me.LblScanningOperator.AutoSize = True
        Me.LblScanningOperator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanningOperator.Location = New System.Drawing.Point(71, 55)
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
        Me.TxtScanningOperator.Location = New System.Drawing.Point(206, 55)
        Me.TxtScanningOperator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtScanningOperator.Name = "TxtScanningOperator"
        Me.TxtScanningOperator.Size = New System.Drawing.Size(132, 22)
        Me.TxtScanningOperator.TabIndex = 8
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
        'MeterQcPointTableAdapter1
        '
        Me.MeterQcPointTableAdapter1.ClearBeforeFill = True
        '
        'MetersTableAdapter1
        '
        Me.MetersTableAdapter1.ClearBeforeFill = True
        '
        'StationsTableAdapter1
        '
        Me.StationsTableAdapter1.ClearBeforeFill = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.meterQcPointTableAdapter = Me.MeterQcPointTableAdapter1
        Me.TableAdapterManager1.MetersTableAdapter = Me.MetersTableAdapter1
        Me.TableAdapterManager1.StationsTableAdapter = Me.StationsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Me.UsersTableAdapter1
        '
        'MeterQcPointBindingSource
        '
        Me.MeterQcPointBindingSource.DataMember = "meterQcPoint"
        Me.MeterQcPointBindingSource.DataSource = Me.AqualocDataSet
        '
        'StationsBindingSource
        '
        Me.StationsBindingSource.DataMember = "Stations"
        Me.StationsBindingSource.DataSource = Me.AqualocDataSet
        '
        'LabelFailCount
        '
        Me.LabelFailCount.AutoSize = True
        Me.LabelFailCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFailCount.Location = New System.Drawing.Point(233, 360)
        Me.LabelFailCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFailCount.Name = "LabelFailCount"
        Me.LabelFailCount.Size = New System.Drawing.Size(77, 20)
        Me.LabelFailCount.TabIndex = 14
        Me.LabelFailCount.Text = "Fail Count:"
        '
        'LabelPassCount
        '
        Me.LabelPassCount.AutoSize = True
        Me.LabelPassCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassCount.Location = New System.Drawing.Point(40, 360)
        Me.LabelPassCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassCount.Name = "LabelPassCount"
        Me.LabelPassCount.Size = New System.Drawing.Size(82, 20)
        Me.LabelPassCount.TabIndex = 15
        Me.LabelPassCount.Text = "Pass Count:"
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
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(206, 101)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Station"
        '
        'FormStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(414, 432)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPassCount)
        Me.Controls.Add(Me.LabelFailCount)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.TxtScanningOperator)
        Me.Controls.Add(Me.LblScanningOperator)
        Me.Controls.Add(Me.TxtScanBox)
        Me.Controls.Add(Me.ButtonScanningNext)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStation"
        CType(Me.AqualocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeterQcPointBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonScanningNext As Button
    Friend WithEvents TxtScanBox As TextBox
    Friend WithEvents LblScanningOperator As Label
    Friend WithEvents TxtScanningOperator As TextBox
    Friend WithEvents AqualocDataSet As DataEntityTier.AqualocDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents MetersBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents MeterQcPointTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.meterQcPointTableAdapter
    Friend WithEvents MetersTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.MetersTableAdapter
    Friend WithEvents StationsTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.StationsTableAdapter
    Friend WithEvents UsersTableAdapter1 As DataAccessTier.AqualocDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager1 As DataAccessTier.AqualocDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MeterQcPointBindingSource As BindingSource
    Friend WithEvents StationsBindingSource As BindingSource
    Friend WithEvents LabelFailCount As Label
    Friend WithEvents LabelPassCount As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
